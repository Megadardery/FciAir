using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerPage : Form
    {

        private int CustomerID = 0;

        string CustomerTicketsCond ;
        string CustomerFlightCols = "FlightID,Source,Destination,DepartTime,ArriveTime";
        string CustomerFlightTicketsCols = "TicketID,Tickets.FlightID,Source,Destination,DepartTime,ArriveTime,Price,AgeGroup,Class,BookDate";
        public CustomerPage(int id)
        {
            InitializeComponent();
            CustomerID = id;
            CustomerTicketsCond = "CustomerID = " + CustomerID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBy = cboSearch.Text;
            string req = txtSearchBar.Text;

            try
            {
                Logic.LoadListData(Program.dbms.SearchBy("Flights",searchBy,req,CustomerFlightCols), listVFlights);
            }
            catch (SqlException ex)
            {
                var reason = DBMS.ParseException(ex);
                if (reason == DBMS.SqlErrorNumber.NotInteger)
                {
                    MessageBox.Show(Logic.ErrorMessages.IntegerOnly, "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            cboClass.SelectedIndex = 0;

            List<string> cols;

            cols = Program.dbms.GetTableColumns("Flights",CustomerFlightCols);
            Logic.LoadListColumns(cols, listVFlights);
            Logic.LoadListColumns(cols, cboSearch);

            Logic.LoadListData(Program.dbms.GetTableData("Flights","1=1" ,CustomerFlightCols), listVFlights);

            const string flightJOINticket = "Tickets JOIN Flights ON Tickets.FlightID = Flights.FlightID";

            cols = Program.dbms.GetTableColumns(flightJOINticket, CustomerFlightTicketsCols);
            Logic.LoadListColumns(cols, listVMyFlights);

            Logic.LoadListData(Program.dbms.GetTableData(flightJOINticket, CustomerTicketsCond, CustomerFlightTicketsCols), listVMyFlights);


            lblIDCustomer.Text = CustomerID.ToString();
            List<object> userData = Program.dbms.GetTableData("Customers", $"CustomerID = { CustomerID }")[0];
            lbluserCustomer.Text = userData[6].ToString();

            txtMyFirstName.Text = userData[1].ToString();
            txtMyLastName.Text = userData[2].ToString();
            txtMyPassport.Text = userData[3].ToString();
            txtMyNationality.Text = userData[4].ToString();
            dtpMyBirthdate.Value = (DateTime)userData[5];
            txtMyUsername.Text = userData[6].ToString();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
                if (txtSearchBar.Text == "") Logic.LoadListData(Program.dbms.GetTableData("Flights", "1=1", CustomerFlightCols), listVFlights);

        }

        private void listVFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            bool correct = Program.dbms.CheckPasswordCustomer(CustomerID, txtMyOldPassword.Text);
            if (!correct)
            {
                MessageBox.Show("You have entered your previous password incorrectly", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pass = txtMyNewPassword.Text == "" ? txtMyOldPassword.Text : txtMyNewPassword.Text;
                try
                {
                    Program.dbms.UpdateCustomer(CustomerID, txtMyPassport.Text, txtMyFirstName.Text, txtMyLastName.Text, txtMyUsername.Text, pass,txtMyNationality.Text,dtpMyBirthdate.Value);
                    lbluserCustomer.Text = txtMyUsername.Text;

                }
                catch (SqlException ex)
                {
                    var reason = DBMS.ParseException(ex);
                    switch (reason)
                    {
                        case DBMS.SqlErrorNumber.Duplication:
                            MessageBox.Show(Logic.ErrorMessages.DuplicateUsername, "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case DBMS.SqlErrorNumber.Truncation:
                            MessageBox.Show(Logic.ErrorMessages.Truncation, "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        default:
                            MessageBox.Show(ex.Message);
                            break;
                    }
                }
            }
            txtMyOldPassword.Clear();
            txtMyNewPassword.Clear();
        }

        private void TextMyInfos_TextChanged(object sender, EventArgs e)
        {
            if (txtMyFirstName.Text=="" || txtMyLastName.Text=="" || txtMyPassport.Text == "" || txtMyNationality.Text == "" || txtMyUsername.Text == "" || txtMyOldPassword.Text=="" || dtpMyBirthdate.Value > DateTime.Now)
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }

        private void CustomerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.homePage.Show();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            int[] ID;
            DialogResult result = MessageBox.Show("Do you want to delete the account?","Delete Account",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ID = new int[1]; ID[0] = int.Parse(lblIDCustomer.Text);
                Program.dbms.DeleteCustomer(ID);
                this.Close();
            }
        }
    }
}
