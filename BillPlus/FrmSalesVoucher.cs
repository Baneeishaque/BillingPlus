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
    public partial class FrmSalesVoucher : Form
    {
        public FrmSalesVoucher()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        public static int salenosend;
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        public void financialyear()
        {
            DataTable dt = p.selectcompany();
            c.Financialyear = dt.Rows[0][7].ToString();
        }
        int i;
      
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
          //  tabPage4.Text = "product wise സാധനങ്ങൾ വിറ്റതിന്റെ റിപ്പോർട്ട്";
        }

        private void SalesVoucher_Enter(object sender, EventArgs e)
        {
        
            //maxid
            //salesmaxid
            DataTable dt = p.salesmaxid();
            if (dt.Rows[0][0].ToString() == "")
            {
                SalesNo.Text = "1";

            }
            else
            {
                int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
               SalesNo.Text=  idValue.ToString();
            }

            //paymentmode
            if (txtpaymentmode.Text == "Cash")
            {
                CustomerName.Text = "Cash Customer";
                CustomerName.Enabled = false;
            }
            else
            {
                CustomerName.Text = "";
                CustomerName.Enabled = true;
            }

          
        }

        private void btnaddproducttogrid_Click(object sender, EventArgs e)
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

                    int n = dgvsales.Rows.Add();
                    dgvsales.Rows[n].Cells[0].Value = productcode.Text;
                    dgvsales.Rows[n].Cells[1].Value = productname.Text;
                    dgvsales.Rows[n].Cells[2].Value = quantity.Text;
                    dgvsales.Rows[n].Cells[3].Value = lblunit.Text;
                    dgvsales.Rows[n].Cells[4].Value = prize.Text;
                    dgvsales.Rows[n].Cells[5].Value = txtdiscount.Text;
                    dgvsales.Rows[n].Cells[6].Value = totalamount.Text;

                    dgvsales.FirstDisplayedScrollingRowIndex = dgvsales.RowCount - 1;
                    
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

        private void dgvpurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prize_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalamount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void productcode_SelectionChangeCommitted(object sender, EventArgs e)
        {

          

                //check product code exist or not
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
                else
                {
                MessageBox.Show("Product not found", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
          




         


        }

    
        private void productname_SelectionChangeCommitted(object sender, EventArgs e)
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
            else
            {
           MessageBox.Show("Product not found", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void productname_Leave(object sender, EventArgs e)
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
            else
            {
      MessageBox.Show("Product not found", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void productcode_Leave(object sender, EventArgs e)
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
            else
            {
              MessageBox.Show("Product not found", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
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

        private void prize_TextChanged(object sender, EventArgs e)
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

        private void txtdiscount_TextChanged(object sender, EventArgs e)
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

        private void quantity_Leave(object sender, EventArgs e)
        {
            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                float qnty = float.Parse(quantity.Text);
                float price = float.Parse(prize.Text);
                float dicnt = float.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                float qntyprice = qnty * price;


                float discoutnamount = ((dicnt * qntyprice) / 100);


                float total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void prize_Leave(object sender, EventArgs e)
        {
            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                float qnty = float.Parse(quantity.Text);
                float price = float.Parse(prize.Text);
                float dicnt = float.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                float qntyprice = qnty * price;


                float discoutnamount = ((dicnt * qntyprice) / 100);


                float total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            if (quantity.Text != "" && prize.Text != "" && txtdiscount.Text != "")
            {
                float qnty = float.Parse(quantity.Text);
                float price = float.Parse(prize.Text);
                float dicnt = float.Parse(txtdiscount.Text);
                //  float totlamnt = float.Parse(totalamount.Text);



                float qntyprice = qnty * price;


                float discoutnamount = ((dicnt * qntyprice) / 100);


                float total = qntyprice - discoutnamount;

                totalamount.Text = total.ToString();




            }
            else
            {
                totalamount.Text = "";
            }
        }

        private void FrmSalesVoucher_Load(object sender, EventArgs e)
        {

            DataTable dtp = p.SelectProductdetails();
            productcode.DataSource = dtp;
            productcode.ValueMember = "productcode";
            productcode.DisplayMember = "productcode";


            productname.DataSource = dtp;
            productname.ValueMember = "productcode";
            productname.DisplayMember = "productname";



            DataTable dts = p.selectcompanycustomerdetails();
            CustomerName.DataSource = dts;
            CustomerName.DisplayMember = "username";
            CustomerName.ValueMember = "id";
            CustomerName.Text = "Cash Customer";
            checkBoxWholeSale.Checked = false;
        }

        private void totalamount_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void productcode_SelectedValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void productcode_SelectedIndexChanged(object sender, EventArgs e)
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

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.Productcode = productcode.Text;
            DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

            if (dtprdctcodecheck.Rows.Count == 1 )
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

        private void grandtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dicounttxt_TextChanged(object sender, EventArgs e)
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

        private void dicounttxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nettotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paidtext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paidtext_TextChanged(object sender, EventArgs e)
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

        private void savepurchase_Click(object sender, EventArgs e)
        {



            errorProvider1.Clear();
            //validation for credit cusotmer exist or not

            //c.Username = CustomerName.Text;
            //DataTable dtvalidationname = p.selectcustomerbynamesvalidaion(c);


            decimal balndisplying=decimal.Parse( balance.Text);
            if (dgvsales.Rows.Count == 0 || grandtotal.Text == "" || dicounttxt.Text == "" || nettotal.Text == "" || paidtext.Text == "" || (txtpaymentmode.Text == "Cash" && balndisplying != 0) || (txtpaymentmode.Text == "Credit" && CustomerName.Text==""))
            {

                if (txtpaymentmode.Text == "Cash" && balndisplying != 0)
                {
                    MessageBox.Show("Cash customer's balance amount must be zero", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
                if (txtpaymentmode.Text == "Credit" && CustomerName.Text == "")
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

            DialogResult dialogResult = MessageBox.Show("Save transaction for the customer '"+CustomerName.Text+"' with Amount Rs '"+paidtext.Text+"' ?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {





                ///if it is a new user just save it here


                c.Username = CustomerName.Text;
                DataTable dtvalidationnamecustomerexistornot = p.selectcustomerbynamesvalidaion(c);

                if (dtvalidationnamecustomerexistornot.Rows.Count == 0 && CustomerName.Text != "Cash Customer")
                {
                    //if laready exist do nothing else add it
                 
                    
                    DataTable dtidname = p.Mastersmaxid();
                    if (dtidname.Rows[0][0].ToString() == "")
                    {
                        c.Id = 1;

                    }
                    else
                    {
                        int idValue = (int.Parse(dtidname.Rows[0][0].ToString())) + 1;
                        c.Id = idValue;
                    }
                    c.Username = CustomerName.Text;
                    c.Address = "";
                    c.Contactno = "";

                    financialyear();
                    c.Accounttype = "";
                    c.Startingamount =0;
                    c.Status = "";
                    c.Closingamount = 0;
                    c.Statusclosing = "From";
                    c.Adhars = "";
                    c.Remarks = "";
                    p.inerttblMaster(c);
                    //it's a code for insert data into valie clode 

                }
                else
                {
                    
                }







                for (int i = 0; i < dgvsales.Rows.Count; i++)
                {



                    c.Salesno = int.Parse(SalesNo.Text);//insert into database, SAlesNo Auto increment Value added to database
                    c.Id = dgvsales.CurrentCell.RowIndex;
                    c.Customer = CustomerName.Text;

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



                  


                    //check product exsist or not by name  Add product if donot added before

                    c.Productname = dgvsales.Rows[i].Cells[1].Value.ToString();
                    c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();
                    DataTable dtprdctcodecheckexistornot = p.Selectproductdetailsbyproductnameandcode(c);

                    if (dtprdctcodecheckexistornot.Rows.Count == 1)
                    {
                        // if product name already addedd do nothing
                    }
                    else
                    {
                        //Add the product

                        DataTable dtprint = p.productsmaxid();
                        if (dtprint.Rows[0][0].ToString() == "")
                        {
                            c.Id = 1;

                        }
                        else
                        {
                            int idValue = (int.Parse(dtprint.Rows[0][0].ToString())) + 1;
                            c.Id = idValue;
                        }
                        c.Productname = dgvsales.Rows[i].Cells[1].Value.ToString();
                        c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();

                        c.Sellingprice =decimal.Parse( dgvsales.Rows[i].Cells[4].Value.ToString());
                        c.Category ="0";
                        c.Unit = dgvsales.Rows[i].Cells[3].Value.ToString();
                        c.Gst = 0;
                        c.Cgst = 0;
                        c.Sgst = 0;
                        c.Stockstrt = 0;
                        financialyear();
                        c.Gstamount =0;


                        c.Purchasedprice = 0;

                       
                        c.Closingstock = 0;
                        p.insrtintoProductCreation(c);



                    }



                    // Stock update

                    c.Productcode = dgvsales.Rows[i].Cells[0].Value.ToString();

                    DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                    float currentstock = float.Parse(dtprdctcodecheck.Rows[0][9].ToString());
                    float qntiy = float.Parse(dgvsales.Rows[i].Cells[2].Value.ToString());

                    float stockafterthissale = currentstock - qntiy;

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




                //update credit customer balance amunt 
                if (txtpaymentmode.Text == "Credit")
                {

                    c.Username = CustomerName.Text;
                    DataTable updatecresitbalance = p.selectcustomerbynamesvalidaion(c);
                    if (updatecresitbalance.Rows.Count > 0)
                    {
                        decimal currentbalcne = decimal.Parse(updatecresitbalance.Rows[0][6].ToString());
                        decimal balnceinthispurchse = currentbalcne + decimal.Parse(balance.Text);

                        c.Username = CustomerName.Text;
                        c.Startingamount = balnceinthispurchse;
                        p.updteMasteronsales(c);
                    }
                }
                 
                        DataSetSalesinvoice ds = new DataSetSalesinvoice();
                        DataTable dt = ds.Tables["DataTablesalesbill"];


                            foreach (DataGridViewRow dgr in dgvsales.Rows)
                            {

                             
                            
                                dt.Rows.Add(SalesNo.Text, CustomerName.Text, SalesDate.Text, dgr.Index+1, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), dgr.Cells[3].Value.ToString(), dgr.Cells[4].Value.ToString(), dgr.Cells[5].Value.ToString(), dgr.Cells[6].Value.ToString(), txtpaymentmode.Text, balance.Text, grandtotal.Text, dicounttxt.Text, nettotal.Text, paidtext.Text);

                            }

                            CrystalReportSalesBill objRpt = new CrystalReportSalesBill();
                            objRpt.Database.Tables["DataTablesalesbill"].SetDataSource(ds.Tables["DataTablesalesbill"]);
     
                            FormPrint f = new FormPrint(objRpt);
                        f.ShowDialog();
                   

                    



             


                    MessageBox.Show("Transaction saved succesfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        //refresh
                        
                        //increment id


                        DataTable dtrefresh = p.salesmaxid();
                        if (dtrefresh.Rows[0][0].ToString() == "")
                        {
                            SalesNo.Text = "1";

                        }
                        else
                        {
                            int idValue = (int.Parse(dtrefresh.Rows[0][0].ToString())) + 1;
                            SalesNo.Text = idValue.ToString();
                        }

                        dgvsales.DataSource = null;




                        DataTable dts = p.selectcompanycustomerdetails();
                        CustomerName.DataSource = dts;
                        CustomerName.DisplayMember = "username";
                        CustomerName.ValueMember = "id";
                      
                        CustomerName.Text = "Cash Customer";

                        DataTable dtp = p.SelectProductdetails();
                        productcode.DataSource = dtp;
                        productcode.ValueMember = "productcode";
                        productcode.DisplayMember = "productcode";


                        productname.DataSource = dtp;
                        productname.ValueMember = "productcode";
                        productname.DisplayMember = "productname";

                        quantity.Text = "1";
                        prize.Text = "";
                        txtdiscount.Text = "0";
                        totalamount.Text = "";
                        txtpaymentmode.Text = "Cash";
                        narrrations.Text = "";
                        balance.Text = "00.00";
                        grandtotal.Text="00.00";
                        dicounttxt.Text = "0";
                        nettotal.Text = "00.00";
                        paidtext.Text = "";
                        lblunit.Text = "Unit";
                        btnaddproducttogrid.Text = "+";
                        checkBoxWholeSale.Checked = false;
                        dgvsales.Rows.Clear();

                    }

                         
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else

                    }

                }
              

       
              

        }

        private void nettotal_TextChanged(object sender, EventArgs e)
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

        private void txtpaymentmode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmSalesVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {

           



   



        }

        private void refresh_Click(object sender, EventArgs e)
        {
            //refresh

            //increment id


            DataTable dt = p.salesmaxid();
            if (dt.Rows[0][0].ToString() == "")
            {
                SalesNo.Text = "1";

            }
            else
            {
                int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                SalesNo.Text = idValue.ToString();
            }

            dgvsales.Rows.Clear();
            CustomerName.Text = "Cash Customer";

            DataTable dtp = p.SelectProductdetails();
            productcode.DataSource = dtp;
            productcode.ValueMember = "productcode";
            productcode.DisplayMember = "productcode";


            productname.DataSource = dtp;
            productname.ValueMember = "productcode";
            productname.DisplayMember = "productname";
            //productname.Text = ""; productcode.Text = "";
            quantity.Text = "1";
            prize.Text = "";
            txtdiscount.Text = "0";
            totalamount.Text = "";
            txtpaymentmode.Text = "Cash";
            narrrations.Text = "";
            balance.Text = "00.00";
            grandtotal.Text = "00.00";
            dicounttxt.Text = "0";
            nettotal.Text = "00.00";
            paidtext.Text = "";
            lblunit.Text = "Unit"; btnaddproducttogrid.Text = "+";
        }

        private void viewsaletab_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Admin@123")
            {
                groupBox3.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();

                DataTable dt = p.Selectsalesdetails(c);

                viewsales.AutoGenerateColumns = false;
                viewsales.DataSource = dt;


                //view total


                decimal sum = 0;
                for (int i = 0; i < viewsales.Rows.Count; i++)
                {
                    if (viewsales.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(viewsales.Rows[i].Cells[4].Value);
                    }
                }
                lbl_total.Text = sum.ToString();


                // name view in combobox
                DataTable dts = p.selectcompanycustomerdetails();
                cmb_name_all_collection.DataSource = dts;
                cmb_name_all_collection.DisplayMember = "username";
                cmb_name_all_collection.ValueMember = "id";










            }
            else
            {
                groupBox3.Visible = false;
                groupBox1.Visible = false; groupBox2.Visible = false;
            }





         
        }

        private void refreshview_Click(object sender, EventArgs e)
        {

            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();

            DataTable dt = p.Selectsalesdetails(c);//Selectsalesdetailsvustomerwise

            viewsales.AutoGenerateColumns = false;
            viewsales.DataSource = dt;



            decimal sum = 0;
            for (int i = 0; i < viewsales.Rows.Count; i++)
            {
                if (viewsales.Rows[i].Cells[4].Value != null)
                {
                    sum += Convert.ToDecimal(viewsales.Rows[i].Cells[4].Value);
                }
            }
            lbl_total.Text = sum.ToString();

        }

        private void cmb_name_all_collection_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in viewsales.Rows)
            {
                string s = row.Cells[2].Value.ToString();

                if (!s.StartsWith(cmb_name_all_collection.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[viewsales.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;

            }

        }

        private void SalesVoucher_Click(object sender, EventArgs e)
        {
           
        }






        public CrystalReportCollectamount objRpt { get; set; }

        public CrystalReportCollectamount objRptsale { get; set; }

        public CrystalReportCollectamount objRptsalesinv { get; set; }

        private void viewsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Formupdatesale f = new Formupdatesale();
            salenosend =int.Parse( viewsales.CurrentRow.Cells["Column12"].Value.ToString());
            f.ShowDialog();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text == "Admin@123")
            {
                groupBox3.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();

                DataTable dt = p.Selectsalesdetails(c);

                viewsales.AutoGenerateColumns = false;
                viewsales.DataSource = dt;


                //view total


                decimal sum = 0;
                for (int i = 0; i < viewsales.Rows.Count; i++)
                {
                    if (viewsales.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(viewsales.Rows[i].Cells[4].Value);
                    }
                }
                lbl_total.Text = sum.ToString();

                //view name in combobx
                // name view in combobox
                DataTable dts = p.selectcompanycustomerdetails();
                cmb_name_all_collection.DataSource = dts;
                cmb_name_all_collection.DisplayMember = "username";
                cmb_name_all_collection.ValueMember = "id";



            }
            else
            {

                groupBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            FrmAddMasters f = new FrmAddMasters();
            f.ShowDialog();
        }

        private void txtpaymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtpaymentmode.Text == "Cash")
            {
                CustomerName.Text = "Cash Customer";
                CustomerName.Enabled = false;
            }
            else
            {
                CustomerName.Text = "";
                CustomerName.Enabled = true;
            }

        }

        private void viewsales_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Formupdatesale f = new Formupdatesale();
            salenosend = int.Parse(viewsales.CurrentRow.Cells["Column12"].Value.ToString());
            f.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void customerwisesearch_Click(object sender, EventArgs e)
        {
            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            c.Customer = cmb_name_all_collection.Text;
            DataTable dt = p.Selectsalesdetailsvustomerwise(c);//Selectsalesdetailsvustomerwise
            viewsales.AutoGenerateColumns = false;
            if (dt.Rows.Count > 0)
            {
                viewsales.DataSource = dt;
                decimal sum = 0;
                for (int i = 0; i < viewsales.Rows.Count; i++)
                {
                    if (viewsales.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(viewsales.Rows[i].Cells[4].Value);
                    }
                }
                lbl_total.Text = sum.ToString();
            }
            else
            {
                viewsales.DataSource = null;
                lbl_total.Text = "00.00";
                MessageBox.Show("No Sales found for this customer", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
             
            }


         


        }

        private void btndatewisesearch_Click(object sender, EventArgs e)
        {
            DateTime dateto = DateTime.Parse(dateTimePickersearch.Text);
            var shortDateto = dateto.ToString("yyyy-MM-dd");



     




            //Selectsalesdetailsdatewise



            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            c.Salesdate = DateTime.Parse(shortDateto.ToString());
            DataTable dt = p.Selectsalesdetailsdatewise(c);//Selectsalesdetailsvustomerwise
            viewsales.AutoGenerateColumns = false;
            if (dt.Rows.Count > 0)
            {
                viewsales.DataSource = dt;
                decimal sum = 0;
                for (int i = 0; i < viewsales.Rows.Count; i++)
                {
                    if (viewsales.Rows[i].Cells[4].Value != null)
                    {
                        sum += Convert.ToDecimal(viewsales.Rows[i].Cells[4].Value);
                    }
                }
                lbl_total.Text = sum.ToString();
            }
            else
            {
                viewsales.DataSource = null;
                lbl_total.Text = "00.00";
                MessageBox.Show("No Sales found in this date", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
               
            }








        }

        private void cmbbillNo_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in viewsales.Rows)
            {
                string s = row.Cells[0].Value.ToString();

                if (!s.StartsWith(cmbbillNo.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[viewsales.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void barcodetext_TextChanged(object sender, EventArgs e)
        {
            //if barcode mode






          
        }

        private void barcodetext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                c.Productcode = barcodetext.Text;
                DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                if (dtprdctcodecheck.Rows.Count == 1)
                {

                    productcode.Text = dtprdctcodecheck.Rows[0][2].ToString();
                    productname.Text = dtprdctcodecheck.Rows[0][1].ToString();
                    lblunit.Text = dtprdctcodecheck.Rows[0][5].ToString();

                    if (checkBoxWholeSale.Checked == false)
                    {

                        prize.Text = dtprdctcodecheck.Rows[0][4].ToString();
                    }
                    else
                    {
                        prize.Text = dtprdctcodecheck.Rows[0][3].ToString();
                    }




                    quantity.Text = "1";
                    txtdiscount.Text = "0";
                    totalamount.Text = dtprdctcodecheck.Rows[0][4].ToString();


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



                        int n = dgvsales.Rows.Add();
                        dgvsales.Rows[n].Cells[0].Value = productcode.Text;
                        dgvsales.Rows[n].Cells[1].Value = productname.Text;
                        dgvsales.Rows[n].Cells[2].Value = quantity.Text;
                        dgvsales.Rows[n].Cells[3].Value = lblunit.Text;
                        dgvsales.Rows[n].Cells[4].Value = prize.Text;
                        dgvsales.Rows[n].Cells[5].Value = txtdiscount.Text;
                        dgvsales.Rows[n].Cells[6].Value = totalamount.Text;

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



                        //clear after adding grid
                        quantity.Text = "1";
                        prize.Text = "";
                        txtdiscount.Text = "0";
                        lblunit.Text = "Unit";
                        totalamount.Text = "";
                        productcode.Text = "";
                        productname.Text = "";
                        barcodetext.Text = "";

                        if (balance.Text == "0")
                        {
                            balance.Text = "00.00";
                        }




                    }




                }
                else
                {
                    MessageBox.Show("Product not found", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    barcodetext.SelectionStart = 0;
                    barcodetext.SelectionLength = barcodetext.Text.Length;
                }
            }
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

        private void dgvsales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        
    }
}
