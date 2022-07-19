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
    public partial class FunMessageBox : Form
    {

        // Constructor is private. To create an instance of this, use the
        // static method ShowForm(string, string);
        private FunMessageBox(string message, string caption)
        {
            InitializeComponent();

            // the AddRange method determines the z-order of the controls in the list
            // and not needed in this scenario.
            // this.Controls.AddRange(new Control[] { this.buttonNo, this.buttonYes, this.textText });
            textText.Text = message;
            this.Text = caption;
            this.ShowDialog();
        }


        /// <summary>
        /// Shows a fun message box with a message but no caption (empty string)
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static DialogResult ShowForm(string message)
        {
            return FunMessageBox.ShowForm(message, "");
        }

        /// <summary>
        /// Shows a fun message box with caption and message
        /// </summary>
        /// <param name="message">The message to be displayed</param>
        /// <param name="caption">The window caption</param>
        /// <returns></returns>
        public static DialogResult ShowForm(string message, string caption)
        {
            FunMessageBox fmb = new FunMessageBox(message, caption);
            DialogResult result;

            // wait for user to click a button, the return the result.
            fmb.WaitForResult();

            result = fmb.DialogResult;
            // we can now dispose of the funmessagebox
            fmb.Close();
            fmb.Dispose();

            return result;
        }

        void WaitForResult()
        {
            // goes into an infinite loop waiting for a button to be pressed on the form
            while (this.DialogResult == DialogResult.None)
            {
                Thread.Sleep(50);
                Application.DoEvents();
            }

        }


        private void buttonNo_MouseEnter(object sender, EventArgs e)
        {
            // ye shall not press the No button!
            //Random randomNumberGenerator = new Random();
            //buttonNo.Location = new Point(randomNumberGenerator.Next(this.Width - buttonNo.Width), randomNumberGenerator.Next(this.Height - buttonNo.Height - 40));
           
        }

        private void FunMessageBox_Load(object sender, EventArgs e)
        {
            // set ini position
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);

            Utils.DisableCloseButton(this.Handle.ToInt32());

        }
    }
}
