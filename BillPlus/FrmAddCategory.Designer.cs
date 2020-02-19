namespace BillPlus
{
    partial class frmAddcategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddcategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.saveAccountHead = new System.Windows.Forms.Button();
            this.dgvcategory = new System.Windows.Forms.DataGridView();
            this.idcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorycolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletecolumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 123;
            this.label13.Text = "Category Name";
            // 
            // saveAccountHead
            // 
            this.saveAccountHead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAccountHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAccountHead.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.saveAccountHead.ForeColor = System.Drawing.Color.Black;
            this.saveAccountHead.Image = ((System.Drawing.Image)(resources.GetObject("saveAccountHead.Image")));
            this.saveAccountHead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAccountHead.Location = new System.Drawing.Point(428, 7);
            this.saveAccountHead.Margin = new System.Windows.Forms.Padding(2);
            this.saveAccountHead.Name = "saveAccountHead";
            this.saveAccountHead.Size = new System.Drawing.Size(73, 32);
            this.saveAccountHead.TabIndex = 1;
            this.saveAccountHead.Text = "       Save";
            this.saveAccountHead.UseVisualStyleBackColor = true;
            this.saveAccountHead.Click += new System.EventHandler(this.saveAccountHead_Click);
            // 
            // dgvcategory
            // 
            this.dgvcategory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcolumn,
            this.categorycolumn,
            this.deletecolumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcategory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvcategory.Location = new System.Drawing.Point(11, 43);
            this.dgvcategory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvcategory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcategory.Size = new System.Drawing.Size(490, 205);
            this.dgvcategory.TabIndex = 0;
            this.dgvcategory.TabStop = false;
            this.dgvcategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategory_CellClick);
            this.dgvcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idcolumn
            // 
            this.idcolumn.DataPropertyName = "id";
            this.idcolumn.HeaderText = "id";
            this.idcolumn.Name = "idcolumn";
            this.idcolumn.ReadOnly = true;
            this.idcolumn.Visible = false;
            // 
            // categorycolumn
            // 
            this.categorycolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categorycolumn.DataPropertyName = "categoryname";
            this.categorycolumn.HeaderText = "Category";
            this.categorycolumn.Name = "categorycolumn";
            this.categorycolumn.ReadOnly = true;
            // 
            // deletecolumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deletecolumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.deletecolumn.HeaderText = "";
            this.deletecolumn.Image = ((System.Drawing.Image)(resources.GetObject("deletecolumn.Image")));
            this.deletecolumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.deletecolumn.Name = "deletecolumn";
            this.deletecolumn.ReadOnly = true;
            this.deletecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletecolumn.Width = 25;
            // 
            // categoryname
            // 
            this.categoryname.BackColor = System.Drawing.Color.White;
            this.categoryname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.categoryname.ForeColor = System.Drawing.Color.Black;
            this.categoryname.Location = new System.Drawing.Point(108, 11);
            this.categoryname.Multiline = true;
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(277, 27);
            this.categoryname.TabIndex = 0;
            // 
            // frmAddcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 259);
            this.Controls.Add(this.categoryname);
            this.Controls.Add(this.dgvcategory);
            this.Controls.Add(this.saveAccountHead);
            this.Controls.Add(this.label13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddcategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.FrmAddAccountHeads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button saveAccountHead;
        private System.Windows.Forms.DataGridView dgvcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorycolumn;
        private System.Windows.Forms.DataGridViewImageColumn deletecolumn;
        private System.Windows.Forms.TextBox categoryname;

    }
}