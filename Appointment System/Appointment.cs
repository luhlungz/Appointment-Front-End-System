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
using System.Drawing.Printing;
using System.IO;

namespace Appointment_System
{
    public partial class Appointment : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard a = new Dashboard();
        public Appointment(Dashboard a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet5.Payment3' table. You can move, or remove it, as needed.
            this.payment3TableAdapter.Fill(this.groupWst14DataSet5.Payment3);
            // TODO: This line of code loads data into the 'groupWst14DataSet4.Payment1' table. You can move, or remove it, as needed.
            //this.payment1TableAdapter2.Fill(this.groupWst14DataSet4.Payment1);
            // TODO: This line of code loads data into the 'groupWst14DataSet31.Payment2' table. You can move, or remove it, as needed.
            this.payment2TableAdapter.Fill(this.groupWst14DataSet31.Payment2);
            // TODO: This line of code loads data into the 'groupWst14DataSet21.Payment1' table. You can move, or remove it, as needed.
            //this.payment1TableAdapter1.Fill(this.groupWst14DataSet21.Payment1);
            // TODO: This line of code loads data into the 'groupWst14DataSet11.Payment1' table. You can move, or remove it, as needed.
          //  this.payment1TableAdapter.Fill(this.groupWst14DataSet11.Payment1);
            // TODO: This line of code loads data into the 'groupWst14DataSet1.Appointment3' table. You can move, or remove it, as needed.
            this.appointment3TableAdapter.Fill(this.groupWst14DataSet1.Appointment3);
            // TODO: This line of code loads data into the 'groupWst14DataSet1.BarberTable' table. You can move, or remove it, as needed.
            this.barberTableTableAdapter.Fill(this.groupWst14DataSet1.BarberTable);
            // TODO: This line of code loads data into the 'groupWst14DataSet1.Appointment2' table. You can move, or remove it, as needed.
            this.appointment2TableAdapter.Fill(this.groupWst14DataSet1.Appointment2);
            // TODO: This line of code loads data into the 'groupWst14DataSet1.Appointment1' table. You can move, or remove it, as needed.
            this.appointment1TableAdapter.Fill(this.groupWst14DataSet1.Appointment1);
            // TODO: This line of code loads data into the 'groupWst14DataSet2.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.groupWst14DataSet2.Customer1);
            // TODO: This line of code loads data into the 'groupWst14DataSet1.Timeslot1' table. You can move, or remove it, as needed.
            this.timeslot1TableAdapter.Fill(this.groupWst14DataSet1.Timeslot1);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Haircut' table. You can move, or remove it, as needed.
            this.haircutTableAdapter.Fill(this.groupWst14DataSet.Haircut);

            dateTimePicker1.MinDate = DateTime.Today;

        }

        private void fillByHaircut_NameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.haircutTableAdapter.FillByHaircut_Name(this.groupWst14DataSet.Haircut);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            appointment3TableAdapter1.FillByCustomer_Name(groupWst14DataSet1.Appointment3, textBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            // Check if the selected barber has an appointment at the chosen date and time
            SqlCommand barberCheckCmd = new SqlCommand("SELECT COUNT(*) FROM Appointment3 WHERE Barber_Name = @Barber_Name AND TimeStart = @TimeStart AND Date = @Date", cn);
            barberCheckCmd.Parameters.AddWithValue("@Barber_Name", comboBox9.Text);
            barberCheckCmd.Parameters.AddWithValue("@TimeStart", comboBox3.Text);
            barberCheckCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            int existingBarberAppointments = (int)barberCheckCmd.ExecuteScalar();

            // Check if the selected customer has an appointment on the chosen date
            SqlCommand customerCheckCmd = new SqlCommand("SELECT COUNT(*) FROM Appointment3 WHERE Customer_Name = @Customer_Name AND Date = @Date", cn);
            customerCheckCmd.Parameters.AddWithValue("@Customer_Name", comboBox2.Text);
            customerCheckCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            int existingCustomerAppointments = (int)customerCheckCmd.ExecuteScalar();

            if (existingBarberAppointments > 0)
            {
                MessageBox.Show("This barber already has an appointment at this time. Please select another date or time.");
            }
            else if (existingCustomerAppointments > 0)
            {
                MessageBox.Show("This customer already has an appointment on this date. Please select another date.");
            }
            else
            {
                cm = new SqlCommand("INSERT INTO Appointment3(Customer_Name, Barber_Name, Haicut_Name, TimeStart, TimeEnd, Date) VALUES (@Customer_Name, @Barber_Name, @Haicut_Name, @TimeStart, @TimeEnd, @Date)", cn);
                cm.Parameters.AddWithValue("@Customer_Name", comboBox2.Text);
                cm.Parameters.AddWithValue("@Barber_Name", comboBox9.Text);
                cm.Parameters.AddWithValue("@Haicut_Name", comboBox1.Text);
                cm.Parameters.AddWithValue("@TimeStart", comboBox3.Text);
                cm.Parameters.AddWithValue("@TimeEnd", comboBox4.Text);
                cm.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cm.ExecuteNonQuery();
                MessageBox.Show("Record has been added successfully");
                this.appointment3TableAdapter1.Fill(this.groupWst14DataSet1.Appointment3);
            }



            cn.Close();

            comboBox2.Focus();

            //dateTimePicker1.MinDate = DateTime.Today;

            //MessageBox.Show(comboBox2.Text);
            //MessageBox.Show(dateTimePicker1.Value.ToString());
            //MessageBox.Show(comboBox2.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //string formattedDateTime = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            appointment3TableAdapter1.UpdateQuery(comboBox2.Text, comboBox9.Text, comboBox1.Text,comboBox3.Text,comboBox4.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), id);
            appointment3TableAdapter1.Fill(groupWst14DataSet1.Appointment3);
            appointment3TableAdapter.Fill(groupWst14DataSet1.Appointment3);
            MessageBox.Show("Updated Successfully");
            


        }
        //int id = 0;
        private void appointment2DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DeleteRowFromDataGridView(int id)
        {
            // Locate the row in the dataset and remove it from the DataTable
            DataRow rowToDelete = groupWst14DataSet1.Appointment3.Rows.Find(id);
            if (rowToDelete != null)
            {
                groupWst14DataSet1.Appointment3.Rows.Remove(rowToDelete);
                MessageBox.Show("Deleted Successfully from Application");
            }
            else
            {
                MessageBox.Show("Row not found in the dataset");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //appointment3TableAdapter1.DeleteQuery(id);
            if (id > 0)
            {
                DeleteRowFromDataGridView(id);
                // Refresh the DataGridView after removing the row
                appointment3DataGridView.DataSource = groupWst14DataSet1.Appointment3;
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("No row selected for deletion.");
            }
        }

        private void appointment2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void appointment3DataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBox2.Text = appointment3DataGridView.CurrentRow.Cells[1].Value.ToString();
            id = int.Parse(appointment3DataGridView.CurrentRow.Cells[0].Value.ToString());
            comboBox9.Text = appointment3DataGridView.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = appointment3DataGridView.CurrentRow.Cells[3].Value.ToString();
            comboBox3.Text = appointment3DataGridView.CurrentRow.Cells[4].Value.ToString();
            comboBox4.Text = appointment3DataGridView.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = appointment3DataGridView.CurrentRow.Cells[6].Value.ToString();

           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO Payment3 (AppointmentID,HaircutName,Price,AmountTendered,Change,Total) VALUES (@AppointmentID, @HaircutName, @Price, @AmountTendered, @Change, @Total)", cn);
            cm.Parameters.AddWithValue("@AppointmentID", comboBox11.Text);
            cm.Parameters.AddWithValue("@HaircutName", comboBox12.Text);
            cm.Parameters.AddWithValue("@Price", comboBox13.Text);
            cm.Parameters.AddWithValue("@AmountTendered", textBox4.Text);
            cm.Parameters.AddWithValue("@Change", textBox3.Text);
            cm.Parameters.AddWithValue("@Total", textBox2.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been added successfully");
            this.payment3TableAdapter.Fill(this.groupWst14DataSet5.Payment3);
            cn.Close();

            textBox4.Clear();
            textBox3.Clear();
            textBox2.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Variables to store parsed values
            decimal price;
            decimal amountTendered;

            // Check if Price and AmountTendered are valid numeric values
            if (decimal.TryParse(comboBox13.Text, out price) && decimal.TryParse(textBox4.Text, out amountTendered))
            {
                // Calculate the change
                decimal change = amountTendered - price;

                // Display the change in textBox3
                textBox3.Text = change.ToString();
            }
            else
            {
                // Handle the case where input is not a valid numeric value
                MessageBox.Show("Please enter valid numeric values for Price and Amount Tendered.");
                textBox3.Text = string.Empty;
            }
        }
        private void GenerateReceipt()
        {
            // Create a PrintDocument object
            PrintDocument pd = new PrintDocument();

            // Set up the PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(GenerateReceipt_PrintPage);

            // Print the document
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void GenerateReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the content of the receipt to be printed
            Random random = new Random();
            string businessName = "KIWA SIDE VIP Salon";
            string address = "Address: Peck Road, South Beach, Durban, 4001";
            string phone = "Phone: 083 724 6020";
            string email = "Email: hazakimanas430@gmail.com";
            string receiptDate = "Receipt Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string receiptNumber = "Receipt #: " + random.Next(100, 1000).ToString(); // You can generate a unique receipt number here

            string haircutName = "Haircut Name : " + comboBox12.Text;
            string amountTendered = "Amount Tendered: R" + textBox4.Text;
            string price = "Price: R" + comboBox13.Text;
            string change = "Change: R" + textBox3.Text;
          
            string total = "Total: " + textBox2.Text;
            
            string thankYouMessage = "Thank you for your business!";

            // Create a font and brush for drawing text
            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);

            // Create a rectangle to define the printable area
            RectangleF rect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);

            // Create a StringFormat object to specify text alignment
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;

            // Draw the receipt content on the page
            e.Graphics.DrawString(businessName, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(address, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(phone, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(email, font, brush, rect, format);
            rect.Y += 30;
            e.Graphics.DrawString("--------------------------------------------------", font, brush, rect, format);
            rect.Y += 40;
            e.Graphics.DrawString(receiptDate, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(receiptNumber, font, brush, rect, format);
            rect.Y += 30;
            e.Graphics.DrawString("--------------------------------------------------", font, brush, rect, format);
            rect.Y += 40;
            e.Graphics.DrawString(haircutName, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(amountTendered, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(price, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(change, font, brush, rect, format);
            rect.Y += 30;
            e.Graphics.DrawString("--------------------------------------------------", font, brush, rect, format);
            rect.Y += 40;
            e.Graphics.DrawString(total, font, brush, rect, format);
            rect.Y += 30;
            e.Graphics.DrawString("--------------------------------------------------", font, brush, rect, format);
            rect.Y += 60;
            e.Graphics.DrawString(thankYouMessage, font, brush, rect, format);
        }

        private void buttonGenerateReceipt_Click(object sender, EventArgs e)
        {
            
        }








        private void button5_Click(object sender, EventArgs e)
        {
             GenerateReceipt();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
