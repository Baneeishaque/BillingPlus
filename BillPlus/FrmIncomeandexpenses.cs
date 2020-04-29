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
    public partial class FrmIncomeandexpenses : Form
    {
        public FrmIncomeandexpenses()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        public static string fromdate;
        public static string todate;
        public static string totalsale;
        public static string totalinstallment;
        public static string totalotherincome;

        public static string totalpurchase;

        public static string totalinstallmentpaid;

        public static string totalotherexpense;

        public static string totalincome;

        public static string totalexpense;

        public static string profitsend;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void profitandloss_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void savincome_Click(object sender, EventArgs e)
        {
    
       
            
            errorProvider1.Clear();
     
            if (CmbIncome.Text=="" || TxtAMountIncome.Text == ""  )
            {
                if (CmbIncome.Text == "")
                {
                    errorProvider1.SetError(CmbIncome, "Can't be Null");
                }
                if (TxtAMountIncome.Text == "")
                {
                    errorProvider1.SetError(TxtAMountIncome, "Can't be Null");
                }
              
            }
            else
            {


                DataTable dt = p.incomemaxid();
                if (dt.Rows[0][0].ToString() == "")
                {
                    c.Id = 1;

                }
                else
                {
                    int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                    c.Id = idValue;
                }
      c.Incomeorexpence = "Income";
      DataTable dtfinancial = p.selectcompany();

      c.Financialyear = dtfinancial.Rows[0][7].ToString();


      c.Collctiondate =DateTime.Parse( dtmIncome.Text);
      c.Typrofepnce = CmbIncome.Text;
      c.Descrption = TxtIncomeDescription.Text;
      c.Amount =decimal.Parse( TxtAMountIncome.Text);
         p.insrtintoincomeexpese(c);

         MessageBox.Show("Income saved succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
         DataTable dtfinancials = p.selectcompany();

         c.Financialyear = dtfinancials.Rows[0][7].ToString();
         c.Typrofepnce = "Income";
         DataTable dts = p.Selecincomeexpense(c);
         dgvIncome.AutoGenerateColumns = false;
         dgvIncome.DataSource = dts;



         decimal sum = 0;
         for (int i = 0; i < dgvIncome.Rows.Count; i++)
         {
             if (dgvIncome.Rows[i].Cells[4].Value != null)
             {
                 sum += Convert.ToDecimal(dgvIncome.Rows[i].Cells[4].Value);
             }
         }
         lblTotalIncome.Text = sum.ToString();

            } 


        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            if (cmbexpensess.Text == "" || txtamountexpense.Text == "" )
            {
                if (cmbexpensess.Text == "")
                {
                    errorProvider1.SetError(cmbexpensess, "Can't be Null");
                }
                if (txtamountexpense.Text == "")
                {
                    errorProvider1.SetError(txtamountexpense, "Can't be Null");
                }
               
            }
            else
            {








                DataTable dt = p.incomemaxid();
                if (dt.Rows[0][0].ToString() == "")
                {
                   c.Id = 1;

                }
                else
                {
                    int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                    c.Id = idValue;
                }
                c.Incomeorexpence = "Expense";
                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();

                c.Collctiondate = DateTime.Parse(dtmexpense.Text);
                c.Typrofepnce = cmbexpensess.Text;
                c.Descrption = txtexpensedescription.Text;
                c.Amount = decimal.Parse(txtamountexpense.Text);
                p.insrtintoincomeexpese(c);

                MessageBox.Show("Expense saved succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DataTable dtfinancials = p.selectcompany();

                c.Financialyear = dtfinancials.Rows[0][7].ToString();
                c.Typrofepnce = "Expense";
                DataTable dts = p.Selecincomeexpense(c);
                dgvexpense.AutoGenerateColumns = false;
                dgvexpense.DataSource = dts;


                decimal sum = 0;
                for (int i = 0; i < dgvexpense.Rows.Count; i++)
                {
                    if (dgvexpense.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(dgvexpense.Rows[i].Cells[4].Value);
                    }
                }
                lblexpensetotal.Text = sum.ToString();

            } 


        }

        private void txtamountexpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void TxtAMountIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void viewincoime_Enter(object sender, EventArgs e)
        {
            
          DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            c.Typrofepnce = "Income";
            DataTable dt = p.Selecincomeexpense(c);
            dgvIncome.AutoGenerateColumns = false;
            dgvIncome.DataSource = dt;


            decimal sum = 0;
            for (int i = 0; i < dgvIncome.Rows.Count; i++)
            {
                if (dgvIncome.Rows[i].Cells[4].Value != null)
                {
                    sum += Convert.ToDecimal(dgvIncome.Rows[i].Cells[4].Value);
                }
            }
            lblTotalIncome.Text = sum.ToString();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            DataTable dtfinancials = p.selectcompany();

            c.Financialyear = dtfinancials.Rows[0][7].ToString();
            c.Typrofepnce = "Expense";
            DataTable dt = p.Selecincomeexpense(c);
            dgvexpense.AutoGenerateColumns = false;
            dgvexpense.DataSource = dt;



            decimal sum = 0;
            for (int i = 0; i < dgvexpense.Rows.Count; i++)
            {
                if (dgvexpense.Rows[i].Cells[4].Value != null)
                {
                    sum += Convert.ToDecimal(dgvexpense.Rows[i].Cells[4].Value);
                }
            }
            lblexpensetotal.Text = sum.ToString();
        }

        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {  DialogResult dialogResult = MessageBox.Show("Are you sure want to delete?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {

                c.Id = int.Parse(dgvIncome.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                p.deleteintoincomeexpese(c);

                MessageBox.Show("Income deleted succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DataTable dtfinancials = p.selectcompany();

                c.Financialyear = dtfinancials.Rows[0][7].ToString();
                c.Typrofepnce = "Income";
                DataTable dts = p.Selecincomeexpense(c);
                dgvIncome.AutoGenerateColumns = false;
                dgvIncome.DataSource = dts;



                decimal sum = 0;
                for (int i = 0; i < dgvIncome.Rows.Count; i++)
                {
                    if (dgvIncome.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(dgvIncome.Rows[i].Cells[4].Value);
                    }
                }
                lblTotalIncome.Text = sum.ToString();



                //refresh brach

                //DataTable dtview = p.selectcompanycustomerdetails();
                //txtexpensedescription.DataSource = dtview;
                //txtexpensedescription.ValueMember = "status";
                //txtexpensedescription.DisplayMember = "status";


            }


            else if (dialogResult == DialogResult.No)
            {
                //do something else

            }


            }
















        }

        private void dgvexpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {

                    c.Id = int.Parse(dgvexpense.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString());
                    p.deleteintoincomeexpese(c);

                    MessageBox.Show("Expense deleted succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    DataTable dtfinancials = p.selectcompany();

                    c.Financialyear = dtfinancials.Rows[0][7].ToString();
                    c.Typrofepnce = "Expense";
                    DataTable dts = p.Selecincomeexpense(c);
                    dgvexpense.AutoGenerateColumns = false;
                    dgvexpense.DataSource = dts;


                    decimal sum = 0;
                    for (int i = 0; i < dgvexpense.Rows.Count; i++)
                    {
                        if (dgvexpense.Rows[i].Cells[4].Value != null)
                        {
                            sum += Convert.ToDecimal(dgvexpense.Rows[i].Cells[4].Value);
                        }
                    }
                    lblexpensetotal.Text = sum.ToString();
                }


                else if (dialogResult == DialogResult.No)
                {
                    //do something else

                }


            }
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {

          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {



            //sum of sale

      
            DataTable dtfinancialssss = p.selectcompany();

            c.Financialyear = dtfinancialssss.Rows[0][7].ToString();


            DateTime datefromsale = DateTime.Parse(dtmfrom.Text);
            var shortDatefromsale = datefromsale.ToString("yyyy-MM-dd");


            DateTime datetosales = DateTime.Parse(dtmto.Text);
            var shortDatetosale = datetosales.ToString("yyyy-MM-dd");




            c.Collcndatefrom = DateTime.Parse(shortDatefromsale.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetosale.ToString());
            decimal saleamountsum = 0;
            DataTable dtsale = p.selectsumsaleinbetweendates(c);

            if (dtsale.Rows.Count != 0 && dtsale.Rows[0][0].ToString() != "")
            {
                txttotalsalesamount.Text = dtsale.Rows[0][0].ToString();
                saleamountsum = decimal.Parse(dtsale.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                txttotalsalesamount.Text = "0";
            }



            //


            //sum installment


            DataTable dtfinancialfinc = p.selectcompany();//   cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            c.Financialyear = dtfinancialfinc.Rows[0][7].ToString();

            DateTime datefroinstallment = DateTime.Parse(dtmfrom.Text);
            var shortDatefrominstallment = datefroinstallment.ToString("yyyy-MM-dd");


            DateTime datetoinstallment = DateTime.Parse(dtmto.Text);
            var shortDatetoinstallment = datetoinstallment.ToString("yyyy-MM-dd");


            decimal installment = 0;
            c.Collcndatefrom = DateTime.Parse(shortDatefrominstallment.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoinstallment.ToString());
            //  c.Branch = cmbbranch.Text;

            DataTable dtinst = p.selectsuminstallmentsearch(c);
            if (dtinst.Rows.Count != 0 && dtinst.Rows[0][0].ToString() != "")
            {
                installment = decimal.Parse(dtinst.Rows[0][0].ToString()); //total of installment
                totalinstallmenttextsale.Text = dtinst.Rows[0][0].ToString();


            }
            else
            {
             totalinstallmenttextsale.Text = "0";
            }







            //incomesum

           
 

            DataTable dtfinancial = p.selectcompany();


            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Income";


            DateTime datefrom = DateTime.Parse(dtmfrom.Text);
            var shortDatefrom = datefrom.ToString("yyyy-MM-dd 00:00:00");

            DateTime dateto = DateTime.Parse(dtmto.Text);
            var shortDateto = dateto.ToString("yyyy-MM-dd 00:00:00");



            c.Collcndatefrom = DateTime.Parse(shortDatefrom.ToString());
            c.Collcndateto = DateTime.Parse(shortDateto.ToString());
          //  c.Branch = cmbbranch.Text;
            decimal indirectincomecal = 0;
            DataTable dt = p.selectsumincomedate(c);
            if (dt.Rows.Count != 0 && dt.Rows[0][0].ToString() != "")
            {
                totalinderctincome.Text = dt.Rows[0][0].ToString();
                indirectincomecal = decimal.Parse(dt.Rows[0][0].ToString());//indirect income
            }
            else
            {
                totalinderctincome.Text = "0";
            }

            

                //===========EXPENSE SECTION==========



            //sum of purchase


            DataTable dtfinancialpurch = p.selectcompany();

            c.Financialyear = dtfinancialpurch.Rows[0][7].ToString();


            DateTime datefrompurchase = DateTime.Parse(dtmfrom.Text);
            var shortDatefrompurchase = datefrompurchase.ToString("yyyy-MM-dd");


            DateTime datetopurchase = DateTime.Parse(dtmto.Text);
            var shortDatetopurchase = datetopurchase.ToString("yyyy-MM-dd");




            c.Collcndatefrom = DateTime.Parse(shortDatefrompurchase.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetopurchase.ToString());
            decimal purchaseamountsum = 0;
            DataTable dtpurchase = p.selectsumpurchaseinbetweendates(c);

            if (dtpurchase.Rows.Count != 0 && dtpurchase.Rows[0][0].ToString() != "")
            {
                totalpurchaseamuount.Text = dtpurchase.Rows[0][0].ToString();
                purchaseamountsum = decimal.Parse(dtpurchase.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                totalpurchaseamuount.Text = "0";
            }


            //sum installment supplier


            DataTable dtfinancialfincpurchase = p.selectcompany();//   cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            c.Financialyear = dtfinancialfincpurchase.Rows[0][7].ToString();

            DateTime datefroinstallmentpurch = DateTime.Parse(dtmfrom.Text);
            var shortDatefrominstallmentpurch = datefroinstallmentpurch.ToString("yyyy-MM-dd");


            DateTime datetoinstallmentpurch = DateTime.Parse(dtmto.Text);
            var shortDatetoinstallmentpurchase = datetoinstallmentpurch.ToString("yyyy-MM-dd");


            decimal installmentpurchase = 0;
            c.Collcndatefrom = DateTime.Parse(shortDatefrominstallment.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoinstallment.ToString());
            //  c.Branch = cmbbranch.Text;

            DataTable dtinstsupp = p.selectsuminstallmentsearchsupplier(c);
            if (dtinstsupp.Rows.Count != 0 && dtinstsupp.Rows[0][0].ToString() != "")
            {
                installmentpurchase = decimal.Parse(dtinstsupp.Rows[0][0].ToString()); //total of installment
                totalinstallmentpurchase.Text = dtinstsupp.Rows[0][0].ToString();


            }
            else
            {
                totalinstallmentpurchase.Text = "0";
            }





            //sum of expense
      

            DataTable dtfinancials = p.selectcompany();


            DateTime datefromexpns = DateTime.Parse(dtmfrom.Text);
            var shortDatefromexpns = datefromexpns.ToString("yyyy-MM-dd 00:00:00");

            DateTime datetoexpns = DateTime.Parse(dtmto.Text);
            var shortDatetoexpns = datetoexpns.ToString("yyyy-MM-dd 00:00:00");


            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Expense";

            c.Collcndatefrom = DateTime.Parse(shortDatefromexpns.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoexpns.ToString());
            decimal indexrectexpncecal = 0;

            DataTable dtexpns = p.selectexpensewisedate(c);
            if (dtexpns.Rows.Count != 0 && dtexpns.Rows[0][0].ToString() != "")
            {
                otherexpensetext.Text = dtexpns.Rows[0][0].ToString();
                indexrectexpncecal = decimal.Parse(dtexpns.Rows[0][0].ToString());//indirect income
            }
            else
            {
                otherexpensetext.Text = "0";
            }




          


            //TOTAL CALCULATIONS

            decimal TOTALINCOME = saleamountsum + installment + indirectincomecal;

            totaldailyincome.Text = TOTALINCOME.ToString(); //TOTAL INCOME

            decimal TOTALEXPENSE = purchaseamountsum + installmentpurchase + indexrectexpncecal;

            totalexpence.Text = TOTALEXPENSE.ToString();





            decimal profit = (TOTALINCOME) - (TOTALEXPENSE);
            if (profit < 0)
            {
                profitandloss.Text = (-profit) + " " + "Loss";
            }
            else
            {
                profitandloss.Text = (profit).ToString();
            }




        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {



            //sum of sale
            // 

            decimal saleamountsum = 0;
            DataTable dtfinancialssss = p.selectcompany();

            c.Financialyear = dtfinancialssss.Rows[0][7].ToString();


            DataTable dtsale = p.selectsumsale(c);
            if (dtsale.Rows.Count != 0 && dtsale.Rows[0][0].ToString() != "")
            {
                txttotalsalesamount.Text = dtsale.Rows[0][0].ToString();
                saleamountsum = decimal.Parse(dtsale.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                txttotalsalesamount.Text = "0";
            }




            //sum installment


            decimal installment = 0;

            DataTable dtfinancialfinc = p.selectcompany();

            c.Financialyear = dtfinancialfinc.Rows[0][7].ToString();


            DataTable dtinst = p.selectsuminstallment(c);
            if (dtinst.Rows.Count != 0 && dtinst.Rows[0][0].ToString() != "")
            {

                totalinstallmenttextsale.Text = dtinst.Rows[0][0].ToString();
                installment = decimal.Parse(dtinst.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                totalinstallmenttextsale.Text = "0";
            }




            //incomesum other income sum


            decimal indirectincomecal = 0;

            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Income";
            DataTable dt = p.selectsumincome(c);
            if (dt.Rows.Count != 0 && dt.Rows[0][0].ToString() != "")
            {
                totalinderctincome.Text = dt.Rows[0][0].ToString();
                indirectincomecal = decimal.Parse(dt.Rows[0][0].ToString());//indirect income
            }
            else
            {
                totalinderctincome.Text = "0";
            }



            //credit sales

           


            decimal installmentpending = 0;

            DataTable dtfinancialfincpend = p.selectcompany();

            c.Financialyear = dtfinancialfincpend.Rows[0][7].ToString();


            DataTable dtinstpend = p.selectsumofcreditsales(c);
            if (dtinstpend.Rows.Count != 0 && dtinstpend.Rows[0][0].ToString() != "")
            {

                lblpendingincome.Text = dtinstpend.Rows[0][0].ToString();
                installmentpending = decimal.Parse(dtinstpend.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                lblpendingincome.Text = "0";
            }








            

            //====================== EXPENSE SIDE




            //sum of purchase
            // 

            decimal purchaseamountsum = 0;
            DataTable dtfinancialpurchase = p.selectcompany();

            c.Financialyear = dtfinancialpurchase.Rows[0][7].ToString();


            DataTable dtpurchase = p.selectsumpurchase(c);
            if (dtpurchase.Rows.Count != 0 && dtpurchase.Rows[0][0].ToString() != "")
            {
                totalpurchaseamuount.Text = dtpurchase.Rows[0][0].ToString();
                purchaseamountsum = decimal.Parse(dtpurchase.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                totalpurchaseamuount.Text = "0";
            }



            //sum installment purchase


            decimal installmentpurchase = 0;

            DataTable dtfinancialfincpurhcase = p.selectcompany();

            c.Financialyear = dtfinancialfincpurhcase.Rows[0][7].ToString();


            DataTable dtinstpurchase = p.selectsuminstallmentpurchase(c);
            if (dtinstpurchase.Rows.Count != 0 && dtinstpurchase.Rows[0][0].ToString() != "")
            {

                totalinstallmentpurchase.Text = dtinstpurchase.Rows[0][0].ToString();
                installmentpurchase = decimal.Parse(dtinstpurchase.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                totalinstallmentpurchase.Text = "0";
            }





            //expense sum other expense sum
            decimal indexrectexpncecal = 0;
            DataTable dtfinancials = p.selectcompany();

            c.Financialyear = dtfinancials.Rows[0][7].ToString();

            c.Typrofepnce = "Expense";
            DataTable dtss = p.selectsumincome(c);
            if (dtss.Rows.Count != 0 && dtss.Rows[0][0].ToString() != "")
            {
                otherexpensetext.Text = dtss.Rows[0][0].ToString();
                indexrectexpncecal = decimal.Parse(dtss.Rows[0][0].ToString());  //indirect expense
            }
            else
            {
                otherexpensetext.Text = "0";
            }





            //credit purchases




            decimal installmentcreditpurhcase = 0;

            DataTable dtfinancialfincpendcredt = p.selectcompany();

            c.Financialyear = dtfinancialfincpendcredt.Rows[0][7].ToString();


            DataTable dtinstpendcredt = p.selectsumofcreditpurchase(c);
            if (dtinstpendcredt.Rows.Count != 0 && dtinstpendcredt.Rows[0][0].ToString() != "")
            {

                lblpendingexpense.Text = dtinstpendcredt.Rows[0][0].ToString();
                installmentcreditpurhcase = decimal.Parse(dtinstpendcredt.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                lblpendingexpense.Text = "0";
            }












            //total calculation

            decimal totalincome = saleamountsum + installment  +indirectincomecal;

            totaldailyincome.Text = totalincome.ToString();


            decimal totalexpense = purchaseamountsum + installmentpurchase + indexrectexpncecal;

            totalexpence.Text = totalexpense.ToString();


            //profit
            decimal profit = (totalincome) - (totalexpense);
            if (profit < 0)
            {
                profitandloss.Text = (-profit) + " " + "Loss";
            }
            else
            {
                profitandloss.Text = (profit).ToString();
            }


            //pending profit



            decimal profitpending = (installmentpending) - (installmentcreditpurhcase);
            lbltotalpendingbalance.Text = profitpending.ToString();
            if (profitpending < 0)
            {
                lbltotalpendingbalance.Text = (-profitpending) + " " + "Loss";
            }
            else
            {
                lbltotalpendingbalance.Text = (profitpending).ToString();
            }
     


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin@123")
            {
                groupBox7.Visible = true;
                btnRefresh.Visible = true;
            groupBox4.Visible = true;

            groupBox3.Visible = true; btnsms.Visible = true;

            //sum of sale
            // 

            decimal saleamountsum = 0;
            DataTable dtfinancialssss = p.selectcompany();

            c.Financialyear = dtfinancialssss.Rows[0][7].ToString();


            DataTable dtsale = p.selectsumsale(c);
            if (dtsale.Rows.Count != 0 && dtsale.Rows[0][0].ToString() != "")
            {
                txttotalsalesamount.Text = dtsale.Rows[0][0].ToString();
                saleamountsum = decimal.Parse(dtsale.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                txttotalsalesamount.Text = "0";
            }




            //sum installment


            decimal installment = 0;

            DataTable dtfinancialfinc = p.selectcompany();

            c.Financialyear = dtfinancialfinc.Rows[0][7].ToString();


            DataTable dtinst = p.selectsuminstallment(c);
            if (dtinst.Rows.Count != 0 && dtinst.Rows[0][0].ToString() != "")
            {

                totalinstallmenttextsale.Text = dtinst.Rows[0][0].ToString();
                installment = decimal.Parse(dtinst.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                totalinstallmenttextsale.Text = "0";
            }




            //incomesum other income sum


            decimal indirectincomecal = 0;

            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Income";
            DataTable dt = p.selectsumincome(c);
            if (dt.Rows.Count != 0 && dt.Rows[0][0].ToString() != "")
            {
                totalinderctincome.Text = dt.Rows[0][0].ToString();
                indirectincomecal = decimal.Parse(dt.Rows[0][0].ToString());//indirect income
            }
            else
            {
                totalinderctincome.Text = "0";
            }



            //credit sales




            decimal installmentpending = 0;

            DataTable dtfinancialfincpend = p.selectcompany();

            c.Financialyear = dtfinancialfincpend.Rows[0][7].ToString();


            DataTable dtinstpend = p.selectsumofcreditsales(c);
            if (dtinstpend.Rows.Count != 0 && dtinstpend.Rows[0][0].ToString() != "")
            {

                lblpendingincome.Text = dtinstpend.Rows[0][0].ToString();
                installmentpending = decimal.Parse(dtinstpend.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                lblpendingincome.Text = "0";
            }










            //====================== EXPENSE SIDE




            //sum of purchase
            // 

            decimal purchaseamountsum = 0;
            DataTable dtfinancialpurchase = p.selectcompany();

            c.Financialyear = dtfinancialpurchase.Rows[0][7].ToString();


            DataTable dtpurchase = p.selectsumpurchase(c);
            if (dtpurchase.Rows.Count != 0 && dtpurchase.Rows[0][0].ToString() != "")
            {
                totalpurchaseamuount.Text = dtpurchase.Rows[0][0].ToString();
                purchaseamountsum = decimal.Parse(dtpurchase.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                totalpurchaseamuount.Text = "0";
            }



            //sum installment purchase


            decimal installmentpurchase = 0;

            DataTable dtfinancialfincpurhcase = p.selectcompany();

            c.Financialyear = dtfinancialfincpurhcase.Rows[0][7].ToString();


            DataTable dtinstpurchase = p.selectsuminstallmentpurchase(c);
            if (dtinstpurchase.Rows.Count != 0 && dtinstpurchase.Rows[0][0].ToString() != "")
            {

                totalinstallmentpurchase.Text = dtinstpurchase.Rows[0][0].ToString();
                installmentpurchase = decimal.Parse(dtinstpurchase.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                totalinstallmentpurchase.Text = "0";
            }





            //expense sum other expense sum
            decimal indexrectexpncecal = 0;
            DataTable dtfinancials = p.selectcompany();

            c.Financialyear = dtfinancials.Rows[0][7].ToString();

            c.Typrofepnce = "Expense";
            DataTable dtss = p.selectsumincome(c);
            if (dtss.Rows.Count != 0 && dtss.Rows[0][0].ToString() != "")
            {
                otherexpensetext.Text = dtss.Rows[0][0].ToString();
                indexrectexpncecal = decimal.Parse(dtss.Rows[0][0].ToString());  //indirect expense
            }
            else
            {
                otherexpensetext.Text = "0";
            }





            //credit purchases




            decimal installmentcreditpurhcase = 0;

            DataTable dtfinancialfincpendcredt = p.selectcompany();

            c.Financialyear = dtfinancialfincpendcredt.Rows[0][7].ToString();


            DataTable dtinstpendcredt = p.selectsumofcreditpurchase(c);
            if (dtinstpendcredt.Rows.Count != 0 && dtinstpendcredt.Rows[0][0].ToString() != "")
            {

                lblpendingexpense.Text = dtinstpendcredt.Rows[0][0].ToString();
                installmentcreditpurhcase = decimal.Parse(dtinstpendcredt.Rows[0][0].ToString()); //total of installment



            }
            else
            {
                lblpendingexpense.Text = "0";
            }












            //total calculation

            decimal totalincome = saleamountsum + installment + indirectincomecal;

            totaldailyincome.Text = totalincome.ToString();


            decimal totalexpense = purchaseamountsum + installmentpurchase + indexrectexpncecal;

            totalexpence.Text = totalexpense.ToString();


            //profit
            decimal profit = (totalincome) - (totalexpense);
            if (profit < 0)
            {
                profitandloss.Text = (-profit) + " " + "Loss";
            }
            else
            {
                profitandloss.Text = (profit).ToString();
            }


            //pending profit



            decimal profitpending = (installmentpending) - (installmentcreditpurhcase);
            lbltotalpendingbalance.Text = profitpending.ToString();
            if (profitpending < 0)
            {
                lbltotalpendingbalance.Text = (-profitpending) + " " + "Loss";
            }
            else
            {
                lbltotalpendingbalance.Text = (profitpending).ToString();
            }
     
             


            }
            else
            {
                groupBox7.Visible = false;
                btnRefresh.Visible = false;
                groupBox4.Visible = false; groupBox3.Visible = false; btnsms.Visible = false;
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
           // DataTable dtview = p.selectcompanycustomerdetails();
            //TxtIncomeDescription.DataSource = dtview;
            //TxtIncomeDescription.ValueMember = "status";
            //TxtIncomeDescription.DisplayMember = "status";

        }

        private void txtexpensedescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtIncomeDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void FrmIncomeandexpenses_Load(object sender, EventArgs e)
        {

        }

        private void FrmIncomeandexpenses_Load_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin@123")
            {
                groupBox7.Visible = true;
                btnRefresh.Visible = true;
                groupBox4.Visible = true;

                groupBox3.Visible = true; btnsms.Visible = true;

                //sum of sale
                // 

                decimal saleamountsum = 0;
                DataTable dtfinancialssss = p.selectcompany();

                c.Financialyear = dtfinancialssss.Rows[0][7].ToString();


                DataTable dtsale = p.selectsumsale(c);
                if (dtsale.Rows.Count != 0 && dtsale.Rows[0][0].ToString() != "")
                {
                    txttotalsalesamount.Text = dtsale.Rows[0][0].ToString();
                    saleamountsum = decimal.Parse(dtsale.Rows[0][0].ToString()); // sum sale
                }
                else
                {
                    txttotalsalesamount.Text = "0";
                }




                //sum installment


                decimal installment = 0;

                DataTable dtfinancialfinc = p.selectcompany();

                c.Financialyear = dtfinancialfinc.Rows[0][7].ToString();


                DataTable dtinst = p.selectsuminstallment(c);
                if (dtinst.Rows.Count != 0 && dtinst.Rows[0][0].ToString() != "")
                {

                    totalinstallmenttextsale.Text = dtinst.Rows[0][0].ToString();
                    installment = decimal.Parse(dtinst.Rows[0][0].ToString()); //total of installment



                }
                else
                {
                    totalinstallmenttextsale.Text = "0";
                }




                //incomesum other income sum


                decimal indirectincomecal = 0;

                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();

                c.Typrofepnce = "Income";
                DataTable dt = p.selectsumincome(c);
                if (dt.Rows.Count != 0 && dt.Rows[0][0].ToString() != "")
                {
                    totalinderctincome.Text = dt.Rows[0][0].ToString();
                    indirectincomecal = decimal.Parse(dt.Rows[0][0].ToString());//indirect income
                }
                else
                {
                    totalinderctincome.Text = "0";
                }



                //credit sales




                decimal installmentpending = 0;

                DataTable dtfinancialfincpend = p.selectcompany();

                c.Financialyear = dtfinancialfincpend.Rows[0][7].ToString();


                DataTable dtinstpend = p.selectsumofcreditsales(c);
                if (dtinstpend.Rows.Count != 0 && dtinstpend.Rows[0][0].ToString() != "")
                {

                    lblpendingincome.Text = dtinstpend.Rows[0][0].ToString();
                    installmentpending = decimal.Parse(dtinstpend.Rows[0][0].ToString()); //total of installment



                }
                else
                {
                    lblpendingincome.Text = "0";
                }










                //====================== EXPENSE SIDE




                //sum of purchase
                // 

                decimal purchaseamountsum = 0;
                DataTable dtfinancialpurchase = p.selectcompany();

                c.Financialyear = dtfinancialpurchase.Rows[0][7].ToString();


                DataTable dtpurchase = p.selectsumpurchase(c);
                if (dtpurchase.Rows.Count != 0 && dtpurchase.Rows[0][0].ToString() != "")
                {
                    totalpurchaseamuount.Text = dtpurchase.Rows[0][0].ToString();
                    purchaseamountsum = decimal.Parse(dtpurchase.Rows[0][0].ToString()); // sum sale
                }
                else
                {
                    totalpurchaseamuount.Text = "0";
                }



                //sum installment purchase


                decimal installmentpurchase = 0;

                DataTable dtfinancialfincpurhcase = p.selectcompany();

                c.Financialyear = dtfinancialfincpurhcase.Rows[0][7].ToString();


                DataTable dtinstpurchase = p.selectsuminstallmentpurchase(c);
                if (dtinstpurchase.Rows.Count != 0 && dtinstpurchase.Rows[0][0].ToString() != "")
                {

                    totalinstallmentpurchase.Text = dtinstpurchase.Rows[0][0].ToString();
                    installmentpurchase = decimal.Parse(dtinstpurchase.Rows[0][0].ToString()); //total of installment



                }
                else
                {
                    totalinstallmentpurchase.Text = "0";
                }





                //expense sum other expense sum
                decimal indexrectexpncecal = 0;
                DataTable dtfinancials = p.selectcompany();

                c.Financialyear = dtfinancials.Rows[0][7].ToString();

                c.Typrofepnce = "Expense";
                DataTable dtss = p.selectsumincome(c);
                if (dtss.Rows.Count != 0 && dtss.Rows[0][0].ToString() != "")
                {
                    otherexpensetext.Text = dtss.Rows[0][0].ToString();
                    indexrectexpncecal = decimal.Parse(dtss.Rows[0][0].ToString());  //indirect expense
                }
                else
                {
                    otherexpensetext.Text = "0";
                }





                //credit purchases




                decimal installmentcreditpurhcase = 0;

                DataTable dtfinancialfincpendcredt = p.selectcompany();

                c.Financialyear = dtfinancialfincpendcredt.Rows[0][7].ToString();


                DataTable dtinstpendcredt = p.selectsumofcreditpurchase(c);
                if (dtinstpendcredt.Rows.Count != 0 && dtinstpendcredt.Rows[0][0].ToString() != "")
                {

                    lblpendingexpense.Text = dtinstpendcredt.Rows[0][0].ToString();
                    installmentcreditpurhcase = decimal.Parse(dtinstpendcredt.Rows[0][0].ToString()); //total of installment



                }
                else
                {
                    lblpendingexpense.Text = "0";
                }












                //total calculation

                decimal totalincome = saleamountsum + installment + indirectincomecal;

                totaldailyincome.Text = totalincome.ToString();


                decimal totalexpense = purchaseamountsum + installmentpurchase + indexrectexpncecal;

                totalexpence.Text = totalexpense.ToString();


                //profit
                decimal profit = (totalincome) - (totalexpense);
                if (profit < 0)
                {
                    profitandloss.Text = (-profit) + " " + "Loss";
                }
                else
                {
                    profitandloss.Text = (profit).ToString();
                }


                //pending profit



                decimal profitpending = (installmentpending) - (installmentcreditpurhcase);
                lbltotalpendingbalance.Text = profitpending.ToString();
                if (profitpending < 0)
                {
                    lbltotalpendingbalance.Text = (-profitpending) + " " + "Loss";
                }
                else
                {
                    lbltotalpendingbalance.Text = (profitpending).ToString();
                }




            }
            else
            {
                groupBox7.Visible = false;
                btnRefresh.Visible = false;
                groupBox4.Visible = false; groupBox3.Visible = false; btnsms.Visible = false;
            }
        }

        private void btnviewincome_Click(object sender, EventArgs e)
        {
            FrmAddMasters f = new FrmAddMasters();
            f.ShowDialog();
        }

        private void btnviewexpense_Click(object sender, EventArgs e)
        {
            FrmSupplier f = new FrmSupplier();
            f.ShowDialog();
        }

        private void btnsms_Click(object sender, EventArgs e)
        {


            //sum of sale


            DataTable dtfinancialssss = p.selectcompany();

            c.Financialyear = dtfinancialssss.Rows[0][7].ToString();


            DateTime datefromsale = DateTime.Parse(dtmfrom.Text);
            var shortDatefromsale = datefromsale.ToString("yyyy-MM-dd");


            DateTime datetosales = DateTime.Parse(dtmto.Text);
            var shortDatetosale = datetosales.ToString("yyyy-MM-dd");




            c.Collcndatefrom = DateTime.Parse(shortDatefromsale.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetosale.ToString());
            decimal saleamountsum = 0;
            DataTable dtsale = p.selectsumsaleinbetweendates(c);

            if (dtsale.Rows.Count != 0 && dtsale.Rows[0][0].ToString() != "")
            {
                txttotalsalesamount.Text = dtsale.Rows[0][0].ToString();
                saleamountsum = decimal.Parse(dtsale.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                txttotalsalesamount.Text = "0";
            }



            //


            //sum installment


            DataTable dtfinancialfinc = p.selectcompany();//   cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            c.Financialyear = dtfinancialfinc.Rows[0][7].ToString();

            DateTime datefroinstallment = DateTime.Parse(dtmfrom.Text);
            var shortDatefrominstallment = datefroinstallment.ToString("yyyy-MM-dd");


            DateTime datetoinstallment = DateTime.Parse(dtmto.Text);
            var shortDatetoinstallment = datetoinstallment.ToString("yyyy-MM-dd");


            decimal installment = 0;
            c.Collcndatefrom = DateTime.Parse(shortDatefrominstallment.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoinstallment.ToString());
            //  c.Branch = cmbbranch.Text;

            DataTable dtinst = p.selectsuminstallmentsearch(c);
            if (dtinst.Rows.Count != 0 && dtinst.Rows[0][0].ToString() != "")
            {
                installment = decimal.Parse(dtinst.Rows[0][0].ToString()); //total of installment
                totalinstallmenttextsale.Text = dtinst.Rows[0][0].ToString();


            }
            else
            {
                totalinstallmenttextsale.Text = "0";
            }







            //incomesum




            DataTable dtfinancial = p.selectcompany();


            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Income";


            DateTime datefrom = DateTime.Parse(dtmfrom.Text);
            var shortDatefrom = datefrom.ToString("yyyy-MM-dd 00:00:00");

            DateTime dateto = DateTime.Parse(dtmto.Text);
            var shortDateto = dateto.ToString("yyyy-MM-dd 00:00:00");



            c.Collcndatefrom = DateTime.Parse(shortDatefrom.ToString());
            c.Collcndateto = DateTime.Parse(shortDateto.ToString());
            //  c.Branch = cmbbranch.Text;
            decimal indirectincomecal = 0;
            DataTable dt = p.selectsumincomedate(c);
            if (dt.Rows.Count != 0 && dt.Rows[0][0].ToString() != "")
            {
                totalinderctincome.Text = dt.Rows[0][0].ToString();
                indirectincomecal = decimal.Parse(dt.Rows[0][0].ToString());//indirect income
            }
            else
            {
                totalinderctincome.Text = "0";
            }



            //===========EXPENSE SECTION==========



            //sum of purchase


            DataTable dtfinancialpurch = p.selectcompany();

            c.Financialyear = dtfinancialpurch.Rows[0][7].ToString();


            DateTime datefrompurchase = DateTime.Parse(dtmfrom.Text);
            var shortDatefrompurchase = datefrompurchase.ToString("yyyy-MM-dd");


            DateTime datetopurchase = DateTime.Parse(dtmto.Text);
            var shortDatetopurchase = datetopurchase.ToString("yyyy-MM-dd");




            c.Collcndatefrom = DateTime.Parse(shortDatefrompurchase.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetopurchase.ToString());
            decimal purchaseamountsum = 0;
            DataTable dtpurchase = p.selectsumpurchaseinbetweendates(c);

            if (dtpurchase.Rows.Count != 0 && dtpurchase.Rows[0][0].ToString() != "")
            {
                totalpurchaseamuount.Text = dtpurchase.Rows[0][0].ToString();
                purchaseamountsum = decimal.Parse(dtpurchase.Rows[0][0].ToString()); // sum sale
            }
            else
            {
                totalpurchaseamuount.Text = "0";
            }


            //sum installment supplier


            DataTable dtfinancialfincpurchase = p.selectcompany();//   cmd.CommandText = "select sum(amount) from  tblincomeandexpenses where financialyear=@financialyear and incomeorexpense=@incomeorexpense and description=@description and dateof>=@collectiondatefrom and dateof<=@collectiondateto";


            c.Financialyear = dtfinancialfincpurchase.Rows[0][7].ToString();

            DateTime datefroinstallmentpurch = DateTime.Parse(dtmfrom.Text);
            var shortDatefrominstallmentpurch = datefroinstallmentpurch.ToString("yyyy-MM-dd");


            DateTime datetoinstallmentpurch = DateTime.Parse(dtmto.Text);
            var shortDatetoinstallmentpurchase = datetoinstallmentpurch.ToString("yyyy-MM-dd");


            decimal installmentpurchase = 0;
            c.Collcndatefrom = DateTime.Parse(shortDatefrominstallment.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoinstallment.ToString());
            //  c.Branch = cmbbranch.Text;

            DataTable dtinstsupp = p.selectsuminstallmentsearchsupplier(c);
            if (dtinstsupp.Rows.Count != 0 && dtinstsupp.Rows[0][0].ToString() != "")
            {
                installmentpurchase = decimal.Parse(dtinstsupp.Rows[0][0].ToString()); //total of installment
                totalinstallmentpurchase.Text = dtinstsupp.Rows[0][0].ToString();


            }
            else
            {
                totalinstallmentpurchase.Text = "0";
            }





            //sum of expense


            DataTable dtfinancials = p.selectcompany();


            DateTime datefromexpns = DateTime.Parse(dtmfrom.Text);
            var shortDatefromexpns = datefromexpns.ToString("yyyy-MM-dd 00:00:00");

            DateTime datetoexpns = DateTime.Parse(dtmto.Text);
            var shortDatetoexpns = datetoexpns.ToString("yyyy-MM-dd 00:00:00");


            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            c.Typrofepnce = "Expense";

            c.Collcndatefrom = DateTime.Parse(shortDatefromexpns.ToString());
            c.Collcndateto = DateTime.Parse(shortDatetoexpns.ToString());
            decimal indexrectexpncecal = 0;

            DataTable dtexpns = p.selectexpensewisedate(c);
            if (dtexpns.Rows.Count != 0 && dtexpns.Rows[0][0].ToString() != "")
            {
                otherexpensetext.Text = dtexpns.Rows[0][0].ToString();
                indexrectexpncecal = decimal.Parse(dtexpns.Rows[0][0].ToString());//indirect income
            }
            else
            {
                otherexpensetext.Text = "0";
            }







            //TOTAL CALCULATIONS

            decimal TOTALINCOME = saleamountsum + installment + indirectincomecal;

            totaldailyincome.Text = TOTALINCOME.ToString(); //TOTAL INCOME

            decimal TOTALEXPENSE = purchaseamountsum + installmentpurchase + indexrectexpncecal;

            totalexpence.Text = TOTALEXPENSE.ToString();





            decimal profit = (TOTALINCOME) - (TOTALEXPENSE);
            if (profit < 0)
            {
                profitandloss.Text = (-profit) + " " + "Loss";
            }
            else
            {
                profitandloss.Text = (profit).ToString();
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //sms send
            
            
            
            fromdate = dtmfrom.Text;
            todate = dtmto.Text;
            totalsale = txttotalsalesamount.Text;
            totalinstallment = totalinstallmenttextsale.Text;
            totalotherincome = totalinderctincome.Text;

            totalpurchase = totalpurchaseamuount.Text;

            totalinstallmentpaid = totalinstallmentpurchase.Text;

            totalotherexpense = otherexpensetext.Text;

            totalincome = totaldailyincome.Text;

            totalexpense = totalexpence.Text;
            profitsend = profitandloss.Text;


            FrmSMSAccounts f = new FrmSMSAccounts();
            f.ShowDialog();



        }

     
    }

      
}
