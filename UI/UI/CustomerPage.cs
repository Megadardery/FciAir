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
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
                if (txtSearchBar.Text == "") Logic.LoadListData(Program.dbms.GetTableData("Flights", "1=1", CustomerFlightCols), listVFlights);

        }

        private void listVFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
