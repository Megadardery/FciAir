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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int id = Program.dbms.LoginAdmin(txtUsername.Text, txtPassword.Text);
            if (id == -1)
            {
                MessageBox.Show("Incorrect Username or password, Please double check them.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminPage ap = new AdminPage(id);
                ap.Show();
                
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !(txtUsername.Text == "" || txtPassword.Text== "" );
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.Yes)
                Program.homePage.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
