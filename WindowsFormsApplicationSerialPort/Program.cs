using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Author: Stefan Seeland stefan.seeland@gmx.at
namespace WindowsFormsApplicationSerialPort
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
            Application.Run(new Rs232tool());
        }
    }
}
