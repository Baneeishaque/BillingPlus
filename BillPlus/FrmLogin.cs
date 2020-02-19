using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace BillPlus
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass cls = new containerclass();
       

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt= p.selectcompany();
            if (dt.Rows[0][9].ToString() == txtbx_password.Text)
            {
                FrmSplashScreen hm = new FrmSplashScreen();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The password you entered is incorrect,try again", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtbx_password.Clear();
            }

           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            FrmCmpnySettings cmpny = new FrmCmpnySettings();
            cmpny.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           DataTable dt= p.selectcompany();
           if (dt.Rows.Count > 0)
           {
               btn_login.Enabled = true;// if already exist login else register
               btn_register.Enabled = false;

               companyname.Text=dt.Rows[0][1].ToString();
               financialyear.Text = dt.Rows[0][7].ToString();
                   
           }
           else
           {
               btn_login.Enabled = false;// if already exist login else register
               btn_register.Enabled = true;
           }
        }

        private void companyname_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void financialyear_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void companyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void financialyear_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void txtbx_password_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable dt = p.selectcompany();
                    if (dt.Rows[0][9].ToString() == txtbx_password.Text)
                    {
                        FrmSplashScreen hm = new FrmSplashScreen();
                        hm.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtbx_password.Clear();
                        MessageBox.Show("The password you entered is incorrect,try again", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
          
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_reset_Click(object sender, EventArgs e)
        {
            frmForgettPassword f = new frmForgettPassword();
            f.ShowDialog();
        }

        
    }
}
