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
    public partial class FrmSMSAccounts : Form
    {
        public FrmSMSAccounts()
        {
            InitializeComponent();
        }

        private void FrmSMSAccounts_Load(object sender, EventArgs e)
        {

            try
            {




                // institution nme



                txt_phone.Text = "9847180475";


                txtSend_sms.Text = @"Dear BillingPlus User,Your Accounts summary FROM  " + FrmIncomeandexpenses.fromdate + " TO " + FrmIncomeandexpenses.todate + 
                    " ."+Environment.NewLine+Environment.NewLine+" TOTAL SALES = " + FrmIncomeandexpenses.totalsale +Environment.NewLine + Environment.NewLine+
                    " INSTALLMENT RECEIVED = "+FrmIncomeandexpenses.totalinstallment+Environment.NewLine+Environment.NewLine+
                    " OTHER INCOME = " + FrmIncomeandexpenses.totalotherincome + Environment.NewLine+Environment.NewLine+
                    " TOTAL PURCHASE = " + FrmIncomeandexpenses.totalpurchase + Environment.NewLine+Environment.NewLine+
                    " TOTAL INSTALLMENT PAID = "+FrmIncomeandexpenses.totalinstallmentpaid+Environment.NewLine+Environment.NewLine+
                    " OTHER EXPENSE = "+FrmIncomeandexpenses.totalotherexpense+Environment.NewLine+Environment.NewLine+
                    " TOTAL INCOME = "+FrmIncomeandexpenses.totalincome+Environment.NewLine+Environment.NewLine+
                    " TOTAL EXPENSE = "+FrmIncomeandexpenses.totalexpense+Environment.NewLine+Environment.NewLine+
                    " PROFIT = " + FrmIncomeandexpenses.profitsend + Environment.NewLine + Environment.NewLine + " Thanks and Regards BillingPlus." + 
                "";


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

                     

                                string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=" + txtSend_sms.Text + "&senderId=KTSTOR&routeId=1&mobileNos=" + txt_phone.Text + "&smsContentType=english";
                                Stream myStream = client.OpenRead(s);


                                StreamReader sr = new StreamReader(myStream);
                                //MessageBox.Show( sr.ReadToEnd().ToString());

                                myStream.Close();
                   
                      
                          


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
    }
}
