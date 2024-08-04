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
using System.Text.RegularExpressions;

namespace Appointment_System
{
    public partial class ManageEmployee : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard m = new Dashboard();
        public ManageEmployee(Dashboard m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.groupWst14DataSet.Employee);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            employeeTableAdapter1.FillBy(groupWst14DataSet.Employee, textBox8.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }
        int id = 0;
        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox13.Text = employeeDataGridView.CurrentRow.Cells[2].Value.ToString();
            id = int.Parse(employeeDataGridView.CurrentRow.Cells[0].Value.ToString());
            textBox9.Text = employeeDataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = employeeDataGridView.CurrentRow.Cells[3].Value.ToString();
            textBox15.Text = employeeDataGridView.CurrentRow.Cells[4].Value.ToString();
            textBox11.Text = employeeDataGridView.CurrentRow.Cells[5].Value.ToString();
            textBox14.Text = employeeDataGridView.CurrentRow.Cells[6].Value.ToString();
            textBox12.Text = employeeDataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bool employeeArchived = bool.Parse(textBox12.Text);
            employeeTableAdapter1.UpdateQuery(textBox13.Text, textBox9.Text, textBox10.Text,textBox15.Text,textBox11.Text,textBox14.Text,Convert.ToBoolean(textBox12.Text), id);
            employeeTableAdapter1.Fill(groupWst14DataSet.Employee);
            employeeTableAdapter.Fill(groupWst14DataSet.Employee);
            MessageBox.Show("Updated Successfully");
        }

        private void DeleteQuery(int id)
        {
            // Locate the row in the dataset and remove it
            DataRow rowToDelete = groupWst14DataSet.Employee.Rows.Find(id);
            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                MessageBox.Show("Deleted Successfully from Application");
            }
            else
            {
                MessageBox.Show("Row not found in the dataset");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //employeeTableAdapter1.DeleteQuery(id);
            employeeTableAdapter1.Fill(groupWst14DataSet.Employee);
            employeeTableAdapter.Fill(groupWst14DataSet.Employee);
            MessageBox.Show("Deleted Successfully");
            DeleteQuery(id);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cn.Open();

            if (!textBox6.Text.StartsWith("0"))
            {
                MessageBox.Show("Phone number must start with '0'.");
                cn.Close();
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (!Regex.IsMatch(textBox4.Text, emailPattern))
            {
                MessageBox.Show("Invalid email address.");
                cn.Close();
                return;
            }

            bool employeeArchived = bool.Parse(textBox3.Text);
            cm = new SqlCommand("insert into Employee(EmployeeType,Employee_Name,Employee_Surname,Employee_Email,Employee_Phone_No,Employee_Password,Employee_Archived) values (@EmployeeType,@Employee_Name,@Employee_Surname,@Employee_Email,@Employee_Phone_No,@Employee_Password,@Employee_Archived)", cn);
            cm.Parameters.AddWithValue("@EmployeeType", textBox5.Text);
            cm.Parameters.AddWithValue("@Employee_Name", textBox1.Text);
            cm.Parameters.AddWithValue("@Employee_Surname", textBox2.Text);
            cm.Parameters.AddWithValue("@Employee_Email", textBox4.Text);
            cm.Parameters.AddWithValue("@Employee_Phone_No", textBox6.Text);
            cm.Parameters.AddWithValue("@Employee_Password", textBox7.Text);
            cm.Parameters.AddWithValue("@Employee_Archived", employeeArchived);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been added successfully");
            this.employeeTableAdapter.Fill(this.groupWst14DataSet.Employee);
            cn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Focus();

        }

        private void tabPage1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
