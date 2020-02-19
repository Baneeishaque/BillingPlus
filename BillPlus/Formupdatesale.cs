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
    public partial class Formupdatesale : Form
    {
        public Formupdatesale()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass(); 
        int i;
      
        private void paidtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void paidtext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nettotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void nettotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void grandtotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dicounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dicounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {

        }

        private void totalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalamount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void prize_TextChanged(object sender, EventArgs e)
        {

        }

        private void prize_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void prize_Leave(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void quantity_Leave(object sender, EventArgs e)
        {

        }

        private void savepurchase_Click(object sender, EventArgs e)
        {

        }

        private void txtpaymentmode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productname_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void productname_Leave(object sender, EventArgs e)
        {

        }

        private void productcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productcode_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void productcode_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void productcode_Leave(object sender, EventArgs e)
        {

        }

        private void SalesNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Formupdatesale_Load(object sender, EventArgs e)
        {

            //load
            DataTable dtp = p.SelectProductdetails();
            productcode.DataSource = dtp;
            productcode.ValueMember = "productcode";
            productcode.DisplayMember = "productcode";


            productname.DataSource = dtp;
            productname.ValueMember = "productcode";
            productname.DisplayMember = "productname";







            int saled = FrmSalesVoucher.salenosend;
                c.Salesno=saled;


                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();


                  DataTable dt= p.Selecsaledetailforupdation( c);

                  dgvsales.AutoGenerateColumns = false;
                  dgvsales.DataSource = dt;




                  SalesNo.Text = saled.ToString();
            
                  CustomerNames.Text=     dt.Rows[0][2].ToString();

               SalesDate.Text=dt.Rows[0][3].ToString();
                 
             txtpaymentmode.Text=dt.Rows[0][11].ToString();

                
           narrrations.Text=dt.Rows[0][13].ToString();
       balance.Text=dt.Rows[0][14].ToString();
              
             grandtotal.Text=dt.Rows[0][16].ToString();
              dicounttxt.Text=dt.Rows[0][17].ToString();
                nettotal.Text=dt.Rows[0][18].ToString();
                paidtext.Text =  dt.Rows[0][19].ToString();




                checkBoxWholeSale.Checked = false; ;



        }

        private void btnaddproducttogrid_Click_1(object sender, EventArgs e)
        {

            if (productcode.Text == "" || productname.Text == "" || quantity.Text == "" || prize.Text == "" || txtdiscount.Text == "" || totalamount.Text == "")
            {
                if (productcode.Text == "")
                {
                    errorProvider1.SetError(productcode, "Required field ");

                }


                if (productname.Text == "")
                {
                    errorProvider1.SetError(productname, "Required field ");
                }

                if (quantity.Text == "")
                {
                    errorProvider1.SetError(quantity, "Required field ");
                }
                if (prize.Text == "")
                {
                    errorProvider1.SetError(prize, "Required field ");
                }
                if (txtdiscount.Text == "")
                {
                    errorProvider1.SetError(txtdiscount, "Required field ");
                }
                if (totalamount.Text == "")
                {
                    errorProvider1.SetError(totalamount, "Required field ");
                }



            }
            else
            {



                //check product exsist or not

                //c.Productcode = productcode.Text; 

                //DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                //if (dtprdctcodecheck.Rows.Count == 1)
                //{
                //lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();
                //prize.Text = dtprdctcodecheck.Rows[0][4].ToString();

                if (btnaddproducttogrid.Text == "+")
                {

                    //int n = dgvsales.Rows.Add();
                    //dgvsales.Rows[n].Cells[0].Value = productcode.Text;
                    //dgvsales.Rows[n].Cells[1].Value = productname.Text;
                    //dgvsales.Rows[n].Cells[2].Value = quantity.Text;
                    //dgvsales.Rows[n].Cells[3].Value = lblunit.Text;
                    //dgvsales.Rows[n].Cells[4].Value = prize.Text;
                    //dgvsales.Rows[n].Cells[5].Value = txtdiscount.Text;
                    //dgvsales.Rows[n].Cells[6].Value = totalamount.Text;



                    c.Salesno = int.Parse(SalesNo.Text);
                    c.Id = 1;
                    c.Customer = CustomerNames.Text;

                    c.Salesdate = DateTime.Parse(SalesDate.Text);
                    c.Productcode = productcode.Text;
                    c.Productname = productname.Text;
                    
                    c.Quantity = float.Parse( quantity.Text);
                    c.Unit = lblunit.Text;

                    c.Price = decimal.Parse( prize.Text);
                    c.Discount = decimal.Parse(txtdiscount.Text);
                    c.Total = decimal.Parse(totalamount.Text);
                    c.Paymentmode = txtpaymentmode.Text;

                    DataTable dtfinancial = p.selectcompany();

                    c.Financialyear = dtfinancial.Rows[0][7].ToString();
                    c.Narration = narrrations.Text;
                    c.Balance = decimal.Parse(balance.Text);
                    c.Status = "";

                    if (grandtotal.Text == "")
                    {
                        c.Grandtotal = 0;
                    }

                    else
                    {
                        c.Grandtotal = decimal.Parse(grandtotal.Text);
                    }

                    if (dicounttxt.Text == "")
                    {
                        c.Discounttotal = 0;
                    }

                    else
                    {
                        c.Discounttotal = decimal.Parse(dicounttxt.Text);
                    }


                    if (nettotal.Text == "")
                    {
                        c.Nettotal = 0;
                    }

                    else
                    {
                        c.Nettotal = decimal.Parse(nettotal.Text);
                    }

                    if (paidtext.Text == "")
                    {
                        c.Paid = 0;
                    }

                    else
                    {
                        c.Paid = decimal.Parse(paidtext.Text);
                    }

                    p.insrtintosalesvoucher(c);


                    //refreshgrid
                    int saled = FrmSalesVoucher.salenosend;
                    c.Salesno = saled;
                    DataTable dtfinancials = p.selectcompany();
                    c.Financialyear = dtfinancials.Rows[0][7].ToString();
                    DataTable dt = p.Selecsaledetailforupdation(c);
                    dgvsales.AutoGenerateColumns = false;
                    dgvsales.DataSource = dt;



                    //calculations


                    quantity.Text = "1";
                    txtdiscount.Text = "0";

                    paidtext.Text = "";

                    decimal sum = 0;
                    for (int i = 0; i < dgvsales.Rows.Count; i++)
                    {
                        if (dgvsales.Rows[i].Cells[6].Value != null)
                        {
                            sum += Convert.ToDecimal(dgvsales.Rows[i].Cells[6].Value);
                        }
                    }
                    grandtotal.Text = sum.ToString();


                    //net total
                    if (dicounttxt.Text != "" && grandtotal.Text != "")
                    {

                        decimal grndtot = decimal.Parse(grandtotal.Text);
                        decimal discnt = decimal.Parse(dicounttxt.Text);

                        if (discnt <= 100)
                        {

                            decimal dicountamount = ((discnt * grndtot) / 100);

                            decimal nettot = grndtot - dicountamount;

                            nettotal.Text = nettot.ToString();
                            balance.Text = nettot.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Discount can't greater than 100%", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                            nettotal.Text = "";
                            dicounttxt.Text = "";
                            paidtext.Text = "";
                            quantity.Text = "1";
                            balance.Text = "00.00"; txtdiscount.Text = "0";
                        }
                    }
                    else
                    {
                        nettotal.Text = "";
                        dicounttxt.Text = "";
                        paidtext.Text = "";
                        balance.Text = "00.00";
                        quantity.Text = "1"; txtdiscount.Text = "0";
                    }





                    // CLEAR AFTER ADDING TO GRID

                    quantity.Text = "1";
                    prize.Text = "";
                    txtdiscount.Text = "0";
                    lblunit.Text = "Unit";
                    totalamount.Text = "";
                    //productcode.Text = "";
                    //productname.Text = "";

                    if (balance.Text == "0")
                    {
                        balance.Text = "00.00";
                    }
                    btnaddproducttogrid.Text = "+";


                }   //IF BUTTON TEXT U

                else
                {
                    // if button text=u





                    DataGridViewRow row = dgvsales.Rows[i];
                    row.Cells[0].Value = productcode.Text;
                    row.Cells[1].Value = productname.Text;
                    row.Cells[2].Value = quantity.Text;
                    row.Cells[3].Value = lblunit.Text;
                    row.Cells[4].Value = prize.Text;
                    row.Cells[5].Value = txtdiscount.Text;
                    row.Cells[6].Value = totalamount.Text;
                    btnaddproducttogrid.Text = "+";

                    quantity.Text = "1";
                    txtdiscount.Text = "0";

                    paidtext.Text = "";

                    decimal sum = 0;
                    for (int j = 0; j < dgvsales.Rows.Count; j++)
                    {
                        if (dgvsales.Rows[j].Cells[6].Value != null)
                        {
                            sum += Convert.ToDecimal(dgvsales.Rows[j].Cells[6].Value);
                        }
                    }
                    grandtotal.Text = sum.ToString();


                    //net total
                    if (dicounttxt.Text != "" && grandtotal.Text != "")
                    {

                        decimal grndtot = decimal.Parse(grandtotal.Text);
                        decimal discnt = decimal.Parse(dicounttxt.Text);

                        if (discnt <= 100)
                        {

                            decimal dicountamount = ((discnt * grndtot) / 100);

                            decimal nettot = grndtot - dicountamount;

                            nettotal.Text = nettot.ToString();
                            balance.Text = nettot.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Discount can't greater than 100%", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                            nettotal.Text = "";
                            dicounttxt.Text = "";
                            paidtext.Text = "";
                            quantity.Text = "1";
                            balance.Text = "00.00"; txtdiscount.Text = "0";
                        }
                    }
                    else
                    {
                        nettotal.Text = "";
                        dicounttxt.Text = "";
                        paidtext.Text = "";
                        balance.Text = "00.00";
                        quantity.Text = "1"; txtdiscount.Text = "0";
                    }





                    // CLEAR AFTER ADDING TO GRID

                    quantity.Text = "1";
                    prize.Text = "";
                    txtdiscount.Text = "0";
                    lblunit.Text = "Unit";
                    totalamount.Text = "";

                    if (balance.Text == "0")
                    {
                        balance.Text = "00.00";
                    }

                    btnaddproducttogrid.Text = "+";


                }


            }


    }

        private void txtdiscount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void totalamount_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void prize_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void quantity_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void SalesNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void productcode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            c.Productcode = productcode.Text;
            DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

            if (dtprdctcodecheck.Rows.Count == 1)
            {
                lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();
                if (checkBoxWholeSale.Checked == false)
                {

                    prize.Text = dtprdctcodecheck.Rows[0][4].ToString();
                }
                else
                {
                    prize.Text = dtprdctcodecheck.Rows[0][3].ToString();
                }
            }
        }

        private void productname_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            c.Productcode = productcode.Text;
            DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

            if (dtprdctcodecheck.Rows.Count == 1)
            {
                lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();
                if (checkBoxWholeSale.Checked == false)
                {

                    prize.Text = dtprdctcodecheck.Rows[0][4].ToString();
                }
                else
                {
                    prize.Text = dtprdctcodecheck.Rows[0][3].ToString();
                }
            }
        }

        private void productname_Leave_1(object sender, EventArgs e)
        {
            c.Productcode = productcode.Text;
            DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

            if (dtprdctcodecheck.Rows.Count == 1)
            {
                lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();
                if (checkBoxWholeSale.Checked == false)
                {

                    prize.Text = dtprdctcodecheck.Rows[0][4].ToString();
                }
                else
                {
                    prize.Text = dtprdctcodecheck.Rows[0][3].ToString();
                }
            }
        }

        private void productcode_Leave_1(object sender, EventArgs e)
        {
            c.Productcode = productcode.Text;
            DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

            if (dtprdctcodecheck.Rows.Count == 1)
            {
                lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();
                if (checkBoxWholeSale.Checked == false)
                {

                    prize.Text = dtprdctcodecheck.Rows[0][4].ToString();
                }
                else
                {
                    prize.Text = dtprdctcodecheck.Rows[0][3].ToString();
                }
            }
        }

        private void quantity_TextChanged_1(object sender, EventArgs e)
        {


            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                decimal qnty = decimal.Parse(quantity.Text);
                decimal price = decimal.Parse(prize.Text);
                decimal dicnt = decimal.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                decimal qntyprice = qnty * price;


                decimal discoutnamount = ((dicnt * qntyprice) / 100);


                decimal total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void prize_TextChanged_1(object sender, EventArgs e)
        {
            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                decimal qnty = decimal.Parse(quantity.Text);
                decimal price = decimal.Parse(prize.Text);
                decimal dicnt = decimal.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                decimal qntyprice = qnty * price;


                decimal discoutnamount = ((dicnt * qntyprice) / 100);


                decimal total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void txtdiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                decimal qnty = decimal.Parse(quantity.Text);
                decimal price = decimal.Parse(prize.Text);
                decimal dicnt = decimal.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                decimal qntyprice = qnty * price;


                decimal discoutnamount = ((dicnt * qntyprice) / 100);


                decimal total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void dicounttxt_TextChanged_1(object sender, EventArgs e)
        {
            if (dicounttxt.Text != "" && grandtotal.Text != "")
            {

                decimal grndtot = decimal.Parse(grandtotal.Text);
                decimal discnt = decimal.Parse(dicounttxt.Text);

                if (discnt <= 100)
                {

                    decimal dicountamount = ((discnt * grndtot) / 100);

                    decimal nettot = grndtot - dicountamount;

                    nettotal.Text = nettot.ToString();


                    balance.Text = nettot.ToString();
                }
                else
                {
                    MessageBox.Show("Discount can't greater than 100%", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    nettotal.Text = "";
                    dicounttxt.Text = "";
                    paidtext.Text = "";
                    balance.Text = grandtotal.Text;
                }
            }
            else
            {
                nettotal.Text = "";
                dicounttxt.Text = "";
                paidtext.Text = "";
                balance.Text = grandtotal.Text;
            }

            if (balance.Text == "0")
            {
                balance.Text = "00.00";
            }
        }

        private void nettotal_TextChanged_1(object sender, EventArgs e)
        {
            if (nettotal.Text != "")
            {
                decimal nettot = decimal.Parse(nettotal.Text);
                balance.Text = nettotal.Text;

                paidtext.ReadOnly = false;
            }
            else
            {
                balance.Text = grandtotal.Text;
                paidtext.ReadOnly = true;
                paidtext.Text = "";
            }
            if (balance.Text == "0")
            {
                balance.Text = "00.00";
            }
        }

        private void paidtext_TextChanged_1(object sender, EventArgs e)
        {
            if (nettotal.Text != "" && paidtext.Text != "")
            {
                decimal nettot = decimal.Parse(nettotal.Text);
                decimal paid = decimal.Parse(paidtext.Text);
                decimal balnce = nettot - paid;
                if (balnce < 0)
                {
                    MessageBox.Show("Cannot pay more than total amount", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    balance.Text = nettotal.Text;
                    paidtext.Text = "";

                }
                else
                {
                    balance.Text = balnce.ToString();

                }

            }

            else
            {
                balance.Text = nettotal.Text;
            }

            if (balance.Text == "0")
            {
                balance.Text = "00.00";
            }
        }

        private void dicounttxt_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void nettotal_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void paidtext_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {






          
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this sale?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something


                    //============delete


                    //belw code find the customer
                    int saled = int.Parse(SalesNo.Text);
                    c.Salesno = saled;

                    DataTable dtfinancialyr = p.selectcompany();

                    c.Financialyear = dtfinancialyr.Rows[0][7].ToString();

                    DataTable customerdetailsusingsalesno = p.Selecsaledetailforupdation(c);

                    //update credit customer balance amunt before delete
                    if (customerdetailsusingsalesno.Rows[0][11].ToString() == "Credit") //old sale is a credit
                    {

                        c.Username = customerdetailsusingsalesno.Rows[0][2].ToString();
                        DataTable selectcustomerfrommaster = p.selectcustomerbynamesvalidaion(c);
                        if (selectcustomerfrommaster.Rows.Count > 0)
                        {
                            decimal totalbalancefromthiscustomernowinmaster = decimal.Parse(selectcustomerfrommaster.Rows[0][6].ToString()); //total balance

                            //if(user paying now > old - else +) do the same in delete

                            //
                            decimal paidnow = decimal.Parse(paidtext.Text);
                            decimal paidbefore = decimal.Parse(customerdetailsusingsalesno.Rows[0][19].ToString());
                            decimal oldbalance = decimal.Parse(customerdetailsusingsalesno.Rows[0][14].ToString());




                            decimal balnceinthispurchse = totalbalancefromthiscustomernowinmaster - oldbalance;

                            c.Username = customerdetailsusingsalesno.Rows[0][2].ToString();
                            c.Startingamount = balnceinthispurchse;
                            p.updteMasteronsales(c);
                        }
                    }





                    //======update stock

                    for (int i = 0; i < dgvsales.Rows.Count; i++)
                    {

                        c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();

                        DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                        float currentstock = float.Parse(dtprdctcodecheck.Rows[0][9].ToString());
                        float qntiy = float.Parse(dgvsales.Rows[i].Cells[2].Value.ToString());

                        float stockafterthissale = currentstock + qntiy;

                        //update stock
                        c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();
                        c.Productname = dgvsales.Rows[i].Cells[1].Value.ToString();

                        if (stockafterthissale < 0)
                        {
                            c.Stockstrt = 0;
                        }
                        else
                        {

                            c.Stockstrt = stockafterthissale;
                        }
                        p.updatestockonsale(c);


                    }


                    //====delete sales

                    c.Salesno = int.Parse(SalesNo.Text);
                    p.deleteisales(c);














                    MessageBox.Show("Transaction deleted succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    // ==================-----update student registration----------------====================//

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    
                }

          
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {






            errorProvider1.Clear();
            //validation for credit cusotmer exist or not

            c.Username = CustomerNames.Text;
            DataTable dtvalidationname = p.selectcustomerbynamesvalidaion(c);


            decimal balndisplying = decimal.Parse(balance.Text);
            if (dgvsales.Rows.Count == 0 || grandtotal.Text == "" || dicounttxt.Text == "" || nettotal.Text == "" || paidtext.Text == "" || (txtpaymentmode.Text == "Cash" && balndisplying != 0) || (txtpaymentmode.Text == "Credit" && dtvalidationname.Rows.Count == 0))
            {

                if (txtpaymentmode.Text == "Cash" && balndisplying != 0)
                {
                    MessageBox.Show("Cash customer's balance amount must be zero", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
                if ((txtpaymentmode.Text == "Credit" && dtvalidationname.Rows.Count == 0))
                {
                    MessageBox.Show("Please select a valid customer", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
                if (dgvsales.Rows.Count == 0)
                {
                    errorProvider1.SetError(dgvsales, "Can't be Null");
                }

                if (grandtotal.Text == "")
                {

                    errorProvider1.SetError(grandtotal, "Can't be Null");
                }

                if (dicounttxt.Text == "")
                {

                    errorProvider1.SetError(dicounttxt, "Can't be Null");
                }

                if (nettotal.Text == "")
                {

                    errorProvider1.SetError(nettotal, "Can't be Null");
                }

                if (paidtext.Text == "")
                {

                    errorProvider1.SetError(paidtext, "Can't be Null");
                }
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Update transaction for the customer '" + CustomerNames.Text + "' with Amount Rs '" + paidtext.Text + "' ?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {

                    //============delete


                        //belw code find the customer
                        int saled =int.Parse( SalesNo.Text);
                        c.Salesno = saled;

                        DataTable dtfinancialyr = p.selectcompany();

                        c.Financialyear = dtfinancialyr.Rows[0][7].ToString();

                        DataTable customerdetailsusingsalesno = p.Selecsaledetailforupdation(c);
                    
                    //update credit customer balance amunt before delete
                        if (customerdetailsusingsalesno.Rows[0][11].ToString() == "Credit") //old sale is a credit
                    {

                        c.Username = customerdetailsusingsalesno.Rows[0][2].ToString();
                        DataTable selectcustomerfrommaster = p.selectcustomerbynamesvalidaion(c);
                        if (selectcustomerfrommaster.Rows.Count > 0)
                        {
                            decimal totalbalancefromthiscustomernowinmaster = decimal.Parse(selectcustomerfrommaster.Rows[0][6].ToString()); //total balance

                            //if(user paying now > old - else +) do the same in delete

                            //
                            decimal paidnow = decimal.Parse(paidtext.Text);
                            decimal paidbefore = decimal.Parse(customerdetailsusingsalesno.Rows[0][19].ToString());
                            decimal oldbalance = decimal.Parse(customerdetailsusingsalesno.Rows[0][14].ToString());




                            decimal balnceinthispurchse = totalbalancefromthiscustomernowinmaster - oldbalance;

                            c.Username = customerdetailsusingsalesno.Rows[0][2].ToString();
                            c.Startingamount = balnceinthispurchse;
                            p.updteMasteronsales(c);
                        }
                    }


                    c.Salesno = int.Parse(SalesNo.Text);
                    p.deleteisales(c);




                    //=========insert



                    for (int i = 0; i < dgvsales.Rows.Count; i++)
                    {



                        c.Salesno = int.Parse(SalesNo.Text);
                        c.Id = dgvsales.CurrentCell.RowIndex; 
                        c.Customer = CustomerNames.Text;

                        c.Salesdate = DateTime.Parse(SalesDate.Text);
                        c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();
                        c.Productname = dgvsales.Rows[i].Cells[1].Value.ToString();
                        c.Quantity = float.Parse(dgvsales.Rows[i].Cells[2].Value.ToString());
                        c.Unit = dgvsales.Rows[i].Cells[3].Value.ToString();

                        c.Price = decimal.Parse(dgvsales.Rows[i].Cells[4].Value.ToString());
                        c.Discount = decimal.Parse(dgvsales.Rows[i].Cells[5].Value.ToString());
                        c.Total = decimal.Parse(dgvsales.Rows[i].Cells[6].Value.ToString());
                        c.Paymentmode = txtpaymentmode.Text;

                        DataTable dtfinancial = p.selectcompany();

                        c.Financialyear = dtfinancial.Rows[0][7].ToString();
                        c.Narration = narrrations.Text;
                        c.Balance = decimal.Parse(balance.Text);
                        c.Status = "";
                        c.Grandtotal = decimal.Parse(grandtotal.Text);
                        c.Discounttotal = decimal.Parse(dicounttxt.Text);
                        c.Nettotal = decimal.Parse(nettotal.Text);
                        c.Paid = decimal.Parse(paidtext.Text);
                        p.insrtintosalesvoucher(c);



                        // Stock 

                        //c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();

                        //DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                        //float currentstock = float.Parse(dtprdctcodecheck.Rows[0][9].ToString());
                        //float qntiy = float.Parse(dgvsales.Rows[i].Cells[2].Value.ToString());

                        //float stockafterthissale = currentstock - qntiy;

                        ////update stock
                        //c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();
                        //c.Productname = dgvsales.Rows[i].Cells[1].Value.ToString();

                        //if (stockafterthissale < 0)
                        //{
                        //    c.Stockstrt = 0;
                        //}
                        //else
                        //{

                        //    c.Stockstrt = stockafterthissale;
                        //}
                        //p.updatestockonsale(c);


                    }




                    //update credit customer balance amunt 
                    if (txtpaymentmode.Text == "Credit")
                    {

                        c.Username = CustomerNames.Text;
                        DataTable updatecresitbalance = p.selectcustomerbynamesvalidaion(c);
                        if (updatecresitbalance.Rows.Count > 0)
                        {
                            decimal currentbalcne = decimal.Parse(updatecresitbalance.Rows[0][6].ToString());
                            decimal balnceinthispurchse = currentbalcne + decimal.Parse(balance.Text);

                            c.Username = CustomerNames.Text;
                            c.Startingamount = balnceinthispurchse;
                            p.updteMasteronsales(c);
                        }
                    }





                    //print

                    DataSetSalesinvoice ds = new DataSetSalesinvoice();
                    DataTable dt = ds.Tables["DataTablesalesbill"];




                    foreach (DataGridViewRow dgr in dgvsales.Rows)
                    {
                        //  dt.Rows.Add(lbl_admission_no.Text, lbl_name_of_student.Text, lbl_class.Text, lbl_div.Text, dgr.Cells[0].Value, dgr.Cells[1].Value, total_fee_collcns, dgr.Cells[2].Value, billnumbers, dtm_fee_collection_date.Text, lbl_total_fee.Text, lbl_balance.Text);
                        dt.Rows.Add(SalesNo.Text, CustomerNames.Text, SalesDate.Text, dgr.Index + 1, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), dgr.Cells[3].Value.ToString(), dgr.Cells[4].Value.ToString(), dgr.Cells[5].Value.ToString(), dgr.Cells[6].Value.ToString(), txtpaymentmode.Text, balance.Text, grandtotal.Text, dicounttxt.Text, nettotal.Text, paidtext.Text);

                    }

                    CrystalReportSalesBill objRpt = new CrystalReportSalesBill();
                    objRpt.Database.Tables["DataTablesalesbill"].SetDataSource(ds.Tables["DataTablesalesbill"]);

                    FormPrint f = new FormPrint(objRpt);
                    f.ShowDialog();





                    MessageBox.Show("Transaction updated succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                   

                }


                else if (dialogResult == DialogResult.No)
                {
                    //do something else

                }

            }
              

















        }

        private void dgvsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                foreach (DataGridViewCell oneCell in dgvsales.SelectedCells)
                {
                    if (oneCell.Selected)
                        dgvsales.Rows.RemoveAt(oneCell.RowIndex);
                }



                decimal sum = 0;
                for (int i = 0; i < dgvsales.Rows.Count; i++)
                {
                    if (dgvsales.Rows[i].Cells[6].Value != null)
                    {
                        sum += Convert.ToDecimal(dgvsales.Rows[i].Cells[6].Value);
                    }
                }
                grandtotal.Text = sum.ToString();



                //net total

                if (dicounttxt.Text != "" && grandtotal.Text != "")
                {

                    decimal grndtot = decimal.Parse(grandtotal.Text);
                    decimal discnt = decimal.Parse(dicounttxt.Text);

                    if (discnt <= 100)
                    {

                        decimal dicountamount = ((discnt * grndtot) / 100);

                        decimal nettot = grndtot - dicountamount;

                        nettotal.Text = nettot.ToString();

                        balance.Text = nettot.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Discount can't greater than 100%", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        nettotal.Text = "";
                        dicounttxt.Text = "";
                        paidtext.Text = "";
                        balance.Text = "00.00";
                        btnaddproducttogrid.Text = "+";
                    }
                }
                else
                {
                    nettotal.Text = "";
                    dicounttxt.Text = "";
                    paidtext.Text = "";
                    balance.Text = "00.00";

                    btnaddproducttogrid.Text = "+";


                }




                paidtext.Text = "";

                quantity.Text = "1";
                prize.Text = "";
                txtdiscount.Text = "0";
                lblunit.Text = "Unit";
                totalamount.Text = "";

                if (balance.Text == "0")
                {
                    balance.Text = "00.00";
                }

                btnaddproducttogrid.Text = "+";

            }
            else
            {

                i = e.RowIndex;

                if (i >= 0)
                {

                    i = e.RowIndex;
                    DataGridViewRow row = dgvsales.Rows[i];
                    productcode.Text = row.Cells[1].Value.ToString();
                    productname.Text = row.Cells[0].Value.ToString();
                    quantity.Text = row.Cells[2].Value.ToString();
                    lblunit.Text = row.Cells[3].Value.ToString();
                    prize.Text = row.Cells[4].Value.ToString();
                    txtdiscount.Text = row.Cells[5].Value.ToString();
                    totalamount.Text = row.Cells[6].Value.ToString();
                    btnaddproducttogrid.Text = "u";

                }
                else
                {

                    MessageBox.Show("Invalid Attempt", "MaxBizz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Note :  " + ex.Message, "MaxBiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void txtpaymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtpaymentmode.Text == "Cash")
            {
                CustomerNames.Text = "Cash Customer";
                CustomerNames.Enabled = false;
            }
            else
            {
             
                CustomerNames.Enabled = true;
            }
        }

        private void totalamount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

            DataTable dts = p.selectcompanycustomerdetails();
            CustomerNames.DataSource = dts;
            CustomerNames.DisplayMember = "username";
            CustomerNames.ValueMember = "id";
            //   CustomerName.Text = "Cash Customer";


        }

        private void txtpaymentmode_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void SalesNo_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefreshdata_Click(object sender, EventArgs e)
        {

            quantity.Text = "1";
            prize.Text = "";
            txtdiscount.Text = "0";
            lblunit.Text = "Unit";
            totalamount.Text = "";

            if (balance.Text == "0")
            {
                balance.Text = "00.00";
            }

            btnaddproducttogrid.Text = "+";
        }

    
       
}}
