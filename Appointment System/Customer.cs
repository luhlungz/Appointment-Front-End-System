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
    public partial class Customer : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        SqlDataReader dr;
        Dashboard c = new Dashboard();
        public Customer(Dashboard c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet1.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.groupWst14DataSet1.Customer1);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.groupWst14DataSet.Customer1);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            customer1TableAdapter1.FillByName(groupWst14DataSet.Customer1, textBox6.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (!textBox3.Text.StartsWith("0"))
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

            cm = new SqlCommand("insert into Customer1 (Customer_Name,Customer_Surname,Customer_Phone_No,Customer_Email,Customer_Address) values (@Customer_Name,@Customer_Surname,@Customer_Phone_No,@Customer_Email,@Customer_Address)", cn);
            cm.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
            cm.Parameters.AddWithValue("@Customer_Surname", textBox2.Text);
            cm.Parameters.AddWithValue("@Customer_Phone_No", textBox3.Text);
            cm.Parameters.AddWithValue("@Customer_Email", textBox4.Text);
            cm.Parameters.AddWithValue("@Customer_Address", textBox5.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been added successfully");
            this.customer1TableAdapter.Fill(this.groupWst14DataSet.Customer1);
            cn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customer1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id = 0;

        private void customer1DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox8.Text = customer1DataGridView.CurrentRow.Cells[1].Value.ToString();
            id = int.Parse(customer1DataGridView.CurrentRow.Cells[0].Value.ToString());
            textBox7.Text = customer1DataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = customer1DataGridView.CurrentRow.Cells[3].Value.ToString();
            textBox10.Text = customer1DataGridView.CurrentRow.Cells[4].Value.ToString();
            textBox11.Text = customer1DataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer1TableAdapter1.UpdateQuery(textBox8.Text,textBox7.Text,textBox9.Text,textBox10.Text,textBox11.Text,id);
            customer1TableAdapter1.Fill(groupWst14DataSet1.Customer1);
            customer1TableAdapter.Fill(groupWst14DataSet1.Customer1);
            MessageBox.Show("Updated Successfully");
        }

        private void DeleteQuery(int id)
        {
            // Locate the row in the dataset and remove it
            DataRow rowToDelete = groupWst14DataSet.Customer1.Rows.Find(id);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //customer1TableAdapter1.DeleteQuery(id);
            customer1TableAdapter1.Fill(groupWst14DataSet1.Customer1);
            customer1TableAdapter.Fill(groupWst14DataSet1.Customer1);
            MessageBox.Show("Deleted Successfully");
            DeleteQuery(id);
        }

        private void textBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
