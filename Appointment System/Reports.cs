using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.IO;

namespace Appointment_System
{
    public partial class Reports : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard r = new Dashboard();

        public Reports(Dashboard r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet.BarberTable' table. You can move, or remove it, as needed.
            this.barberTableTableAdapter.Fill(this.groupWst14DataSet.BarberTable);
            // Populate the comboBoxBarberNames with the names of available barbers
            PopulateBarberNamesComboBox();
        }

        private void PopulateBarberNamesComboBox()
        {
            // Create a default empty option
            DataTable emptyTable = new DataTable();
            emptyTable.Columns.Add("Barber", typeof(string));
            emptyTable.Rows.Add("All Barbers"); // You can customize the text as needed

            // Retrieve the list of barber names from the database
            string query = "SELECT DISTINCT Barber FROM Appointments";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Combine the empty option with the database results
            DataTable combinedTable = emptyTable.Copy();
            combinedTable.Merge(dataTable);

            // Bind the data to the comboBoxBarberNames
            comboBoxBarberNames.DataSource = combinedTable;
            comboBoxBarberNames.DisplayMember = "Barber";
            comboBoxBarberNames.ValueMember = "Barber";
        }

            private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected dates from the DateTimePickers
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            // Get the selected barber name from the comboBox
            string selectedBarberName = comboBoxBarberNames.SelectedValue.ToString();

            // Modify the SQL query to filter by date and optionally by barber name
            string sqlQuery = $"SELECT * FROM Appointments WHERE Date BETWEEN '{fromDate.ToString("yyyy-MM-dd")}' AND '{toDate.ToString("yyyy-MM-dd")}'";

            if (selectedBarberName != "All Barbers")
            {
                sqlQuery += $" AND Barber = '{selectedBarberName}'";
            }

            // Your report generation code here
            string reportFilePath = @"C:\Users\lungz\source\repos\Appointment System\Appointment System\ReportGenerator\CrystalReport\crptReport.rpt";
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(reportFilePath);

            ConnectionInfo connectionInfo = new ConnectionInfo();
            connectionInfo.ServerName = "146.230.177.46";
            connectionInfo.DatabaseName = "GroupWst14";
            connectionInfo.UserID = "GroupWst14";
            connectionInfo.Password = "9da81";

            foreach (Table table in reportDocument.Database.Tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            DataTable dataTable1 = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(sqlQuery, cn);
            dataAdapter1.Fill(dataTable1);

            reportDocument.Database.Tables[0].SetDataSource(dataTable1);

            ReportViewer.ReportSource = reportDocument;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBarberNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

