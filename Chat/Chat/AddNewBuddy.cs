using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Chat
{
    public partial class AddNewBuddyForm : Form
    {
        // An event that passes info back to the caller Form
        public event EventHandler NotifyParent;

        // Method that will be used to wire up the event
        protected void OnNotifyParent()
        {
            if (NotifyParent != null)
            {
                // Pass buddy info back to the parent form
                NotifyParent(this, new NotifyAddNewBuddyToTopParentEventArgs(txtHost.Text, txtEmail.Text, txtNickname.Text, Convert.ToInt32(txtRating.Text), Convert.ToInt32(txtSelectedImageIndex.Text)));
            }
        }

        // public constructor.. 
        public AddNewBuddyForm(string caption, string yesButtonText, string noButtonText, string hostname, string email, string nickName, int rating, int imageIndex)
        {
            InitializeComponent();

            // init various captions and button texts
            this.Text = caption;
            btnAccept.Text = yesButtonText + "! ";
            btnCancel.Text = noButtonText + "! ";

            // init the fields on the form
            txtHost.Text = hostname;
            txtEmail.Text = email;
            txtNickname.Text = nickName;

            // Checks done on parameters passed in.
            if (rating >= trackRating.Minimum && rating <= trackRating.Maximum)
            {
                txtRating.Text = rating.ToString();
                trackRating.Value = rating;
            }
            else
            {
                txtRating.Text = (Math.Round(((decimal)(trackRating.Maximum - trackRating.Minimum) / 2),0,MidpointRounding.AwayFromZero)).ToString();
                trackRating.Value = Convert.ToInt32(txtRating.Text);
            }


            if (imageIndex >= 0 && imageIndex < imageList2.Images.Count)
            {
                picSelectedImage.Image = imageList2.Images[imageIndex];
                txtSelectedImageIndex.Text = imageIndex.ToString();
            }
            else
            {
                picSelectedImage.Image = imageList2.Images[0];
                txtSelectedImageIndex.Text = "0";
            }
        }

  

        private void trackRating_Scroll(object sender, EventArgs e)
        {
            txtRating.Text = trackRating.Value.ToString();
        }

        private void txtRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackRating.Value = Convert.ToInt32(txtRating.Text);
            }
            catch (Exception)
            {
                //Ignore all Format Exceptions and Argument out of Range Exceptions.
                //MessageBox.Show(err.ToString());
            }
        }


        private void AddNewBuddyForm_Load(object sender, EventArgs e)
        {
            // the +20 is so that user can see the titlebar of the parent window
            this.Location = new Point(this.Owner.Left, this.Owner.Top + 20);

            Utils.DisableCloseButton(this.Handle.ToInt32());
            
            // Tooltip delay
            tipEmail.AutoPopDelay = 8000;
            tipHostname.AutoPopDelay = 8000;
            tipImage.AutoPopDelay = 8000;
            tipNickName.AutoPopDelay = 8000;
            tipRating.AutoPopDelay = 8000;

            // Tooltip title
            tipEmail.ToolTipTitle = lblEmail.Text;
            tipHostname.ToolTipTitle = lblEmail.Text;
            tipImage.ToolTipTitle = lblImage.Text;
            tipNickName.ToolTipTitle = lblNickName.Text;
            tipRating.ToolTipTitle = lblRating.Text;

            // Tooltip text
            tipEmail.SetToolTip(lblEmailTip, "Email address of the buddy. Optional.");
            tipImage.SetToolTip(lblImageTip, "An image that will appear beside buddy's name.");
            tipHostname.SetToolTip(lblHostNameTip, "The computer name or IP your buddy is using.");
            tipNickName.SetToolTip(lblNickNameTip, "What you like to name your buddy. The name will appear in your buddy list.");
            tipRating.SetToolTip(lblRatingTip, "A arbitrary rating of your buddy. Reserved for future use.");

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // constraints
            if (txtNickname.Text.Trim() == "")
            {
                MessageBox.Show(this, "Buddy name is not optional", "Name is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtHost.Text.Trim() == "")
            {
                MessageBox.Show(this, "Host name/IP is not optional", "Hostname is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.OnNotifyParent();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // browse for an image to be attached to the buddy.
            ImageSelectionForm imageForm = new ImageSelectionForm(imageList2, Convert.ToInt32(txtSelectedImageIndex.Text));

            imageForm.NotifyParent += new EventHandler(imageForm_NotifyParent);
            imageForm.ShowDialog(this);
        }

        private void imageForm_NotifyParent(object sender, EventArgs e)
        {
            // on receiving the event notification, update the picture box with 
            // the image and hidden text box with the selected index
            txtSelectedImageIndex.Text = ((NotifyImageSelectionToAddNewBuddyEventArgs)e).SelectedImageIndex.ToString();
            picSelectedImage.Image = imageList2.Images[((NotifyImageSelectionToAddNewBuddyEventArgs)e).SelectedImageIndex];
        }



    }
}
