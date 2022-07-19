namespace Chat
{
    partial class ImageSelectionForm
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
            this.lvwImages = new System.Windows.Forms.ListView();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwImages
            // 
            this.lvwImages.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvwImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwImages.GridLines = true;
            this.lvwImages.Location = new System.Drawing.Point(0, 0);
            this.lvwImages.MultiSelect = false;
            this.lvwImages.Name = "lvwImages";
            this.lvwImages.Size = new System.Drawing.Size(522, 224);
            this.lvwImages.TabIndex = 0;
            this.lvwImages.UseCompatibleStateImageBehavior = false;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOK.Location = new System.Drawing.Point(0, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(522, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ImageSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 257);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvwImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageSelectionForm";
            this.Text = "Select an Image";
            this.Load += new System.EventHandler(this.ImageSelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lvwImages;
    }
}