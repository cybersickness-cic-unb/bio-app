using System;
using System.Windows.Forms;

namespace BC
{
    internal static class Program
    {
        /// <summary>
        /// Main entry point to the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmMain());
            //Application.Run(new FrmTest());
        }
    }
}
