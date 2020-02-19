using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmsClient;
using System.Net;
using System.IO;
namespace BillPlus
{
    public partial class FrmSMS : Form
    {
        public FrmSMS()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        private void btn_sms_Click(object sender, EventArgs e)
        {
            try
            {

                errorProvider_sms.Clear();
                if ( txtmsg_insdividual.Text == "" || txt_phone.Text == "")
                {
                    if (txtmsg_insdividual.Text == "")
                    {
                        errorProvider_sms.SetError(txtmsg_insdividual, "Required field");
                    }

                    if (txt_phone.Text == "")
                    {
                        errorProvider_sms.SetError(txt_phone, "Required field");
                    }
                   

                }

                else
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to send SMS?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {


                        try
                        {



                            WebClient client = new WebClient();
                            // english

                            if (radioButton_eng.Checked == true)
                            {




                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtmsg_insdividual.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + txt_phone.Text + "&smsContentType=english";

                              
                                
                                
                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                                //MessageBox.Show( sr.ReadToEnd().ToString());

                                myStream.Close();
                            }
                            // malayalam

                            if (radioButton_mal.Checked == true)
                            {

                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtmsg_insdividual.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + txt_phone.Text + "&smsContentType=english";

                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                                //MessageBox.Show( sr.ReadToEnd().ToString());

                                myStream.Close();
                            }


                            MessageBox.Show("Messege has been sent successfully", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       

                            //clear
                            txt_phone.Text = "";
                            txtmsg_insdividual.Text = "";


                         
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Please Check Your Internet Connection", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else

                    }


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Internet Connection", "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void FrmSMS_Load(object sender, EventArgs e)
        {
            radioButton_eng.Checked = true;

         

        }

        private void txtmsg_insdividual_TextChanged(object sender, EventArgs e)
        {
            if (txtmsg_insdividual.Text != "")
            {
                var userInput = txtmsg_insdividual.Text;
                lbl_count.Text = userInput.Length.ToString();
            }
            else
            {
                lbl_count.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btniew_Click(object sender, EventArgs e)
        {
            if (cmbvIEWcUSTOMER.Text != "" || cmbvIEWcUSTOMER.Text != "---Select---" || cmbcustomerid.Text != "" || cmbcustomerid.Text != "---Select---" || cmbcustomerid.Text != null)
            {


                c.Id = int.Parse(cmbcustomerid.Text);
                DataTable dtview = p.selectcustomerbyid(c);
                if (dtview.Rows.Count > 0)
                {
                   
                    txt_phone.Text = dtview.Rows[0][3].ToString();
                  
                }
                else
                {
                    MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
            }
            else
            {
                MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void FrmSMS_Enter(object sender, EventArgs e)
        {
            DataTable dt = p.selectcompanycustomerdetails();
            cmbvIEWcUSTOMER.DataSource = dt;
            cmbvIEWcUSTOMER.ValueMember = "id";
            cmbvIEWcUSTOMER.DisplayMember = "username";

            cmbcustomerid.DataSource = dt;
            cmbcustomerid.ValueMember = "id";
            cmbcustomerid.DisplayMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_view_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_view.Checked == true)
            {
                DataTable dt = p.selectcompanycustomerdetails();
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = dt;



            }
            else
            {
                DataTable dt = p.selectcompanycustomerdetails();
             
                dgvCustomers.DataSource = null;

            }
        }

        private void btn_mass_sms_Click(object sender, EventArgs e)
        {
            try
            {

                errorProvider_sms.Clear();
                if (txtMassMsg.Text == "")
                {
                    
                    if (txtMassMsg.Text == "")
                    {
                        errorProvider_sms.SetError(txtMassMsg, "Required field");
                    }




                }

                else
                {

               

                    DataTable dt = p.selectcompanycustomerdetails();
                    dgvCustomers.AutoGenerateColumns = false;
                    dgvCustomers.DataSource = dt;




                    if (dgvCustomers.DataSource != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure want to send sms to all customers?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string mob = "";

                            for (int i = 0; i < dgvCustomers.Rows.Count; i++)
                            {
                                mob = mob + dgvCustomers.Rows[i].Cells[1].Value.ToString() + ",";

                            }    //"to=" + dataGridView_student_details.Rows[i].Cells[2].Value.ToString() + "&" +


                            WebClient client = new WebClient();
                            // english

                            if (radioButton_eng.Checked == true)
                            {



                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtMassMsg.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + mob + "&smsContentType=english";



                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                       

                                myStream.Close();

                            }
                            // malayalam

                            if (radioButton_mal.Checked == true)
                            {

                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtMassMsg.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + mob + "&smsContentType=english";



                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                              

                                myStream.Close();




                            }




                            txtMassMsg.Text = "";

                        
                            dgvCustomers.DataSource = null;

                            MessageBox.Show("Messege has been sent successfully,to all customers", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no customer found", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                    }






                    //        reg.Id = p.maxid_sms_number();
                    //        reg.Sms_date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    //        reg.Sms_content = txtMassMsg.Text;
                    //        reg.Remarks = "Has been sent";
                    //        acadamicyear();
                    //        reg.Name_of_student = dataGridView_student_details.Rows[i].Cells[1].Value.ToString();
                    //        reg.Admisn_no = int.Parse(dataGridView_student_details.Rows[i].Cells[0].Value.ToString());
                    //        p.insert_sms_tble__provider_function(reg);

                    //        // clear


                    //    }


                    //    MessageBox.Show("Messege has been sent successfully,to all students in this institution", "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{

                    //}



                }
            }




            catch (Exception )
            {
                MessageBox.Show("Can't send SMS,Please check your internet Connection", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
