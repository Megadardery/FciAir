using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            bool restart;
            do
            {
                restart = false;
                try
                {
                    dbms.OpenConnection();
                }
                catch
                {
                    DialogResult response = MessageBox.Show("Unable to establish the connection, Please make sure you have it installed and properly configured.",
                 "Fatal Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);

                    if (response != DialogResult.Retry)
                        return;

                    restart = true;
                    continue;
                }
            } while (restart);
            do
            {
                restart = false;
                try
                {
                    dbms.SwitchToFci();
                }
                catch
                {
                    DialogResult response = MessageBox.Show("Couldn't open the Database, it might not exist. Do you want to attempt to create it?",
                     "Database not found", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (response != DialogResult.Yes)
                        return;

                    dbms.CreateDatabase();
                    restart = true;
                    continue;
                }

            } while (restart);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            homePage = new HomePage();
            Application.Run(homePage);
            dbms.CloseConnection();
        }
    }
}
