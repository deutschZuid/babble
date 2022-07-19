using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
    public partial class ImageSelectionForm : Form
    {
        // An event that passes info back to the caller Form
        public event EventHandler NotifyParent;

        // Method that will be used to wire up the event
        protected void OnNotifyParent()
        {
            if (NotifyParent != null)
            {
                // Multi-select property of Listview is set to false, therefore the first element in the
                // SelectedIndexSelection is the only selected element.
                NotifyParent(this, new NotifyImageSelectionToAddNewBuddyEventArgs(lvwImages.SelectedIndices[0]));
            }
        }

        public ImageSelectionForm(ImageList imgList, int selectedIndex)
        {
            InitializeComponent();

            lvwImages.SmallImageList = imgList;
            lvwImages.LargeImageList = imgList;

            // Add images as items to the listview
            for (int i=0; i < lvwImages.SmallImageList.Images.Count; i++) {
                lvwImages.Items.Add(new ListViewItem("", i));
                lvwImages.Items[i].ImageIndex = i;
            }

            lvwImages.Items[selectedIndex].Selected = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvwImages.SelectedIndices.Count <= 0) // no image selected
            {
                MessageBox.Show(this, "No image selected. Please make sure you select an image for the new buddy.", "No image selected", MessageBoxButtons.OK);
            }
            else
            {
                // notify the parent that this child form is about to close and this is
                // the last chance to process the information in this form.
                this.OnNotifyParent();
                this.Close();
            }
        }

        private void ImageSelectionForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            Utils.DisableCloseButton(this.Handle.ToInt32());
        }
    }
}
