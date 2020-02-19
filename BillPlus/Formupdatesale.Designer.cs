namespace BillPlus
{
    partial class Formupdatesale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formupdatesale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.prize = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnaddproducttogrid = new System.Windows.Forms.Button();
            this.productname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productcode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paidtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nettotal = new System.Windows.Forms.TextBox();
            this.grandtotal = new System.Windows.Forms.TextBox();
            this.dicounttxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.narrrations = new System.Windows.Forms.RichTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtpaymentmode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.refresh = new System.Windows.Forms.Button();
            this.SalesDate = new System.Windows.Forms.DateTimePicker();
            this.btnrefreshdata = new System.Windows.Forms.Button();
            this.checkBoxWholeSale = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtdiscount.Location = new System.Drawing.Point(1010, 69);
            this.txtdiscount.Multiline = true;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(52, 26);
            this.txtdiscount.TabIndex = 225;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged_1);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress_1);
            // 
            // totalamount
            // 
            this.totalamount.BackColor = System.Drawing.Color.White;
            this.totalamount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.totalamount.ForeColor = System.Drawing.Color.Red;
            this.totalamount.Location = new System.Drawing.Point(1113, 69);
            this.totalamount.Multiline = true;
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(108, 26);
            this.totalamount.TabIndex = 226;
            this.totalamount.TextChanged += new System.EventHandler(this.totalamount_TextChanged_1);
            this.totalamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalamount_KeyPress_1);
            // 
            // prize
            // 
            this.prize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.prize.ForeColor = System.Drawing.Color.Red;
            this.prize.Location = new System.Drawing.Point(854, 69);
            this.prize.Multiline = true;
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(100, 26);
            this.prize.TabIndex = 224;
            this.prize.TextChanged += new System.EventHandler(this.prize_TextChanged_1);
            this.prize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prize_KeyPress_1);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.quantity.Location = new System.Drawing.Point(700, 69);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 26);
            this.quantity.TabIndex = 221;
            this.quantity.Text = "1";
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged_1);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress_1);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(960, 75);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 16);
            this.label39.TabIndex = 237;
            this.label39.Text = "Disc%";
            // 
            // btnaddproducttogrid
            // 
            this.btnaddproducttogrid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproducttogrid.ForeColor = System.Drawing.Color.Black;
            this.btnaddproducttogrid.Location = new System.Drawing.Point(1227, 72);
            this.btnaddproducttogrid.Name = "btnaddproducttogrid";
            this.btnaddproducttogrid.Size = new System.Drawing.Size(20, 22);
            this.btnaddproducttogrid.TabIndex = 227;
            this.btnaddproducttogrid.Text = "+";
            this.btnaddproducttogrid.UseVisualStyleBackColor = true;
            this.btnaddproducttogrid.Click += new System.EventHandler(this.btnaddproducttogrid_Click_1);
            // 
            // productname
            // 
            this.productname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.productname.FormattingEnabled = true;
            this.productname.Location = new System.Drawing.Point(297, 72);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(354, 24);
            this.productname.TabIndex = 220;
            this.productname.SelectedIndexChanged += new System.EventHandler(this.productname_SelectedIndexChanged_1);
            this.productname.Leave += new System.EventHandler(this.productname_Leave_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(209, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 231;
            this.label8.Text = "Prdct Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1068, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 16);
            this.label18.TabIndex = 235;
            this.label18.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(807, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 16);
            this.label17.TabIndex = 223;
            this.label17.Text = "Price";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblunit.ForeColor = System.Drawing.Color.Red;
            this.lblunit.Location = new System.Drawing.Point(769, 75);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(33, 16);
            this.lblunit.TabIndex = 234;
            this.lblunit.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(657, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 233;
            this.label10.Text = "Qnty";
            // 
            // productcode
            // 
            this.productcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.productcode.FormattingEnabled = true;
            this.productcode.Location = new System.Drawing.Point(61, 72);
            this.productcode.Name = "productcode";
            this.productcode.Size = new System.Drawing.Size(145, 24);
            this.productcode.TabIndex = 218;
            this.productcode.SelectedIndexChanged += new System.EventHandler(this.productcode_SelectedIndexChanged_1);
            this.productcode.Leave += new System.EventHandler(this.productcode_Leave_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 232;
            this.label9.Text = "Code";
            // 
            // CustomerNames
            // 
            this.CustomerNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerNames.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.CustomerNames.FormattingEnabled = true;
            this.CustomerNames.Location = new System.Drawing.Point(297, 20);
            this.CustomerNames.Name = "CustomerNames";
            this.CustomerNames.Size = new System.Drawing.Size(430, 28);
            this.CustomerNames.TabIndex = 219;
            this.CustomerNames.TabStop = false;
            this.CustomerNames.Text = "Cash Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(761, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 229;
            this.label2.Text = "Sales Date";
            // 
            // SalesNo
            // 
            this.SalesNo.DropDownHeight = 1;
            this.SalesNo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.SalesNo.ForeColor = System.Drawing.Color.Red;
            this.SalesNo.FormattingEnabled = true;
            this.SalesNo.IntegralHeight = false;
            this.SalesNo.Location = new System.Drawing.Point(61, 20);
            this.SalesNo.Name = "SalesNo";
            this.SalesNo.Size = new System.Drawing.Size(145, 28);
            this.SalesNo.TabIndex = 217;
            this.SalesNo.TabStop = false;
            this.SalesNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesNo_KeyPress_1);
            this.SalesNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SalesNo_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(212, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 230;
            this.label3.Text = "Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 228;
            this.label6.Text = "S.ID";
            // 
            // paidtext
            // 
            this.paidtext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.paidtext.ForeColor = System.Drawing.Color.Red;
            this.paidtext.Location = new System.Drawing.Point(1138, 425);
            this.paidtext.Margin = new System.Windows.Forms.Padding(2);
            this.paidtext.Multiline = true;
            this.paidtext.Name = "paidtext";
            this.paidtext.Size = new System.Drawing.Size(134, 21);
            this.paidtext.TabIndex = 252;
            this.paidtext.TextChanged += new System.EventHandler(this.paidtext_TextChanged_1);
            this.paidtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paidtext_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1094, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 251;
            this.label5.Text = "Paid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1067, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 250;
            this.label1.Text = "Net Total";
            // 
            // nettotal
            // 
            this.nettotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.nettotal.ForeColor = System.Drawing.Color.Red;
            this.nettotal.Location = new System.Drawing.Point(1138, 398);
            this.nettotal.Margin = new System.Windows.Forms.Padding(2);
            this.nettotal.Multiline = true;
            this.nettotal.Name = "nettotal";
            this.nettotal.Size = new System.Drawing.Size(134, 21);
            this.nettotal.TabIndex = 248;
            this.nettotal.Text = "00.00";
            this.nettotal.TextChanged += new System.EventHandler(this.nettotal_TextChanged_1);
            this.nettotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nettotal_KeyPress_1);
            // 
            // grandtotal
            // 
            this.grandtotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.grandtotal.Location = new System.Drawing.Point(1138, 348);
            this.grandtotal.Margin = new System.Windows.Forms.Padding(2);
            this.grandtotal.Multiline = true;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(134, 21);
            this.grandtotal.TabIndex = 246;
            this.grandtotal.TabStop = false;
            this.grandtotal.Text = "00.00";
            // 
            // dicounttxt
            // 
            this.dicounttxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.dicounttxt.Location = new System.Drawing.Point(1138, 373);
            this.dicounttxt.Margin = new System.Windows.Forms.Padding(2);
            this.dicounttxt.Multiline = true;
            this.dicounttxt.Name = "dicounttxt";
            this.dicounttxt.Size = new System.Drawing.Size(134, 21);
            this.dicounttxt.TabIndex = 247;
            this.dicounttxt.Text = "0";
            this.dicounttxt.TextChanged += new System.EventHandler(this.dicounttxt_TextChanged_1);
            this.dicounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dicounttxt_KeyPress_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(1051, 379);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 16);
            this.label20.TabIndex = 249;
            this.label20.Text = "Discount(%)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(1049, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 16);
            this.label21.TabIndex = 245;
            this.label21.Text = "Grand Total";
            // 
            // narrrations
            // 
            this.narrrations.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.narrrations.Location = new System.Drawing.Point(122, 384);
            this.narrrations.Margin = new System.Windows.Forms.Padding(2);
            this.narrrations.Name = "narrrations";
            this.narrrations.Size = new System.Drawing.Size(323, 60);
            this.narrrations.TabIndex = 239;
            this.narrrations.TabStop = false;
            this.narrrations.Text = "";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(493, 353);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 16);
            this.label32.TabIndex = 244;
            this.label32.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.Color.Red;
            this.balance.Location = new System.Drawing.Point(495, 373);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(199, 73);
            this.balance.TabIndex = 240;
            this.balance.Text = "00.00";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(416, 448);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(568, 56);
            this.groupBox4.TabIndex = 241;
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
            this.btnClose.Location = new System.Drawing.Point(332, 19);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 33);
            this.btnClose.TabIndex = 778;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "      Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(225, 20);
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
            this.btn_delete.Location = new System.Drawing.Point(118, 20);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 32);
            this.btn_delete.TabIndex = 776;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "    Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txtpaymentmode
            // 
            this.txtpaymentmode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtpaymentmode.FormattingEnabled = true;
            this.txtpaymentmode.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.txtpaymentmode.Location = new System.Drawing.Point(123, 357);
            this.txtpaymentmode.Margin = new System.Windows.Forms.Padding(2);
            this.txtpaymentmode.Name = "txtpaymentmode";
            this.txtpaymentmode.Size = new System.Drawing.Size(322, 24);
            this.txtpaymentmode.TabIndex = 238;
            this.txtpaymentmode.TabStop = false;
            this.txtpaymentmode.Text = "Cash";
            this.txtpaymentmode.SelectedIndexChanged += new System.EventHandler(this.txtpaymentmode_SelectedIndexChanged);
            this.txtpaymentmode.SelectionChangeCommitted += new System.EventHandler(this.txtpaymentmode_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(15, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 243;
            this.label13.Text = "Payment Mode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(15, 391);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 242;
            this.label14.Text = "Narration";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvsales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvsales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvsales.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvsales.Location = new System.Drawing.Point(18, 101);
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvsales.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvsales.RowTemplate.Height = 40;
            this.dgvsales.Size = new System.Drawing.Size(1266, 238);
            this.dgvsales.TabIndex = 253;
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column11.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column19.DefaultCellStyle = dataGridViewCellStyle11;
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
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refresh.Location = new System.Drawing.Point(733, 18);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(28, 32);
            this.refresh.TabIndex = 254;
            this.refresh.TabStop = false;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // SalesDate
            // 
            this.SalesDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDate.Location = new System.Drawing.Point(854, 22);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(418, 22);
            this.SalesDate.TabIndex = 760;
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
            this.btnrefreshdata.Location = new System.Drawing.Point(1252, 69);
            this.btnrefreshdata.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefreshdata.Name = "btnrefreshdata";
            this.btnrefreshdata.Size = new System.Drawing.Size(26, 26);
            this.btnrefreshdata.TabIndex = 762;
            this.btnrefreshdata.TabStop = false;
            this.btnrefreshdata.UseVisualStyleBackColor = true;
            this.btnrefreshdata.Click += new System.EventHandler(this.btnrefreshdata_Click);
            // 
            // checkBoxWholeSale
            // 
            this.checkBoxWholeSale.AutoSize = true;
            this.checkBoxWholeSale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxWholeSale.ForeColor = System.Drawing.Color.Red;
            this.checkBoxWholeSale.Location = new System.Drawing.Point(17, 476);
            this.checkBoxWholeSale.Name = "checkBoxWholeSale";
            this.checkBoxWholeSale.Size = new System.Drawing.Size(136, 20);
            this.checkBoxWholeSale.TabIndex = 763;
            this.checkBoxWholeSale.Text = "WholeSale Mode";
            this.checkBoxWholeSale.UseVisualStyleBackColor = true;
            // 
            // Formupdatesale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 510);
            this.Controls.Add(this.checkBoxWholeSale);
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
            this.Controls.Add(this.narrrations);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtpaymentmode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.btnaddproducttogrid);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CustomerNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "Formupdatesale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Sale";
            this.Load += new System.EventHandler(this.Formupdatesale_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.TextBox prize;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnaddproducttogrid;
        private System.Windows.Forms.ComboBox productname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox productcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CustomerNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SalesNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paidtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nettotal;
        private System.Windows.Forms.TextBox grandtotal;
        private System.Windows.Forms.TextBox dicounttxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox narrrations;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtpaymentmode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnupdate;
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
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker SalesDate;
        private System.Windows.Forms.Button btnrefreshdata;
        private System.Windows.Forms.CheckBox checkBoxWholeSale;
    }
}