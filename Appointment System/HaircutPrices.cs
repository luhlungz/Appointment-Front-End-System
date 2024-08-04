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
    public partial class HaircutPrices : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard h = new Dashboard();
        public HaircutPrices(Dashboard h)
        {
            InitializeComponent();
            this.h = h;
        }
       


        private void HaircutPrices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet.Haircut' table. You can move, or remove it, as needed.
            this.haircutTableAdapter.Fill(this.groupWst14DataSet.Haircut);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            haircutTableAdapter1.FillByName(groupWst14DataSet.Haircut, textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into Haircut (Haircut_Name,Haircut_Price) values (@Haircut_Name,@Haircut_Price)", cn);
            cm.Parameters.AddWithValue("@Haircut_Name", textBox1.Text);
            cm.Parameters.AddWithValue("@Haircut_Price", textBox2.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been added successfully");
            cn.Close();
            this.haircutTableAdapter.Fill(this.groupWst14DataSet.Haircut);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void haircutDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = haircutDataGridView.CurrentRow.Cells[1].Value.ToString();
            id = int.Parse(haircutDataGridView.CurrentRow.Cells[0].Value.ToString());
            textBox5.Text = haircutDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            haircutTableAdapter1.UpdateQuery(textBox4.Text,Convert.ToDecimal(textBox5.Text), id);
            haircutTableAdapter1.Fill(groupWst14DataSet.Haircut);
            haircutTableAdapter.Fill(groupWst14DataSet.Haircut);
            MessageBox.Show("Updated Successfully");
        }

        private void DeleteQuery(int id)
        {
            // Locate the row in the dataset and remove it
            DataRow rowToDelete = groupWst14DataSet.Haircut.Rows.Find(id);
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
            //haircutTableAdapter1.DeleteQuery(id);
            haircutTableAdapter1.Fill(groupWst14DataSet.Haircut);
            haircutTableAdapter.Fill(groupWst14DataSet.Haircut);
            MessageBox.Show("Deleted Successfully");
            DeleteQuery(id);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

