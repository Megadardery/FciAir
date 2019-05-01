using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        public static DBMS dbms;
        public static HomePage homePage;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dbms = new DBMS();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            homePage = new HomePage();
            Application.Run(homePage);
        }
    }
}
