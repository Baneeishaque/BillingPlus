namespace BillPlus
{
    partial class FrmSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_view = new System.Windows.Forms.CheckBox();
            this.btn_mass_sms = new System.Windows.Forms.Button();
            this.txtMassMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcustomerid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btniew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbvIEWcUSTOMER = new System.Windows.Forms.ComboBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.radioButton_mal = new System.Windows.Forms.RadioButton();
            this.radioButton_eng = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_center_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sms = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmsg_insdividual = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.errorProvider_sms = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_sms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.checkBox_view);
            this.groupBox3.Controls.Add(this.btn_mass_sms);
            this.groupBox3.Controls.Add(this.txtMassMsg);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(707, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(618, 214);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Mass Messege";
            // 
            // checkBox_view
            // 
            this.checkBox_view.AutoSize = true;
            this.checkBox_view.Location = new System.Drawing.Point(424, 82);
            this.checkBox_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_view.Name = "checkBox_view";
            this.checkBox_view.Size = new System.Drawing.Size(50, 20);
            this.checkBox_view.TabIndex = 727;
            this.checkBox_view.Text = "View";
            this.checkBox_view.UseVisualStyleBackColor = true;
            this.checkBox_view.CheckedChanged += new System.EventHandler(this.checkBox_view_CheckedChanged);
            // 
            // btn_mass_sms
            // 
            this.btn_mass_sms.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mass_sms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mass_sms.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mass_sms.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_mass_sms.Image = ((System.Drawing.Image)(resources.GetObject("btn_mass_sms.Image")));
            this.btn_mass_sms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mass_sms.Location = new System.Drawing.Point(479, 41);
            this.btn_mass_sms.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mass_sms.Name = "btn_mass_sms";
            this.btn_mass_sms.Size = new System.Drawing.Size(119, 101);
            this.btn_mass_sms.TabIndex = 5;
            this.btn_mass_sms.Text = "Send SMS to all Customers";
            this.btn_mass_sms.UseVisualStyleBackColor = true;
            this.btn_mass_sms.Click += new System.EventHandler(this.btn_mass_sms_Click);
            // 
            // txtMassMsg
            // 
            this.txtMassMsg.BackColor = System.Drawing.Color.White;
            this.txtMassMsg.ForeColor = System.Drawing.Color.Black;
            this.txtMassMsg.Location = new System.Drawing.Point(44, 22);
            this.txtMassMsg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMassMsg.Multiline = true;
            this.txtMassMsg.Name = "txtMassMsg";
            this.txtMassMsg.Size = new System.Drawing.Size(368, 157);
            this.txtMassMsg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "Mssg";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcustomerid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvCustomers);
            this.groupBox2.Location = new System.Drawing.Point(14, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1311, 316);
            this.groupBox2.TabIndex = 128;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // cmbcustomerid
            // 
            this.cmbcustomerid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcustomerid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcustomerid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustomerid.FormattingEnabled = true;
            this.cmbcustomerid.Location = new System.Drawing.Point(380, 116);
            this.cmbcustomerid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcustomerid.Name = "cmbcustomerid";
            this.cmbcustomerid.Size = new System.Drawing.Size(262, 26);
            this.cmbcustomerid.TabIndex = 732;
            this.cmbcustomerid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(309, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 733;
            this.label7.Text = "Customer ID";
            this.label7.Visible = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 22);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.Size = new System.Drawing.Size(1297, 283);
            this.dgvCustomers.TabIndex = 127;
            this.dgvCustomers.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "username";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "contactno";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mobile No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btniew);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbvIEWcUSTOMER);
            this.groupBox1.Controls.Add(this.lbl_count);
            this.groupBox1.Controls.Add(this.radioButton_mal);
            this.groupBox1.Controls.Add(this.radioButton_eng);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_center_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_sms);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmsg_insdividual);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_uname);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(687, 214);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Individual SMS ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btniew
            // 
            this.btniew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btniew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btniew.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniew.ForeColor = System.Drawing.Color.Black;
            this.btniew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniew.Location = new System.Drawing.Point(596, 15);
            this.btniew.Margin = new System.Windows.Forms.Padding(2);
            this.btniew.Name = "btniew";
            this.btniew.Size = new System.Drawing.Size(73, 36);
            this.btniew.TabIndex = 731;
            this.btniew.Text = "View";
            this.btniew.UseVisualStyleBackColor = true;
            this.btniew.Visible = false;
            this.btniew.Click += new System.EventHandler(this.btniew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(263, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 730;
            this.label6.Text = "Name";
            this.label6.Visible = false;
            // 
            // cmbvIEWcUSTOMER
            // 
            this.cmbvIEWcUSTOMER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbvIEWcUSTOMER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbvIEWcUSTOMER.FormattingEnabled = true;
            this.cmbvIEWcUSTOMER.Location = new System.Drawing.Point(302, 22);
            this.cmbvIEWcUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.cmbvIEWcUSTOMER.Name = "cmbvIEWcUSTOMER";
            this.cmbvIEWcUSTOMER.Size = new System.Drawing.Size(290, 24);
            this.cmbvIEWcUSTOMER.TabIndex = 729;
            this.cmbvIEWcUSTOMER.Visible = false;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_count.Location = new System.Drawing.Point(344, 151);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(36, 16);
            this.lbl_count.TabIndex = 126;
            this.lbl_count.Text = "Count";
            // 
            // radioButton_mal
            // 
            this.radioButton_mal.AutoSize = true;
            this.radioButton_mal.Location = new System.Drawing.Point(347, 174);
            this.radioButton_mal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_mal.Name = "radioButton_mal";
            this.radioButton_mal.Size = new System.Drawing.Size(42, 20);
            this.radioButton_mal.TabIndex = 125;
            this.radioButton_mal.TabStop = true;
            this.radioButton_mal.Text = "Mal";
            this.radioButton_mal.UseVisualStyleBackColor = true;
            this.radioButton_mal.Visible = false;
            // 
            // radioButton_eng
            // 
            this.radioButton_eng.AutoSize = true;
            this.radioButton_eng.Location = new System.Drawing.Point(347, 153);
            this.radioButton_eng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_eng.Name = "radioButton_eng";
            this.radioButton_eng.Size = new System.Drawing.Size(44, 20);
            this.radioButton_eng.TabIndex = 124;
            this.radioButton_eng.TabStop = true;
            this.radioButton_eng.Text = "Eng";
            this.radioButton_eng.UseVisualStyleBackColor = true;
            this.radioButton_eng.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(139, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 122;
            this.label5.Text = "SenderID";
            this.label5.Visible = false;
            // 
            // txt_center_id
            // 
            this.txt_center_id.BackColor = System.Drawing.Color.White;
            this.txt_center_id.ForeColor = System.Drawing.Color.Black;
            this.txt_center_id.Location = new System.Drawing.Point(203, 76);
            this.txt_center_id.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_center_id.Multiline = true;
            this.txt_center_id.Name = "txt_center_id";
            this.txt_center_id.ReadOnly = true;
            this.txt_center_id.Size = new System.Drawing.Size(24, 41);
            this.txt_center_id.TabIndex = 2;
            this.txt_center_id.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(506, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "      Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sms
            // 
            this.btn_sms.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sms.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sms.ForeColor = System.Drawing.Color.Black;
            this.btn_sms.Image = ((System.Drawing.Image)(resources.GetObject("btn_sms.Image")));
            this.btn_sms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sms.Location = new System.Drawing.Point(395, 153);
            this.btn_sms.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sms.Name = "btn_sms";
            this.btn_sms.Size = new System.Drawing.Size(107, 38);
            this.btn_sms.TabIndex = 5;
            this.btn_sms.Text = "Send SMS";
            this.btn_sms.UseVisualStyleBackColor = true;
            this.btn_sms.Click += new System.EventHandler(this.btn_sms_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(11, 44);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 16);
            this.label32.TabIndex = 115;
            this.label32.Text = "Passwrd";
            this.label32.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Uname";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 117;
            this.label1.Text = "     To\r\nNumbers";
            // 
            // txtmsg_insdividual
            // 
            this.txtmsg_insdividual.BackColor = System.Drawing.Color.White;
            this.txtmsg_insdividual.ForeColor = System.Drawing.Color.Black;
            this.txtmsg_insdividual.Location = new System.Drawing.Point(347, 15);
            this.txtmsg_insdividual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtmsg_insdividual.Multiline = true;
            this.txtmsg_insdividual.Name = "txtmsg_insdividual";
            this.txtmsg_insdividual.Size = new System.Drawing.Size(322, 131);
            this.txtmsg_insdividual.TabIndex = 4;
            this.txtmsg_insdividual.TextChanged += new System.EventHandler(this.txtmsg_insdividual_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(66, 18);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(237, 180);
            this.txt_phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(309, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 120;
            this.label2.Text = "Mssg";
            // 
            // txt_uname
            // 
            this.txt_uname.BackColor = System.Drawing.Color.White;
            this.txt_uname.ForeColor = System.Drawing.Color.Black;
            this.txt_uname.Location = new System.Drawing.Point(66, 32);
            this.txt_uname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_uname.Multiline = true;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.ReadOnly = true;
            this.txt_uname.Size = new System.Drawing.Size(146, 41);
            this.txt_uname.TabIndex = 0;
            this.txt_uname.Visible = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(66, 76);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.ReadOnly = true;
            this.txt_pass.Size = new System.Drawing.Size(131, 41);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Visible = false;
            // 
            // errorProvider_sms
            // 
            this.errorProvider_sms.ContainerControl = this;
            // 
            // FrmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS";
            this.Load += new System.EventHandler(this.FrmSMS_Load);
            this.Enter += new System.EventHandler(this.FrmSMS_Enter);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_sms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_view;
        private System.Windows.Forms.Button btn_mass_sms;
        private System.Windows.Forms.TextBox txtMassMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btniew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbvIEWcUSTOMER;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.RadioButton radioButton_mal;
        private System.Windows.Forms.RadioButton radioButton_eng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_center_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sms;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmsg_insdividual;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ErrorProvider errorProvider_sms;
        private System.Windows.Forms.ComboBox cmbcustomerid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}