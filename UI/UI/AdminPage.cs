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
        public AdminPage()
        {
            InitializeComponent();
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
                txtDistination.Text = ret[6].Text;
            }
        }
        

        private void AdminPage_Load(object sender, EventArgs e)
        {
            Logic.LoadListColumns(Program.dbms.GetTableColumns("Flights"), lstFlights);
            Logic.LoadListData(Program.dbms.GetTableData("Flights"), lstFlights);

            Logic.LoadListColumns(Program.dbms.GetTableColumns("Aircrafts"), lstAircrafts);
            Logic.LoadListData(Program.dbms.GetTableData("Aircrafts"), lstAircrafts);

            Logic.LoadListColumns(Program.dbms.GetTableColumns("Customers"), lstCustomers);
            Logic.LoadListData(Program.dbms.GetTableData("Customers"), lstCustomers);

            Logic.LoadListColumns(Program.dbms.GetTableColumns("Monitor"), lstMonitor);
            Logic.LoadListData(Program.dbms.GetTableData("Monitor"), lstMonitor);

            Logic.LoadListColumns(Program.dbms.GetTableColumns("Tickets"), lstTickets);
            Logic.LoadListData(Program.dbms.GetTableData("Tickets"), lstTickets);

        }
        
    }
}
