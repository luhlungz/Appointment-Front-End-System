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

namespace Appointment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid User Name", "Error");
                return false;

            }else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid Password", "Error");
                return false;
            }
            return true;
        }
        public static string username = "";
        public static string password = "";
        private void button1_Click(object sender, EventArgs e)

        { 
            if (isValid())
            {
             
                   
                    employeeTableAdapter1.FillByUser(groupWst14DataSet1.Employee, textBox1.Text, textBox2.Text);
                    if (groupWst14DataSet1.Employee.Rows.Count > 0)
                    {
                    MessageBox.Show("Login Successful");
                        username = textBox1.Text;
                        password = textBox2.Text;
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                {
                    MessageBox.Show("Login Details are Incorrect");
                }
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
