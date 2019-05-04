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
            bool onlyOnce = true;
        restart:
            try
            {

                try
                {
                    dbms = new DBMS();
                }
                //if FciAir is not reachable, this will only be performed once
                catch (SqlException ex) when (ex.Message.StartsWith("Cannot open database") && onlyOnce == true)
                {
                    DialogResult response = MessageBox.Show("Database not found. Do you want to attempt to create it?",
                      "Database not found", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (response == DialogResult.Yes)
                    {
                        DBMS.CreateDatabase();
                        goto restart;
                    }
                    else
                        return;
                }
            }
            catch
            {
                DialogResult response = MessageBox.Show("Unable to establish the connection, Please make sure you have it installed and properly configured.",
                  "Fatal Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);

                if (response == DialogResult.Retry)
                    goto restart;
                else
                    return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            homePage = new HomePage();
            Application.Run(homePage);
            dbms.CloseConnection();
        }
    }
}
