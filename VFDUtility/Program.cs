using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;

namespace VFDUtility
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show(
                    "No COM ports have been found on this system. Cannot start application.",
                    "VFD Utility",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Application.Run(new Form1());
        }
    }
}