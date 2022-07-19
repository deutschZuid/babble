using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Chat
{
    // manipulates the chatlogs and interfaces with the file system.
    class LogOperator
    {
        private static string _defaultChatLogFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Application.CompanyName +
                @"\" + Application.ProductName + @"\XMLs\chatlogs\"; 
        
        // creates an instance of chatlog
        public static ChatLog GetNewChatLog(string LogName)
        {
            ChatLog cl = new ChatLog(LogName);
            
            /* Read from XML file if exists, else continue */
            //ReadChatLog(ref cl);
            return cl;
        }

        /* 
         * this method reads a chatlog from disc 
         */
        public static bool ReadChatLog(ref ChatLog log)
        {
            XmlDocument xmldoc = new XmlDocument();

            string defaultLogFileName = _defaultChatLogFolderPath + log.LogName + ".xml";

            // standard directory checking
            if (!Directory.Exists(_defaultChatLogFolderPath))
            {
                // directory doesn't exist, just return false. Readchatlog is not responsible for creating directories.
                return false;
            }

            // this is a new chatlog
            if (!File.Exists(defaultLogFileName))
            {
                // return false if file doesn't exist
                return false;
            }

            try
            {
                // loads the Xml log from file
                xmldoc.Load(defaultLogFileName);
            }
            catch (Exception)
            {
                // exit out of the procedure with the false flag
                return false;
            }

            if (xmldoc.DocumentElement.Name != "chatlog")
            {
                // valid xmldoc, but wrong root element!
                return false;
            }

            try {
                // each entry in the xml file is represented by the <entry> tag
                for (int i = 0; i < xmldoc.DocumentElement.ChildNodes.Count; i++)
                {
                    XmlNode logChildNode = xmldoc.DocumentElement.ChildNodes[i];
                    ChatLog.Line newLine = new ChatLog.Line();

                    newLine.Initiator = logChildNode.ChildNodes[0].InnerText;
                    newLine.LineDateTime = DateTime.Parse(logChildNode.ChildNodes[1].InnerText);
                    newLine.Message = logChildNode.ChildNodes[2].InnerText;

                    log.AddLine(newLine);
                }
            }

            catch (Exception)
            {
                //MessageBox.Show("Error while analysing chatlog file: " + defaultLogFileName);
                return false;
            }

            return true;
        }



        /* 
         * This method writes a chatlog object to disc
         */
        public static bool WriteChatLog(ChatLog log)
        {
            // this can change in future releases
            string defaultLogFileName = _defaultChatLogFolderPath + log.LogName + ".xml";

            // abstract representation of xml document structure
            XmlDocument xmldoc = new XmlDocument();

            if (log != null) {
                try
                {
                    // standard directory checking
                    if (!Directory.Exists(_defaultChatLogFolderPath))
                    {
                        Directory.CreateDirectory(_defaultChatLogFolderPath);
                    }
                } 
                catch (Exception ex) {
                    MessageBox.Show("Unable to create log directory. System error: " + ex.Message);
                    return false;
                }

                // chatlog file is being created for the first time...
                if (!File.Exists(defaultLogFileName))
                {
                    // not able to create the chatlog file for some reason
                    if (!CreateXmlHeader(defaultLogFileName, "chatlog"))
                    {
                        return false;
                    }
                }

                try
                {
                    // loads the Xml log from file
                    xmldoc.Load(defaultLogFileName);
                }
                catch (XmlException)
                {
                    // for some reason the file has been tampered with - recreate it
                    if (!CreateXmlHeader(defaultLogFileName, "chatlog"))
                    {
                        return false;
                    }
                    else
                    {
                        // load the file again - necessary as otherwise we wouldn't be in this catch-block!
                        xmldoc.Load(defaultLogFileName);
                    }
                }
                catch (Exception genEx)
                {
                    // all other exceptions - exit out of the procedure with the false flag
                    MessageBox.Show("Error reading from log file " + defaultLogFileName + " System error: " + genEx.Message);
                    return false;
                }

                // now go through each chatlog line and insert into the xml doc structure
                try {
                    foreach (ChatLog.Line line in log.GetLines()) {

                        XmlNode newEntryNode = xmldoc.CreateElement("entry");

                        XmlNode nodeInitiator = xmldoc.CreateElement("name");
                        nodeInitiator.InnerText = line.Initiator;

                        XmlNode nodeDateTime = xmldoc.CreateElement("date");
                        nodeDateTime.InnerText = line.LineDateTime.ToString();

                        XmlNode nodeMessage = xmldoc.CreateElement("message");
                        nodeMessage.InnerText = line.Message;

                        newEntryNode.AppendChild(nodeInitiator);
                        newEntryNode.AppendChild(nodeDateTime);
                        newEntryNode.AppendChild(nodeMessage);

                        xmldoc.DocumentElement.AppendChild(newEntryNode);
                    }

                    // this saves the structure in the memory to disc
                    xmldoc.Save(defaultLogFileName);
                }
                catch (Exception ex)
                {
                    // do nothing and return false
                    MessageBox.Show(ex.Message);
                    return false;
                }

                // insertion(s) completed successfully
                return true;
            }

            // the 'log' object was null - so return false
            return false;
        }

        /* 
         * A procedure that creates an elementary header for an XML file. Should probably be moved to the Utils.cs file and have class visibility
         */
        private static bool CreateXmlHeader(string filename, string root) {
            try
            {
                XmlDocument xmldoc = new XmlDocument();

                //let's add the XML declaration section
                XmlNode xmlDocDeclaration = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xmldoc.AppendChild(xmlDocDeclaration);

                //let's add the root element
                XmlNode xmlChatLogRoot = xmldoc.CreateElement(root);
                xmldoc.AppendChild(xmlChatLogRoot);

                xmldoc.Save(filename);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to create chatlog header:  " + e.Message);
                return false;
            }

            return true;
        }

    }

    // Representation of a chatlog
    // A chatlog contains a name, a Line object (inner class) and abilities to add/remove lines.
    // It does not interface with the file system. 
    // Not many comments are included in the class as everything is pretty straightforward and obvious.
    class ChatLog
    {

        private string strLogName;
        private List<Line> lines;

        // inner class
        public class Line
        {
            public string Initiator;
            public DateTime LineDateTime;
            public string Message;
        }

        public List<Line> GetLines()
        {
            return lines;
        }

        public string LogName
        {
            get
            {
                return strLogName;
            }
        }

        public ChatLog(string name)
        {
            this.strLogName = name;
            this.lines = new List<Line>();
        }

        public void AddLine(string strMessage, string strAgent)
        {
            this.AddLine(strMessage, strAgent, DateTime.Now);
        }

        public void AddLine(string strMessage, string strAgent, DateTime dt)
        {
            Line newLine = new Line();
            newLine.LineDateTime = dt;
            newLine.Message = strMessage;
            newLine.Initiator = strAgent;
            lines.Add(newLine);
        }

        public void AddLine(Line line)
        {
            lines.Add(line);
        }

        public void DeleteLine(int lnNumber)
        {
            lines.RemoveAt(lnNumber);
        }
    }
}
