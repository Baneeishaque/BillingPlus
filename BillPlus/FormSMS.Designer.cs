﻿namespace BillPlus
{
    partial class FormSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSMS));
            this.radioButton_mal = new System.Windows.Forms.RadioButton();
            this.radioButton_eng = new System.Windows.Forms.RadioButton();
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
            // radioButton_mal
            // 
            this.radioButton_mal.AutoSize = true;
            this.radioButton_mal.Location = new System.Drawing.Point(14, 200);
            this.radioButton_mal.Name = "radioButton_mal";
            this.radioButton_mal.Size = new System.Drawing.Size(45, 19);
            this.radioButton_mal.TabIndex = 159;
            this.radioButton_mal.Text = "Mal";
            this.radioButton_mal.UseVisualStyleBackColor = true;
            // 
            // radioButton_eng
            // 
            this.radioButton_eng.AutoSize = true;
            this.radioButton_eng.Location = new System.Drawing.Point(14, 170);
            this.radioButton_eng.Name = "radioButton_eng";
            this.radioButton_eng.Size = new System.Drawing.Size(46, 19);
            this.radioButton_eng.TabIndex = 158;
            this.radioButton_eng.Text = "Eng";
            this.radioButton_eng.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 156;
            this.label2.Text = "Messege";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 155;
            this.label1.Text = "To";
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(72, 16);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(228, 44);
            this.txt_phone.TabIndex = 151;
            this.txt_phone.TabStop = false;
            // 
            // txtSend_sms
            // 
            this.txtSend_sms.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend_sms.Location = new System.Drawing.Point(72, 70);
            this.txtSend_sms.Multiline = true;
            this.txtSend_sms.Name = "txtSend_sms";
            this.txtSend_sms.Size = new System.Drawing.Size(228, 97);
            this.txtSend_sms.TabIndex = 152;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(193, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 154;
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
            this.btn_issue.Location = new System.Drawing.Point(85, 172);
            this.btn_issue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(101, 42);
            this.btn_issue.TabIndex = 153;
            this.btn_issue.Text = "Send SMS";
            this.btn_issue.UseVisualStyleBackColor = true;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // errorProvider_send_sms
            // 
            this.errorProvider_send_sms.ContainerControl = this;
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 238);
            this.Controls.Add(this.radioButton_mal);
            this.Controls.Add(this.radioButton_eng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txtSend_sms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_issue);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS";
            this.Load += new System.EventHandler(this.FormSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_send_sms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_mal;
        private System.Windows.Forms.RadioButton radioButton_eng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txtSend_sms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.ErrorProvider errorProvider_send_sms;

    }
}