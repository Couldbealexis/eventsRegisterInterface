﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventsRegisterInterface
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

            //frmLogin login = new frmLogin();
            frmAddEvent login = new frmAddEvent();
            login.ShowDialog();

            //Application.Run(new frmLogin());
        }
    }
}
