using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace Chat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // this is a single instance program - set focus to the existing instance 
            // if user is trying to launch the program executable while there is another
            // instance running
            Process[] p = Process.GetProcessesByName(Application.ProductName);

            if (p.Length > 1)
            {

                Utils.SetFocusToPreviousInstance(Application.ProductName + " Version: " + Application.ProductVersion);

            }
            else
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            
        }
    }
}
