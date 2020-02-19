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
    public partial class FrmCmpnySettings : Form
    {
        public FrmCmpnySettings()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        string imagepath="";
        private void FrmCmpnySettings_Load(object sender, EventArgs e)
        {
             DataTable dt = p.selectcompany();
             if (dt.Rows.Count>0)
             {
                 companyname.Text=dt.Rows[0][1].ToString();
                 address.Text = dt.Rows[0][2].ToString();
                 state.Text =dt.Rows[0][3].ToString();
                     pincode.Text =dt.Rows[0][4].ToString();
                     email.Text =dt.Rows[0][5].ToString();
                     
                     financialyearfrom.Text = dt.Rows[0][11].ToString();
                     finanacialyearto.Text = dt.Rows[0][12].ToString();
                     currency.Text = dt.Rows[0][8].ToString();
                 password.Text=dt.Rows[0][9].ToString();
                 setpassword.Text = dt.Rows[0][9].ToString();
                 setpassword.Enabled = false;
                 password.Enabled = false;
                 setpassword.PasswordChar = Convert.ToChar( "*");
                 phone.Text = dt.Rows[0][10].ToString();


                 if (dt.Rows[0][6].ToString() != "")
                 {

                     image.Image = Image.FromFile(dt.Rows[0][6].ToString());
                 }
                 else
                 {
                     image.Image = null;
                 }
                 image.SizeMode = PictureBoxSizeMode.StretchImage;//make picture box stretch
                 
             }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {




            //c.Name_of_student = "a";
            //reg.Address = "add";
            //reg.Amount = 6578656;
            //p.emptb(reg);
            errorProvidercompanysettings.Clear();
            if (companyname.Text == "" || financialyearfrom.Text == "" || finanacialyearto.Text == "" || setpassword.Text == "" || password.Text == "" || phone.Text == "" || setpassword.Text != password.Text)
            {
                if (companyname.Text == "")
                {
                    errorProvidercompanysettings.SetError(companyname, "Required field");
                }
                if (phone.Text == "")
                {
                    errorProvidercompanysettings.SetError(phone, "Required field");
                }
                if (financialyearfrom.Text == "")
                {
                    errorProvidercompanysettings.SetError(financialyearfrom, "Required field");
                }
                if (finanacialyearto.Text == "")
                {
                    errorProvidercompanysettings.SetError(finanacialyearto, "Required field");
                }
                if (setpassword.Text == "")
                {
                    errorProvidercompanysettings.SetError(setpassword, "Required field");
                }
                if (password.Text == "")
                {
                    errorProvidercompanysettings.SetError(password, "Required field");
                }
                if (setpassword.Text != password.Text)
                {
                    MessageBox.Show("Password do not match", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
            }
            else
            {

                // if no data found save it else update it


                DataTable dt = p.selectcompany();
                if (dt.Rows.Count > 0) //Update
                {

                    c.Companyid = 1;
                    c.Companyname = companyname.Text;
                    c.Address = address.Text;
                    c.Phone = phone.Text;

                    c.State = state.Text;
                    c.Pincode = pincode.Text;
                    c.Email = email.Text;
                    c.Logo = imagepath;


                   
                    if (imagepath.ToString() == "" && dt.Rows[0][6].ToString() != "")
                    {
                        c.Logo = dt.Rows[0][6].ToString();

                    }
                    else
                    {
                        c.Logo = imagepath;
                    }




                    c.Financialyear = financialyearfrom.Text + "-" + finanacialyearto.Text;
                    c.Currency = currency.Text;
                    c.Password = password.Text;
                    c.Financialyearfrom = financialyearfrom.Text;
                    c.Financialyearto = finanacialyearto.Text;
                    p.updatecompanysettings(c);
                    MessageBox.Show("Company details updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    //this.Hide();
                    this.Close();
                    // refresh

                    DataTable dtrefsh = p.selectcompany();
                    if (dtrefsh.Rows.Count > 0)
                    {
                        companyname.Text = dtrefsh.Rows[0][1].ToString();
                        address.Text = dtrefsh.Rows[0][2].ToString();
                        state.Text = dtrefsh.Rows[0][3].ToString();
                        pincode.Text = dtrefsh.Rows[0][4].ToString();
                        email.Text = dtrefsh.Rows[0][5].ToString();

                        financialyearfrom.Text = dtrefsh.Rows[0][11].ToString();
                        finanacialyearto.Text = dtrefsh.Rows[0][12].ToString();
                        currency.Text = dtrefsh.Rows[0][8].ToString();
                        password.Text = dtrefsh.Rows[0][9].ToString();
                        setpassword.Text = dtrefsh.Rows[0][9].ToString();
                        setpassword.Enabled = false;
                        password.Enabled = false;
                        setpassword.PasswordChar = Convert.ToChar("*");
                        phone.Text = dtrefsh.Rows[0][10].ToString();


                        if (dtrefsh.Rows[0][6].ToString() != "")
                        {

                            image.Image = Image.FromFile(dtrefsh.Rows[0][6].ToString());
                        }
                        else
                        {
                            image.Image = null;
                        }
                        image.SizeMode = PictureBoxSizeMode.StretchImage;//make picture box stretch

                    }



                }
                else  //save
                {


                    c.Companyid = 1;
                    c.Companyname = companyname.Text;
                    c.Address = address.Text;
                    c.Phone = phone.Text;

                    c.State = state.Text;
                    c.Pincode = pincode.Text;
                    c.Email = email.Text;
                    c.Logo = imagepath;
                    c.Financialyear = financialyearfrom.Text +"-"+finanacialyearto.Text;
                    c.Currency = currency.Text;
                    c.Password = password.Text;
                    c.Financialyearfrom = financialyearfrom.Text;
                    c.Financialyearto = finanacialyearto.Text;
                    p.insertintocompanysettings(c);
                    MessageBox.Show("Company  registration was successful", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    FrmLogin f = new FrmLogin();
                    f.Show();
                    this.Close();
                }
            }
        }



        private void upload_Click(object sender, EventArgs e)
        {
            try
            {

                // open file dialog 
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box
                    image.Image = Image.FromFile(open.FileName);
                    // image file path
                    imagepath = open.FileName;

                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetpassword_Click(object sender, EventArgs e)
        {
            frmResetPassword f = new frmResetPassword();
            f.ShowDialog();

        }

      

       
    }
}
