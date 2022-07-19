namespace Chat
{
    partial class AddNewBuddyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBuddyForm));
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNickNameTip = new System.Windows.Forms.Label();
            this.lblHostNameTip = new System.Windows.Forms.Label();
            this.lblEmailTip = new System.Windows.Forms.Label();
            this.lblRatingTip = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.trackRating = new System.Windows.Forms.TrackBar();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblImageTip = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tipNickName = new System.Windows.Forms.ToolTip(this.components);
            this.tipHostname = new System.Windows.Forms.ToolTip(this.components);
            this.tipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.tipRating = new System.Windows.Forms.ToolTip(this.components);
            this.tipImage = new System.Windows.Forms.ToolTip(this.components);
            this.txtSelectedImageIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(155, 26);
            this.txtNickname.MaxLength = 50;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(115, 20);
            this.txtNickname.TabIndex = 0;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(155, 66);
            this.txtHost.MaxLength = 100;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(115, 20);
            this.txtHost.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 106);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNickName.ImageKey = "Preppy.ico";
            this.lblNickName.ImageList = this.imageList1;
            this.lblNickName.Location = new System.Drawing.Point(9, 26);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(84, 15);
            this.lblNickName.TabIndex = 3;
            this.lblNickName.Text = "       Nickname";
            this.lblNickName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHostName.ImageKey = "Network Connections.ico";
            this.lblHostName.ImageList = this.imageList1;
            this.lblHostName.Location = new System.Drawing.Point(9, 66);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(116, 15);
            this.lblHostName.TabIndex = 4;
            this.lblHostName.Text = "       Hostname or IP:";
            this.lblHostName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.ImageKey = "Bank Check.ico";
            this.lblEmail.ImageList = this.imageList1;
            this.lblEmail.Location = new System.Drawing.Point(9, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "       Email Addy:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNickNameTip
            // 
            this.lblNickNameTip.AutoSize = true;
            this.lblNickNameTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickNameTip.ImageKey = "Help.ico";
            this.lblNickNameTip.ImageList = this.imageList1;
            this.lblNickNameTip.Location = new System.Drawing.Point(125, 26);
            this.lblNickNameTip.Name = "lblNickNameTip";
            this.lblNickNameTip.Size = new System.Drawing.Size(22, 15);
            this.lblNickNameTip.TabIndex = 7;
            this.lblNickNameTip.Text = "     ";
            this.lblNickNameTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHostNameTip
            // 
            this.lblHostNameTip.AutoSize = true;
            this.lblHostNameTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostNameTip.ImageKey = "Help.ico";
            this.lblHostNameTip.ImageList = this.imageList1;
            this.lblHostNameTip.Location = new System.Drawing.Point(128, 66);
            this.lblHostNameTip.Name = "lblHostNameTip";
            this.lblHostNameTip.Size = new System.Drawing.Size(16, 15);
            this.lblHostNameTip.TabIndex = 8;
            this.lblHostNameTip.Text = "   ";
            this.lblHostNameTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailTip
            // 
            this.lblEmailTip.AutoSize = true;
            this.lblEmailTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTip.ImageKey = "Help.ico";
            this.lblEmailTip.ImageList = this.imageList1;
            this.lblEmailTip.Location = new System.Drawing.Point(128, 106);
            this.lblEmailTip.Name = "lblEmailTip";
            this.lblEmailTip.Size = new System.Drawing.Size(16, 15);
            this.lblEmailTip.TabIndex = 9;
            this.lblEmailTip.Text = "   ";
            this.lblEmailTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRatingTip
            // 
            this.lblRatingTip.AutoSize = true;
            this.lblRatingTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingTip.ImageKey = "Help.ico";
            this.lblRatingTip.ImageList = this.imageList1;
            this.lblRatingTip.Location = new System.Drawing.Point(128, 146);
            this.lblRatingTip.Name = "lblRatingTip";
            this.lblRatingTip.Size = new System.Drawing.Size(16, 15);
            this.lblRatingTip.TabIndex = 11;
            this.lblRatingTip.Text = "   ";
            this.lblRatingTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRating.ImageKey = "Favorite.ico";
            this.lblRating.ImageList = this.imageList1;
            this.lblRating.Location = new System.Drawing.Point(9, 146);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(67, 15);
            this.lblRating.TabIndex = 12;
            this.lblRating.Text = "       Rating:";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackRating
            // 
            this.trackRating.Location = new System.Drawing.Point(150, 142);
            this.trackRating.Name = "trackRating";
            this.trackRating.Size = new System.Drawing.Size(95, 45);
            this.trackRating.TabIndex = 13;
            this.trackRating.Value = 5;
            this.trackRating.Scroll += new System.EventHandler(this.trackRating_Scroll);
            // 
            // txtRating
            // 
            this.txtRating.ForeColor = System.Drawing.Color.Lime;
            this.txtRating.Location = new System.Drawing.Point(247, 149);
            this.txtRating.MaxLength = 2;
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(23, 20);
            this.txtRating.TabIndex = 4;
            this.txtRating.Text = "5";
            this.txtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRating.TextChanged += new System.EventHandler(this.txtRating_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.ImageKey = "Ok.ico";
            this.btnAccept.ImageList = this.imageList1;
            this.btnAccept.Location = new System.Drawing.Point(44, 258);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 23);
            this.btnAccept.TabIndex = 15;
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
            this.btnCancel.Location = new System.Drawing.Point(150, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImage.ImageKey = "Adobe Illustator.ico";
            this.lblImage.ImageList = this.imageList1;
            this.lblImage.Location = new System.Drawing.Point(9, 186);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(63, 15);
            this.lblImage.TabIndex = 17;
            this.lblImage.Text = "       Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImageTip
            // 
            this.lblImageTip.AutoSize = true;
            this.lblImageTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageTip.ImageKey = "Help.ico";
            this.lblImageTip.ImageList = this.imageList1;
            this.lblImageTip.Location = new System.Drawing.Point(128, 186);
            this.lblImageTip.Name = "lblImageTip";
            this.lblImageTip.Size = new System.Drawing.Size(16, 15);
            this.lblImageTip.TabIndex = 18;
            this.lblImageTip.Text = "   ";
            this.lblImageTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "0.ico");
            this.imageList2.Images.SetKeyName(1, "1.ico");
            this.imageList2.Images.SetKeyName(2, "2.ico");
            this.imageList2.Images.SetKeyName(3, "3.ico");
            this.imageList2.Images.SetKeyName(4, "4.ico");
            this.imageList2.Images.SetKeyName(5, "5.ico");
            this.imageList2.Images.SetKeyName(6, "6.ico");
            this.imageList2.Images.SetKeyName(7, "7.ico");
            this.imageList2.Images.SetKeyName(8, "8.ico");
            this.imageList2.Images.SetKeyName(9, "9.ico");
            this.imageList2.Images.SetKeyName(10, "10.ico");
            this.imageList2.Images.SetKeyName(11, "11.ico");
            this.imageList2.Images.SetKeyName(12, "12.ico");
            this.imageList2.Images.SetKeyName(13, "13.ico");
            this.imageList2.Images.SetKeyName(14, "14.ico");
            this.imageList2.Images.SetKeyName(15, "15.ico");
            this.imageList2.Images.SetKeyName(16, "16.ico");
            this.imageList2.Images.SetKeyName(17, "17.ico");
            this.imageList2.Images.SetKeyName(18, "18.ico");
            this.imageList2.Images.SetKeyName(19, "19.ico");
            this.imageList2.Images.SetKeyName(20, "20.ico");
            this.imageList2.Images.SetKeyName(21, "21.ico");
            this.imageList2.Images.SetKeyName(22, "22.ico");
            this.imageList2.Images.SetKeyName(23, "23.ico");
            this.imageList2.Images.SetKeyName(24, "24.ico");
            this.imageList2.Images.SetKeyName(25, "25.ico");
            this.imageList2.Images.SetKeyName(26, "26.ico");
            this.imageList2.Images.SetKeyName(27, "27.ico");
            this.imageList2.Images.SetKeyName(28, "28.ico");
            this.imageList2.Images.SetKeyName(29, "29.ico");
            this.imageList2.Images.SetKeyName(30, "30.ico");
            this.imageList2.Images.SetKeyName(31, "31.ico");
            this.imageList2.Images.SetKeyName(32, "32.ico");
            this.imageList2.Images.SetKeyName(33, "33.ico");
            this.imageList2.Images.SetKeyName(34, "34.ico");
            this.imageList2.Images.SetKeyName(35, "35.ico");
            this.imageList2.Images.SetKeyName(36, "36.ico");
            this.imageList2.Images.SetKeyName(37, "37.ico");
            this.imageList2.Images.SetKeyName(38, "38.ico");
            this.imageList2.Images.SetKeyName(39, "39.ico");
            this.imageList2.Images.SetKeyName(40, "40.ico");
            this.imageList2.Images.SetKeyName(41, "41.ico");
            this.imageList2.Images.SetKeyName(42, "42.ico");
            this.imageList2.Images.SetKeyName(43, "43.ico");
            this.imageList2.Images.SetKeyName(44, "44.ico");
            this.imageList2.Images.SetKeyName(45, "45.ico");
            this.imageList2.Images.SetKeyName(46, "46.ico");
            this.imageList2.Images.SetKeyName(47, "47.ico");
            this.imageList2.Images.SetKeyName(48, "48.ico");
            this.imageList2.Images.SetKeyName(49, "49.ico");
            this.imageList2.Images.SetKeyName(50, "50.ico");
            this.imageList2.Images.SetKeyName(51, "51.ico");
            this.imageList2.Images.SetKeyName(52, "52.ico");
            this.imageList2.Images.SetKeyName(53, "53.ico");
            this.imageList2.Images.SetKeyName(54, "54.ico");
            this.imageList2.Images.SetKeyName(55, "55.ico");
            this.imageList2.Images.SetKeyName(56, "56.ico");
            this.imageList2.Images.SetKeyName(57, "57.ico");
            this.imageList2.Images.SetKeyName(58, "58.ico");
            this.imageList2.Images.SetKeyName(59, "59.ico");
            this.imageList2.Images.SetKeyName(60, "60.ico");
            this.imageList2.Images.SetKeyName(61, "61.ico");
            this.imageList2.Images.SetKeyName(62, "62.ico");
            this.imageList2.Images.SetKeyName(63, "63.ico");
            this.imageList2.Images.SetKeyName(64, "64.ico");
            this.imageList2.Images.SetKeyName(65, "65.ico");
            this.imageList2.Images.SetKeyName(66, "66.ico");
            this.imageList2.Images.SetKeyName(67, "67.ico");
            this.imageList2.Images.SetKeyName(68, "68.ico");
            this.imageList2.Images.SetKeyName(69, "69.ico");
            this.imageList2.Images.SetKeyName(70, "70.ico");
            this.imageList2.Images.SetKeyName(71, "71.ico");
            this.imageList2.Images.SetKeyName(72, "72.ico");
            this.imageList2.Images.SetKeyName(73, "73.ico");
            this.imageList2.Images.SetKeyName(74, "74.ico");
            this.imageList2.Images.SetKeyName(75, "75.ico");
            this.imageList2.Images.SetKeyName(76, "76.ico");
            this.imageList2.Images.SetKeyName(77, "77.ico");
            this.imageList2.Images.SetKeyName(78, "78.ico");
            this.imageList2.Images.SetKeyName(79, "79.ico");
            this.imageList2.Images.SetKeyName(80, "80.ico");
            this.imageList2.Images.SetKeyName(81, "81.ico");
            this.imageList2.Images.SetKeyName(82, "82.ico");
            this.imageList2.Images.SetKeyName(83, "83.ico");
            this.imageList2.Images.SetKeyName(84, "84.ico");
            this.imageList2.Images.SetKeyName(85, "85.ico");
            this.imageList2.Images.SetKeyName(86, "86.ico");
            this.imageList2.Images.SetKeyName(87, "87.ico");
            this.imageList2.Images.SetKeyName(88, "88.ico");
            this.imageList2.Images.SetKeyName(89, "89.ico");
            this.imageList2.Images.SetKeyName(90, "90.ico");
            this.imageList2.Images.SetKeyName(91, "91.ico");
            this.imageList2.Images.SetKeyName(92, "92.ico");
            this.imageList2.Images.SetKeyName(93, "93.ico");
            this.imageList2.Images.SetKeyName(94, "94.ico");
            this.imageList2.Images.SetKeyName(95, "95.ico");
            this.imageList2.Images.SetKeyName(96, "96.ico");
            this.imageList2.Images.SetKeyName(97, "97.ico");
            this.imageList2.Images.SetKeyName(98, "98.ico");
            this.imageList2.Images.SetKeyName(99, "99.ico");
            this.imageList2.Images.SetKeyName(100, "100.ico");
            this.imageList2.Images.SetKeyName(101, "101.ico");
            this.imageList2.Images.SetKeyName(102, "102.ico");
            this.imageList2.Images.SetKeyName(103, "103.ico");
            this.imageList2.Images.SetKeyName(104, "104.ico");
            this.imageList2.Images.SetKeyName(105, "105.ico");
            this.imageList2.Images.SetKeyName(106, "106.ico");
            this.imageList2.Images.SetKeyName(107, "107.ico");
            this.imageList2.Images.SetKeyName(108, "108.ico");
            this.imageList2.Images.SetKeyName(109, "109.ico");
            this.imageList2.Images.SetKeyName(110, "110.ico");
            this.imageList2.Images.SetKeyName(111, "111.ico");
            this.imageList2.Images.SetKeyName(112, "112.ico");
            this.imageList2.Images.SetKeyName(113, "113.ico");
            this.imageList2.Images.SetKeyName(114, "114.ico");
            this.imageList2.Images.SetKeyName(115, "115.ico");
            this.imageList2.Images.SetKeyName(116, "116.ico");
            this.imageList2.Images.SetKeyName(117, "117.ico");
            this.imageList2.Images.SetKeyName(118, "118.ico");
            this.imageList2.Images.SetKeyName(119, "119.ico");
            this.imageList2.Images.SetKeyName(120, "120.ico");
            this.imageList2.Images.SetKeyName(121, "121.ico");
            this.imageList2.Images.SetKeyName(122, "122.ico");
            this.imageList2.Images.SetKeyName(123, "123.ico");
            this.imageList2.Images.SetKeyName(124, "124.ico");
            this.imageList2.Images.SetKeyName(125, "125.ico");
            this.imageList2.Images.SetKeyName(126, "126.ico");
            this.imageList2.Images.SetKeyName(127, "127.ico");
            this.imageList2.Images.SetKeyName(128, "128.ico");
            this.imageList2.Images.SetKeyName(129, "129.ico");
            this.imageList2.Images.SetKeyName(130, "130.ico");
            this.imageList2.Images.SetKeyName(131, "131.ico");
            this.imageList2.Images.SetKeyName(132, "132.ico");
            this.imageList2.Images.SetKeyName(133, "133.ico");
            this.imageList2.Images.SetKeyName(134, "134.ico");
            this.imageList2.Images.SetKeyName(135, "135.ico");
            this.imageList2.Images.SetKeyName(136, "136.ico");
            this.imageList2.Images.SetKeyName(137, "137.ico");
            this.imageList2.Images.SetKeyName(138, "138.ico");
            this.imageList2.Images.SetKeyName(139, "139.ico");
            this.imageList2.Images.SetKeyName(140, "140.ico");
            this.imageList2.Images.SetKeyName(141, "141.ico");
            this.imageList2.Images.SetKeyName(142, "142.ico");
            this.imageList2.Images.SetKeyName(143, "143.ico");
            this.imageList2.Images.SetKeyName(144, "144.ico");
            this.imageList2.Images.SetKeyName(145, "145.ico");
            this.imageList2.Images.SetKeyName(146, "146.ico");
            this.imageList2.Images.SetKeyName(147, "147.ico");
            this.imageList2.Images.SetKeyName(148, "148.ico");
            this.imageList2.Images.SetKeyName(149, "149.ico");
            this.imageList2.Images.SetKeyName(150, "150.ico");
            this.imageList2.Images.SetKeyName(151, "151.ico");
            this.imageList2.Images.SetKeyName(152, "152.ico");
            this.imageList2.Images.SetKeyName(153, "153.ico");
            this.imageList2.Images.SetKeyName(154, "154.ico");
            this.imageList2.Images.SetKeyName(155, "155.ico");
            this.imageList2.Images.SetKeyName(156, "156.ico");
            this.imageList2.Images.SetKeyName(157, "157.ico");
            this.imageList2.Images.SetKeyName(158, "158.ico");
            this.imageList2.Images.SetKeyName(159, "159.ico");
            this.imageList2.Images.SetKeyName(160, "160.ico");
            this.imageList2.Images.SetKeyName(161, "161.ico");
            this.imageList2.Images.SetKeyName(162, "162.ico");
            this.imageList2.Images.SetKeyName(163, "163.ico");
            this.imageList2.Images.SetKeyName(164, "164.ico");
            this.imageList2.Images.SetKeyName(165, "165.ico");
            this.imageList2.Images.SetKeyName(166, "166.ico");
            this.imageList2.Images.SetKeyName(167, "167.ico");
            this.imageList2.Images.SetKeyName(168, "168.ico");
            this.imageList2.Images.SetKeyName(169, "169.ico");
            this.imageList2.Images.SetKeyName(170, "170.ico");
            this.imageList2.Images.SetKeyName(171, "171.ico");
            this.imageList2.Images.SetKeyName(172, "172.ico");
            this.imageList2.Images.SetKeyName(173, "173.ico");
            this.imageList2.Images.SetKeyName(174, "174.ico");
            this.imageList2.Images.SetKeyName(175, "175.ico");
            this.imageList2.Images.SetKeyName(176, "176.ico");
            this.imageList2.Images.SetKeyName(177, "177.ico");
            this.imageList2.Images.SetKeyName(178, "178.ico");
            this.imageList2.Images.SetKeyName(179, "179.ico");
            this.imageList2.Images.SetKeyName(180, "180.ico");
            this.imageList2.Images.SetKeyName(181, "181.ico");
            this.imageList2.Images.SetKeyName(182, "182.ico");
            this.imageList2.Images.SetKeyName(183, "183.ico");
            this.imageList2.Images.SetKeyName(184, "184.ico");
            this.imageList2.Images.SetKeyName(185, "185.ico");
            this.imageList2.Images.SetKeyName(186, "186.ico");
            this.imageList2.Images.SetKeyName(187, "187.ico");
            this.imageList2.Images.SetKeyName(188, "188.ico");
            this.imageList2.Images.SetKeyName(189, "189.ico");
            this.imageList2.Images.SetKeyName(190, "190.ico");
            this.imageList2.Images.SetKeyName(191, "191.ico");
            this.imageList2.Images.SetKeyName(192, "192.ico");
            this.imageList2.Images.SetKeyName(193, "193.ico");
            this.imageList2.Images.SetKeyName(194, "194.ico");
            this.imageList2.Images.SetKeyName(195, "195.ico");
            this.imageList2.Images.SetKeyName(196, "196.ico");
            this.imageList2.Images.SetKeyName(197, "197.ico");
            this.imageList2.Images.SetKeyName(198, "198.ico");
            this.imageList2.Images.SetKeyName(199, "199.ico");
            this.imageList2.Images.SetKeyName(200, "200.ico");
            this.imageList2.Images.SetKeyName(201, "201.ico");
            this.imageList2.Images.SetKeyName(202, "202.ico");
            this.imageList2.Images.SetKeyName(203, "203.ico");
            this.imageList2.Images.SetKeyName(204, "204.ico");
            this.imageList2.Images.SetKeyName(205, "205.ico");
            this.imageList2.Images.SetKeyName(206, "206.ico");
            this.imageList2.Images.SetKeyName(207, "207.ico");
            this.imageList2.Images.SetKeyName(208, "208.ico");
            this.imageList2.Images.SetKeyName(209, "209.ico");
            this.imageList2.Images.SetKeyName(210, "210.ico");
            this.imageList2.Images.SetKeyName(211, "211.ico");
            this.imageList2.Images.SetKeyName(212, "212.ico");
            this.imageList2.Images.SetKeyName(213, "213.ico");
            this.imageList2.Images.SetKeyName(214, "214.ico");
            this.imageList2.Images.SetKeyName(215, "215.ico");
            this.imageList2.Images.SetKeyName(216, "216.ico");
            this.imageList2.Images.SetKeyName(217, "217.ico");
            this.imageList2.Images.SetKeyName(218, "218.ico");
            this.imageList2.Images.SetKeyName(219, "219.ico");
            this.imageList2.Images.SetKeyName(220, "220.ico");
            this.imageList2.Images.SetKeyName(221, "221.ico");
            this.imageList2.Images.SetKeyName(222, "222.ico");
            this.imageList2.Images.SetKeyName(223, "223.ico");
            this.imageList2.Images.SetKeyName(224, "224.ico");
            this.imageList2.Images.SetKeyName(225, "225.ico");
            this.imageList2.Images.SetKeyName(226, "226.ico");
            this.imageList2.Images.SetKeyName(227, "227.ico");
            this.imageList2.Images.SetKeyName(228, "228.ico");
            this.imageList2.Images.SetKeyName(229, "229.ico");
            this.imageList2.Images.SetKeyName(230, "230.ico");
            this.imageList2.Images.SetKeyName(231, "231.ico");
            this.imageList2.Images.SetKeyName(232, "232.ico");
            this.imageList2.Images.SetKeyName(233, "233.ico");
            this.imageList2.Images.SetKeyName(234, "234.ico");
            this.imageList2.Images.SetKeyName(235, "235.ico");
            this.imageList2.Images.SetKeyName(236, "236.ico");
            this.imageList2.Images.SetKeyName(237, "237.ico");
            this.imageList2.Images.SetKeyName(238, "238.ico");
            this.imageList2.Images.SetKeyName(239, "239.ico");
            this.imageList2.Images.SetKeyName(240, "240.ico");
            this.imageList2.Images.SetKeyName(241, "241.ico");
            this.imageList2.Images.SetKeyName(242, "242.ico");
            this.imageList2.Images.SetKeyName(243, "243.ico");
            this.imageList2.Images.SetKeyName(244, "244.ico");
            this.imageList2.Images.SetKeyName(245, "245.ico");
            this.imageList2.Images.SetKeyName(246, "246.ico");
            this.imageList2.Images.SetKeyName(247, "247.ico");
            this.imageList2.Images.SetKeyName(248, "248.ico");
            this.imageList2.Images.SetKeyName(249, "249.ico");
            this.imageList2.Images.SetKeyName(250, "250.ico");
            this.imageList2.Images.SetKeyName(251, "251.ico");
            this.imageList2.Images.SetKeyName(252, "252.ico");
            this.imageList2.Images.SetKeyName(253, "253.ico");
            this.imageList2.Images.SetKeyName(254, "254.ico");
            this.imageList2.Images.SetKeyName(255, "255.ico");
            this.imageList2.Images.SetKeyName(256, "256.ico");
            this.imageList2.Images.SetKeyName(257, "257.ico");
            this.imageList2.Images.SetKeyName(258, "258.ico");
            this.imageList2.Images.SetKeyName(259, "259.ico");
            this.imageList2.Images.SetKeyName(260, "260.ico");
            this.imageList2.Images.SetKeyName(261, "261.ico");
            this.imageList2.Images.SetKeyName(262, "262.ico");
            this.imageList2.Images.SetKeyName(263, "263.ico");
            this.imageList2.Images.SetKeyName(264, "264.ico");
            this.imageList2.Images.SetKeyName(265, "265.ico");
            this.imageList2.Images.SetKeyName(266, "266.ico");
            this.imageList2.Images.SetKeyName(267, "267.ico");
            this.imageList2.Images.SetKeyName(268, "268.ico");
            this.imageList2.Images.SetKeyName(269, "269.ico");
            this.imageList2.Images.SetKeyName(270, "270.ico");
            this.imageList2.Images.SetKeyName(271, "271.ico");
            this.imageList2.Images.SetKeyName(272, "272.ico");
            this.imageList2.Images.SetKeyName(273, "273.ico");
            this.imageList2.Images.SetKeyName(274, "274.ico");
            this.imageList2.Images.SetKeyName(275, "275.ico");
            this.imageList2.Images.SetKeyName(276, "276.ico");
            this.imageList2.Images.SetKeyName(277, "277.ico");
            this.imageList2.Images.SetKeyName(278, "278.ico");
            this.imageList2.Images.SetKeyName(279, "279.ico");
            this.imageList2.Images.SetKeyName(280, "280.ico");
            this.imageList2.Images.SetKeyName(281, "281.ico");
            this.imageList2.Images.SetKeyName(282, "282.ico");
            this.imageList2.Images.SetKeyName(283, "283.ico");
            this.imageList2.Images.SetKeyName(284, "284.ico");
            this.imageList2.Images.SetKeyName(285, "285.ico");
            this.imageList2.Images.SetKeyName(286, "286.ico");
            this.imageList2.Images.SetKeyName(287, "287.ico");
            this.imageList2.Images.SetKeyName(288, "288.ico");
            this.imageList2.Images.SetKeyName(289, "289.ico");
            this.imageList2.Images.SetKeyName(290, "290.ico");
            this.imageList2.Images.SetKeyName(291, "291.ico");
            this.imageList2.Images.SetKeyName(292, "292.ico");
            this.imageList2.Images.SetKeyName(293, "293.ico");
            this.imageList2.Images.SetKeyName(294, "294.ico");
            this.imageList2.Images.SetKeyName(295, "295.ico");
            this.imageList2.Images.SetKeyName(296, "296.ico");
            this.imageList2.Images.SetKeyName(297, "297.ico");
            this.imageList2.Images.SetKeyName(298, "298.ico");
            this.imageList2.Images.SetKeyName(299, "299.ico");
            this.imageList2.Images.SetKeyName(300, "300.ico");
            this.imageList2.Images.SetKeyName(301, "301.ico");
            this.imageList2.Images.SetKeyName(302, "302.ico");
            this.imageList2.Images.SetKeyName(303, "303.ico");
            this.imageList2.Images.SetKeyName(304, "304.ico");
            this.imageList2.Images.SetKeyName(305, "305.ico");
            this.imageList2.Images.SetKeyName(306, "306.ico");
            this.imageList2.Images.SetKeyName(307, "307.ico");
            this.imageList2.Images.SetKeyName(308, "308.ico");
            this.imageList2.Images.SetKeyName(309, "309.ico");
            this.imageList2.Images.SetKeyName(310, "310.ico");
            this.imageList2.Images.SetKeyName(311, "311.ico");
            this.imageList2.Images.SetKeyName(312, "312.ico");
            this.imageList2.Images.SetKeyName(313, "313.ico");
            this.imageList2.Images.SetKeyName(314, "314.ico");
            this.imageList2.Images.SetKeyName(315, "315.ico");
            this.imageList2.Images.SetKeyName(316, "316.ico");
            this.imageList2.Images.SetKeyName(317, "317.ico");
            this.imageList2.Images.SetKeyName(318, "318.ico");
            this.imageList2.Images.SetKeyName(319, "319.ico");
            this.imageList2.Images.SetKeyName(320, "320.ico");
            this.imageList2.Images.SetKeyName(321, "321.ico");
            this.imageList2.Images.SetKeyName(322, "322.ico");
            this.imageList2.Images.SetKeyName(323, "323.ico");
            this.imageList2.Images.SetKeyName(324, "324.ico");
            this.imageList2.Images.SetKeyName(325, "325.ico");
            this.imageList2.Images.SetKeyName(326, "326.ico");
            this.imageList2.Images.SetKeyName(327, "327.ico");
            this.imageList2.Images.SetKeyName(328, "328.ico");
            this.imageList2.Images.SetKeyName(329, "329.ico");
            this.imageList2.Images.SetKeyName(330, "330.ico");
            this.imageList2.Images.SetKeyName(331, "331.ico");
            this.imageList2.Images.SetKeyName(332, "332.ico");
            this.imageList2.Images.SetKeyName(333, "333.ico");
            this.imageList2.Images.SetKeyName(334, "334.ico");
            this.imageList2.Images.SetKeyName(335, "335.ico");
            this.imageList2.Images.SetKeyName(336, "336.ico");
            this.imageList2.Images.SetKeyName(337, "337.ico");
            this.imageList2.Images.SetKeyName(338, "338.ico");
            this.imageList2.Images.SetKeyName(339, "339.ico");
            this.imageList2.Images.SetKeyName(340, "340.ico");
            this.imageList2.Images.SetKeyName(341, "341.ico");
            this.imageList2.Images.SetKeyName(342, "342.ico");
            this.imageList2.Images.SetKeyName(343, "343.ico");
            this.imageList2.Images.SetKeyName(344, "344.ico");
            this.imageList2.Images.SetKeyName(345, "345.ico");
            this.imageList2.Images.SetKeyName(346, "346.ico");
            this.imageList2.Images.SetKeyName(347, "347.ico");
            this.imageList2.Images.SetKeyName(348, "348.ico");
            this.imageList2.Images.SetKeyName(349, "349.ico");
            this.imageList2.Images.SetKeyName(350, "350.ico");
            this.imageList2.Images.SetKeyName(351, "351.ico");
            this.imageList2.Images.SetKeyName(352, "352.ico");
            this.imageList2.Images.SetKeyName(353, "353.ico");
            this.imageList2.Images.SetKeyName(354, "354.ico");
            this.imageList2.Images.SetKeyName(355, "355.ico");
            this.imageList2.Images.SetKeyName(356, "356.ico");
            this.imageList2.Images.SetKeyName(357, "357.ico");
            this.imageList2.Images.SetKeyName(358, "358.ico");
            this.imageList2.Images.SetKeyName(359, "359.ico");
            this.imageList2.Images.SetKeyName(360, "360.ico");
            this.imageList2.Images.SetKeyName(361, "361.ico");
            this.imageList2.Images.SetKeyName(362, "362.ico");
            this.imageList2.Images.SetKeyName(363, "363.ico");
            this.imageList2.Images.SetKeyName(364, "364.ico");
            this.imageList2.Images.SetKeyName(365, "365.ico");
            this.imageList2.Images.SetKeyName(366, "366.ico");
            this.imageList2.Images.SetKeyName(367, "367.ico");
            this.imageList2.Images.SetKeyName(368, "368.ico");
            this.imageList2.Images.SetKeyName(369, "369.ico");
            this.imageList2.Images.SetKeyName(370, "370.ico");
            this.imageList2.Images.SetKeyName(371, "371.ico");
            this.imageList2.Images.SetKeyName(372, "372.ico");
            this.imageList2.Images.SetKeyName(373, "373.ico");
            this.imageList2.Images.SetKeyName(374, "374.ico");
            this.imageList2.Images.SetKeyName(375, "375.ico");
            this.imageList2.Images.SetKeyName(376, "376.ico");
            this.imageList2.Images.SetKeyName(377, "377.ico");
            this.imageList2.Images.SetKeyName(378, "378.ico");
            this.imageList2.Images.SetKeyName(379, "379.ico");
            this.imageList2.Images.SetKeyName(380, "380.ico");
            this.imageList2.Images.SetKeyName(381, "381.ico");
            this.imageList2.Images.SetKeyName(382, "382.ico");
            this.imageList2.Images.SetKeyName(383, "383.ico");
            this.imageList2.Images.SetKeyName(384, "384.ico");
            this.imageList2.Images.SetKeyName(385, "385.ico");
            this.imageList2.Images.SetKeyName(386, "386.ico");
            this.imageList2.Images.SetKeyName(387, "387.ico");
            this.imageList2.Images.SetKeyName(388, "388.ico");
            this.imageList2.Images.SetKeyName(389, "389.ico");
            this.imageList2.Images.SetKeyName(390, "390.ico");
            this.imageList2.Images.SetKeyName(391, "391.ico");
            this.imageList2.Images.SetKeyName(392, "392.ico");
            this.imageList2.Images.SetKeyName(393, "393.ico");
            this.imageList2.Images.SetKeyName(394, "394.ico");
            this.imageList2.Images.SetKeyName(395, "395.ico");
            this.imageList2.Images.SetKeyName(396, "396.ico");
            this.imageList2.Images.SetKeyName(397, "397.ico");
            this.imageList2.Images.SetKeyName(398, "398.ico");
            this.imageList2.Images.SetKeyName(399, "399.ico");
            this.imageList2.Images.SetKeyName(400, "400.ico");
            this.imageList2.Images.SetKeyName(401, "401.ico");
            this.imageList2.Images.SetKeyName(402, "402.ico");
            this.imageList2.Images.SetKeyName(403, "403.ico");
            this.imageList2.Images.SetKeyName(404, "404.ico");
            this.imageList2.Images.SetKeyName(405, "405.ico");
            this.imageList2.Images.SetKeyName(406, "406.ico");
            this.imageList2.Images.SetKeyName(407, "407.ico");
            this.imageList2.Images.SetKeyName(408, "408.ico");
            this.imageList2.Images.SetKeyName(409, "409.ico");
            this.imageList2.Images.SetKeyName(410, "410.ico");
            this.imageList2.Images.SetKeyName(411, "411.ico");
            this.imageList2.Images.SetKeyName(412, "412.ico");
            this.imageList2.Images.SetKeyName(413, "413.ico");
            this.imageList2.Images.SetKeyName(414, "414.ico");
            this.imageList2.Images.SetKeyName(415, "415.ico");
            this.imageList2.Images.SetKeyName(416, "416.ico");
            this.imageList2.Images.SetKeyName(417, "417.ico");
            this.imageList2.Images.SetKeyName(418, "418.ico");
            this.imageList2.Images.SetKeyName(419, "419.ico");
            this.imageList2.Images.SetKeyName(420, "420.ico");
            this.imageList2.Images.SetKeyName(421, "421.ico");
            this.imageList2.Images.SetKeyName(422, "422.ico");
            this.imageList2.Images.SetKeyName(423, "423.ico");
            this.imageList2.Images.SetKeyName(424, "424.ico");
            this.imageList2.Images.SetKeyName(425, "425.ico");
            this.imageList2.Images.SetKeyName(426, "426.ico");
            this.imageList2.Images.SetKeyName(427, "427.ico");
            this.imageList2.Images.SetKeyName(428, "428.ico");
            this.imageList2.Images.SetKeyName(429, "429.ico");
            this.imageList2.Images.SetKeyName(430, "430.ico");
            this.imageList2.Images.SetKeyName(431, "431.ico");
            this.imageList2.Images.SetKeyName(432, "432.ico");
            this.imageList2.Images.SetKeyName(433, "433.ico");
            this.imageList2.Images.SetKeyName(434, "434.ico");
            this.imageList2.Images.SetKeyName(435, "435.ico");
            this.imageList2.Images.SetKeyName(436, "436.ico");
            this.imageList2.Images.SetKeyName(437, "437.ico");
            this.imageList2.Images.SetKeyName(438, "438.ico");
            this.imageList2.Images.SetKeyName(439, "439.ico");
            this.imageList2.Images.SetKeyName(440, "440.ico");
            this.imageList2.Images.SetKeyName(441, "441.ico");
            this.imageList2.Images.SetKeyName(442, "442.ico");
            this.imageList2.Images.SetKeyName(443, "443.ico");
            this.imageList2.Images.SetKeyName(444, "444.ico");
            this.imageList2.Images.SetKeyName(445, "445.ico");
            this.imageList2.Images.SetKeyName(446, "446.ico");
            this.imageList2.Images.SetKeyName(447, "447.ico");
            this.imageList2.Images.SetKeyName(448, "448.ico");
            this.imageList2.Images.SetKeyName(449, "449.ico");
            this.imageList2.Images.SetKeyName(450, "450.ico");
            this.imageList2.Images.SetKeyName(451, "451.ico");
            this.imageList2.Images.SetKeyName(452, "452.ico");
            this.imageList2.Images.SetKeyName(453, "453.ico");
            this.imageList2.Images.SetKeyName(454, "454.ico");
            this.imageList2.Images.SetKeyName(455, "455.ico");
            this.imageList2.Images.SetKeyName(456, "456.ico");
            this.imageList2.Images.SetKeyName(457, "457.ico");
            this.imageList2.Images.SetKeyName(458, "458.ico");
            this.imageList2.Images.SetKeyName(459, "459.ico");
            this.imageList2.Images.SetKeyName(460, "460.ico");
            this.imageList2.Images.SetKeyName(461, "461.ico");
            this.imageList2.Images.SetKeyName(462, "462.ico");
            this.imageList2.Images.SetKeyName(463, "463.ico");
            this.imageList2.Images.SetKeyName(464, "464.ico");
            this.imageList2.Images.SetKeyName(465, "465.ico");
            this.imageList2.Images.SetKeyName(466, "466.ico");
            this.imageList2.Images.SetKeyName(467, "467.ico");
            this.imageList2.Images.SetKeyName(468, "468.ico");
            this.imageList2.Images.SetKeyName(469, "469.ico");
            this.imageList2.Images.SetKeyName(470, "470.ico");
            this.imageList2.Images.SetKeyName(471, "471.ico");
            this.imageList2.Images.SetKeyName(472, "472.ico");
            this.imageList2.Images.SetKeyName(473, "473.ico");
            this.imageList2.Images.SetKeyName(474, "474.ico");
            this.imageList2.Images.SetKeyName(475, "475.ico");
            this.imageList2.Images.SetKeyName(476, "476.ico");
            this.imageList2.Images.SetKeyName(477, "477.ico");
            this.imageList2.Images.SetKeyName(478, "478.ico");
            this.imageList2.Images.SetKeyName(479, "479.ico");
            this.imageList2.Images.SetKeyName(480, "480.ico");
            this.imageList2.Images.SetKeyName(481, "481.ico");
            this.imageList2.Images.SetKeyName(482, "482.ico");
            this.imageList2.Images.SetKeyName(483, "483.ico");
            this.imageList2.Images.SetKeyName(484, "484.ico");
            this.imageList2.Images.SetKeyName(485, "485.ico");
            this.imageList2.Images.SetKeyName(486, "486.ico");
            this.imageList2.Images.SetKeyName(487, "487.ico");
            this.imageList2.Images.SetKeyName(488, "488.ico");
            this.imageList2.Images.SetKeyName(489, "489.ico");
            this.imageList2.Images.SetKeyName(490, "490.ico");
            this.imageList2.Images.SetKeyName(491, "491.ico");
            this.imageList2.Images.SetKeyName(492, "492.ico");
            this.imageList2.Images.SetKeyName(493, "493.ico");
            this.imageList2.Images.SetKeyName(494, "494.ico");
            this.imageList2.Images.SetKeyName(495, "495.ico");
            this.imageList2.Images.SetKeyName(496, "496.ico");
            this.imageList2.Images.SetKeyName(497, "497.ico");
            this.imageList2.Images.SetKeyName(498, "498.ico");
            this.imageList2.Images.SetKeyName(499, "499.ico");
            this.imageList2.Images.SetKeyName(500, "500.ico");
            this.imageList2.Images.SetKeyName(501, "501.ico");
            this.imageList2.Images.SetKeyName(502, "502.ico");
            this.imageList2.Images.SetKeyName(503, "503.ico");
            this.imageList2.Images.SetKeyName(504, "504.ico");
            this.imageList2.Images.SetKeyName(505, "505.ico");
            this.imageList2.Images.SetKeyName(506, "506.ico");
            this.imageList2.Images.SetKeyName(507, "507.ico");
            this.imageList2.Images.SetKeyName(508, "508.ico");
            this.imageList2.Images.SetKeyName(509, "509.ico");
            this.imageList2.Images.SetKeyName(510, "510.ico");
            this.imageList2.Images.SetKeyName(511, "511.ico");
            this.imageList2.Images.SetKeyName(512, "512.ico");
            this.imageList2.Images.SetKeyName(513, "513.ico");
            this.imageList2.Images.SetKeyName(514, "514.ico");
            this.imageList2.Images.SetKeyName(515, "515.ico");
            this.imageList2.Images.SetKeyName(516, "bennet.png");
            this.imageList2.Images.SetKeyName(517, "claire.png");
            this.imageList2.Images.SetKeyName(518, "dl.png");
            this.imageList2.Images.SetKeyName(519, "hiro.png");
            this.imageList2.Images.SetKeyName(520, "nathan.png");
            this.imageList2.Images.SetKeyName(521, "nicki.png");
            this.imageList2.Images.SetKeyName(522, "parkman.png");
            this.imageList2.Images.SetKeyName(523, "peter.png");
            this.imageList2.Images.SetKeyName(524, "suresh.png");
            this.imageList2.Images.SetKeyName(525, "sylar.png");
            this.imageList2.Images.SetKeyName(526, "acida.png");
            this.imageList2.Images.SetKeyName(527, "cake1.png");
            this.imageList2.Images.SetKeyName(528, "cake2.png");
            this.imageList2.Images.SetKeyName(529, "cake big.png");
            this.imageList2.Images.SetKeyName(530, "cake slice1.png");
            this.imageList2.Images.SetKeyName(531, "cake slice2.png");
            this.imageList2.Images.SetKeyName(532, "candy green.png");
            this.imageList2.Images.SetKeyName(533, "candy orange.png");
            this.imageList2.Images.SetKeyName(534, "choko_crema.png");
            this.imageList2.Images.SetKeyName(535, "choko_emo.png");
            this.imageList2.Images.SetKeyName(536, "choko_milky.png");
            this.imageList2.Images.SetKeyName(537, "cream1.png");
            this.imageList2.Images.SetKeyName(538, "cream2.png");
            this.imageList2.Images.SetKeyName(539, "cream3.png");
            this.imageList2.Images.SetKeyName(540, "cream choco.png");
            this.imageList2.Images.SetKeyName(541, "cream crazy.png");
            this.imageList2.Images.SetKeyName(542, "cream funny.png");
            this.imageList2.Images.SetKeyName(543, "cream happy ice.png");
            this.imageList2.Images.SetKeyName(544, "cream pink.png");
            this.imageList2.Images.SetKeyName(545, "flat01.PNG");
            this.imageList2.Images.SetKeyName(546, "flat02.PNG");
            this.imageList2.Images.SetKeyName(547, "milky_blue.png");
            this.imageList2.Images.SetKeyName(548, "red_jam.png");
            this.imageList2.Images.SetKeyName(549, "tropic.png");
            this.imageList2.Images.SetKeyName(550, "Urban MSN1.ico");
            this.imageList2.Images.SetKeyName(551, "Urban MSN2.ico");
            this.imageList2.Images.SetKeyName(552, "Urban MSN3.ico");
            this.imageList2.Images.SetKeyName(553, "Urban MSN4.ico");
            this.imageList2.Images.SetKeyName(554, "Urban MSN5.ico");
            this.imageList2.Images.SetKeyName(555, "XP PPL01.ico");
            this.imageList2.Images.SetKeyName(556, "XP PPL02.ico");
            this.imageList2.Images.SetKeyName(557, "XP PPL03.ico");
            this.imageList2.Images.SetKeyName(558, "XP PPL04.ico");
            this.imageList2.Images.SetKeyName(559, "XP PPL05.ico");
            this.imageList2.Images.SetKeyName(560, "XP PPL06.ico");
            this.imageList2.Images.SetKeyName(561, "XP PPL07.ico");
            this.imageList2.Images.SetKeyName(562, "XP PPL08.ico");
            this.imageList2.Images.SetKeyName(563, "XP PPL09.ico");
            this.imageList2.Images.SetKeyName(564, "XP PPL10.ico");
            this.imageList2.Images.SetKeyName(565, "XP PPL11.ico");
            this.imageList2.Images.SetKeyName(566, "XP PPL12.ico");
            this.imageList2.Images.SetKeyName(567, "XP PPL13.ico");
            this.imageList2.Images.SetKeyName(568, "XP PPL14.ico");
            this.imageList2.Images.SetKeyName(569, "XP PPL15.ico");
            // 
            // picSelectedImage
            // 
            this.picSelectedImage.Location = new System.Drawing.Point(248, 186);
            this.picSelectedImage.Name = "picSelectedImage";
            this.picSelectedImage.Size = new System.Drawing.Size(21, 22);
            this.picSelectedImage.TabIndex = 19;
            this.picSelectedImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.ImageKey = "Folder Open.ico";
            this.btnBrowse.ImageList = this.imageList1;
            this.btnBrowse.Location = new System.Drawing.Point(164, 183);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tipNickName
            // 
            this.tipNickName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipHostname
            // 
            this.tipHostname.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipEmail
            // 
            this.tipEmail.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipRating
            // 
            this.tipRating.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tipImage
            // 
            this.tipImage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtSelectedImageIndex
            // 
            this.txtSelectedImageIndex.Location = new System.Drawing.Point(74, 230);
            this.txtSelectedImageIndex.Name = "txtSelectedImageIndex";
            this.txtSelectedImageIndex.Size = new System.Drawing.Size(18, 20);
            this.txtSelectedImageIndex.TabIndex = 21;
            this.txtSelectedImageIndex.Visible = false;
            // 
            // AddNewBuddyForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AccessibleName = "`";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.txtSelectedImageIndex);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picSelectedImage);
            this.Controls.Add(this.lblImageTip);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.trackRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblRatingTip);
            this.Controls.Add(this.lblEmailTip);
            this.Controls.Add(this.lblHostNameTip);
            this.Controls.Add(this.lblNickNameTip);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewBuddyForm";
            this.Load += new System.EventHandler(this.AddNewBuddyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblNickNameTip;
        private System.Windows.Forms.Label lblHostNameTip;
        private System.Windows.Forms.Label lblEmailTip;
        private System.Windows.Forms.Label lblRatingTip;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TrackBar trackRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblImageTip;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox picSelectedImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolTip tipNickName;
        private System.Windows.Forms.ToolTip tipHostname;
        private System.Windows.Forms.ToolTip tipEmail;
        private System.Windows.Forms.ToolTip tipRating;
        private System.Windows.Forms.ToolTip tipImage;
        private System.Windows.Forms.TextBox txtSelectedImageIndex;
    }
}