using MovieLibraryApplication.CLIENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieLibraryApplication
{
    static class Date
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
