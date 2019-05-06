using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
            this.Icon = UI.Properties.Resources.myico;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = Program.dbms.LoginCustomer(txtUsername.Text, txtPassword.Text);
            if (id == -1)
            {
                MessageBox.Show("Incorrect Username or password, Please double check them.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CustomerPage ap = new CustomerPage(id);
                ap.Show();

                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !(txtUsername.Text == "" || txtPassword.Text == "");
        }

        private void CustomerLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.Yes)
                Program.homePage.Show();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            CustomerSignUp a2 = new CustomerSignUp();
            a2.ShowDialog();
        }
    }
}
