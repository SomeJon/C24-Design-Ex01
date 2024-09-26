using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookClient.Code
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// check something
        /// </summary>
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }


    }
}
