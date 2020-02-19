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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }
        containerclass c=new containerclass();
        provider p=new provider();
        int idsended = 0;
        public static string pcdsend;
        public void financialyear()
        {
            DataTable dt = p.selectcompany();
            c.Financialyear = dt.Rows[0][7].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProviderBillingplus.Clear();
            if (productName.Text == "" || productCode.Text == "" || sellingPrice.Text == ""  || unit.Text == "" || startingStock.Text == "" )
            {
                if (productName.Text == "")
                {
                    errorProviderBillingplus.SetError(productName, "required field");
                }
                if (productCode.Text == "")
                {
                    errorProviderBillingplus.SetError(productCode, "required field");
                }
                if (sellingPrice.Text == "")
                {
                    errorProviderBillingplus.SetError(sellingPrice, "required field");
                }
              
                if (unit.Text == "")
                {
                    errorProviderBillingplus.SetError(unit, "required field");

                }

              


            }
            else
            {
                if (btnSave.Text == "     Save")
                {

                //check product code exist or not
                c.Productcode = productCode.Text;
                DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                if (dtprdctcodecheck.Rows.Count == 0)
                {

                    DataTable dt = p.productsmaxid();
                    if (dt.Rows[0][0].ToString() == "")
                    {
                        c.Id = 1;

                    }
                    else
                    {
                        int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                        c.Id = idValue;
                    }
                    c.Productname = productName.Text;
                    c.Productcode = productCode.Text;

                    c.Sellingprice = decimal.Parse(sellingPrice.Text);
                    if (category.Text == "")
                    {
                        c.Category = "0";
                    }
                    else
                    {
                        c.Category = category.Text;
                    }
                    c.Unit = unit.Text;
                    c.Gst = float.Parse(gst.Text);
                    c.Cgst = float.Parse(cgst.Text);
                    c.Sgst = float.Parse(sgst.Text);
                    c.Stockstrt = float.Parse(startingStock.Text);
                    financialyear();
                    c.Gstamount = decimal.Parse(gstAmount.Text);

                    if (Barcode.Text == "")
                    {
                        c.Purchasedprice = 0;

                    }
                    else
                    {
                        c.Purchasedprice = decimal.Parse(Barcode.Text);
                    }
                    c.Closingstock = 0;
                    p.insrtintoProductCreation(c);
                    MessageBox.Show("Product addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    DataTable dtp = p.SelectProductdetails();
                    dgvAddproduct.AutoGenerateColumns = false;
                    dgvAddproduct.DataSource = dtp;







                    //updateProductCreation


                    //clear

                    productName.Text = "";
                    productCode.Text = "";

                    sellingPrice.Text = "";
                    category.Text = "";
                    unit.Text = "";
                
                    startingStock.Text = "";
                    //   gstAmount.Text = "";
                    Barcode.Text = ""; btnSave.Text = "     Save";

                }


                else
                {
                    MessageBox.Show("Productcode was already added.Try another one.", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
               

                }

                //update

                if (btnSave.Text == "     Update")
                {
                    string prdctcodebeforeupdation = pcdsend;

                    if (prdctcodebeforeupdation == productCode.Text)  // productcode check
                    {

                        c.Id = idsended;
                        c.Productname = productName.Text;
                        c.Productcode = productCode.Text;

                        c.Sellingprice = decimal.Parse(sellingPrice.Text);
                        c.Category = category.Text;
                        c.Unit = unit.Text;
                        c.Gst = float.Parse(gst.Text);
                        c.Cgst = float.Parse(cgst.Text);
                        c.Sgst = float.Parse(sgst.Text);
                        c.Stockstrt = float.Parse(startingStock.Text);
                        financialyear();
                        c.Gstamount = decimal.Parse(gstAmount.Text);

                        if (Barcode.Text == "")
                        {
                            c.Purchasedprice = 0;

                        }
                        else
                        {
                            c.Purchasedprice = decimal.Parse(Barcode.Text);
                        }
                        c.Closingstock = 0;
                        p.updateProductCreation(c);
                        MessageBox.Show("Product updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DataTable dtp = p.SelectProductdetails();
                        dgvAddproduct.AutoGenerateColumns = false;
                        dgvAddproduct.DataSource = dtp;



                        //clear
                        btnSave.Text = "     Save";
                        productName.Text = "";
                        productCode.Text = "";

                        sellingPrice.Text = "";
                        category.Text = "";
                        unit.Text = "";
                        //gst.Text = "";
                        //cgst.Text = "";
                        //sgst.Text = "";
                        startingStock.Text = "";
                        //   gstAmount.Text = "";
                        Barcode.Text = "";




                    }
                    else
                    {


                        c.Productcode = productCode.Text;
                        DataTable dtprdctcodecheck = p.Selectproductdetailsbyproductcode(c);

                        if (dtprdctcodecheck.Rows.Count == 0)
                        {

                            c.Id = idsended;
                            c.Productname = productName.Text;
                            c.Productcode = productCode.Text;

                            c.Sellingprice = decimal.Parse(sellingPrice.Text);
                            c.Category = category.Text;
                            c.Unit = unit.Text;
                            c.Gst = float.Parse(gst.Text);
                            c.Cgst = float.Parse(cgst.Text);
                            c.Sgst = float.Parse(sgst.Text);
                            c.Stockstrt = float.Parse(startingStock.Text);
                            financialyear();
                            c.Gstamount = decimal.Parse(gstAmount.Text);

                            if (Barcode.Text == "")
                            {
                                c.Purchasedprice = 0;

                            }
                            else
                            {
                                c.Purchasedprice = decimal.Parse(Barcode.Text);
                            }
                            c.Closingstock = 0;
                            p.updateProductCreation(c);
                            MessageBox.Show("Product updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            DataTable dtp = p.SelectProductdetails();
                            dgvAddproduct.AutoGenerateColumns = false;
                            dgvAddproduct.DataSource = dtp;



                            //clear
                            btnSave.Text = "     Save";
                            productName.Text = "";
                            productCode.Text = "";

                            sellingPrice.Text = "";
                            category.Text = "";
                            unit.Text = "";
                            //gst.Text = "";
                            //cgst.Text = "";
                            //sgst.Text = "";
                            startingStock.Text = "";
                            //   gstAmount.Text = "";
                            Barcode.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Productcode was already added.Try another one.", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                        }




                    }


                    

                 

                   

                }


            }
        }
        private void sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cgst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sgst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gstAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void startingStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //clear

            productName.Text = "";
            productCode.Text = "";

            sellingPrice.Text = "";
            category.Text = "";
            unit.Text = "";
            //gst.Text = "";
            //cgst.Text = "";
            //sgst.Text = "";
            startingStock.Text = "";
           // gstAmount.Text = "";
            Barcode.Text = "";
            btnSave.Text = "     Save";
            DataTable dtp = p.SelectProductdetails();
            dgvAddproduct.AutoGenerateColumns = false;
            dgvAddproduct.DataSource = dtp;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageaddprdct_Enter(object sender, EventArgs e)
        {
            //clear
            DataTable dtp = p.SelectProductdetails();
            dgvAddproduct.AutoGenerateColumns = false;
            dgvAddproduct.DataSource = dtp;
            //view category


        //    DataTable dts = p.selectfromcategory();
        //category.DataSource = dts;
        //category.ValueMember = "id";
        //category.DisplayMember = "categoryname";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageviewstock_Enter(object sender, EventArgs e)
        {
            DataTable dtp = p.SelectProductdetails();
            dgvViewStock.AutoGenerateColumns = false;
            dgvViewStock.DataSource = dtp;
        }

        private void tabPagepriceList_Enter(object sender, EventArgs e)
        {
            DataTable dtp = p.SelectProductdetails();
            dgvPriceList.AutoGenerateColumns = false;
            dgvPriceList.DataSource = dtp;
        }

        private void btnAddcategory_Click(object sender, EventArgs e)
        {
            frmAddcategory f = new frmAddcategory();
            f.ShowDialog();
        }

        private void category_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void btnrefreshprdct_Click(object sender, EventArgs e)
        {
            DataTable dts = p.selectfromcategory();
            //category.DataSource = dts;
            //category.ValueMember = "id";
            //category.DisplayMember = "categoryname";

        }

        private void gst_TextChanged(object sender, EventArgs e)
        {
            if (sellingPrice.Text != "" && sellingPrice.Text != "." && gst.Text != "" && gst.Text != ".")
            {

                //calculate Gst Amount
                float sellingprc =float.Parse( sellingPrice.Text);
                float gsta = float.Parse(gst.Text);
                float gstamount = (gsta * sellingprc / 100);
                gstAmount.Text = gstamount.ToString();
            }
            else
            {
                gstAmount.Text = "";
            }


                // calculate Cgst and Sgst

                if (gst.Text != "" && gst.Text != ".")
                {
                    float gstp = float.Parse(gst.Text);
                    cgst.Text = (gstp / 2).ToString();
                    sgst.Text = (gstp / 2).ToString();

                }
                else
                {
                    //  Gst.Text = "";
                    cgst.Text = "";
                    sgst.Text = "";
                }
                // for .
          
          
        }

        private void sellingPrice_TextChanged(object sender, EventArgs e)
        {

            if (sellingPrice.Text != "" && sellingPrice.Text != "." && gst.Text != "" && gst.Text != ".")
            {

                //calculate Gst Amount
                float sellingprc = float.Parse(sellingPrice.Text);
                float gsta = float.Parse(gst.Text);
                float gstamount = (gsta * sellingprc / 100);
                gstAmount.Text = gstamount.ToString();
            }
            else
            {
              //  gstAmount.Text = "";
            } 
        }

        private void sgst_TextChanged(object sender, EventArgs e)
        {

        }

        private void Barcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gst_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAddproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
       
      
     
                


            //delete

            if (e.ColumnIndex == 6)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this product?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {


                    c.Id = int.Parse(dgvAddproduct.CurrentRow.Cells["Column1"].Value.ToString());
                    p.Deleteproduct(c);


                    //clear
                    DataTable dtp = p.SelectProductdetails();
                    dgvAddproduct.AutoGenerateColumns = false;
                    dgvAddproduct.DataSource = dtp;
                    productName.Text = "";
                    productCode.Text = "";

                    sellingPrice.Text = "";
                    category.Text = "";
                    unit.Text = "";
                    //gst.Text = "";
                    //cgst.Text = "";
                    //sgst.Text = "";
                    startingStock.Text = "";
                    //gstAmount.Text = "";
                    Barcode.Text = "";

                    btnSave.Text = "     Save";


                }
                else if (dialogResult == DialogResult.No)
                {
                    //clear
                    DataTable dtp = p.SelectProductdetails();
                    dgvAddproduct.AutoGenerateColumns = false;
                    dgvAddproduct.DataSource = dtp;
                    productName.Text = "";
                    productCode.Text = "";

                    sellingPrice.Text = "";
                    category.Text = "";
                    unit.Text = "";
                    //gst.Text = "";
                    //cgst.Text = "";
                    //sgst.Text = "";
                    startingStock.Text = "";
                    //gstAmount.Text = "";
                    Barcode.Text = "";

                    btnSave.Text = "     Save";

                }





            }
            else
            {
                c.Id = int.Parse(dgvAddproduct.CurrentRow.Cells["Column1"].Value.ToString());
                DataTable dt = p.SelectProductdetailsbyid(c);


                idsended = int.Parse(dgvAddproduct.CurrentRow.Cells["Column1"].Value.ToString());
                productName.Text = dt.Rows[0][1].ToString();
                productCode.Text = dt.Rows[0][2].ToString();
                pcdsend = dt.Rows[0][2].ToString();
                category.Text = dt.Rows[0][3].ToString();
                sellingPrice.Text = dt.Rows[0][4].ToString();
                Barcode.Text = dt.Rows[0][12].ToString();
                unit.Text = dt.Rows[0][5].ToString();
                startingStock.Text = dt.Rows[0][9].ToString();
                gst.Text = dt.Rows[0][6].ToString();
                cgst.Text = dt.Rows[0][7].ToString();
                sgst.Text = dt.Rows[0][8].ToString();
                gstAmount.Text = dt.Rows[0][11].ToString();
                btnSave.Text = "     Update";
            }
        
        }

        private void searchproduct_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddproduct.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(searchproduct.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvAddproduct.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void cmbprdctsearchlist_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgvViewStock.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(cmbprdctsearchlist.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvViewStock.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void stockindescendingbtn_Click(object sender, EventArgs e)
        {
            this.dgvViewStock.Sort(this.dgvViewStock.Columns["dataGridViewTextBoxColumn10"], ListSortDirection.Descending);
        }

        private void stockinascendingbtn_Click(object sender, EventArgs e)
        {
            this.dgvViewStock.Sort(this.dgvViewStock.Columns["dataGridViewTextBoxColumn10"], ListSortDirection.Ascending);

        }

        private void pricedescnding_Click(object sender, EventArgs e)
        {
            this.dgvPriceList.Sort(this.dgvPriceList.Columns["pricecolumn"], ListSortDirection.Descending);

        }

        private void priceascending_Click(object sender, EventArgs e)
        {
            this.dgvPriceList.Sort(this.dgvPriceList.Columns["pricecolumn"], ListSortDirection.Ascending);

        }

        private void cmbprodctpricelist_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPriceList.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(cmbprodctpricelist.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPriceList.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void stoclrefresh_Click(object sender, EventArgs e)
        {
            DataTable dtp = p.SelectProductdetails();
            dgvViewStock.AutoGenerateColumns = false;
            dgvViewStock.DataSource = dtp;
        }

        private void refreshpriucelist_Click(object sender, EventArgs e)
        {
            DataTable dtp = p.SelectProductdetails();
            dgvPriceList.AutoGenerateColumns = false;
            dgvPriceList.DataSource = dtp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
           checkBoxautogenerate.Checked = true;
        }

        private void dgvAddproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void category_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void productName_TextChanged(object sender, EventArgs e)
        {
            if (productName.Text != "" && checkBoxautogenerate.Checked==true)
            {
                productCode.Text = productName.Text;
            }
            if (productName.Text == "")
            {
                productCode.Text = "";
            }
        }

        private void productCode_Enter(object sender, EventArgs e)
        {
            if (productName.Text != "" && checkBoxautogenerate.Checked == true)
            {
                productCode.Text = productName.Text;
            }
            if (productName.Text == "")
            {
                productCode.Text ="";
            }
        }

     

     

        
    
        

        
    }
}
