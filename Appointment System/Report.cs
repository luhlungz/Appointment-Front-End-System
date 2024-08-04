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

namespace Appointment_System
{
    public partial class Report : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard r = new Dashboard();
        public Report(Dashboard r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void crvDataTable_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand command = new SqlCommand("Select from Appointment3");
        }
    }
}
