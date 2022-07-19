using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;


namespace Chat
{
    public partial class ChatForm : Form
    {
        private TcpClient objClient;

        private int port;
        private Buddy buddy;
        private bool hasFocus;

        // introduced in 1.3.6.2
        private ChatLog _chatlog;


        public ChatForm(int port, Buddy buddy, Icon formIcon)
        {
            InitializeComponent();

            // new event handler for when the form gains focus (implemented on rtbType)
            rtbType.GotFocus += new EventHandler(rtbType_GotFocus);

            // new event handler for when the form loses focus (implemented on rtbType)
            rtbType.LostFocus += new EventHandler(rtbType_LostFocus);

            // this property tells other objects whether this form (in the form of rtbType) has focus
            hasFocus = false;

            if (formIcon != null)
            {
                this.Icon = formIcon;
            }

            this.port = port;
            this.buddy = buddy;

            // attach chatlog to the chat window object - logoperator will take care of reading the chat log from disc
            this.AttachChatLog(LogOperator.GetNewChatLog(this.buddy.HostName.ToLower()));

            this.Text = "Chatting with: " + buddy.NickName + " on " + buddy.HostName;

        }

        private void rtbType_GotFocus(object sender, EventArgs e)
        {
            hasFocus = true;
        }

        private void rtbType_LostFocus(object sender, EventArgs e)
        {
            hasFocus = false;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // update the local history box with the new text
            try
            {
                this.WriteMessage(rtbType.Text, false);

                // instantiate the objClient to start sending the message
                // to the specified host/port;
                objClient = new TcpClient();
                objClient.Connect(buddy.HostName, port);

                NetworkStream stream = objClient.GetStream();

                // this includes an object array that will be streamed to the recipient
                // it currently includes the machine name of the sender and the text string.
                StreamedObject strObj = new StreamedObject(System.Environment.MachineName, rtbType.Text);

                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, strObj);

                objClient.Close();

                rtbType.Text = "";


            }
            catch (SocketException serr)
            {
                // this is what this will do currently.
                MessageBox.Show(this, "Your buddy <" + buddy.NickName + "> on " + buddy.HostName + " is currently offline or there is a network problem. (Error: " + serr.Message + ")", "Unable to connect to your buddy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                rtbType.Text = "";
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("closing reason: " + e.CloseReason.ToString());
            // this occurs when user clicks on the close button on the main form which of course minimizes the main form - no need to write chat log
            // in this case
            switch (e.CloseReason)
            {
                case CloseReason.FormOwnerClosing:
                    // do nothing
                    break;
                default:
                    LogOperator.WriteChatLog(this.GetAttachedChatLog());
                    break;
            }
        }

        public void WriteMessage(string message, bool remote)
        {
            if (remote)
            {
                Utils.ColorAndAppend(ref rtbMessage, this.buddy.NickName + ": " + message + "\n", Properties.Settings.Default.TheirForeground);

                // now add text to chat log
                this.GetAttachedChatLog().AddLine(message, this.buddy.NickName);
            }
            else
            {
                Utils.ColorAndAppend(ref rtbMessage, "Me: " + message + "\n", Properties.Settings.Default.MyForeground);

                // now add text to chat log
                this.GetAttachedChatLog().AddLine(message, "Me");
            }
        }

        public string getHostName() { return this.buddy.HostName; }

        public Buddy getBuddy() { return this.buddy; }

        public Icon getIcon() { return this.Icon; }

        public int getPort() { return this.port; }

        public bool TypeBoxHasFocus
        {
            get
            {
                return hasFocus;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void rtbType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rtbType_KeyDown(object sender, KeyEventArgs e)
        {

            // send the message if enter is pressed with the Control key being pressed down
            // Ctrl-Enter will produce a new line
            if (e.KeyCode == Keys.Enter && !e.Control)
            {
                e.SuppressKeyPress = true;
                btSend_Click(sender, e);
            }

        }

        private void rtbType_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void rtbMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // disable keystrokes
            e.Handled = true;
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            rtbMessage.ScrollToCaret();
        }

 
        private void ChatForm_Paint(object sender, PaintEventArgs e)
        {
            //MainForm mother = (MainForm)this.Owner;
           // rtbMessage.BackColor = mother.options.BackGround;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            // launch the window dead at the center of the primary screen
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbType.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbType.AppendText(Clipboard.GetText());
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbMessage.SelectedText);
        }

        private void rtbType_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void rtbMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        public void TypeBoxFocus()
        {
                this.hasFocus = true;
                rtbType.Focus();
        }

        private void AttachChatLog(ChatLog cl) {
            this._chatlog = cl;
        }

        ChatLog GetAttachedChatLog()
        {
            return _chatlog;
        }

    }
}
