﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookClient.Code
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// check something
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
