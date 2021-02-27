using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform2.GUI;
using Winform2.Entities;
using System.Configuration;

namespace Winform2
{
    static class Program
    {
        public static Users us;
        public static string strcon;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            strcon = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
