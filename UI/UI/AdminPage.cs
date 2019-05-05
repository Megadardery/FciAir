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
    public partial class AdminPage : Form
    {
        private int AdminID;
        public AdminPage(int id)
        {
            InitializeComponent();
            AdminID = id;
        }

        private void ClearFlightData()
        {
            lblFlightID.Text = "";
            txtAircraftID.Text = "";
            dtpDepart.Text = "";
            dtpArrive.Text = "";
            numRequiredSeats.Value = 0;
            txtSource.Text = "";
            txtDestination.Text = "";
        }

        private void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFlights.SelectedItems.Count > 0)
            {
                var ret = lstFlights.SelectedItems[0].SubItems;
                lblFlightID.Text = ret[0].Text;
                txtAircraftID.Text = ret[1].Text;
                dtpDepart.Text = ret[2].Text;
                dtpArrive.Text = ret[3].Text;
                numRequiredSeats.Value = int.Parse(ret[4].Text);
                txtSource.Text = ret[5].Text;
                txtDestination.Text = ret[6].Text;
            }
            btnClearF.Enabled = btnEraseF.Enabled = true;
            btnUpdateF.Text = "Update";
        }
        

        private void AdminPage_Load(object sender, EventArgs e)
        {
            List<string> cols;

            cols = Program.dbms.GetTableColumns("Flights");
            Logic.LoadListColumns(cols, lstFlights);
            Logic.LoadListColumns(cols, cmbSearchF);

            Logic.LoadListData(Program.dbms.GetTableData("Flights"), lstFlights);
            //return;
            
            cols = Program.dbms.GetTableColumns("Aircrafts");
            Logic.LoadListColumns(cols, lstAircrafts);
            Logic.LoadListColumns(cols, cmbSearchAC);

            Logic.LoadListData(Program.dbms.GetTableData("Aircrafts"), lstAircrafts);


            cols = Program.dbms.GetTableColumns("Customers");
            Logic.LoadListColumns(cols, lstCustomers);
            Logic.LoadListColumns(cols, cmbSearchC);

            Logic.LoadListData(Program.dbms.GetTableData("Customers"), lstCustomers);


            cols = Program.dbms.GetTableColumns("Tickets");
            Logic.LoadListColumns(cols, lstTickets);
            Logic.LoadListColumns(cols, cmbSearchT);

            Logic.LoadListData(Program.dbms.GetTableData("Tickets"), lstTickets);

            lblIDAdmin.Text = AdminID.ToString();
            List<object> userData = Program.dbms.GetTableData("Admins", $"AdminID = { AdminID }")[0];
            lbluserAdmin.Text = userData[3].ToString();
            txtMyFirstName.Text = userData[1].ToString();
            txtMyLastName.Text = userData[2].ToString();
            txtMyUsername.Text = userData[3].ToString();

            Logic.LoadListData(Program.dbms.GetTableData("Monitor", $"AdminID = { AdminID }"), lstMyMonitors);

        }

    

        private void btnClearF_Click(object sender, EventArgs e)
        {
            ClearFlightData();
            if (lstFlights.SelectedItems.Count > 0)
                lstFlights.SelectedIndices.Clear();
            else
            {
                //TODO if no item selected
            }

            btnClearF.Enabled = btnEraseF.Enabled = false;
            btnUpdateF.Text = "Add";

        }

        private void btnEraseF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this aircraft? This will cause all of its flights and all the tickets on these flights to be removed as well!", "Delete Aircraft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int[] ID = new int[1];
                ID[0] = int.Parse(lstFlights.SelectedItems[0].SubItems[0].Text);
                Program.dbms.DeleteFlight(ID);

                btnClearF.PerformClick();

                AdminPage_Load(null, null);
            }
        }

        private void btnUpdateF_Click(object sender, EventArgs e)
        {
            if (lstFlights.SelectedItems.Count > 0)
                Program.dbms.UpdateFlight(int.Parse(lblFlightID.Text),int.Parse(txtAircraftID.Text), dtpDepart.Value, dtpArrive.Value, (int)numRequiredSeats.Value, txtSource.Text, txtDestination.Text);
            else
                Program.dbms.InsertFlight(int.Parse(txtAircraftID.Text),dtpDepart.Value,dtpArrive.Value,(int)numRequiredSeats.Value,txtSource.Text,txtDestination.Text);

            Logic.LoadListData(Program.dbms.GetTableData("Flights"), lstFlights);
            btnClearF.PerformClick();
        }

        private void lstAircrafts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAircrafts.SelectedItems.Count > 0)
            {
                var ret = lstAircrafts.SelectedItems[0].SubItems;
                lblAircraftID.Text = ret[0].Text;
                numMaxSeats.Value = int.Parse(ret[2].Text);
                txtModel.Text = ret[3].Text;
                txtPilotName.Text = ret[4].Text;
                dtpPilotBirthdate.Value = DateTime.Parse(ret[5].Text);
                txtSalary.Text = ret[6].Text;
            }
            btnClearAC.Enabled = btnEraseAC.Enabled = true;
            btnUpdateAC.Text = "Update";
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.homePage.Show();
        }

        private void lstMyMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMyMonitors.SelectedIndex >= 0)
                btnRemoveMonitor.Enabled = true;
            else
                btnRemoveMonitor.Enabled = false;
        }

        private void btnRemoveMonitor_Click(object sender, EventArgs e)
        {
            Program.dbms.DeleteMonitor(AdminID, int.Parse(lstMyMonitors.SelectedItem.ToString()));
            Logic.LoadListData(Program.dbms.GetTableData("Monitor", $"AdminID = { AdminID }"), lstMyMonitors);
            lstMyMonitors_SelectedIndexChanged(null, null);
        }

        private void txtFlightIDM_TextChanged(object sender, EventArgs e)
        {
            btnConfirmMonitor.Enabled = !(txtFlightIDM.Text == "");
        }

        private void btnConfirmMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                Program.dbms.InsertMonitor(AdminID, int.Parse(txtFlightIDM.Text));
                txtFlightIDM.Clear();
            }
            catch (SqlException ex)
            {
                var reason = DBMS.ParseException(ex);
                switch (reason)
                {
                    case DBMS.SqlErrorNumber.Duplication:
                        MessageBox.Show(Logic.ErrorMessages.DuplicatePrimaryKey, "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DBMS.SqlErrorNumber.ForeignKeyViolation:
                        MessageBox.Show(Logic.ErrorMessages.ForeignViolation, "Flight doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a proper Flight ID", "Cannot parse data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Logic.LoadListData(Program.dbms.GetTableData("Monitor", $"AdminID = { AdminID }"), lstMyMonitors);

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            bool correct = Program.dbms.CheckPasswordAdmin(AdminID, txtMyOldPassword.Text);
            if (!correct)
            {
                MessageBox.Show("You have entered your previous password incorrectly", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pass = txtMyNewPassword.Text == "" ? txtMyOldPassword.Text : txtMyNewPassword.Text;
                try
                {
                    Program.dbms.UpdateAdmin(AdminID, txtMyFirstName.Text, txtMyLastName.Text, txtMyUsername.Text, pass);
                    lbluserAdmin.Text = txtMyUsername.Text;
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

        private void btnSearchF_Click(object sender, EventArgs e)
        {
            //if (txtSearchF.Text == "")
                //return;

            if(cmbSearchF.Text.Equals("DepartTime") || cmbSearchF.Text.Equals("ArriveTime"))
                Logic.LoadListData(Program.dbms.SearchByTime("Flights", cmbSearchF.Text, dtpFrom.Value, dtpTo.Value), lstFlights);
            else
                Logic.LoadListData(Program.dbms.SearchBy("Flights", cmbSearchF.Text, txtSearchF.Text), lstFlights);
        }

        private void cmbSearchF_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchF.Text = dtpFrom.Text = dtpTo.Text = "";
     
            if (cmbSearchF.Text.Equals("DepartTime") || cmbSearchF.Text.Equals("ArriveTime"))
            {
                lblFrom.Visible = lblTo.Visible = true;
                dtpFrom.Visible = dtpTo.Visible = true;
                txtSearchF.Visible = false;
            }
            else
            {
                lblFrom.Visible = lblTo.Visible = false;
                dtpFrom.Visible = dtpTo.Visible = false;
                txtSearchF.Visible = true;
            }
            Logic.LoadListData(Program.dbms.GetTableData("Flights"), lstFlights);
        }

        private void btnSearchAC_Click(object sender, EventArgs e)
        {
            Logic.LoadListData(Program.dbms.SearchBy("Aircrafts", cmbSearchAC.Text, txtSearchAC.Text), lstAircrafts);
        }

        private void btnSearchC_Click(object sender, EventArgs e)
        {
            Logic.LoadListData(Program.dbms.SearchBy("Customers", cmbSearchC.Text, txtSearchC.Text), lstCustomers);
        }

        private void btnsearchT_Click(object sender, EventArgs e)
        {
            Logic.LoadListData(Program.dbms.SearchBy("Tickets", cmbSearchT.Text, txtSearchT.Text), lstTickets);

        }
        private void txtSearchF_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchF.Text == "") Logic.LoadListData(Program.dbms.GetTableData("Flights"), lstFlights);
        }
        private void txtSearchAC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchAC.Text == "") Logic.LoadListData(Program.dbms.GetTableData("Aircrafts"), lstAircrafts);

        }

        private void txtSearchC_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchC.Text == "")  Logic.LoadListData(Program.dbms.GetTableData("Customers"), lstCustomers);

        }

        private void txtSearchT_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchT.Text == "") Logic.LoadListData(Program.dbms.GetTableData("Tickets"), lstTickets);
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextMyInfos_TextChanged(object sender, EventArgs e)
        {
            if (txtMyFirstName.Text == "" || txtMyLastName.Text == "" || txtMyUsername.Text == "" || txtMyOldPassword.Text == "")
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }

        private void btnClearAC_Click(object sender, EventArgs e)
        {
            lblAircraftID.Text = "";
            txtModel.Text = "";
            numMaxSeats.Value = 0;
            txtPilotName.Text = "";
            dtpPilotBirthdate.Text = "";
            txtSalary.Text = "";

            if (lstAircrafts.SelectedItems.Count > 0)
                lstAircrafts.SelectedIndices.Clear();
            else
            {
                //TODO if no item selected
            }

            btnEraseAC.Enabled = btnClearAC.Enabled = false;
            btnUpdateAC.Text = "Add";
        }

        private void btnEraseAC_Click(object sender, EventArgs e)
        {
            //NOTE : an Error may happen due to the foreign keys
            //should delete all flights, tickets and customer that related to this aircraft
            var result = MessageBox.Show("Are you sure you want to delete this aircraft? This will cause all of its flights and all the tickets on these flights to be removed as well!", "Delete Aircraft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int[] ID = new int[1];
                ID[0] = int.Parse((lstAircrafts.SelectedItems[0].SubItems)[0].Text);
                Program.dbms.DeleteAircrafts(ID);

                btnClearAC.PerformClick();

                AdminPage_Load(null, null);
            }
        }

        private void btnUpdateAC_Click(object sender, EventArgs e)
        {
            if (lstAircrafts.SelectedItems.Count > 0)
                Program.dbms.UpdateAirCraft(int.Parse(lblAircraftID.Text), AdminID, (int)numMaxSeats.Value, txtModel.Text, txtPilotName.Text, dtpPilotBirthdate.Value, int.Parse(txtSalary.Text));
            else
                Program.dbms.InsertAircraft(AdminID, (int)numMaxSeats.Value, txtModel.Text, txtPilotName.Text, dtpPilotBirthdate.Value, int.Parse(txtSalary.Text));

            Console.Write("done");

            Logic.LoadListData(Program.dbms.GetTableData("Aircrafts"), lstAircrafts);
            btnClearAC.PerformClick();
        }

        private void btnEraseT_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedItems.Count == 0) return;

            var result = MessageBox.Show("Are you sure you want to delete this ticket?", "Delete Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int[] ID = new int[1];
                ID[0] = int.Parse((lstTickets.SelectedItems[0].SubItems)[0].Text);
                Program.dbms.DeleteTicket(ID);

                AdminPage_Load(null, null);
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Program.dbms.InsertAdmin(txtAddFirstName.Text, txtAddLastName.Text, txtAddUsername.Text, txtAddPassword.Text);
                MessageBox.Show("Admin registration is successful!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddFirstName.Clear();
                txtAddLastName.Clear();
                txtAddUsername.Clear();
                txtAddPassword.Clear();
            }
            catch (SqlException ex)
            {
                var reason = DBMS.ParseException(ex);
                switch (reason)
                {
                    case DBMS.SqlErrorNumber.Duplication:
                        MessageBox.Show(Logic.ErrorMessages.DuplicateUsername, "Username already exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case DBMS.SqlErrorNumber.Truncation:
                        MessageBox.Show(Logic.ErrorMessages.Truncation, "Too long", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void TextNewAdmin_TextChanged(object sender, EventArgs e)
        {
            if (txtAddFirstName.Text == "" || txtAddLastName.Text == "" || txtAddPassword.Text == "" || txtAddUsername.Text == "")
                btnAddAdmin.Enabled = false;
            else
                btnAddAdmin.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.AdminPage_Load(null, null);
        }
    }
}
