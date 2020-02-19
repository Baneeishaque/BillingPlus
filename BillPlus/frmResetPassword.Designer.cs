namespace BillPlus
{
    partial class frmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox_confirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_newpassword = new System.Windows.Forms.TextBox();
            this.textbox_cureentpassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(142, 92);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 33);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "  Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textBox_confirmpassword
            // 
            this.textBox_confirmpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmpassword.Location = new System.Drawing.Point(124, 66);
            this.textBox_confirmpassword.Multiline = true;
            this.textBox_confirmpassword.Name = "textBox_confirmpassword";
            this.textBox_confirmpassword.PasswordChar = '*';
            this.textBox_confirmpassword.Size = new System.Drawing.Size(295, 21);
            this.textBox_confirmpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 125;
            this.label1.Text = "Confirm Password";
            // 
            // textbox_newpassword
            // 
            this.textbox_newpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_newpassword.Location = new System.Drawing.Point(124, 39);
            this.textbox_newpassword.Multiline = true;
            this.textbox_newpassword.Name = "textbox_newpassword";
            this.textbox_newpassword.Size = new System.Drawing.Size(295, 21);
            this.textbox_newpassword.TabIndex = 1;
            // 
            // textbox_cureentpassword
            // 
            this.textbox_cureentpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cureentpassword.Location = new System.Drawing.Point(124, 12);
            this.textbox_cureentpassword.Multiline = true;
            this.textbox_cureentpassword.Name = "textbox_cureentpassword";
            this.textbox_cureentpassword.PasswordChar = '*';
            this.textbox_cureentpassword.Size = new System.Drawing.Size(295, 21);
            this.textbox_cureentpassword.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 123;
            this.label11.Text = "New Password";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(7, 16);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(111, 15);
            this.Label10.TabIndex = 122;
            this.Label10.Text = "Current Password";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(257, 92);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(107, 33);
            this.btnclose.TabIndex = 126;
            this.btnclose.Text = "      Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 136);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox_confirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_newpassword);
            this.Controls.Add(this.textbox_cureentpassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResetPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.TextBox textBox_confirmpassword;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textbox_newpassword;
        internal System.Windows.Forms.TextBox textbox_cureentpassword;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button btnclose;
    }
}