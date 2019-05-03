using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI
{
    public partial class CustomerSignUp : Form
    {
        SqlException ee = null;
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program.dbms.InsertCustomer(fName.Text, lName.Text, passPortID.Text, nationality.Text, birth.Value, username.Text, pass.Text);
                MessageBox.Show("Registration Successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //if exception is caught alwayes enter the same exception
            catch (SqlException ee)
            {
                var reason = DBMS.ParseException(ee);
                switch (reason)
                {
                    case DBMS.SqlErrorNumber.Duplication:
                        MessageBox.Show(Logic.ErrorMessages.DuplicateUsername, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DBMS.SqlErrorNumber.Truncation:
                        MessageBox.Show(Logic.ErrorMessages.Truncation , "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case DBMS.SqlErrorNumber.Unknown:
                        MessageBox.Show(ee.Message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Registration",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || passPortID.Text == "" || nationality.Text == "" || birth.Value > DateTime.Now || username.Text == "" || pass.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;

        }

        private void CustomerSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
