
namespace Appointment_System
{
    partial class Barber
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barberSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barberPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barberTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst14DataSet = new Appointment_System.GroupWst14DataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.MaskedTextBox();
            this.barberTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barberTableTableAdapter = new Appointment_System.GroupWst14DataSetTableAdapters.BarberTableTableAdapter();
            this.barberTableTableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.BarberTableTableAdapter();
            this.appointment1TableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.Appointment1TableAdapter();
            this.tableAdapterManager = new Appointment_System.GroupWst14DataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barberTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 691);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(284, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "ADD BARBER";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(272, 280);
            this.textBox4.Mask = "0000000000";
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox4_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(269, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(501, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(504, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(931, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barberIDDataGridViewTextBoxColumn,
            this.barberNameDataGridViewTextBoxColumn,
            this.barberSurnameDataGridViewTextBoxColumn,
            this.barberPhoneNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barberTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 281);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barberIDDataGridViewTextBoxColumn
            // 
            this.barberIDDataGridViewTextBoxColumn.DataPropertyName = "Barber_ID";
            this.barberIDDataGridViewTextBoxColumn.HeaderText = "Barber_ID";
            this.barberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barberIDDataGridViewTextBoxColumn.Name = "barberIDDataGridViewTextBoxColumn";
            this.barberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.barberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // barberNameDataGridViewTextBoxColumn
            // 
            this.barberNameDataGridViewTextBoxColumn.DataPropertyName = "Barber_Name";
            this.barberNameDataGridViewTextBoxColumn.HeaderText = "Barber_Name";
            this.barberNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barberNameDataGridViewTextBoxColumn.Name = "barberNameDataGridViewTextBoxColumn";
            this.barberNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // barberSurnameDataGridViewTextBoxColumn
            // 
            this.barberSurnameDataGridViewTextBoxColumn.DataPropertyName = "Barber_Surname";
            this.barberSurnameDataGridViewTextBoxColumn.HeaderText = "Barber_Surname";
            this.barberSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barberSurnameDataGridViewTextBoxColumn.Name = "barberSurnameDataGridViewTextBoxColumn";
            this.barberSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // barberPhoneNoDataGridViewTextBoxColumn
            // 
            this.barberPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Barber_Phone_No";
            this.barberPhoneNoDataGridViewTextBoxColumn.HeaderText = "Barber_Phone_No";
            this.barberPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barberPhoneNoDataGridViewTextBoxColumn.Name = "barberPhoneNoDataGridViewTextBoxColumn";
            this.barberPhoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // barberTableBindingSource
            // 
            this.barberTableBindingSource.DataMember = "BarberTable";
            this.barberTableBindingSource.DataSource = this.groupWst14DataSet;
            // 
            // groupWst14DataSet
            // 
            this.groupWst14DataSet.DataSetName = "GroupWst14DataSet";
            this.groupWst14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barber Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.barberTableDataGridView);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(931, 662);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update and Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(14, 303);
            this.textBox5.Mask = "0000000000";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 22);
            this.textBox5.TabIndex = 9;
            // 
            // barberTableDataGridView
            // 
            this.barberTableDataGridView.AutoGenerateColumns = false;
            this.barberTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barberTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.barberTableDataGridView.DataSource = this.barberTableBindingSource;
            this.barberTableDataGridView.Location = new System.Drawing.Point(253, 52);
            this.barberTableDataGridView.Name = "barberTableDataGridView";
            this.barberTableDataGridView.RowHeadersWidth = 51;
            this.barberTableDataGridView.RowTemplate.Height = 24;
            this.barberTableDataGridView.Size = new System.Drawing.Size(639, 363);
            this.barberTableDataGridView.TabIndex = 8;
            this.barberTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barberTableDataGridView_CellContentClick);
            this.barberTableDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.barberTableDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barber_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barber_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Barber_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Barber_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Barber_Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Barber_Surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Barber_Phone_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Barber_Phone_No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 107);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(14, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 22);
            this.textBox6.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // barberTableTableAdapter
            // 
            this.barberTableTableAdapter.ClearBeforeFill = true;
            // 
            // barberTableTableAdapter1
            // 
            this.barberTableTableAdapter1.ClearBeforeFill = true;
            // 
            // appointment1TableAdapter1
            // 
            this.appointment1TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment1TableAdapter = this.appointment1TableAdapter1;
            this.tableAdapterManager.Appointment2TableAdapter = null;
            this.tableAdapterManager.Appointment3TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarberTable1TableAdapter = null;
            this.tableAdapterManager.BarberTableTableAdapter = this.barberTableTableAdapter;
            this.tableAdapterManager.Customer1TableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployeeTypeTableAdapter = null;
            this.tableAdapterManager.HaircutTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Timeslot1TableAdapter = null;
            this.tableAdapterManager.TimeslotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Appointment_System.GroupWst14DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Barber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Barber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barber";
            this.Load += new System.EventHandler(this.Barber_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barberTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private GroupWst14DataSet groupWst14DataSet;
        private System.Windows.Forms.BindingSource barberTableBindingSource;
        private GroupWst14DataSetTableAdapters.BarberTableTableAdapter barberTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barberSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barberPhoneNoDataGridViewTextBoxColumn;
        private GroupWst14DataSetTableAdapters.BarberTableTableAdapter barberTableTableAdapter1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textBox4;
        private GroupWst14DataSetTableAdapters.Appointment1TableAdapter appointment1TableAdapter1;
        private System.Windows.Forms.DataGridView barberTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private GroupWst14DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox textBox5;
        private System.Windows.Forms.Label label8;
    }
}