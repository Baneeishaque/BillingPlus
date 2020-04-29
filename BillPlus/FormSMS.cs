using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using SmsClient;
using System.Net;
using System.IO;
namespace BillPlus
{
    public partial class FormSMS : Form
    {
        public FormSMS()
        {
            InitializeComponent();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider_send_sms.Clear();
                if (txt_phone.Text == "" || txtSend_sms.Text == "")
                {
                    if (txt_phone.Text == "")
                    {
                        errorProvider_send_sms.SetError(txt_phone, "Required field");
                    }



                    if (txtSend_sms.Text == "")
                    {
                        errorProvider_send_sms.SetError(txtSend_sms, "Required field");
                    }


                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to send sms?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        try
                        {



                            WebClient client = new WebClient();
                            // english

                            if (radioButton_eng.Checked == true)
                            {


                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtSend_sms.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + txt_phone.Text + "&smsContentType=english";
                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                                //MessageBox.Show( sr.ReadToEnd().ToString());

                                myStream.Close();
                            }
                            // malayalam

                            if (radioButton_mal.Checked == true)
                            {

                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtSend_sms.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + txt_phone.Text + "&smsContentType=unicode";

                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                                //MessageBox.Show( sr.ReadToEnd().ToString());

                                myStream.Close();
                            }



                            MessageBox.Show("Messege has been sent successfully", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            // clear



                            this.Close();

                        }


                        catch (Exception)
                        {
                            MessageBox.Show("Can't send SMS,Please check your internet Connection or SMS balance exhausted ", "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't send SMS,Please check your internet Connection or SMS balance exhausted ", "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FormSMS_Load(object sender, EventArgs e)
        {
            try
            {

             
                

                // institution nme



                radioButton_eng.Checked = true;
                txt_phone.Text = FrmAddMasters.mobilesend;


                txtSend_sms.Text = "Dear Customer,You have to pay an amount of " + FrmAddMasters.balncesend + " in KTK STORE AYIKKARAPPADI .Remind you to pay the amount more earlier as possible .Thanks and Regards KTK STORE AYIKKARAPPADI";
                          

            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
