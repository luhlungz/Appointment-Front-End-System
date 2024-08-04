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
    public partial class Barber : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard b = new Dashboard();
        public Barber(Dashboard b)
        {
            InitializeComponent();
            this.b = b;
          
        }
        


        private void Barber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet.BarberTable' table. You can move, or remove it, as needed.
            this.barberTableTableAdapter.Fill(this.groupWst14DataSet.BarberTable);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            barberTableTableAdapter1.FillByBarber_Name(groupWst14DataSet.BarberTable, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (!textBox4.Text.StartsWith("0"))
            {
                MessageBox.Show("Phone number must start with '0'.");
                cn.Close();
                return;
            }

            cm = new SqlCommand("insert into BarberTable (Barber_Name,Barber_Surname,Barber_Phone_No) values (@Barber_Name,@Barber_Surname,@Barber_Phone_No)", cn);
            cm.Parameters.AddWithValue("@Barber_Name", textBox1.Text);
            cm.Parameters.AddWithValue("@Barber_Surname", textBox3.Text);
            cm.Parameters.AddWithValue("@Barber_Phone_No", textBox4.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been added successfully");
            this.barberTableTableAdapter.Fill(this.groupWst14DataSet.BarberTable);
            cn.Close();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void barberTableDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox7.Text = barberTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            id =int.Parse(barberTableDataGridView.CurrentRow.Cells[0].Value.ToString());
            textBox6.Text = barberTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = barberTableDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barberTableTableAdapter1.UpdateQuery(textBox7.Text, textBox6.Text, textBox5.Text, id);
            barberTableTableAdapter1.Fill(groupWst14DataSet.BarberTable);
            barberTableTableAdapter.Fill(groupWst14DataSet.BarberTable);
            MessageBox.Show("Updated Successfully");
        }

        private void DeleteQuery(int id)
        {
            // Locate the row in the dataset and remove it
            DataRow rowToDelete = groupWst14DataSet.BarberTable.Rows.Find(id);
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
            barberTableTableAdapter1.DeleteQuery(id);
            barberTableTableAdapter1.Fill(groupWst14DataSet.BarberTable);
            barberTableTableAdapter.Fill(groupWst14DataSet.BarberTable);
            MessageBox.Show("Deleted Successfully");

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void barberTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
