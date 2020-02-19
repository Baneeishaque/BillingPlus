namespace BillPlus
{
    partial class FrmPurchaseUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseUpdate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvsales = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewImageColumn();
            this.paidtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nettotal = new System.Windows.Forms.TextBox();
            this.grandtotal = new System.Windows.Forms.TextBox();
            this.dicounttxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.narrrations = new System.Windows.Forms.RichTextBox();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.prize = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.txtpaymentmode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnaddproducttogrid = new System.Windows.Forms.Button();
            this.productname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productcode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SalesDate = new System.Windows.Forms.DateTimePicker();
            this.btnrefreshdata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(249, 20);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 32);
            this.btnupdate.TabIndex = 777;
            this.btnupdate.TabStop = false;
            this.btnupdate.Text = "    Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(142, 20);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 32);
            this.btn_delete.TabIndex = 776;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "    Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(415, 442);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(568, 56);
            this.groupBox4.TabIndex = 278;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(356, 19);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 33);
            this.btnClose.TabIndex = 778;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "      Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvsales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvsales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column18,
            this.Column19,
            this.Column1,
            this.Column23});
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle68.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle68;
            this.dgvsales.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvsales.Location = new System.Drawing.Point(1, 92);
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.ReadOnly = true;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.RowHeadersDefaultCellStyle = dataGridViewCellStyle69;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvsales.RowsDefaultCellStyle = dataGridViewCellStyle70;
            this.dgvsales.RowTemplate.Height = 40;
            this.dgvsales.Size = new System.Drawing.Size(1300, 238);
            this.dgvsales.TabIndex = 314;
            this.dgvsales.TabStop = false;
            this.dgvsales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsales_CellClick);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "productcode";
            this.Column10.HeaderText = "Product Code";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "productname";
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column11.DefaultCellStyle = dataGridViewCellStyle66;
            this.Column11.HeaderText = "Product Name";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "quantity";
            this.Column13.HeaderText = "Qnty";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "unit";
            this.Column14.HeaderText = "Unit";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "price";
            this.Column15.HeaderText = "Price";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "discount";
            this.Column18.HeaderText = "Disc%";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column19.DataPropertyName = "total";
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column19.DefaultCellStyle = dataGridViewCellStyle67;
            this.Column19.HeaderText = "Total";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "rowid";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Delete";
            this.Column23.Image = ((System.Drawing.Image)(resources.GetObject("Column23.Image")));
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column23.ToolTipText = "Delete";
            this.Column23.Width = 50;
            // 
            // paidtext
            // 
            this.paidtext.ForeColor = System.Drawing.Color.Red;
            this.paidtext.Location = new System.Drawing.Point(1135, 423);
            this.paidtext.Margin = new System.Windows.Forms.Padding(2);
            this.paidtext.Multiline = true;
            this.paidtext.Name = "paidtext";
            this.paidtext.Size = new System.Drawing.Size(160, 27);
            this.paidtext.TabIndex = 312;
            this.paidtext.TabStop = false;
            this.paidtext.TextChanged += new System.EventHandler(this.paidtext_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1093, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 311;
            this.label5.Text = "Paid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1069, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 310;
            this.label1.Text = "Net Total";
            // 
            // nettotal
            // 
            this.nettotal.ForeColor = System.Drawing.Color.Red;
            this.nettotal.Location = new System.Drawing.Point(1135, 392);
            this.nettotal.Margin = new System.Windows.Forms.Padding(2);
            this.nettotal.Multiline = true;
            this.nettotal.Name = "nettotal";
            this.nettotal.Size = new System.Drawing.Size(160, 27);
            this.nettotal.TabIndex = 308;
            this.nettotal.TabStop = false;
            this.nettotal.Text = "00.00";
            this.nettotal.TextChanged += new System.EventHandler(this.nettotal_TextChanged);
            // 
            // grandtotal
            // 
            this.grandtotal.Location = new System.Drawing.Point(1135, 331);
            this.grandtotal.Margin = new System.Windows.Forms.Padding(2);
            this.grandtotal.Multiline = true;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(160, 27);
            this.grandtotal.TabIndex = 306;
            this.grandtotal.TabStop = false;
            this.grandtotal.Text = "00.00";
            // 
            // dicounttxt
            // 
            this.dicounttxt.Location = new System.Drawing.Point(1135, 362);
            this.dicounttxt.Margin = new System.Windows.Forms.Padding(2);
            this.dicounttxt.Multiline = true;
            this.dicounttxt.Name = "dicounttxt";
            this.dicounttxt.Size = new System.Drawing.Size(160, 27);
            this.dicounttxt.TabIndex = 307;
            this.dicounttxt.TabStop = false;
            this.dicounttxt.Text = "0";
            this.dicounttxt.TextChanged += new System.EventHandler(this.dicounttxt_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(1054, 367);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 16);
            this.label20.TabIndex = 309;
            this.label20.Text = "Discount(%)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(1054, 337);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 16);
            this.label21.TabIndex = 305;
            this.label21.Text = "Grand Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(1045, 60);
            this.txtdiscount.Multiline = true;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(47, 26);
            this.txtdiscount.TabIndex = 288;
            this.txtdiscount.TabStop = false;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            // 
            // narrrations
            // 
            this.narrrations.Location = new System.Drawing.Point(116, 366);
            this.narrrations.Margin = new System.Windows.Forms.Padding(2);
            this.narrrations.Name = "narrrations";
            this.narrrations.Size = new System.Drawing.Size(317, 60);
            this.narrrations.TabIndex = 291;
            this.narrrations.TabStop = false;
            this.narrrations.Text = "";
            // 
            // totalamount
            // 
            this.totalamount.BackColor = System.Drawing.Color.White;
            this.totalamount.ForeColor = System.Drawing.Color.Red;
            this.totalamount.Location = new System.Drawing.Point(1135, 60);
            this.totalamount.Multiline = true;
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(107, 26);
            this.totalamount.TabIndex = 289;
            this.totalamount.TabStop = false;
            this.totalamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalamount_KeyPress);
            // 
            // prize
            // 
            this.prize.ForeColor = System.Drawing.Color.Red;
            this.prize.Location = new System.Drawing.Point(866, 60);
            this.prize.Multiline = true;
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(123, 26);
            this.prize.TabIndex = 287;
            this.prize.TabStop = false;
            this.prize.TextChanged += new System.EventHandler(this.prize_TextChanged);
            this.prize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prize_KeyPress);
            this.prize.Leave += new System.EventHandler(this.prize_Leave);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(716, 60);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(59, 26);
            this.quantity.TabIndex = 283;
            this.quantity.Text = "1";
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            this.quantity.Leave += new System.EventHandler(this.quantity_Leave);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(995, 66);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 16);
            this.label39.TabIndex = 304;
            this.label39.Text = "Disc%";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(450, 342);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 16);
            this.label32.TabIndex = 303;
            this.label32.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.Red;
            this.balance.Location = new System.Drawing.Point(452, 362);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(199, 73);
            this.balance.TabIndex = 300;
            this.balance.Text = "00.00";
            // 
            // txtpaymentmode
            // 
            this.txtpaymentmode.FormattingEnabled = true;
            this.txtpaymentmode.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.txtpaymentmode.Location = new System.Drawing.Point(117, 339);
            this.txtpaymentmode.Margin = new System.Windows.Forms.Padding(2);
            this.txtpaymentmode.Name = "txtpaymentmode";
            this.txtpaymentmode.Size = new System.Drawing.Size(316, 24);
            this.txtpaymentmode.TabIndex = 290;
            this.txtpaymentmode.TabStop = false;
            this.txtpaymentmode.Text = "Cash";
            this.txtpaymentmode.SelectedIndexChanged += new System.EventHandler(this.txtpaymentmode_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 302;
            this.label13.Text = "Payment Mode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 385);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 301;
            this.label14.Text = "Narration";
            // 
            // btnaddproducttogrid
            // 
            this.btnaddproducttogrid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproducttogrid.ForeColor = System.Drawing.Color.Black;
            this.btnaddproducttogrid.Location = new System.Drawing.Point(1248, 62);
            this.btnaddproducttogrid.Name = "btnaddproducttogrid";
            this.btnaddproducttogrid.Size = new System.Drawing.Size(20, 22);
            this.btnaddproducttogrid.TabIndex = 285;
            this.btnaddproducttogrid.Text = "+";
            this.btnaddproducttogrid.UseVisualStyleBackColor = true;
            this.btnaddproducttogrid.Click += new System.EventHandler(this.btnaddproducttogrid_Click);
            // 
            // productname
            // 
            this.productname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.FormattingEnabled = true;
            this.productname.Location = new System.Drawing.Point(54, 62);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(346, 24);
            this.productname.TabIndex = 280;
            this.productname.SelectedIndexChanged += new System.EventHandler(this.productname_SelectedIndexChanged);
            this.productname.SelectionChangeCommitted += new System.EventHandler(this.productname_SelectionChangeCommitted);
            this.productname.Leave += new System.EventHandler(this.productname_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 295;
            this.label8.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1096, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 16);
            this.label18.TabIndex = 299;
            this.label18.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(819, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 16);
            this.label17.TabIndex = 286;
            this.label17.Text = "Price";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.ForeColor = System.Drawing.Color.Red;
            this.lblunit.Location = new System.Drawing.Point(781, 66);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(33, 16);
            this.lblunit.TabIndex = 298;
            this.lblunit.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(677, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 297;
            this.label10.Text = "Qnty";
            // 
            // productcode
            // 
            this.productcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productcode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productcode.FormattingEnabled = true;
            this.productcode.Location = new System.Drawing.Point(478, 62);
            this.productcode.Name = "productcode";
            this.productcode.Size = new System.Drawing.Size(194, 24);
            this.productcode.TabIndex = 282;
            this.productcode.SelectedIndexChanged += new System.EventHandler(this.productcode_SelectedIndexChanged);
            this.productcode.SelectionChangeCommitted += new System.EventHandler(this.productcode_SelectionChangeCommitted);
            this.productcode.SelectedValueChanged += new System.EventHandler(this.productcode_SelectedValueChanged);
            this.productcode.Leave += new System.EventHandler(this.productcode_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(406, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 296;
            this.label9.Text = "Code";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.CustomerName.FormattingEnabled = true;
            this.CustomerName.Location = new System.Drawing.Point(478, 13);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(511, 28);
            this.CustomerName.TabIndex = 281;
            this.CustomerName.TabStop = false;
            this.CustomerName.Text = "Cash Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1030, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 293;
            this.label2.Text = "Purchase Date";
            // 
            // SalesNo
            // 
            this.SalesNo.DropDownHeight = 1;
            this.SalesNo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalesNo.ForeColor = System.Drawing.Color.Red;
            this.SalesNo.FormattingEnabled = true;
            this.SalesNo.IntegralHeight = false;
            this.SalesNo.Location = new System.Drawing.Point(54, 13);
            this.SalesNo.Name = "SalesNo";
            this.SalesNo.Size = new System.Drawing.Size(346, 28);
            this.SalesNo.TabIndex = 279;
            this.SalesNo.TabStop = false;
            this.SalesNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(404, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 294;
            this.label3.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 292;
            this.label6.Text = "P.ID";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refresh.Location = new System.Drawing.Point(998, 11);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(28, 32);
            this.refresh.TabIndex = 315;
            this.refresh.TabStop = false;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // SalesDate
            // 
            this.SalesDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDate.Location = new System.Drawing.Point(1135, 19);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(166, 22);
            this.SalesDate.TabIndex = 761;
            this.SalesDate.TabStop = false;
            // 
            // btnrefreshdata
            // 
            this.btnrefreshdata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrefreshdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefreshdata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnrefreshdata.ForeColor = System.Drawing.Color.Black;
            this.btnrefreshdata.Image = ((System.Drawing.Image)(resources.GetObject("btnrefreshdata.Image")));
            this.btnrefreshdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefreshdata.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnrefreshdata.Location = new System.Drawing.Point(1273, 61);
            this.btnrefreshdata.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefreshdata.Name = "btnrefreshdata";
            this.btnrefreshdata.Size = new System.Drawing.Size(26, 26);
            this.btnrefreshdata.TabIndex = 766;
            this.btnrefreshdata.TabStop = false;
            this.btnrefreshdata.UseVisualStyleBackColor = true;
            this.btnrefreshdata.Click += new System.EventHandler(this.btnrefreshdata_Click);
            // 
            // FrmPurchaseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 510);
            this.Controls.Add(this.btnrefreshdata);
            this.Controls.Add(this.SalesDate);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dgvsales);
            this.Controls.Add(this.paidtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nettotal);
            this.Controls.Add(this.grandtotal);
            this.Controls.Add(this.dicounttxt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.narrrations);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.txtpaymentmode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnaddproducttogrid);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchaseUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Purchase";
            this.Load += new System.EventHandler(this.FrmPurchaseUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvsales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column23;
        private System.Windows.Forms.TextBox paidtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nettotal;
        private System.Windows.Forms.TextBox grandtotal;
        private System.Windows.Forms.TextBox dicounttxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.RichTextBox narrrations;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.TextBox prize;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.ComboBox txtpaymentmode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnaddproducttogrid;
        private System.Windows.Forms.ComboBox productname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox productcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SalesNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker SalesDate;
        private System.Windows.Forms.Button btnrefreshdata;
    }
}