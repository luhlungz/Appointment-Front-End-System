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
using System.IO;

namespace Appointment_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Maximize the form
            WindowState = FormWindowState.Maximized;

            employeeTableAdapter1.FillByUser(groupWst14DataSet1.Employee,Form1.username,Form1.password);
            if (groupWst14DataSet1.Employee.Rows.Count > 0)
            {
                if (groupWst14DataSet1.Employee.Rows[0][1].ToString() == "Receptionist")
                {
                    button4.Visible = false;
                    button5.Visible = false;
                    button7.Visible = false;
                    button1.Visible = false;

                }
                
            }

                BLDate.Text = DateTime.Now.ToString();

           // panel1.Dock = DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Barber c = new Barber(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HaircutPrices c = new HaircutPrices(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Appointments c = new Appointments(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();

        }

        private void BLDate_Click(object sender, EventArgs e)
        {
          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageEmployee c = new ManageEmployee(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Reports c = new Reports(this);
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.BringToFront();
            c.Show();

        }
    }
}
