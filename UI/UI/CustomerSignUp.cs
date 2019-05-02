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
            bool b = false;
            try
            {
                Program.dbms.InsertCustomer(fName.Text, lName.Text, int.Parse(passPortID.Text), nationality.Text, birth.Value, username.Text, pass.Text);
            }
            //if exception is caught alwayes enter the same exception
            catch (SqlException ee)
            {
                MessageBox.Show(Program.dbms.ParseException(ee).ToString());
                b = true;
            }
            if (!b)
            {
                MessageBox.Show("regestraion Successful");
                this.Close();
            }
        }

    

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || passPortID.Text == "" || nationality.Text == "" || birth.Value > DateTime.Now || username.Text == "" || pass.Text == "")
                button1.Enabled = false;
            else
            {
                if (birth.Value > DateTime.Now)
                    MessageBox.Show("incorrect date");

                else button1.Enabled = true;
            }

        }
    }
}
