
namespace Appointment_System
{
    partial class HaircutPrices
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.haircutIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircutNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircutPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst14DataSet = new Appointment_System.GroupWst14DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHaircut = new System.Windows.Forms.DataGridView();
            this.haircutIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircutNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haircutPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.haircutDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.haircutTableAdapter = new Appointment_System.GroupWst14DataSetTableAdapters.HaircutTableAdapter();
            this.barberTable1TableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.BarberTable1TableAdapter();
            this.haircutTableAdapter1 = new Appointment_System.GroupWst14DataSetTableAdapters.HaircutTableAdapter();
            this.tableAdapterManager = new Appointment_System.GroupWst14DataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haircutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaircut)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haircutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 702);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.haircutIDDataGridViewTextBoxColumn1,
            this.haircutNameDataGridViewTextBoxColumn1,
            this.haircutPriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.haircutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(303, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 544);
            this.dataGridView1.TabIndex = 6;
            // 
            // haircutIDDataGridViewTextBoxColumn1
            // 
            this.haircutIDDataGridViewTextBoxColumn1.DataPropertyName = "Haircut_ID";
            this.haircutIDDataGridViewTextBoxColumn1.HeaderText = "Haircut_ID";
            this.haircutIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.haircutIDDataGridViewTextBoxColumn1.Name = "haircutIDDataGridViewTextBoxColumn1";
            this.haircutIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.haircutIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // haircutNameDataGridViewTextBoxColumn1
            // 
            this.haircutNameDataGridViewTextBoxColumn1.DataPropertyName = "Haircut_Name";
            this.haircutNameDataGridViewTextBoxColumn1.HeaderText = "Haircut_Name";
            this.haircutNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.haircutNameDataGridViewTextBoxColumn1.Name = "haircutNameDataGridViewTextBoxColumn1";
            this.haircutNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // haircutPriceDataGridViewTextBoxColumn1
            // 
            this.haircutPriceDataGridViewTextBoxColumn1.DataPropertyName = "Haircut_Price";
            this.haircutPriceDataGridViewTextBoxColumn1.HeaderText = "Haircut_Price";
            this.haircutPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.haircutPriceDataGridViewTextBoxColumn1.Name = "haircutPriceDataGridViewTextBoxColumn1";
            this.haircutPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // haircutBindingSource
            // 
            this.haircutBindingSource.DataMember = "Haircut";
            this.haircutBindingSource.DataSource = this.groupWst14DataSet;
            // 
            // groupWst14DataSet
            // 
            this.groupWst14DataSet.DataSetName = "GroupWst14DataSet";
            this.groupWst14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(298, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ADD HAIRCUT:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage2.Controls.Add(this.dgvHaircut);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHaircut
            // 
            this.dgvHaircut.AutoGenerateColumns = false;
            this.dgvHaircut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaircut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.haircutIDDataGridViewTextBoxColumn,
            this.haircutNameDataGridViewTextBoxColumn,
            this.haircutPriceDataGridViewTextBoxColumn});
            this.dgvHaircut.DataSource = this.haircutBindingSource;
            this.dgvHaircut.Location = new System.Drawing.Point(61, 136);
            this.dgvHaircut.Name = "dgvHaircut";
            this.dgvHaircut.RowHeadersWidth = 51;
            this.dgvHaircut.RowTemplate.Height = 24;
            this.dgvHaircut.Size = new System.Drawing.Size(689, 483);
            this.dgvHaircut.TabIndex = 2;
            // 
            // haircutIDDataGridViewTextBoxColumn
            // 
            this.haircutIDDataGridViewTextBoxColumn.DataPropertyName = "Haircut_ID";
            this.haircutIDDataGridViewTextBoxColumn.HeaderText = "Haircut_ID";
            this.haircutIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haircutIDDataGridViewTextBoxColumn.Name = "haircutIDDataGridViewTextBoxColumn";
            this.haircutIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.haircutIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // haircutNameDataGridViewTextBoxColumn
            // 
            this.haircutNameDataGridViewTextBoxColumn.DataPropertyName = "Haircut_Name";
            this.haircutNameDataGridViewTextBoxColumn.HeaderText = "Haircut_Name";
            this.haircutNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haircutNameDataGridViewTextBoxColumn.Name = "haircutNameDataGridViewTextBoxColumn";
            this.haircutNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // haircutPriceDataGridViewTextBoxColumn
            // 
            this.haircutPriceDataGridViewTextBoxColumn.DataPropertyName = "Haircut_Price";
            this.haircutPriceDataGridViewTextBoxColumn.HeaderText = "Haircut_Price";
            this.haircutPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haircutPriceDataGridViewTextBoxColumn.Name = "haircutPriceDataGridViewTextBoxColumn";
            this.haircutPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Haircut Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Appointment_System.Properties.Resources.photo_1634480256802_7cb50e5a196a;
            this.tabPage3.Controls.Add(this.haircutDataGridView);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1061, 673);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update and Delete ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // haircutDataGridView
            // 
            this.haircutDataGridView.AutoGenerateColumns = false;
            this.haircutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haircutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.haircutDataGridView.DataSource = this.haircutBindingSource;
            this.haircutDataGridView.Location = new System.Drawing.Point(318, 56);
            this.haircutDataGridView.Name = "haircutDataGridView";
            this.haircutDataGridView.RowHeadersWidth = 51;
            this.haircutDataGridView.RowTemplate.Height = 24;
            this.haircutDataGridView.Size = new System.Drawing.Size(521, 399);
            this.haircutDataGridView.TabIndex = 6;
            this.haircutDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.haircutDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Haircut_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Haircut_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Haircut_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Haircut_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Haircut_Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Haircut_Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(191, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(30, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(30, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 22);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(30, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // haircutTableAdapter
            // 
            this.haircutTableAdapter.ClearBeforeFill = true;
            // 
            // barberTable1TableAdapter1
            // 
            this.barberTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // haircutTableAdapter1
            // 
            this.haircutTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment1TableAdapter = null;
            this.tableAdapterManager.Appointment2TableAdapter = null;
            this.tableAdapterManager.Appointment3TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarberTable1TableAdapter = this.barberTable1TableAdapter1;
            this.tableAdapterManager.BarberTableTableAdapter = null;
            this.tableAdapterManager.Customer1TableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployeeTypeTableAdapter = null;
            this.tableAdapterManager.HaircutTableAdapter = this.haircutTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Timeslot1TableAdapter = null;
            this.tableAdapterManager.TimeslotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Appointment_System.GroupWst14DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // HaircutPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 702);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HaircutPrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaircutPrices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HaircutPrices_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haircutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst14DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaircut)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haircutDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHaircut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private GroupWst14DataSet groupWst14DataSet;
        private System.Windows.Forms.BindingSource haircutBindingSource;
        private GroupWst14DataSetTableAdapters.HaircutTableAdapter haircutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private GroupWst14DataSetTableAdapters.BarberTable1TableAdapter barberTable1TableAdapter1;
        private GroupWst14DataSetTableAdapters.HaircutTableAdapter haircutTableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView haircutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupWst14DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn haircutPriceDataGridViewTextBoxColumn1;
    }
}