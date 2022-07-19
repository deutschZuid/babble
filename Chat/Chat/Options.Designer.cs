namespace Chat
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabChatWindow = new System.Windows.Forms.TabPage();
            this.groupChatNotification = new System.Windows.Forms.GroupBox();
            this.cboFlash = new System.Windows.Forms.CheckBox();
            this.cboSound = new System.Windows.Forms.CheckBox();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.txtLocalFGColor = new System.Windows.Forms.TextBox();
            this.txtRemoteFGColor = new System.Windows.Forms.TextBox();
            this.txtBGColor = new System.Windows.Forms.TextBox();
            this.btnRemoteFGcolor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLocalFGcolor = new System.Windows.Forms.Button();
            this.btnBgcolor = new System.Windows.Forms.Button();
            this.lblBGColor = new System.Windows.Forms.Label();
            this.lblLocalFGColor = new System.Windows.Forms.Label();
            this.lblRemoteFGColor = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabStartup = new System.Windows.Forms.TabPage();
            this.cboStartup = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.tipBGcolor = new System.Windows.Forms.ToolTip(this.components);
            this.tipLocalFGColor = new System.Windows.Forms.ToolTip(this.components);
            this.tipRemoteFGColor = new System.Windows.Forms.ToolTip(this.components);
            this.tipSoundOn = new System.Windows.Forms.ToolTip(this.components);
            this.tipFlashOn = new System.Windows.Forms.ToolTip(this.components);
            this.tabChatWindow.SuspendLayout();
            this.groupChatNotification.SuspendLayout();
            this.groupColor.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabStartup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChatWindow
            // 
            this.tabChatWindow.Controls.Add(this.groupChatNotification);
            this.tabChatWindow.Controls.Add(this.groupColor);
            this.tabChatWindow.Location = new System.Drawing.Point(4, 22);
            this.tabChatWindow.Name = "tabChatWindow";
            this.tabChatWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabChatWindow.Size = new System.Drawing.Size(257, 221);
            this.tabChatWindow.TabIndex = 0;
            this.tabChatWindow.Text = "Chat Window";
            this.tabChatWindow.UseVisualStyleBackColor = true;
            // 
            // groupChatNotification
            // 
            this.groupChatNotification.Controls.Add(this.cboFlash);
            this.groupChatNotification.Controls.Add(this.cboSound);
            this.groupChatNotification.Location = new System.Drawing.Point(0, 104);
            this.groupChatNotification.Name = "groupChatNotification";
            this.groupChatNotification.Size = new System.Drawing.Size(254, 67);
            this.groupChatNotification.TabIndex = 13;
            this.groupChatNotification.TabStop = false;
            this.groupChatNotification.Text = "Chat Notification";
            // 
            // cboFlash
            // 
            this.cboFlash.AutoSize = true;
            this.cboFlash.Location = new System.Drawing.Point(10, 42);
            this.cboFlash.Name = "cboFlash";
            this.cboFlash.Size = new System.Drawing.Size(159, 17);
            this.cboFlash.TabIndex = 5;
            this.cboFlash.Text = "Flash when message arrives";
            this.cboFlash.UseVisualStyleBackColor = true;
            // 
            // cboSound
            // 
            this.cboSound.AutoSize = true;
            this.cboSound.Location = new System.Drawing.Point(10, 19);
            this.cboSound.Name = "cboSound";
            this.cboSound.Size = new System.Drawing.Size(186, 17);
            this.cboSound.TabIndex = 4;
            this.cboSound.Text = "Play sound when message arrives";
            this.cboSound.UseVisualStyleBackColor = true;
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.txtLocalFGColor);
            this.groupColor.Controls.Add(this.txtRemoteFGColor);
            this.groupColor.Controls.Add(this.txtBGColor);
            this.groupColor.Controls.Add(this.btnRemoteFGcolor);
            this.groupColor.Controls.Add(this.btnLocalFGcolor);
            this.groupColor.Controls.Add(this.btnBgcolor);
            this.groupColor.Controls.Add(this.lblBGColor);
            this.groupColor.Controls.Add(this.lblLocalFGColor);
            this.groupColor.Controls.Add(this.lblRemoteFGColor);
            this.groupColor.Location = new System.Drawing.Point(1, 3);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(254, 92);
            this.groupColor.TabIndex = 12;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Colors";
            // 
            // txtLocalFGColor
            // 
            this.txtLocalFGColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLocalFGColor.Enabled = false;
            this.txtLocalFGColor.Location = new System.Drawing.Point(214, 40);
            this.txtLocalFGColor.Name = "txtLocalFGColor";
            this.txtLocalFGColor.Size = new System.Drawing.Size(22, 20);
            this.txtLocalFGColor.TabIndex = 8;
            this.txtLocalFGColor.TabStop = false;
            // 
            // txtRemoteFGColor
            // 
            this.txtRemoteFGColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRemoteFGColor.Enabled = false;
            this.txtRemoteFGColor.Location = new System.Drawing.Point(214, 65);
            this.txtRemoteFGColor.Name = "txtRemoteFGColor";
            this.txtRemoteFGColor.Size = new System.Drawing.Size(22, 20);
            this.txtRemoteFGColor.TabIndex = 7;
            this.txtRemoteFGColor.TabStop = false;
            // 
            // txtBGColor
            // 
            this.txtBGColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBGColor.Enabled = false;
            this.txtBGColor.Location = new System.Drawing.Point(214, 15);
            this.txtBGColor.Name = "txtBGColor";
            this.txtBGColor.Size = new System.Drawing.Size(22, 20);
            this.txtBGColor.TabIndex = 6;
            this.txtBGColor.TabStop = false;
            // 
            // btnRemoteFGcolor
            // 
            this.btnRemoteFGcolor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoteFGcolor.ImageKey = "Statistics.ico";
            this.btnRemoteFGcolor.ImageList = this.imageList1;
            this.btnRemoteFGcolor.Location = new System.Drawing.Point(97, 65);
            this.btnRemoteFGcolor.Name = "btnRemoteFGcolor";
            this.btnRemoteFGcolor.Size = new System.Drawing.Size(111, 20);
            this.btnRemoteFGcolor.TabIndex = 3;
            this.btnRemoteFGcolor.Text = "Browse for color";
            this.btnRemoteFGcolor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoteFGcolor.UseVisualStyleBackColor = true;
            this.btnRemoteFGcolor.Click += new System.EventHandler(this.btnRemoteFGcolor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ok.ico");
            this.imageList1.Images.SetKeyName(1, "absent-blue.ico");
            this.imageList1.Images.SetKeyName(2, "absent-green.ico");
            this.imageList1.Images.SetKeyName(3, "Add.ico");
            this.imageList1.Images.SetKeyName(4, "Administrator.ico");
            this.imageList1.Images.SetKeyName(5, "Adobe Illustator.ico");
            this.imageList1.Images.SetKeyName(6, "Applications Cascade.ico");
            this.imageList1.Images.SetKeyName(7, "Attach.ico");
            this.imageList1.Images.SetKeyName(8, "Bank Check.ico");
            this.imageList1.Images.SetKeyName(9, "Barcode.ico");
            this.imageList1.Images.SetKeyName(10, "bulle-blue.ico");
            this.imageList1.Images.SetKeyName(11, "bulle-green.ico");
            this.imageList1.Images.SetKeyName(12, "bulles.ico");
            this.imageList1.Images.SetKeyName(13, "Cancel.ico");
            this.imageList1.Images.SetKeyName(14, "Chat.ico");
            this.imageList1.Images.SetKeyName(15, "Clients.ico");
            this.imageList1.Images.SetKeyName(16, "Clipboard.ico");
            this.imageList1.Images.SetKeyName(17, "Close 2.ico");
            this.imageList1.Images.SetKeyName(18, "Close.ico");
            this.imageList1.Images.SetKeyName(19, "Coin.ico");
            this.imageList1.Images.SetKeyName(20, "Coinstack.ico");
            this.imageList1.Images.SetKeyName(21, "Contract.ico");
            this.imageList1.Images.SetKeyName(22, "Copy.ico");
            this.imageList1.Images.SetKeyName(23, "Delete.ico");
            this.imageList1.Images.SetKeyName(24, "Document Blank.ico");
            this.imageList1.Images.SetKeyName(25, "Document Write.ico");
            this.imageList1.Images.SetKeyName(26, "Document.ico");
            this.imageList1.Images.SetKeyName(27, "Download.ico");
            this.imageList1.Images.SetKeyName(28, "Favorite.ico");
            this.imageList1.Images.SetKeyName(29, "Files.ico");
            this.imageList1.Images.SetKeyName(30, "Folder Open.ico");
            this.imageList1.Images.SetKeyName(31, "Folder.ico");
            this.imageList1.Images.SetKeyName(32, "Font Open Type.ico");
            this.imageList1.Images.SetKeyName(33, "Gold Bar.ico");
            this.imageList1.Images.SetKeyName(34, "Help.ico");
            this.imageList1.Images.SetKeyName(35, "Home.ico");
            this.imageList1.Images.SetKeyName(36, "horligne.ico");
            this.imageList1.Images.SetKeyName(37, "Info.ico");
            this.imageList1.Images.SetKeyName(38, "Lamp.ico");
            this.imageList1.Images.SetKeyName(39, "Mail.ico");
            this.imageList1.Images.SetKeyName(40, "Messenger.ico");
            this.imageList1.Images.SetKeyName(41, "messenger-blue.ico");
            this.imageList1.Images.SetKeyName(42, "messenger-green.ico");
            this.imageList1.Images.SetKeyName(43, "Money.ico");
            this.imageList1.Images.SetKeyName(44, "Monitor.ico");
            this.imageList1.Images.SetKeyName(45, "Network Connections.ico");
            this.imageList1.Images.SetKeyName(46, "Network.ico");
            this.imageList1.Images.SetKeyName(47, "Notes.ico");
            this.imageList1.Images.SetKeyName(48, "occupé-blue.ico");
            this.imageList1.Images.SetKeyName(49, "occupé-green.ico");
            this.imageList1.Images.SetKeyName(50, "Office Girl.ico");
            this.imageList1.Images.SetKeyName(51, "Ok.ico");
            this.imageList1.Images.SetKeyName(52, "Paste.ico");
            this.imageList1.Images.SetKeyName(53, "Pen.ico");
            this.imageList1.Images.SetKeyName(54, "Preppy.ico");
            this.imageList1.Images.SetKeyName(55, "Preview.ico");
            this.imageList1.Images.SetKeyName(56, "Statistics.ico");
            this.imageList1.Images.SetKeyName(57, "stop.ico");
            this.imageList1.Images.SetKeyName(58, "stop-blue.ico");
            this.imageList1.Images.SetKeyName(59, "stop-green.ico");
            this.imageList1.Images.SetKeyName(60, "Text Bubble.ico");
            this.imageList1.Images.SetKeyName(61, "User Group.ico");
            this.imageList1.Images.SetKeyName(62, "Windows Magnifier.ico");
            this.imageList1.Images.SetKeyName(63, "World.ico");
            this.imageList1.Images.SetKeyName(64, "Zoom.ico");
            // 
            // btnLocalFGcolor
            // 
            this.btnLocalFGcolor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalFGcolor.ImageKey = "Statistics.ico";
            this.btnLocalFGcolor.ImageList = this.imageList1;
            this.btnLocalFGcolor.Location = new System.Drawing.Point(97, 40);
            this.btnLocalFGcolor.Name = "btnLocalFGcolor";
            this.btnLocalFGcolor.Size = new System.Drawing.Size(111, 20);
            this.btnLocalFGcolor.TabIndex = 2;
            this.btnLocalFGcolor.Text = "Browse for color";
            this.btnLocalFGcolor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalFGcolor.UseVisualStyleBackColor = true;
            this.btnLocalFGcolor.Click += new System.EventHandler(this.btnLocalFGcolor_Click);
            // 
            // btnBgcolor
            // 
            this.btnBgcolor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBgcolor.ImageKey = "Statistics.ico";
            this.btnBgcolor.ImageList = this.imageList1;
            this.btnBgcolor.Location = new System.Drawing.Point(97, 15);
            this.btnBgcolor.Name = "btnBgcolor";
            this.btnBgcolor.Size = new System.Drawing.Size(111, 20);
            this.btnBgcolor.TabIndex = 1;
            this.btnBgcolor.Text = "Browse for color";
            this.btnBgcolor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBgcolor.UseVisualStyleBackColor = true;
            this.btnBgcolor.Click += new System.EventHandler(this.btnBgcolor_Click);
            // 
            // lblBGColor
            // 
            this.lblBGColor.AutoSize = true;
            this.lblBGColor.Location = new System.Drawing.Point(6, 17);
            this.lblBGColor.Name = "lblBGColor";
            this.lblBGColor.Size = new System.Drawing.Size(49, 13);
            this.lblBGColor.TabIndex = 0;
            this.lblBGColor.Text = "BG Color";
            // 
            // lblLocalFGColor
            // 
            this.lblLocalFGColor.AutoSize = true;
            this.lblLocalFGColor.Location = new System.Drawing.Point(6, 42);
            this.lblLocalFGColor.Name = "lblLocalFGColor";
            this.lblLocalFGColor.Size = new System.Drawing.Size(77, 13);
            this.lblLocalFGColor.TabIndex = 1;
            this.lblLocalFGColor.Text = "Local FG Color";
            // 
            // lblRemoteFGColor
            // 
            this.lblRemoteFGColor.AutoSize = true;
            this.lblRemoteFGColor.Location = new System.Drawing.Point(6, 67);
            this.lblRemoteFGColor.Name = "lblRemoteFGColor";
            this.lblRemoteFGColor.Size = new System.Drawing.Size(88, 13);
            this.lblRemoteFGColor.TabIndex = 2;
            this.lblRemoteFGColor.Text = "Remote FG Color";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabChatWindow);
            this.TabControl.Controls.Add(this.tabStartup);
            this.TabControl.Location = new System.Drawing.Point(0, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(265, 247);
            this.TabControl.TabIndex = 3;
            // 
            // tabStartup
            // 
            this.tabStartup.Controls.Add(this.cboStartup);
            this.tabStartup.Location = new System.Drawing.Point(4, 22);
            this.tabStartup.Name = "tabStartup";
            this.tabStartup.Size = new System.Drawing.Size(257, 221);
            this.tabStartup.TabIndex = 1;
            this.tabStartup.Text = "Startup";
            this.tabStartup.UseVisualStyleBackColor = true;
            // 
            // cboStartup
            // 
            this.cboStartup.AutoSize = true;
            this.cboStartup.Location = new System.Drawing.Point(12, 16);
            this.cboStartup.Name = "cboStartup";
            this.cboStartup.Size = new System.Drawing.Size(236, 17);
            this.cboStartup.TabIndex = 0;
            this.cboStartup.Text = "Always run Babble when I log onto Windows";
            this.cboStartup.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.ImageKey = "Ok.ico";
            this.btnAccept.ImageList = this.imageList1;
            this.btnAccept.Location = new System.Drawing.Point(4, 250);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(108, 25);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept changes";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "Cancel.ico";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(114, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDefaults.ImageKey = "Statistics.ico";
            this.buttonDefaults.ImageList = this.imageList1;
            this.buttonDefaults.Location = new System.Drawing.Point(188, 250);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(71, 25);
            this.buttonDefaults.TabIndex = 9;
            this.buttonDefaults.Text = "Defaults";
            this.buttonDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // tipBGcolor
            // 
            this.tipBGcolor.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipLocalFGColor
            // 
            this.tipLocalFGColor.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipRemoteFGColor
            // 
            this.tipRemoteFGColor.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipSoundOn
            // 
            this.tipSoundOn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipFlashOn
            // 
            this.tipFlashOn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(264, 281);
            this.Controls.Add(this.buttonDefaults);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabChatWindow.ResumeLayout(false);
            this.groupChatNotification.ResumeLayout(false);
            this.groupChatNotification.PerformLayout();
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabStartup.ResumeLayout(false);
            this.tabStartup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tabChatWindow;
        private System.Windows.Forms.TextBox txtLocalFGColor;
        private System.Windows.Forms.TextBox txtRemoteFGColor;
        private System.Windows.Forms.TextBox txtBGColor;
        private System.Windows.Forms.Button btnRemoteFGcolor;
        private System.Windows.Forms.Button btnLocalFGcolor;
        private System.Windows.Forms.Button btnBgcolor;
        private System.Windows.Forms.Label lblBGColor;
        private System.Windows.Forms.Label lblLocalFGColor;
        private System.Windows.Forms.Label lblRemoteFGColor;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.ToolTip tipBGcolor;
        private System.Windows.Forms.ToolTip tipLocalFGColor;
        private System.Windows.Forms.ToolTip tipRemoteFGColor;
        private System.Windows.Forms.GroupBox groupChatNotification;
        private System.Windows.Forms.CheckBox cboFlash;
        private System.Windows.Forms.CheckBox cboSound;
        private System.Windows.Forms.ToolTip tipSoundOn;
        private System.Windows.Forms.ToolTip tipFlashOn;
        private System.Windows.Forms.TabPage tabStartup;
        private System.Windows.Forms.CheckBox cboStartup;
    }
}