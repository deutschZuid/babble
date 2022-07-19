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
    public partial class OptionsForm : Form
    {
        // private OptionsObject _options;

        // An event that passes info back to the caller Form
        // public event EventHandler NotifyParent;

        // Method that will be used to wire up the event
        /*protected void OnNotifyParent()
        {
            if (NotifyParent != null)
            {
                // Pass buddy info back to the parent form
                NotifyParent(this, new NotifyOptionsToTopParentEventArgs(_options));
            }
        } */

        /// <summary>
        /// Default constructor.
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();
            // this._options = options;

            // start setting out the options graphically
            txtBGColor.BackColor = Properties.Settings.Default.Background;
            txtLocalFGColor.BackColor = Properties.Settings.Default.MyForeground;
            txtRemoteFGColor.BackColor = Properties.Settings.Default.TheirForeground;
            cboSound.Checked = Properties.Settings.Default.CWSoundOn;
            cboFlash.Checked = Properties.Settings.Default.CWFlashOn;
            cboStartup.Checked = Properties.Settings.Default.LaunchAtStartup;

            // set tooltips
            tipBGcolor.AutoPopDelay = 8000;
            tipLocalFGColor.AutoPopDelay = 8000;
            tipRemoteFGColor.AutoPopDelay = 8000;
            tipFlashOn.AutoPopDelay = 8000;
            tipSoundOn.AutoPopDelay = 8000;
            tipBGcolor.ToolTipTitle = lblBGColor.Text;
            tipLocalFGColor.ToolTipTitle = lblLocalFGColor.Text;
            tipRemoteFGColor.ToolTipTitle = lblRemoteFGColor.Text;
            tipFlashOn.ToolTipTitle = cboFlash.Text;
            tipSoundOn.ToolTipTitle = cboSound.Text;
            tipBGcolor.SetToolTip(lblBGColor, "Sets the background color of your chat window history");
            tipLocalFGColor.SetToolTip(lblLocalFGColor, "Sets the text color of your messages");
            tipRemoteFGColor.SetToolTip(lblRemoteFGColor, "Sets the text color of your buddy's messages");
            tipFlashOn.SetToolTip(cboFlash, "Determines if a sound is played when a new message arrives in a chat window when the window is not in focus");
            tipSoundOn.SetToolTip(cboSound, "Determines if the taskbar button of a chat window will flash when a new message arrives");
        }


        private void btnBgcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtBGColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnLocalFGcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtLocalFGColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnRemoteFGcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtRemoteFGColor.BackColor = colorDialog1.Color;
                
            }
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            /* changing the way options are stored. 
            _options.MyForeColor = txtLocalFGColor.BackColor;
            _options.TheirForeColor = txtRemoteFGColor.BackColor;
            _options.BackGround = txtBGColor.BackColor;
            _options.CWFlashOn = cboFlash.Checked;
            _options.CWSoundOn = cboSound.Checked;
             * 
             * */
            // now write options to file
            //_options.SaveOptions();

            Properties.Settings.Default.Background = txtBGColor.BackColor;
            Properties.Settings.Default.TheirForeground = txtRemoteFGColor.BackColor;
            Properties.Settings.Default.MyForeground = txtLocalFGColor.BackColor;
            Properties.Settings.Default.CWFlashOn = cboFlash.Checked;
            Properties.Settings.Default.CWSoundOn = cboSound.Checked;
            Properties.Settings.Default.LaunchAtStartup = cboStartup.Checked;

            // this.OnNotifyParent();
            this.Close();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {

            // set everything back to default
            DialogResult result = FunMessageBox.ShowForm("Are you sure you wish to set the options back to their defaults?", "Defaults");

            if (result == DialogResult.OK)
            {
                // changes made here will not be carried over if the cancel button is hit
                //options.ResetDefaultOptions();
                txtBGColor.BackColor = Properties.Settings.Default.DFBackground;
                txtRemoteFGColor.BackColor = Properties.Settings.Default.DFTheirForeground;
                txtLocalFGColor.BackColor = Properties.Settings.Default.DFMyForeground;
                cboFlash.Checked = Properties.Settings.Default.DFCWFlashOn;
                cboSound.Checked = Properties.Settings.Default.DFCWSoundOn;
                cboStartup.Checked = Properties.Settings.Default.DFaunchAtStartup;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            // the + 20 is so that the user can see the titlebar of the parent
            this.Location = new Point(this.Owner.Left, this.Owner.Top + 20);
        }





    }
}
