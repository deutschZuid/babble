namespace Chat
{
    partial class frmChatlogDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatlogDisplay));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvwLogEntries = new System.Windows.Forms.ListView();
            this.lboListOfLogs = new System.Windows.Forms.ListBox();
            this.btnDeleteLogs = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctxLogEntries = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lvwLogEntries);
            this.panel2.Controls.Add(this.lboListOfLogs);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 315);
            this.panel2.TabIndex = 0;
            // 
            // lvwLogEntries
            // 
            this.lvwLogEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLogEntries.GridLines = true;
            this.lvwLogEntries.Location = new System.Drawing.Point(141, 0);
            this.lvwLogEntries.Name = "lvwLogEntries";
            this.lvwLogEntries.Size = new System.Drawing.Size(461, 315);
            this.lvwLogEntries.TabIndex = 1;
            this.lvwLogEntries.UseCompatibleStateImageBehavior = false;
            // 
            // lboListOfLogs
            // 
            this.lboListOfLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lboListOfLogs.FormattingEnabled = true;
            this.lboListOfLogs.Location = new System.Drawing.Point(0, 0);
            this.lboListOfLogs.Name = "lboListOfLogs";
            this.lboListOfLogs.Size = new System.Drawing.Size(135, 303);
            this.lboListOfLogs.TabIndex = 0;
            // 
            // btnDeleteLogs
            // 
            this.btnDeleteLogs.Location = new System.Drawing.Point(15, 11);
            this.btnDeleteLogs.Name = "btnDeleteLogs";
            this.btnDeleteLogs.Size = new System.Drawing.Size(119, 24);
            this.btnDeleteLogs.TabIndex = 2;
            this.btnDeleteLogs.Text = "Delete selected logs";
            this.btnDeleteLogs.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(529, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDeleteLogs);
            this.panel1.Location = new System.Drawing.Point(13, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 43);
            this.panel1.TabIndex = 1;
            // 
            // ctxLogEntries
            // 
            this.ctxLogEntries.Name = "ctxLogEntries";
            this.ctxLogEntries.Size = new System.Drawing.Size(61, 4);
            // 
            // frmChatlogDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(642, 414);
            this.Name = "frmChatlogDisplay";
            this.Text = "Chat Logs";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwLogEntries;
        private System.Windows.Forms.ListBox lboListOfLogs;
        private System.Windows.Forms.Button btnDeleteLogs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip ctxLogEntries;

    }
}