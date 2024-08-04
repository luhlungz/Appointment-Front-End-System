
namespace Appointment_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.BLDate = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeslot1TableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.Timeslot1TableAdapter();
            this.groupWst14DataSet1 = new Appointment_System.GroupWst14DataSet();
            this.employeeTableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.EmployeeTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BLDate
            // 
            this.BLDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BLDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BLDate.BackgroundImage")));
            this.BLDate.Location = new System.Drawing.Point(718, 12);
            this.BLDate.Name = "BLDate";
            this.BLDate.Size = new System.Drawing.Size(277, 56);
            this.BLDate.TabIndex = 0;
            this.BLDate.Text = "Date/Time";
            this.BLDate.UseVisualStyleBackColor = false;
            this.BLDate.Click += new System.EventHandler(this.BLDate_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.X.BackgroundImage = global::Appointment_System.Properties.Resources.WhatsApp_Image_2023_06_01_at_23_46_27;
            this.X.Location = new System.Drawing.Point(1408, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(111, 46);
            this.X.TabIndex = 1;
            this.X.Text = "Exit";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(47, 530);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 77);
            this.button7.TabIndex = 5;
            this.button7.Text = "Manage Employee";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(47, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 74);
            this.button5.TabIndex = 1;
            this.button5.Text = "Haircut\\Prices";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(47, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Barber";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(47, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Appointment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(47, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(1408, 764);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 46);
            this.button6.TabIndex = 7;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BackgroundImage = global::Appointment_System.Properties.Resources.istockphoto_1209208663_612x612;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(37, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 762);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(47, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BackgroundImage = global::Appointment_System.Properties.Resources.istockphoto_1209208663_612x612;
            this.panel3.Location = new System.Drawing.Point(423, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 566);
            this.panel3.TabIndex = 9;
            // 
            // timeslot1TableAdapter1
            // 
            this.timeslot1TableAdapter1.ClearBeforeFill = true;
            // 
            // groupWst14DataSet1
            // 
            this.groupWst14DataSet1.DataSetName = "GroupWst14DataSet";
            this.groupWst14DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Appointment_System.Properties.Resources.scissors_combs_copy_space;
            this.ClientSize = new System.Drawing.Size(1549, 832);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BLDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.X);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(897, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BLDate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private GroupWst14DataSetTableAdapters.Timeslot1TableAdapter timeslot1TableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GroupWst14DataSet groupWst14DataSet1;
        private GroupWst14DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}