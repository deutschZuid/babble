using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Media;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Chat
{

    public partial class MainForm : Form
    {

        private string buddyListXMLPath;
        private List<Buddy> buddylist; // a list of buddies
        //private List<ChatForm> chatFormlist; // obviously a list of currently open chat windows
        private int tcpPort = 1300; // define port;

        // the tcp server will be run in a different thread to avoid blocking.
        private Thread thdListener;
        private TcpListener objListener;

        public delegate void Invoker(StreamedObject so); // delegate: It's run when a networkstream request is received from a host.


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // retrieve a list of buddies including their IP-Nick-Imageindex-BuddyNodeindex-Email
            // For the moment we will manually define a list. 
            buddylist = new List<Buddy>();
            //chatFormlist = new List<ChatForm>();

            // Buddy List will now be stored under the roaming appdata folder of user's profile instead of under the program's install folder.
            // The Environment.SpecialFolder.ApplicationData returns a SpecialFolder object that points the user's roaming appdata folder. No more, no less.
            buddyListXMLPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Application.CompanyName + @"\" +
                Application.ProductName + @"\XMLs\buddylist.xml";

            // Read from XML file to retrieve a list of buddies from the hard drive, clearflag = false
            if (this.ProcessXMLBuddyList(this.buddyListXMLPath, false))
            {
                // now populate the buddy tree view with the buddylist.
                foreach (Buddy myBuddy in buddylist)
                {
                    TreeNode buddyNode = new TreeNode();
                    tvwBuddies.Nodes.Add(buddyNode);
                    buddyNode.ImageIndex = myBuddy.ImageIndex;
                    buddyNode.SelectedImageIndex = myBuddy.ImageIndex;
                    buddyNode.Text = myBuddy.NickName;
                    buddyNode.Name = myBuddy.NickName;
                }
            }


            // Gentlemen - Start Your... Thread!
            thdListener = new Thread(new ThreadStart(this.Listen));
            thdListener.Start();

            // set initial position of the main window
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.Left = r.Right - this.Width - 150;
            this.Top = r.Bottom - this.Height - 60;

            // set form caption
            this.Text = Application.ProductName + " Version: " + Application.ProductVersion;

            // set system tray ballon text.
            this.notifyMain.BalloonTipTitle = Application.ProductName;
            this.notifyMain.BalloonTipText = Application.ProductName + " is running in your system tray";

            // show the systray icon
            this.notifyMain.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objListener.Stop();
            notifyMain.Visible = false;
            Application.Exit();
        }


        private void tvwBuddies_DoubleClick(object sender, EventArgs e)
        {
            // this makes sure user didn't just double click on a blank space on the lvw.
            if (tvwBuddies.SelectedNode != null)
            {

                Buddy selectedBuddy = null;

                try
                {
                    // loop through the buddylist and find the one that shares the same node index as the selected Node
                    foreach (Buddy buddy in buddylist)
                    {
                        if (tvwBuddies.SelectedNode.Index == buddylist.IndexOf(buddy))
                        {
                            selectedBuddy = buddy;
                            break;
                        }
                    }
                }
                catch (IndexOutOfRangeException IOREx)
                {
                    MessageBox.Show("Array index out of bound. (System messsage: " + IOREx.Message + ")", "Error");
                    return;
                }
                catch (Exception other)
                {
                    MessageBox.Show("Error: " + other.Message, "Error");
                    return;
                }

                try
                {
                    if (selectedBuddy != null)
                    { // only do this if the buddy is found

                        // now check to make sure that there isn't already a chat window open with the selected buddy's IP addy in it
                        bool formExist = false;
                        string buddyHost = "";

                        // throws socketexception if the name cannot be resolved.
                        buddyHost = Dns.GetHostEntry(selectedBuddy.HostName).HostName;


                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm.GetType().Name == "ChatForm")
                            {
                                string cfHost = "";
                                try
                                {
                                    cfHost = Dns.GetHostEntry(((ChatForm)openForm).getBuddy().HostName).HostName;
                                }
                                catch (SocketException)
                                {
                                    // just continue;
                                }


                                // if chat window already exists, bring it to foreground
                                if (cfHost == buddyHost)
                                {
                                    // restore window if minimized
                                    openForm.WindowState = FormWindowState.Normal;
                                    // bring to front of z-order
                                    openForm.BringToFront();
                                    // now focus the form/typebox
                                    ((ChatForm)openForm).TypeBoxFocus();
                                    formExist = true;
                                    break;
                                }
                            }
                        }

                        if (!formExist)
                        {

                            // retrieve the icon file handle for the selected buddy icon from the listview imagelist.
                            Icon chatIcon = Icon.FromHandle(((Bitmap)tvwBuddies.ImageList.Images[selectedBuddy.ImageIndex]).GetHicon());

                            // initiate new chatform and add it to the chatformlist
                            ChatForm letsChat = new ChatForm(tcpPort, selectedBuddy, chatIcon);
                            letsChat.Owner = this;
                            letsChat.Show();

                            // release memory taken up by the Icon
                            chatIcon.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Internal error: Buddy not found in Buddy list");
                    }
                }
                catch (SocketException)
                {
                    // buddy's hostname cannot be resolved
                    if (MessageBox.Show("Buddy's hostname cannot be resolved. Would you like to correct this?",
                        "Invalid buddy hostname", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        editToolStripMenuItem_Click(sender, e);
                    }
                }
                catch (Exception genE)
                {
                    // every other error comes here
                    MessageBox.Show(genE.Message, "Error");
                }
            } 
        }

        private void Listen()
        {
            // start listening for incoming connection requests.
            try
            {
                objListener = new TcpListener(IPAddress.Any, tcpPort);
                objListener.Start();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
                return;
            }

            try
            {
                do
                {
                    // this part of the method defines what to do with incoming TCP requests
                    TcpClient objClient = objListener.AcceptTcpClient();
                    Stream netStream = objClient.GetStream();

                    // Deserialize the incoming bitstream with a binary formatter
                    IFormatter formatter = new BinaryFormatter();
                    // and once the end of the stream has been reached, store the info in a
                    // StreamedObject.
                    StreamedObject objParams = (StreamedObject)formatter.Deserialize(netStream);

                    // invoke a method to process the StreamedObject
                    this.Invoke(new Invoker(this.ShowMessage), objParams);

                } while (true != false);
            }
            catch (SocketException)
            {
                // ignore any blocking exceptions from the AcceptTCPClient method.
                //MessageBox.Show(socErr.Source + ": " + socErr.Message + ". (" + socErr.ToString() + ")");
            }
            catch (Exception otherErr)
            {
                MessageBox.Show(otherErr.Message);
            }
        }

        
        private void ShowMessage(StreamedObject so)
        {
            bool foundChatForm = false;
            bool foundBuddy = false;
            try
            {
                // now use the GetHostEntry method to resolve the IP or Hostname into IPHostEntry format.
                // Note that IPHostEntry lists all IP Addresses associated with the host
                IPHostEntry ipHost = Dns.GetHostEntry(so.Host);
                string senderHost = ipHost.HostName;

                //MessageBox.Show("cf count: " + Application.OpenForms.Count + "\r\nsenderhost: " + senderHost);

                // go through the current list of chat windows and see if a window is already open for the IP address
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.GetType().Name == "ChatForm")
                    {
                        string buddyHost = "";
                        try
                        {
                            buddyHost = Dns.GetHostEntry(((ChatForm)openForm).getBuddy().HostName).HostName;
                        }
                        catch (SocketException)
                        {
                            // dns error - possible if there is a chat window open with an invalid recipient host
                            // just continue
                        }
                        catch (Exception genEx)
                        {
                            // any other errors - display the error and quit out from the method
                            MessageBox.Show(genEx.Message, "Error");
                            return;
                        }

                        if (buddyHost == senderHost)
                        {
                            foundChatForm = true;
                            ((ChatForm)openForm).WriteMessage(so.Data, true);

                            // if the chat window doesn't currently have focus,
                            // flash the taskbar button to notify the user
                            // and stop flashing when the window receives focus.
                            if (!((ChatForm)openForm).TypeBoxHasFocus)
                            {
                                if (Properties.Settings.Default.CWFlashOn)
                                {
                                    Utils.Flash(openForm);
                                }
                                if (Properties.Settings.Default.CWSoundOn)
                                {
                                    SoundPlayer sound = new SoundPlayer("sounds/Knock.wav");
                                    sound.Play();
                                }
                            }

                            break;
                        }
                    }
                }

                // If, after looping through every chatform in the chatformlist, no existing chatform is found for the given senderHost
                // then, loop through the buddylist to see if a buddy already exists for the given senderHost, if yes, start a new chat
                // window along with buddy name, else create a new temp chat window with only the hostname
                if (!foundChatForm)
                {
                    foreach (Buddy b in buddylist)
                    {
                        string buddyHostName = Dns.GetHostEntry(b.HostName).HostName;

                        if (buddyHostName == senderHost)
                        {
                            foundBuddy = true;

                            // create a new chat window with the buddy's details.
                            Icon chatIcon = Icon.FromHandle(((Bitmap)tvwBuddies.ImageList.Images[b.ImageIndex]).GetHicon());

                            ChatForm cf = new ChatForm(tcpPort, b, chatIcon);

                            //chatFormlist.Add(cf);
                            cf.Show(this);

                            cf.WriteMessage(so.Data, true);

                            // buddy found - break out of the for loop
                            break;
                        }
                    }

                    if (!foundBuddy)
                    {
                        // what we are doing here is to create a temporary buddy for the chatwindow with the nickname = senderhostname
                        // no imageindex, buddyindex are supplied. icon would be null - Chat Window will pick it up and use the default
                        // icon in its place. 
                        Buddy tempBuddy = new Buddy(senderHost, senderHost, -1, -1, null, -1);
                        ChatForm cf = new ChatForm(tcpPort, tempBuddy, null);
                        //chatFormlist.Add(cf);
                        cf.Show(this);
                        cf.WriteMessage(so.Data, true);
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // sound file not found.. just don't play sound
            }
            catch (InvalidOperationException)
            {
                // wav file is corrupted or sound device not available. Do nothing.
            }
            catch (UriFormatException)
            {
                // file URI is invalid (shouldn't occur). Do nothing.
            }
            catch (Exception otherErr)
            {
                // all other exceptions.. display them
                MessageBox.Show(otherErr.Message, "Error during show message phase");
            }

        }

        private void moreBuddiesPlzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBuddyForm newBuddyForm = new AddNewBuddyForm("Add a new Buddy", "Accept", "Cancel", "", "", "", 5, 0);
            // newBuddyForm.Parent = this;

            // Declare event handler for the NotifyParent event.
            newBuddyForm.NotifyParent += new EventHandler(newBuddyFormAdd_NotifyParent);

            newBuddyForm.ShowDialog(this);
        }

        // event handler for adding a new buddy
        private void newBuddyFormAdd_NotifyParent(object sender, EventArgs e)
        {
            Buddy newBuddy = new Buddy(((NotifyAddNewBuddyToTopParentEventArgs)e).HostName,
                ((NotifyAddNewBuddyToTopParentEventArgs)e).NickName,
                ((NotifyAddNewBuddyToTopParentEventArgs)e).SelectedImageIndex,
                1,
                ((NotifyAddNewBuddyToTopParentEventArgs)e).EmailAddress,
                ((NotifyAddNewBuddyToTopParentEventArgs)e).Rating);

            // attach the buddy to the end of the buddylist and the tree view.
            buddylist.Add(newBuddy);

            TreeNode buddyNode = new TreeNode(newBuddy.NickName, newBuddy.ImageIndex, newBuddy.ImageIndex);
            buddyNode.Name = newBuddy.NickName;
            tvwBuddies.Nodes.Add(buddyNode);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                // User has chosen to exit the program through normal means. Complete all the cleanup

                e.Cancel = false;

                // write buddy list to disk
                this.WriteXMLBuddyList(this.buddyListXMLPath);

                // save application settings.
                Properties.Settings.Default.Save();

                // now depending on the value of the launchatstartup setting, add or remove its value from the startup registry key. 
                Utils.RunStartup(Properties.Settings.Default.LaunchAtStartup, "Babble Client", Application.ExecutablePath.ToString());

                // continue executing form closing event

            }
            else if (e.CloseReason == CloseReason.UserClosing) 
            {
                e.Cancel = true;
                this.notifyMain.ShowBalloonTip(2000);
                this.Hide();
            }
            else if (e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                exitToolStripMenuItem_Click(sender, e);
            }


        }

        // Allows a window to be brought to the front.
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);		

        private void showBabbleWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // unhide the window (if hidden, and if not already hidden, then this command does nothing
            this.Show();

            // bring the window to the front of the z-order stack.
            SetForegroundWindow(this.Handle.ToInt32());

        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // start up a new options form passing the current options by value;
            OptionsForm optionsForm = new OptionsForm();
            // optionsForm.NotifyParent += new EventHandler(optionsForm_NotifyParent);

            optionsForm.ShowDialog(this);
        }

        private void optionsForm_NotifyParent(object sender, EventArgs e)
        {
            // process options parameters
            // this.options = ((NotifyOptionsToTopParentEventArgs)e).modifiedOptions;
        }

        private void notifyMain_MouseDown(object sender, MouseEventArgs e)
        {
            // only show the main window when user clicks on 
            // the NA icon with their left mouse button
            if (e.Button == MouseButtons.Left)
            {
                showBabbleWindowToolStripMenuItem_Click(sender, e);
            }
        }

        private bool WriteXMLBuddyList(string filePath)
        {
            try {
                // create directory if it does not exist
                if (!Directory.Exists(Path.GetDirectoryName(filePath))) {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }
                // this creates a new buddylist file - if it exists, it will be overwritten
                FileStream fs = new FileStream(filePath, FileMode.Create);

                // Xmlwriter to write XML
                XmlWriter buddyWriter = XmlWriter.Create(fs);

                // Start creating the document
                buddyWriter.WriteStartDocument();
                buddyWriter.WriteStartElement("buddylist");

                // start writing data
                foreach (Buddy buddy in buddylist)
                {
                    buddyWriter.WriteStartElement("buddy");
                    buddyWriter.WriteElementString("name", buddy.NickName);
                    buddyWriter.WriteElementString("host", buddy.HostName);
                    buddyWriter.WriteElementString("email", buddy.EmailAddress);
                    buddyWriter.WriteElementString("buddyindex", buddy.BuddyNodeIndex.ToString());
                    buddyWriter.WriteElementString("imageindex", buddy.ImageIndex.ToString());
                    buddyWriter.WriteElementString("rating", buddy.Rating.ToString());
                    buddyWriter.WriteEndElement();
                }

                // close off the document
                buddyWriter.WriteEndElement();
                buddyWriter.WriteEndDocument();

                buddyWriter.Flush();
                fs.Close();
            } catch (Exception) 
            {
                // do nothing and return false
                return false;
            }
            return true;
        }

        // read the buddylist off the hard drive
        private bool ProcessXMLBuddyList(string filePath, bool clearList)
        {
            XmlTextReader buddyReader = null;
            XmlDocument buddyDocument = null;
            XmlNode buddyRoot = null;
            try
            {
                // create an xml reader
                buddyReader = new XmlTextReader(filePath);
                buddyReader.WhitespaceHandling = WhitespaceHandling.None;

                // abstract representation of the xml document
                buddyDocument = new XmlDocument();
                buddyDocument.Load(buddyReader);

                // root node
                buddyRoot = buddyDocument.DocumentElement;

                if (buddyRoot.Name != "buddylist")
                {
                    MessageBox.Show("Invalid buddylist file: the root node doesn't start with <buddylist>!", "Error opening buddylist file");
                    return false;
                }

                if (clearList)
                {
                    // prepare the buddylist object, only do that when clearlist is true
                    buddylist.Clear();
                }

                // buddyroot is the buddylist elements which contains buddy child elements
                for (int i = 0; i < buddyRoot.ChildNodes.Count; i++)
                {
                    // loop through each 'buddy' child and read off its properties into a Buddy object

                    XmlNode buddyXMLNode = buddyRoot.ChildNodes[i];
                    Buddy buddy = new Buddy();

                    buddy.NickName = buddyXMLNode.ChildNodes[0].InnerText;
                    buddy.HostName = buddyXMLNode.ChildNodes[1].InnerText;
                    buddy.EmailAddress = buddyXMLNode.ChildNodes[2].InnerText;
                    buddy.BuddyNodeIndex = Convert.ToInt32(buddyXMLNode.ChildNodes[3].InnerText);
                    buddy.ImageIndex = Convert.ToInt32(buddyXMLNode.ChildNodes[4].InnerText);
                    buddy.Rating = Convert.ToInt32(buddyXMLNode.ChildNodes[5].InnerText);

                    // add the finished buddy to the buddylist
                    buddylist.Add(buddy);

                    buddyReader.Close();
                }
            }
            catch (Exception)
            {
                // do nothing and close the reader in the finally block
                if (buddyReader!=null)
                {
                    buddyReader.Close();
                }
               return false;
            }

            return true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeThisMToolStripMenuItem_Click(sender, e);
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvwBuddies_DoubleClick(sender, e);
        }

        private void DeleteBuddy()
        {
            TreeNode thePoorFellowWhoIsAboutToBePurged = tvwBuddies.SelectedNode;

            // Delete from buddylist
            buddylist.RemoveAt(thePoorFellowWhoIsAboutToBePurged.Index);

            // Delete from TreeView
            tvwBuddies.Nodes.RemoveAt(thePoorFellowWhoIsAboutToBePurged.Index);

            if (tvwBuddies.Nodes.Count <= 0)
            {
                tvwBuddies.SelectedNode = null;
            }

        }

        private void tvwBuddies_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvwBuddies.SelectedNode = e.Node;
        }

        private void removeThisMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvwBuddies.SelectedNode != null)
            {
                DialogResult result = FunMessageBox.ShowForm("Are you sure you want to delete this buddy?", "Delete this undesirable buddy");

                if (result == DialogResult.OK)
                {
                    this.DeleteBuddy();
                }
                
            }
        }

        private void tvwBuddies_KeyUp(object sender, KeyEventArgs e)
        {
            // pressing the delete invokes the same routine as when picking the Delete buddy option from the menu
            if (e.KeyCode == Keys.Delete)
            {
                deleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void ctxTreeviewMenu_Opening(object sender, CancelEventArgs e)
        {
            // Context menu of the Treeview control
            if (tvwBuddies.SelectedNode != null)
            {
                deleteToolStripMenuItem.Text = "&Delete <" + tvwBuddies.SelectedNode.Text + ">";
                editToolStripMenuItem1.Text = "Edi&t <" + tvwBuddies.SelectedNode.Text + ">";
                deleteToolStripMenuItem.Visible = true;
                editToolStripMenuItem1.Visible = true;
                sendMessageToolStripMenuItem.Visible = true;
            }
            else
            {
                // hide the tool strip items if no node is selected
                deleteToolStripMenuItem.Visible = false;
                editToolStripMenuItem1.Visible = false;
                sendMessageToolStripMenuItem.Visible = false;
            }
            
        }

        private void importBuddyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buddy files should be in xml format
            openFileDialog1.Filter = "Buddy Files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // returns false if the file is not a buddylist - therefore
                // don't refresh the treeview if that's the caes.
                if (this.ProcessXMLBuddyList(openFileDialog1.FileName, false))
                {
                    // refresh the treeview.
                    tvwBuddies.Nodes.Clear();

                    // Build the Nodes in treeview based on the elements in the buddy list
                    for (int i = 0; i < buddylist.Count; i++)
                    {
                        tvwBuddies.Nodes.Add(buddylist.ElementAt(i).NickName);
                        tvwBuddies.Nodes[i].ImageIndex = buddylist.ElementAt(i).ImageIndex;
                        tvwBuddies.Nodes[i].Name = buddylist.ElementAt(i).NickName;
                        tvwBuddies.Nodes[i].SelectedImageIndex = buddylist.ElementAt(i).ImageIndex;
                    }
                }
            }
        }

        private void exportBuddyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buddy files are in xml format
            saveFileDialog1.Filter = "Buddy Files (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Write the XML file in buddy format
                this.WriteXMLBuddyList(saveFileDialog1.FileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About box
            AboutBox1 about = new AboutBox1();
            about.ShowDialog(this);
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit Program
            exitToolStripMenuItem_Click(sender, e);
        }

        private void toolsToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (tvwBuddies.SelectedNode != null)
            {
                removeThisMToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                removeThisMToolStripMenuItem.Text = "&Delete <" + tvwBuddies.SelectedNode.Text + ">";
                editToolStripMenuItem.Text = "Edi&t <" + tvwBuddies.SelectedNode.Text + ">";
            }
            else
            {
                removeThisMToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                removeThisMToolStripMenuItem.Text = "&Delete";
                editToolStripMenuItem.Text = "Edi&t";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Buddy selectedBuddy = buddylist.ElementAt(tvwBuddies.SelectedNode.Index);

                // pass in the existing parameters for this buddy
                AddNewBuddyForm newBuddyForm = new AddNewBuddyForm("Edit <" + selectedBuddy.NickName + ">", "Accept", "Cancel",
                    selectedBuddy.HostName, selectedBuddy.EmailAddress, selectedBuddy.NickName, selectedBuddy.Rating, selectedBuddy.ImageIndex);

                // Declare event handler for the NotifyParent event.
                newBuddyForm.NotifyParent += new EventHandler(newBuddyFormEdit_NotifyParent);

                newBuddyForm.ShowDialog(this);
        }

        private void newBuddyFormEdit_NotifyParent(object sender, EventArgs e)
        {
            Buddy selectedBuddy = buddylist.ElementAt(tvwBuddies.SelectedNode.Index);

            selectedBuddy.HostName = ((NotifyAddNewBuddyToTopParentEventArgs)e).HostName;
            selectedBuddy.NickName = ((NotifyAddNewBuddyToTopParentEventArgs)e).NickName;
            selectedBuddy.EmailAddress = ((NotifyAddNewBuddyToTopParentEventArgs)e).EmailAddress;
            selectedBuddy.Rating = ((NotifyAddNewBuddyToTopParentEventArgs)e).Rating;
            selectedBuddy.ImageIndex = ((NotifyAddNewBuddyToTopParentEventArgs)e).SelectedImageIndex;

            tvwBuddies.SelectedNode.Name = selectedBuddy.NickName;
            tvwBuddies.SelectedNode.Text = selectedBuddy.NickName;
            tvwBuddies.SelectedNode.ImageIndex = selectedBuddy.ImageIndex;
            tvwBuddies.SelectedNode.SelectedImageIndex = selectedBuddy.ImageIndex;
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        public int getListenPort()
        {
            return this.tcpPort;
        }

        private void revisionsTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string revisionsTextFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\patch history\revisions.txt";
            System.Diagnostics.Process.Start(revisionsTextFileName);
        }

    }
}
