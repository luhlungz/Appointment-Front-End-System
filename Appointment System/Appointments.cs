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
using System.Globalization;
using System.Drawing.Printing;
using System.IO;

namespace Appointment_System
{
    public partial class Appointments : Form
    {
        SqlConnection cn = new SqlConnection(db.cn);
        SqlCommand cm;
        Dashboard p = new Dashboard();
        public Appointments(Dashboard p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst14DataSet5.Payment3' table. You can move, or remove it, as needed.
            this.payment3TableAdapter.Fill(this.groupWst14DataSet5.Payment3);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.groupWst14DataSet.Payment);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Timeslot1' table. You can move, or remove it, as needed.
            this.timeslot1TableAdapter.Fill(this.groupWst14DataSet.Timeslot1);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Haircut' table. You can move, or remove it, as needed.
            this.haircutTableAdapter.Fill(this.groupWst14DataSet.Haircut);
            // TODO: This line of code loads data into the 'groupWst14DataSet.BarberTable' table. You can move, or remove it, as needed.
            this.barberTableTableAdapter.Fill(this.groupWst14DataSet.BarberTable);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.groupWst14DataSet.Customer1);
            // TODO: This line of code loads data into the 'groupWst14DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst14DataSet.Customer);
            // TODO: This line of code loads data into the 'groupWst14DataSet6.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.groupWst14DataSet6.Appointments);
            LoadAppointmentsForPresentDay();
        }

        private void LoadAppointmentsForPresentDay()
        {
            cn.Open();

            // Get the current date
            DateTime currentDate = DateTime.Now.Date;

            // Use a parameterized query to filter appointments for the present day
            string query = "SELECT * FROM Appointments WHERE CONVERT(date, Date) = @CurrentDate";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            adapter.SelectCommand.Parameters.AddWithValue("@CurrentDate", currentDate);

            // Create a DataTable to hold the result set
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to dataGridView2
            dataGridView2.DataSource = dataTable;

            cn.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            appointmentsTableAdapter.FillByCustomer(groupWst14DataSet6.Appointments, textBox1.Text);
        }

        private void UpdateAppointment()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE Appointments SET Customer = @Customer, Barber = @Barber, Haircut = @Haircut, Time = @Time, Price = @Price, Date = @Date WHERE ID = @ID", cn);
            cm.Parameters.AddWithValue("@ID", id);
            cm.Parameters.AddWithValue("@Customer", comboBox1.Text);
            cm.Parameters.AddWithValue("@Barber", comboBox2.Text);
            cm.Parameters.AddWithValue("@Haircut", comboBox3.Text);
            cm.Parameters.AddWithValue("@Time", comboBox5.Text);
            cm.Parameters.AddWithValue("@Price", comboBox4.Text);
            cm.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cm.ExecuteNonQuery();
            MessageBox.Show("Record has been updated successfully");
            this.appointmentsTableAdapter.Fill(this.groupWst14DataSet6.Appointments);
            cn.Close();

            // Clear the form fields
            ClearFormFields();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                UpdateAppointment();
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            // Check if the selected barber has an appointment at the chosen date and time
            SqlCommand barberCheckCmd = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE Barber = @Barber AND Time = @Time AND Date = @Date", cn);
            barberCheckCmd.Parameters.AddWithValue("@Barber", comboBox2.Text);
            barberCheckCmd.Parameters.AddWithValue("@Time", comboBox5.Text);
            barberCheckCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            int existingBarberAppointments = (int)barberCheckCmd.ExecuteScalar();

            // Check if the selected customer has an appointment on the chosen date
            SqlCommand customerCheckCmd = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE Customer = @Customer AND Date = @Date", cn);
            customerCheckCmd.Parameters.AddWithValue("@Customer", comboBox1.Text);
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
                cm = new SqlCommand("INSERT INTO Appointments(Customer, Barber, Haircut, Time, Price, Date) VALUES (@Customer, @Barber, @Haircut, @Time, @Price, @Date)", cn);
                cm.Parameters.AddWithValue("@Customer", comboBox1.Text);
                cm.Parameters.AddWithValue("@Barber", comboBox2.Text);
                cm.Parameters.AddWithValue("@Haircut", comboBox3.Text);
                cm.Parameters.AddWithValue("@Time", comboBox5.Text);
                cm.Parameters.AddWithValue("@Price", comboBox4.Text);
                cm.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cm.ExecuteNonQuery();
                MessageBox.Show("Record has been added successfully");
                this.appointmentsTableAdapter.Fill(this.groupWst14DataSet6.Appointments);
            }



            cn.Close();

            comboBox1.Focus();
        }

       /* private void DeleteQuery(int id)
        {
            // Locate the row in the dataset and remove it
            DataRow rowToDelete = groupWst14DataSet6.Appointments.Rows.Find(id);
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
       */
        private void button3_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM Appointments WHERE ID = @ID", cn);
                cm.Parameters.AddWithValue("@ID", id);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted successfully");
                this.appointmentsTableAdapter.Fill(this.groupWst14DataSet6.Appointments);
                cn.Close();

                // Clear the form fields
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }

        }

        private void ClearFormFields()
        {
            id = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO Payment3 (AppointmentID,HaircutName,Price,AmountTendered,Change,Total) VALUES (@AppointmentID, @HaircutName, @Price, @AmountTendered, @Change, @Total)", cn);
            cm.Parameters.AddWithValue("@AppointmentID", IDButton.Text);
            cm.Parameters.AddWithValue("@HaircutName", HaircutButton.Text);
            cm.Parameters.AddWithValue("@Price", PriceButton.Text);
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

        private void button6_Click(object sender, EventArgs e)
        {
            // Variables to store parsed values
            decimal price;
            decimal amountTendered;

            // Check if Price and AmountTendered are valid numeric values
            if (decimal.TryParse(PriceButton.Text, out price) && decimal.TryParse(textBox4.Text, out amountTendered))
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
            string receiptNumber = "Receipt #: " + random.Next(100, 1000).ToString();

            string appointmentID = "Appointment ID: " + IDButton.Text;
            string haircutName = "Haircut Name : " + HaircutButton.Text;
            string barberName = "Barber Name : " + BarberButton.Text;
            string amountTendered = "Amount Tendered: R" + textBox4.Text;
            string price = "Price: R" + PriceButton.Text;

            // Calculate VAT (15% of the price)
            decimal vat = decimal.Parse(PriceButton.Text) * 0.15M;
            string vatAmount = "VAT (15%): R" + vat.ToString("0.00");

            string change = "Change: R" + textBox3.Text;

            // Calculate the total including VAT
           // decimal totalAmount = decimal.Parse(PriceButton.Text) + vat;
            string total = "Total (incl. VAT): R" + PriceButton.Text;

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
            e.Graphics.DrawString(appointmentID, font, brush, rect, format);
            rect.Y += 30;
            e.Graphics.DrawString(haircutName, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(barberName, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(amountTendered, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(price, font, brush, rect, format);
            rect.Y += 20;
            e.Graphics.DrawString(vatAmount, font, brush, rect, format);
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


        private void button5_Click(object sender, EventArgs e)
        {
            GenerateReceipt();
        }
        int id = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            // Convert the string representation of the date to a DateTime object
            string dateString = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime dateValue;

            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            {
                dateTimePicker1.Value = dateValue;
            }
            else
            {
                // Handle the case where the conversion fails
                MessageBox.Show("Error converting date.");
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Assuming that the columns are in the following order: ID, Haircut, Price
                IDButton.Text = row.Cells[0].Value.ToString();   // Column at index 0
                BarberButton.Text = row.Cells[2].Value.ToString();
                HaircutButton.Text = row.Cells[3].Value.ToString(); // Column at index 1
                PriceButton.Text = row.Cells[5].Value.ToString();// Column at index 2
                textBox2.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IDButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void HaircutButton_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
