using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillPlus
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = p.selectcompany();
            if (dt.Rows[0][9].ToString() == textbox_cureentpassword.Text) //Update
            {
                if (textbox_newpassword.Text == textBox_confirmpassword.Text)
                {
                    c.Companyid = 1;
                    c.Password = textBox_confirmpassword.Text;
                    p.updatecompanypaassword(c);
                    MessageBox.Show("Password updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password do not match", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
            }
            else
            {
                MessageBox.Show("The current password you entered is wrong", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
