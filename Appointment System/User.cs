using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Appointment_System
{
    public partial class User : Form
    {
        Dashboard u = new Dashboard();
        public User(Dashboard u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void User_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst14;Persist Security Info=True;User ID=GroupWst14;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO member(Haircut_Name,Haircut_Price) VALUES (@Haircut_Name,@Haircut_Price)", con);
            cmd.Parameters.AddWithValue("@Haircut_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Haircut_Price", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Successfully Added!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
