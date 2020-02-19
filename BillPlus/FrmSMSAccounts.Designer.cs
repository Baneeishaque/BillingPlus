namespace BillPlus
{
    partial class FrmSMSAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMSAccounts));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txtSend_sms = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.errorProvider_send_sms = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_send_sms)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 165;
            this.label2.Text = "Messege";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 164;
            this.label1.Text = "To";
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(74, 11);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(298, 53);
            this.txt_phone.TabIndex = 160;
            this.txt_phone.TabStop = false;
            // 
            // txtSend_sms
            // 
            this.txtSend_sms.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend_sms.Location = new System.Drawing.Point(74, 67);
            this.txtSend_sms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSend_sms.Multiline = true;
            this.txtSend_sms.Name = "txtSend_sms";
            this.txtSend_sms.Size = new System.Drawing.Size(298, 282);
            this.txtSend_sms.TabIndex = 161;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(212, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 52);
            this.button1.TabIndex = 163;
            this.button1.Text = "      Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_issue.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ForeColor = System.Drawing.Color.Black;
            this.btn_issue.Image = ((System.Drawing.Image)(resources.GetObject("btn_issue.Image")));
            this.btn_issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issue.Location = new System.Drawing.Point(104, 355);
            this.btn_issue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(101, 52);
            this.btn_issue.TabIndex = 162;
            this.btn_issue.Text = "Send SMS";
            this.btn_issue.UseVisualStyleBackColor = true;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // errorProvider_send_sms
            // 
            this.errorProvider_send_sms.ContainerControl = this;
            // 
            // FrmSMSAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txtSend_sms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_issue);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSMSAccounts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS";
            this.Load += new System.EventHandler(this.FrmSMSAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_send_sms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txtSend_sms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.ErrorProvider errorProvider_send_sms;
    }
}