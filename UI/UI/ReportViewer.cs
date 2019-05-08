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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FciAirDataSet.Monitor' table. You can move, or remove it, as needed.
            this.MonitorTableAdapter.Fill(this.FciAirDataSet.Monitor);
            // TODO: This line of code loads data into the 'FciAirDataSet.Flights' table. You can move, or remove it, as needed.
            this.FlightsTableAdapter.Fill(this.FciAirDataSet.Flights);
            this.reportViewer1.RefreshReport();
        }
    }
}
