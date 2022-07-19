namespace Chat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.rtbType = new System.Windows.Forms.RichTextBox();
            this.ctxStandardContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.ctxMessageContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btSend = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctxStandardContext.SuspendLayout();
            this.ctxMessageContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbType
            // 
            this.rtbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbType.ContextMenuStrip = this.ctxStandardContext;
            this.rtbType.Location = new System.Drawing.Point(0, 0);
            this.rtbType.Name = "rtbType";
            this.rtbType.Size = new System.Drawing.Size(260, 69);
            this.rtbType.TabIndex = 0;
            this.rtbType.Text = "";
            this.rtbType.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbType_LinkClicked);
            this.rtbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbType_KeyDown);
            this.rtbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbType_KeyPress);
            this.rtbType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbType_KeyUp);
            // 
            // ctxStandardContext
            // 
            this.ctxStandardContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.ctxStandardContext.Name = "ctxStandardContext";
            this.ctxStandardContext.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessage.BackColor = global::Chat.Properties.Settings.Default.Background;
            this.rtbMessage.ContextMenuStrip = this.ctxMessageContext;
            this.rtbMessage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Chat.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.MinimumSize = new System.Drawing.Size(4, 200);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(340, 339);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            this.rtbMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbMessage_LinkClicked);
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            this.rtbMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbMessage_KeyPress);
            // 
            // ctxMessageContext
            // 
            this.ctxMessageContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.ctxMessageContext.Name = "ctxMessageContext";
            this.ctxMessageContext.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.ImageKey = "Mail.ico";
            this.btSend.ImageList = this.imageList1;
            this.btSend.Location = new System.Drawing.Point(266, 0);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(71, 69);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "absent-blue.ico");
            this.imageList1.Images.SetKeyName(1, "absent-green.ico");
            this.imageList1.Images.SetKeyName(2, "Add.ico");
            this.imageList1.Images.SetKeyName(3, "Administrator.ico");
            this.imageList1.Images.SetKeyName(4, "Adobe Illustator.ico");
            this.imageList1.Images.SetKeyName(5, "Applications Cascade.ico");
            this.imageList1.Images.SetKeyName(6, "Attach.ico");
            this.imageList1.Images.SetKeyName(7, "Bank Check.ico");
            this.imageList1.Images.SetKeyName(8, "Barcode.ico");
            this.imageList1.Images.SetKeyName(9, "bulle-blue.ico");
            this.imageList1.Images.SetKeyName(10, "bulle-green.ico");
            this.imageList1.Images.SetKeyName(11, "bulles.ico");
            this.imageList1.Images.SetKeyName(12, "Cancel.ico");
            this.imageList1.Images.SetKeyName(13, "Chat.ico");
            this.imageList1.Images.SetKeyName(14, "Clients.ico");
            this.imageList1.Images.SetKeyName(15, "Clipboard.ico");
            this.imageList1.Images.SetKeyName(16, "Close 2.ico");
            this.imageList1.Images.SetKeyName(17, "Close.ico");
            this.imageList1.Images.SetKeyName(18, "Coin.ico");
            this.imageList1.Images.SetKeyName(19, "Coinstack.ico");
            this.imageList1.Images.SetKeyName(20, "Contract.ico");
            this.imageList1.Images.SetKeyName(21, "Copy.ico");
            this.imageList1.Images.SetKeyName(22, "Delete.ico");
            this.imageList1.Images.SetKeyName(23, "Document Blank.ico");
            this.imageList1.Images.SetKeyName(24, "Document Write.ico");
            this.imageList1.Images.SetKeyName(25, "Document.ico");
            this.imageList1.Images.SetKeyName(26, "Download.ico");
            this.imageList1.Images.SetKeyName(27, "Favorite.ico");
            this.imageList1.Images.SetKeyName(28, "Files.ico");
            this.imageList1.Images.SetKeyName(29, "Folder Open.ico");
            this.imageList1.Images.SetKeyName(30, "Folder.ico");
            this.imageList1.Images.SetKeyName(31, "Font Open Type.ico");
            this.imageList1.Images.SetKeyName(32, "Gold Bar.ico");
            this.imageList1.Images.SetKeyName(33, "Help.ico");
            this.imageList1.Images.SetKeyName(34, "Home.ico");
            this.imageList1.Images.SetKeyName(35, "horligne.ico");
            this.imageList1.Images.SetKeyName(36, "Info.ico");
            this.imageList1.Images.SetKeyName(37, "Lamp.ico");
            this.imageList1.Images.SetKeyName(38, "Mail.ico");
            this.imageList1.Images.SetKeyName(39, "Messenger.ico");
            this.imageList1.Images.SetKeyName(40, "messenger-blue.ico");
            this.imageList1.Images.SetKeyName(41, "messenger-green.ico");
            this.imageList1.Images.SetKeyName(42, "Money.ico");
            this.imageList1.Images.SetKeyName(43, "Monitor.ico");
            this.imageList1.Images.SetKeyName(44, "Network Connections.ico");
            this.imageList1.Images.SetKeyName(45, "Network.ico");
            this.imageList1.Images.SetKeyName(46, "Notes.ico");
            this.imageList1.Images.SetKeyName(47, "occupé-blue.ico");
            this.imageList1.Images.SetKeyName(48, "occupé-green.ico");
            this.imageList1.Images.SetKeyName(49, "Office Girl.ico");
            this.imageList1.Images.SetKeyName(50, "Ok.ico");
            this.imageList1.Images.SetKeyName(51, "Paste.ico");
            this.imageList1.Images.SetKeyName(52, "Pen.ico");
            this.imageList1.Images.SetKeyName(53, "Preppy.ico");
            this.imageList1.Images.SetKeyName(54, "Preview.ico");
            this.imageList1.Images.SetKeyName(55, "Statistics.ico");
            this.imageList1.Images.SetKeyName(56, "stop.ico");
            this.imageList1.Images.SetKeyName(57, "stop-blue.ico");
            this.imageList1.Images.SetKeyName(58, "stop-green.ico");
            this.imageList1.Images.SetKeyName(59, "Text Bubble.ico");
            this.imageList1.Images.SetKeyName(60, "User Group.ico");
            this.imageList1.Images.SetKeyName(61, "Windows Magnifier.ico");
            this.imageList1.Images.SetKeyName(62, "World.ico");
            this.imageList1.Images.SetKeyName(63, "Zoom.ico");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btSend);
            this.panel1.Controls.Add(this.rtbType);
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 76);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rtbMessage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 339);
            this.panel2.TabIndex = 5;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(346, 201);
            this.Name = "ChatForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "IM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChatForm_Paint);
            this.ctxStandardContext.ResumeLayout(false);
            this.ctxMessageContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbType;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip ctxStandardContext;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMessageContext;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
    }
}

