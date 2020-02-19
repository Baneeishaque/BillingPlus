using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
namespace BillPlus
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        decimal amountsend = 0;
        int idsend = 0;
        public void financialyear()
        {
            DataTable dt = p.selectcompany();
            c.Financialyear = dt.Rows[0][7].ToString();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProviderBillingplus.Clear();


            c.Username = customerName.Text;
            DataTable dtvalidationname = p.selectsupplierbynamesvalidaion(c);



            if (customerName.Text == "" ||  customerStartingamount.Text == "" || dtvalidationname.Rows.Count != 0)
            {
               



                if (dtvalidationname.Rows.Count != 0)
                {
                    errorProviderBillingplus.SetError(customerName, "Name already exist");
                }


                if (customerName.Text == "")
                {
                    errorProviderBillingplus.SetError(customerName, "required field");
                }
              
                if (customerStartingamount.Text == "")
                {
                    errorProviderBillingplus.SetError(customerStartingamount, "required field");
                }
            }
            else
            {



                //save

                if (btnSave.Text == "     Save")
                {


                    DataTable dt = p.suppliersmaxid();
                    if (dt.Rows[0][0].ToString() == "")
                    {
                        c.Id = 1;

                    }
                    else
                    {
                        int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                        c.Id = idValue;
                    }
                    c.Username = customerName.Text;
                    c.Address = customerAddress.Text;
                    c.Contactno = customerContact.Text;

                    financialyear();
                    c.Accounttype = "";
                    c.Startingamount = decimal.Parse(customerStartingamount.Text);
                    c.Status = locationcustomer.Text;
                    c.Closingamount = 0;
                    c.Statusclosing = "From";
                    c.Adhars = adhartxt.Text;
                    c.Remarks = remarkstxt.Text;
                    p.inerttblsupplier(c);
                    MessageBox.Show("Supplier addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    customerName.Text = "";
                    customerAddress.Text = "";
                    customerContact.Text = "";
                    customerStartingamount.Text = "";
                    locationcustomer.Text = "TO	";
                    adhartxt.Text = "";
                    remarkstxt.Text = "";
                    btnSave.Text = "     Save";


                    //view

                    DataTable dtview = p.selectsupplierdetails();
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.DataSource = dtview;
                }
            }

            if (btnSave.Text == "     Update")
            {

                if (decimal.Parse(customerStartingamount.Text) < amountsend)
                {
                    MessageBox.Show("New amount cannot be less than old amount", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
                else
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update this supplier?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {


                        c.Id = idsend;
                        c.Username = customerName.Text;
                        c.Address = customerAddress.Text;
                        c.Contactno = customerContact.Text;
                        financialyear();
                        c.Accounttype = "";

                        c.Startingamount = decimal.Parse(customerStartingamount.Text);
                        c.Status = locationcustomer.Text;
                        c.Closingamount = 0;
                        c.Statusclosing = "TO";
                        c.Adhars = adhartxt.Text;
                        c.Remarks = remarkstxt.Text;
                        p.updtesupplierdetails(c);
                        MessageBox.Show("Supplier updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        customerName.Text = "";
                        customerAddress.Text = "";
                        customerContact.Text = "";
                        customerStartingamount.Text = "";
                        locationcustomer.Text = "";
                        adhartxt.Text = "";
                        remarkstxt.Text = "";
                        btnSave.Text = "     Save";


                        //view

                        DataTable dtview = p.selectsupplierdetails();
                        dgvCustomer.AutoGenerateColumns = false;
                        dgvCustomer.DataSource = dtview;

                    }
                }
            }
        }

        private void customerStartingamount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsend = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());
            c.Id = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());
            DataTable dt = p.selectsupplierbyid(c);

            customerName.Text = dt.Rows[0][1].ToString();
            customerAddress.Text = dt.Rows[0][2].ToString();
            customerContact.Text = dt.Rows[0][3].ToString();
            customerStartingamount.Text = dt.Rows[0][6].ToString();
            locationcustomer.Text = dt.Rows[0][7].ToString();
            adhartxt.Text = dt.Rows[0][10].ToString();
            remarkstxt.Text = dt.Rows[0][11].ToString();
            //  customerStartingamount.ReadOnly = true;
            amountsend = decimal.Parse(dt.Rows[0][6].ToString());
            btnSave.Text = "     Update";




            if (e.ColumnIndex == 5)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this supplier?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {

                    c.Id = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());

                    p.Deletsupplier(c);

                    customerName.Text = "";
                    customerAddress.Text = "";
                    customerContact.Text = "";
                    customerStartingamount.Text = "";
                    locationcustomer.Text = "TO";
                    adhartxt.Text = "";
                    remarkstxt.Text = "";
                    btnSave.Text = "     Save";
                    //view


                    DataTable dtview = p.selectsupplierdetails();
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.DataSource = dtview;
                }
                else if (dialogResult == DialogResult.No)
                {

                }





            }






        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            customerName.Text = "";
            customerAddress.Text = "";
            customerContact.Text = "";
            customerStartingamount.Text = "";
            locationcustomer.Text = "FROM";
            adhartxt.Text = "";
            remarkstxt.Text = "";
            btnSave.Text = "     Save";


            //view

            DataTable dtview = p.selectsupplierdetails();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dtview;
            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgvCustomer.Rows[i].Cells[4].Value);

            }
            lblbalanceampooutntotal.Text = total_fee_collcn.ToString();
        }

        private void tabcustomer_Enter(object sender, EventArgs e)
        {
            DataTable dtview = p.selectsupplierdetails();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dtview;
            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgvCustomer.Rows[i].Cells[4].Value);

            }
            lblbalanceampooutntotal.Text = total_fee_collcn.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLocation_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                string s = row.Cells[2].Value.ToString();

                if (!s.StartsWith(cmbLocation.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomer.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                string s = row.Cells[2].Value.ToString();

                if (!s.StartsWith(cmbLocation.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomer.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void searchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(searchCustomer.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomer.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void locationcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tabpageinstallment_Enter(object sender, EventArgs e)
        {
            DataTable dtview = p.selecttblinstallmentsupplierdetails();

            //dgvCustomer.DataSource = dtview;

            cmbSearchCustomer.DataSource = dtview;
            cmbSearchCustomer.ValueMember = "id";
            cmbSearchCustomer.DisplayMember = "username";

            cmbcustomerid.DataSource = dtview;
            cmbcustomerid.ValueMember = "id";
            cmbcustomerid.DisplayMember = "id";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCustomerNAme.Text = "Name of Supplier";
            lblID.Text = "ID";
            lblMobileNo.Text = "Mobile Number";
            txt_fee_collecting_now.Text = "";
            lbl_balance.Text = "00.00";
            lblCurrentbalance.Text = "00.00";
            textBox1.Text = "";
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            c.Username = cmbSearchCustomer.Text;
            DataTable dtvalidationname = p.selectsupplierbynamesvalidaion(c);


            if (cmbSearchCustomer.Text != "" || cmbSearchCustomer.Text != "---Select---" || cmbcustomerid.Text != "" || cmbcustomerid.Text != "---Select---" || cmbcustomerid.Text != null || dtvalidationname.Rows.Count==0)
            {


                if (dtvalidationname.Rows.Count == 0)
                {
                    MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    lblCustomerNAme.Text = "Name of Supplier";
                    lblID.Text = "ID";
                    lblMobileNo.Text = "Mobile Number";
                    txt_fee_collecting_now.Text = "";
                    lbl_balance.Text = "00.00";
                    lblCurrentbalance.Text = "00.00";
                    textBox1.Text = "";
                }
                else
                {

                    c.Id = int.Parse(cmbcustomerid.Text);
                    DataTable dtview = p.selectsupplierrbyid(c);
                    if (dtview.Rows.Count > 0)
                    {
                        lblCustomerNAme.Text = dtview.Rows[0][1].ToString();
                        lblMobileNo.Text = dtview.Rows[0][3].ToString();
                        lbl_balance.Text = dtview.Rows[0][6].ToString();
                        lblCurrentbalance.Text = dtview.Rows[0][6].ToString();
                        lbl_status.Text = dtview.Rows[0][7].ToString();
                        lblbranch.Text = dtview.Rows[0][7].ToString();
                        lblID.Text = dtview.Rows[0][0].ToString();
                        txt_fee_collecting_now.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        lblCustomerNAme.Text = "Name of Supplier";
                        lblID.Text = "ID";
                        lblMobileNo.Text = "Mobile Number";
                        txt_fee_collecting_now.Text = "";
                        lbl_balance.Text = "00.00";
                        lblCurrentbalance.Text = "00.00";
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                lblCustomerNAme.Text = "Name of Supplier";
                lblID.Text = "ID";
                lblMobileNo.Text = "Mobile Number";
                txt_fee_collecting_now.Text = "";
                lbl_balance.Text = "00.00";
                lblCurrentbalance.Text = "00.00";
                textBox1.Text = "";
            }
        }

        private void BTNCMBIDSEARCH_Click(object sender, EventArgs e)
        {
            if (cmbSearchCustomer.Text != "" || cmbSearchCustomer.Text != "---Select---" || cmbcustomerid.Text != "" || cmbcustomerid.Text != "---Select---")
            {


                c.Id = int.Parse(cmbcustomerid.Text);
                DataTable dtview = p.selectsupplierrbyid(c);
                if (dtview.Rows.Count > 0)
                {
                    lblCustomerNAme.Text = dtview.Rows[0][1].ToString();
                    lblMobileNo.Text = dtview.Rows[0][3].ToString();
                    lbl_balance.Text = dtview.Rows[0][6].ToString();
                    lbl_status.Text = dtview.Rows[0][7].ToString();
                    lblID.Text = dtview.Rows[0][0].ToString();
                    lblbranch.Text = dtview.Rows[0][7].ToString();
                    txt_fee_collecting_now.Text = "";
                    dtview.Rows[0][7].ToString();
                    lblCurrentbalance.Text = dtview.Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    lblCustomerNAme.Text = "Name of Supplier";
                    lblID.Text = "ID";
                    lblMobileNo.Text = "Mobile Number";
                    txt_fee_collecting_now.Text = "";
                    lbl_balance.Text = "00.00";
                    lblCurrentbalance.Text = "00.00";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                lblCustomerNAme.Text = "Name of Supplier";
                lblID.Text = "ID";
                lblMobileNo.Text = "Mobile Number";
                txt_fee_collecting_now.Text = "";
                lbl_balance.Text = "00.00";
                lblCurrentbalance.Text = "00.00";
                textBox1.Text = "";
            }
        }

        private void txt_fee_collecting_now_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_save_Click(object sender, EventArgs e)
        {

            errorProviderBillingplus.Clear();
            if (lblCustomerNAme.Text == "Name of Supplier" || lblMobileNo.Text == "Mobile Number" || txt_fee_collecting_now.Text == "" || lblID.Text == "ID" || lbl_status.Text == "To")
            {


                if (lblCustomerNAme.Text == "Name of Supplier")
                {
                    errorProviderBillingplus.SetError(lblCustomerNAme, "required field");
                }

                if (lblMobileNo.Text == "Mobile Number")
                {
                    errorProviderBillingplus.SetError(lblMobileNo, "required field");
                }
                if (lblID.Text == "ID")
                {
                    errorProviderBillingplus.SetError(lblID, "required field");
                }

                if (lbl_status.Text == "To")
                {
                    errorProviderBillingplus.SetError(lbl_status, "required field");
                    MessageBox.Show("Cannot add more than the total balance to be paid", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }
                if (txt_fee_collecting_now.Text == "")
                {
                    errorProviderBillingplus.SetError(txt_fee_collecting_now, "required field");
                    //   MessageBox.Show("Cannot add more than the total Balance to be paid", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                }

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Confirm to save this collection for '" + lblCustomerNAme.Text + "' with Amount Rs '" + txt_fee_collecting_now.Text + "' ?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
       

                  if (dialogResult == DialogResult.Yes)
                {


                    DataTable dtids = p.maxofsuppliercollection();
                    if (dtids.Rows[0][0].ToString() == "")
                    {
                        c.Collctionid = 1;

                    }
                    else
                    {
                        int idValue = (int.Parse(dtids.Rows[0][0].ToString())) + 1;
                        c.Collctionid = idValue;
                    }


                    //Insert
                    DataTable dtfinancial = p.selectcompany();

                    c.Financialyear = dtfinancial.Rows[0][7].ToString();
                    c.Id = int.Parse(lblID.Text);
                    c.Customername = lblCustomerNAme.Text;
                    c.Phone = lblMobileNo.Text;

                    c.Collctiondate = DateTime.Parse(DtmAmountCollection.Text);
                    c.Amountcollectingnow = decimal.Parse(txt_fee_collecting_now.Text);
                    c.Balanceamount = decimal.Parse(lbl_balance.Text);
                    c.Status = "TO";
                    c.Remarks = remarkstxt.Text;
                    c.Branch = lblbranch.Text;
                    p.insrtintoinstallmentcollectionsuppplier(c);

                    //update Balance

                    c.Id = int.Parse(lblID.Text);
                    c.Startingamount = decimal.Parse(lbl_balance.Text);
                    c.Status = "TO";
                    p.updteBalancesuplier(c);

                   MessageBox.Show("Collection addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    lblCustomerNAme.Text = "Name of Supplier";
                    lblID.Text = "ID";
                    lblMobileNo.Text = "Mobile Number";
                    txt_fee_collecting_now.Text = "";
                    lbl_balance.Text = "00.00";
                    lblCurrentbalance.Text = "00.00";
                    textBox1.Text = "";
                    //     lblbranch.Text = "Place";
                    // cmbcustomerid.Text = "";
                    //  cmbSearchCustomer.Text = "---Select---";


                   
                }
                else if (dialogResult == DialogResult.No)
                {

                }

              






            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_fee_collecting_now_TextChanged(object sender, EventArgs e)
        {

            if (txt_fee_collecting_now.Text != "" && txt_fee_collecting_now.Text != ".")
            {
                // decimal fee_collecting_now = decimal.Parse(txt_fee_collecting_now.Text);

                decimal balance = ((decimal.Parse(lblCurrentbalance.Text)) - (decimal.Parse(txt_fee_collecting_now.Text)));

                if (balance < 0)
                {
                    lbl_balance.Text = (-balance).ToString();
                    lbl_status.Text = "To";
                }
                else
                {
                    lbl_balance.Text = balance.ToString();
                    lbl_status.Text = "From";

                }
            }
            else
            {
                decimal balance = ((decimal.Parse(lblCurrentbalance.Text)) - (0));

                if (balance < 0)
                {
                    lbl_balance.Text = (-balance).ToString();
                    lbl_status.Text = "To";
                }
                else
                {
                    lbl_balance.Text = balance.ToString();
                    lbl_status.Text = "From";

                }
            }

        }

        private void cmbcustomerid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            if (txtpaas.Text == "Admin@123")
            {
                groupBox3.Visible = true;
                dgv_collection_today.Visible = true;
                lbl_total.Visible = true;
                label8.Visible = true;

                //  groupBox4.Visible = true;



                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();
                DataTable dt = p.selectinstallmentdetailssupplier(c);
                dgv_collection_today.AutoGenerateColumns = false;
                dgv_collection_today.DataSource = dt;


                decimal total_fee_collcn = 0;
                for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
                {
                    total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

                }
                lbl_total.Text = total_fee_collcn.ToString();






                DataTable dtview = p.selecttblinstallmentsupplierdetails();
                //cmbbranch.DataSource = dtview;
                //cmbbranch.ValueMember = "status";
                //cmbbranch.DisplayMember = "status";

                DataTable dtviews = p.selecttblinstallmentsupplierdetails();
                cmbname.DataSource = dtviews;
                cmbname.ValueMember = "username";
                cmbname.DisplayMember = "username";



            }
            else
            {
                groupBox3.Visible = false;
                dgv_collection_today.Visible = false;
                lbl_total.Visible = false;
                label8.Visible = false;
                //groupBox4.Visible = false;

            }
        }

        private void cmbname_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_collection_today.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(cmbname.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgv_collection_today.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();

                }
                else
                    row.Visible = true;

            }

            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();



        }

        private void btnsearchname_Click(object sender, EventArgs e)
        {
            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            c.Username = cmbname.Text;
            DataTable dt = p.selectinstallmentbysuppliernameselct(c);
            dgv_collection_today.AutoGenerateColumns = false;
            dgv_collection_today.DataSource = dt;


            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            DataTable dt = p.selectinstallmentdetailssupplier(c);
            dgv_collection_today.AutoGenerateColumns = false;
            dgv_collection_today.DataSource = dt;



            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();



            DataTable dtview = p.selecttblinstallmentsupplierdetails();
            //cmbbranch.DataSource = dtview;
            //cmbbranch.ValueMember = "status";
            //cmbbranch.DisplayMember = "status";

            DataTable dtviews = p.selecttblinstallmentsupplierdetails();
            cmbname.DataSource = dtviews;
            cmbname.ValueMember = "username";
            cmbname.DisplayMember = "username";
        }

        private void txtpaas_TextChanged(object sender, EventArgs e)
        {
            if (txtpaas.Text == "Admin@123")
            {


                groupBox3.Visible = true;
                dgv_collection_today.Visible = true;
                lbl_total.Visible = true;
                label8.Visible = true;
                //  groupBox4.Visible = true;



                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();
                DataTable dt = p.selectinstallmentdetailssupplier(c);
                dgv_collection_today.AutoGenerateColumns = false;
                dgv_collection_today.DataSource = dt;



                decimal total_fee_collcn = 0;
                for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
                {
                    total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

                }
                lbl_total.Text = total_fee_collcn.ToString();



                DataTable dtview = p.selecttblinstallmentsupplierdetails();
                //cmbbranch.DataSource = dtview;
                //cmbbranch.ValueMember = "status";
                //cmbbranch.DisplayMember = "status";

                DataTable dtviews = p.selecttblinstallmentsupplierdetails();
                cmbname.DataSource = dtviews;
                cmbname.ValueMember = "username";
                cmbname.DisplayMember = "username";




            }
            else
            {
                groupBox3.Visible = false;
                dgv_collection_today.Visible = false;
                lbl_total.Visible = false;
                label8.Visible = false;
                //groupBox4.Visible = false;
            }
        }

        private void dgv_collection_today_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this payment?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {



                    //update Amount before deletion



                    c.Username = dgv_collection_today.CurrentRow.Cells["Column6"].Value.ToString();
                    DataTable dt = p.selectsupplrbybynamesvalidaion(c);

                    c.Username = dgv_collection_today.CurrentRow.Cells["Column6"].Value.ToString();
                    c.Startingamount = c.Startingamount = decimal.Parse(dt.Rows[0][6].ToString()) + decimal.Parse(dgv_collection_today.CurrentRow.Cells["Column9"].Value.ToString());//old Balance + deleted amout


                    p.updteBalancebysupliername(c);



                    c.Collctionid = int.Parse(dgv_collection_today.CurrentRow.Cells["collctionidcolumn"].Value.ToString());

                    p.Deletecollectionsupplier(c);


                    MessageBox.Show("Collected amount deleted successfully", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    DataTable dtfinancial = p.selectcompany();

                    c.Financialyear = dtfinancial.Rows[0][7].ToString();
                    DataTable dts = p.selectinstallmentdetailssupplier(c);
                    dgv_collection_today.AutoGenerateColumns = false;
                    dgv_collection_today.DataSource = dts;



                    decimal total_fee_collcn = 0;
                    for (int i = 0; i < dgv_collection_today.Rows.Count; i++)
                    {
                        total_fee_collcn += Convert.ToDecimal(dgv_collection_today.Rows[i].Cells[3].Value);

                    }
                    lbl_total.Text = total_fee_collcn.ToString();



                 
                }

                else if (dialogResult == DialogResult.No)
                {

                }



            }
       
       
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {

        }

        private void Btnmexport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "SuppliersBalanceAmount_On_" + SalesDate.Text + ".xls";


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Copy DataGridView results to clipboard
                    copyAlltoClipboard();

                    object misValue = System.Reflection.Missing.Value;
                    Excel.Application xlexcel = new Excel.Application();

                    xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    // Format column D as text before pasting results, this was required for my data
                    Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                    rng.NumberFormat = "@";

                    // Paste clipboard results to worksheet range
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                    // Delete blank column A and select cell A1
                    Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                    delRng.Delete(Type.Missing);
                    xlWorkSheet.get_Range("A1").Select();

                    // Save the excel file under the captured location from the SaveFileDialog
                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);

                    // Clear Clipboard and DataGridView selection
                    Clipboard.Clear();
                    dgvCustomer.ClearSelection();

                    // Open the newly saved excel file
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }


                MessageBox.Show("Task Completed", "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
        }

        private void copyAlltoClipboard()
        {
            dgvCustomer.SelectAll();
            DataObject dataObj = dgvCustomer.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

     
    }
}
