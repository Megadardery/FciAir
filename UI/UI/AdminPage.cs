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
            return;
            
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
            lbluserAdmin.Text = userData[1].ToString();
            txtMyFirstName.Text = userData[1].ToString();
            txtMyLastName.Text = userData[2].ToString();
            txtMyUsername.Text = userData[3].ToString();

            Logic.LoadListData(Program.dbms.GetTableData("Monitor", $"AdminID = { AdminID }"), lstMyMonitors);

        }

        private void txtSearchF_TextChanged(object sender, EventArgs e)
        {
            
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
            int[] ID = new int[1];
            ID[0] = int.Parse((lstFlights.SelectedItems[0].SubItems)[0].Text);
            Program.dbms.DeleteFlight(ID);

            lstFlights.Items.RemoveAt(lstFlights.Items.IndexOf(lstFlights.SelectedItems[0]));

            btnClearF.PerformClick();
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
            if (lstMyMonitors.SelectedIndex > 0)
                btnRemoveMonitor.Enabled = true;
            else
                btnRemoveMonitor.Enabled = false;
        }

        private void btnRemoveMonitor_Click(object sender, EventArgs e)
        {
            Program.dbms.DeleteMonitor(AdminID, int.Parse(lstMyMonitors.SelectedItem.ToString()));
        }

        private void txtFlightIDM_TextChanged(object sender, EventArgs e)
        {
            btnConfirmMonitor.Enabled = !(txtFlightIDM.Text == "");
        }

        private void btnConfirmMonitor_Click(object sender, EventArgs e)
        {
            Program.dbms.InsertMonitor(AdminID, int.Parse(txtFlightIDM.Text));
            Logic.LoadListData(Program.dbms.GetTableData("Monitor", $"AdminID = { AdminID }"), lstMyMonitors);

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            bool correct = Program.dbms.CheckPassword(AdminID, txtMyOldPassword.Text);
            if (!correct)
            {
                MessageBox.Show("You have entered your previous password incorrectly", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtMyOldPassword.Clear();
            txtMyNewPassword.Clear();
        }
    }
}
