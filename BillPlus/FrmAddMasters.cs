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
using Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
namespace BillPlus
{
    public partial class FrmAddMasters : Form
    {
        public FrmAddMasters()
        {
            InitializeComponent();
        }
        provider p = new provider();
        containerclass c = new containerclass();
        int idsend = 0;
        public void financialyear()
        {
            DataTable dt = p.selectcompany();
            c.Financialyear = dt.Rows[0][7].ToString();
        }
        decimal amountsend = 0;

        public static string mobilesend;
        public static string balncesend;

        private void FrmAddMasters_Load(object sender, EventArgs e)
        {
            //dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            //dgvCustomer.EnableHeadersVisualStyles = false;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProviderBillingplus.Clear();


            c.Username = customerName.Text;
            DataTable dtvalidationname= p.selectcustomerbynamesvalidaion( c);



            if (customerName.Text == "" || customerStartingamount.Text == "" || dtvalidationname.Rows.Count!=0)
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

                 
                    DataTable dt = p.Mastersmaxid();
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
                    p.inerttblMaster(c);
                    MessageBox.Show("Customer addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    customerName.Text = "";
                    customerAddress.Text = "";
                    customerContact.Text = "";
                    customerStartingamount.Text = "";
                    locationcustomer.Text = "FROM	";
                    adhartxt.Text = "";
                    remarkstxt.Text = "";
                    btnSave.Text = "     Save";


                    //view

                    DataTable dtview = p.selectcompanycustomerdetails();
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update this customer details?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
                        c.Statusclosing = "From";
                        c.Adhars = adhartxt.Text;
                        c.Remarks = remarkstxt.Text;
                        p.updteMaster(c);
                        MessageBox.Show("Customer updated successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        customerName.Text = "";
                        customerAddress.Text = "";
                        customerContact.Text = "";
                        customerStartingamount.Text = "";
                        locationcustomer.Text = "";
                        adhartxt.Text = "";
                        remarkstxt.Text = "";
                        btnSave.Text = "     Save";


                        //view

                        DataTable dtview = p.selectcompanycustomerdetails();
                        dgvCustomer.AutoGenerateColumns = false;
                        dgvCustomer.DataSource = dtview;

                    }
                }
            }
        }

        private void customerStatus_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void customerStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void saveSupplier_Click(object sender, EventArgs e)
        {

        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            customerName.Text = "";
            customerAddress.Text = "";
            customerContact.Text = "";
            customerStartingamount.Text = "";
            locationcustomer.Text = "FROM	";
            adhartxt.Text = "";
            remarkstxt.Text = "";
            btnSave.Text = "     Save";
            //view
            customerStartingamount.ReadOnly = false;
            DataTable dt = p.selectcompanycustomerdetails();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;

            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgvCustomer.Rows[i].Cells[4].Value);

            }
            lblbalanceampooutntotal.Text = total_fee_collcn.ToString();
        }

        private void supplierStartingAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void accountheadStartingAmount_KeyPress(object sender, KeyPressEventArgs e)
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




        private void closeAccountHead_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AccountHeadStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tabcustomer_Enter(object sender, EventArgs e)
        {

            DataTable dt = p.selectcompanycustomerdetails();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;
          
            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgvCustomer.Rows[i].Cells[4].Value);

            }
            lblbalanceampooutntotal.Text = total_fee_collcn.ToString();
         //   locationcustomer.Text = "Kozhikode	";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //view

           
        }







        private void tabcustomer_Click(object sender, EventArgs e)
        {

        }

        private void addAcounthead_Click(object sender, EventArgs e)
        {
            frmAddcategory f = new frmAddcategory();
            f.ShowDialog();
        }

        private void searchCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex != 6 && e.ColumnIndex != 7)
            {

                idsend = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());
                c.Id = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());
                DataTable dt = p.selectcustomerbyid(c);

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

            }
            if (e.ColumnIndex == 6)
            {

                mobilesend = dgvCustomer.CurrentRow.Cells["Column4"].Value.ToString();
                balncesend = dgvCustomer.CurrentRow.Cells["Column5"].Value.ToString();



                FormSMS f_send = new FormSMS();
                f_send.ShowDialog();
            }









            if (e.ColumnIndex == 5)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this cusotmer?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {

                    c.Id = int.Parse(dgvCustomer.CurrentRow.Cells["customerid"].Value.ToString());

                    p.Deletemaster(c);

                    customerName.Text = "";
                    customerAddress.Text = "";
                    customerContact.Text = "";
                    customerStartingamount.Text = "";
                    locationcustomer.Text = "";
                    adhartxt.Text = "";
                    remarkstxt.Text = "";
                    btnSave.Text = "     Save";
                    //view

                    DataTable dtvw = p.selectcompanycustomerdetails();
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.DataSource = dtvw;
                }
                else if (dialogResult == DialogResult.No)
                {

                }



            }


            if (e.ColumnIndex == 7)
            {
                DataSetprinttotalamount ds = new DataSetprinttotalamount();
                DataTable dt = ds.Tables["DataTableprinttotal"];


                dt.Rows.Add(dgvCustomer.CurrentRow.Cells["Column2"].Value.ToString(), dgvCustomer.CurrentRow.Cells["Column5"].Value.ToString());

                CrystalReporttotatltobepaid objRpt = new CrystalReporttotatltobepaid();
                objRpt.Database.Tables["DataTableprinttotal"].SetDataSource(ds.Tables["DataTableprinttotal"]);

                FormPrint f = new FormPrint(objRpt);
                f.ShowDialog();
            }



        }

        private void tabpageinstallment_Click(object sender, EventArgs e)
        {

        }

        private void tabpageinstallment_Enter(object sender, EventArgs e)
        {
            DataTable dtview = p.selectcompanycustomerdetails();

            //dgvCustomer.DataSource = dtview;

            cmbSearchCustomer.DataSource = dtview;
            cmbSearchCustomer.ValueMember = "id";
            cmbSearchCustomer.DisplayMember = "username";

            cmbcustomerid.DataSource = dtview;
            cmbcustomerid.ValueMember = "id";
            cmbcustomerid.DisplayMember = "id";

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            c.Username = cmbSearchCustomer.Text;
            DataTable dtvalidationname = p.selectcustomerbynamesvalidaion(c);

            if (cmbSearchCustomer.Text != "" || cmbSearchCustomer.Text != "---Select---" || cmbcustomerid.Text != "" || cmbcustomerid.Text != "---Select---" || cmbcustomerid.Text != null || dtvalidationname.Rows.Count==0)
            {
                if (dtvalidationname.Rows.Count == 0)
                {
                    MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    lblCustomerNAme.Text = "Name of customer";
                    lblID.Text = "ID";
                    lblMobileNo.Text = "Mobile Number";
                    txt_fee_collecting_now.Text = "";
                    lbl_balance.Text = "00.00";
                    lblCurrentbalance.Text = "00.00";
                    lblbranch.Text = "Place";
                    textBox1.Text = "";
                }
                else
                {

                    c.Id = int.Parse(cmbcustomerid.Text);
                    DataTable dtview = p.selectcustomerbyid(c);
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
                        lblCustomerNAme.Text = "Name of customer";
                        lblID.Text = "ID";
                        lblMobileNo.Text = "Mobile Number";
                        txt_fee_collecting_now.Text = "";
                        lbl_balance.Text = "00.00";
                        lblCurrentbalance.Text = "00.00";
                        lblbranch.Text = "Place";
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                lblCustomerNAme.Text = "Name of customer";
                lblID.Text = "ID";
                lblMobileNo.Text = "Mobile Number";
                txt_fee_collecting_now.Text = "";
                lbl_balance.Text = "00.00";
                lblCurrentbalance.Text = "00.00";
                lblbranch.Text = "Place";
                textBox1.Text = "";
            }


        }

        private void cmbSearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            errorProviderBillingplus.Clear();
            if (lblCustomerNAme.Text == "Name of customer" || lblMobileNo.Text == "Mobile Number" || txt_fee_collecting_now.Text == "" || lblID.Text == "ID" || lbl_status.Text == "To")
            {


                if (lblCustomerNAme.Text == "Name of customer")
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
                DialogResult dialogResults = MessageBox.Show("Confirm to save this collection for '" + lblCustomerNAme.Text + "' with Amount Rs '" + txt_fee_collecting_now.Text + "' ?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
       
                 //   DialogResult dialogResults = MessageBox.Show("confirm to save this collection?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dialogResults == DialogResult.Yes)
                    {


                        DataTable dtids = p.maxofcollection();
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
                        c.Status = "FROM";
                        c.Remarks = remarkstxt.Text;
                        c.Branch = lblbranch.Text;
                        p.insrtintoinstallmentcollection(c);

                        //update Balance

                        c.Id = int.Parse(lblID.Text);
                        c.Startingamount = decimal.Parse(lbl_balance.Text);
                        c.Status = "FROM";
                        p.updteBalance(c);


                        DialogResult dialogResult = MessageBox.Show("Collection addedd successfully,Do You Want Print?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (dialogResult == DialogResult.Yes)
                        {

                            DataSetCollectAmount ds = new DataSetCollectAmount();
                            DataTable dt = ds.Tables["DataTableCollection"];


                            DateTime dateprint = DateTime.Parse(DtmAmountCollection.Text);
                            var shortdateprint = dateprint.ToString("dd-MMM-yy");




                            dt.Rows.Add(lblID.Text, lblCustomerNAme.Text, txt_fee_collecting_now.Text, lbl_balance.Text, shortdateprint);

                            CrystalReportCollectamount objRpt = new CrystalReportCollectamount();
                            objRpt.Database.Tables["DataTableCollection"].SetDataSource(ds.Tables["DataTableCollection"]);

                            FormPrint f = new FormPrint(objRpt);
                            f.ShowDialog();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }

                        //  MessageBox.Show("Collection addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        lblCustomerNAme.Text = "Name of customer";
                        lblID.Text = "ID";
                        lblMobileNo.Text = "Mobile Number";
                        txt_fee_collecting_now.Text = "";
                        lbl_balance.Text = "00.00";
                        lblCurrentbalance.Text = "00.00";
                        textBox1.Text = "";
                        lblbranch.Text = "Place";
                        // cmbcustomerid.Text = "";
                        //  cmbSearchCustomer.Text = "---Select---";





                    }

            }
        }

        private void BTNCMBIDSEARCH_Click(object sender, EventArgs e)
        {

            if (cmbSearchCustomer.Text != "" || cmbSearchCustomer.Text != "---Select---" || cmbcustomerid.Text != "" || cmbcustomerid.Text != "---Select---")
            {


                c.Id = int.Parse(cmbcustomerid.Text);
                DataTable dtview = p.selectcustomerbyid(c);
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
                    lblCustomerNAme.Text = "Name of customer";
                    lblID.Text = "ID";
                    lblMobileNo.Text = "Mobile Number";
                    txt_fee_collecting_now.Text = "";
                    lbl_balance.Text = "00.00";
                    lblCurrentbalance.Text = "00.00";
                    lblbranch.Text = "Place";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("There is no customer with this name", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                lblCustomerNAme.Text = "Name of customer";
                lblID.Text = "ID";
                lblMobileNo.Text = "Mobile Number";
                txt_fee_collecting_now.Text = "";
                lbl_balance.Text = "00.00";
                lblCurrentbalance.Text = "00.00";
                lblbranch.Text = "Place";
                textBox1.Text = "";
            }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCustomerNAme.Text = "Name of customer";
            lblID.Text = "ID";
            lblMobileNo.Text = "Mobile Number";
            txt_fee_collecting_now.Text = "";
            lbl_balance.Text = "00.00";
            lblCurrentbalance.Text = "00.00";
            lblbranch.Text = "Place";
            textBox1.Text = "";

            //refresh combobox

            DataTable dtview = p.selectcompanycustomerdetails();

            //dgvCustomer.DataSource = dtview;

            cmbSearchCustomer.DataSource = dtview;
            cmbSearchCustomer.ValueMember = "id";
            cmbSearchCustomer.DisplayMember = "username";

            cmbcustomerid.DataSource = dtview;
            cmbcustomerid.ValueMember = "id";
            cmbcustomerid.DisplayMember = "id";


        }

        private void searchCustomer_KeyUp_1(object sender, KeyEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            DataTable dt = p.selectinstallmentdetails(c);
            dgv_collection_todays.AutoGenerateColumns = false;
            dgv_collection_todays.DataSource = dt;
            
            
            
            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();




            //

            DataTable dtview = p.selectcompanycustomerdetails();
            //cmbbranch.DataSource = dtview;
            //cmbbranch.ValueMember = "status";
            //cmbbranch.DisplayMember = "status";

            DataTable dtviews = p.selectcompanycustomerdetails();
            cmbname.DataSource = dtviews;
            cmbname.ValueMember = "username";
            cmbname.DisplayMember = "username";



        }

        private void cmb_name_all_collection_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_collection_todays.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(cmbname.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgv_collection_todays.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();

                }
                else
                    row.Visible = true;

            }

            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();





        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            if (txtpaas.Text == "Admin@123")
            {
                groupBox3.Visible = true;
                dgv_collection_todays.Visible = true;
                lbl_total.Visible = true;
                label8.Visible = true;

              //  groupBox4.Visible = true;



                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();
                DataTable dt = p.selectinstallmentdetails(c);
                dgv_collection_todays.AutoGenerateColumns = false;
                dgv_collection_todays.DataSource = dt;


                decimal total_fee_collcn = 0;
                for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
                {
                    total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

                }
                lbl_total.Text = total_fee_collcn.ToString();






                DataTable dtview = p.selectcompanycustomerdetails();
                //cmbbranch.DataSource = dtview;
                //cmbbranch.ValueMember = "status";
                //cmbbranch.DisplayMember = "status";

                DataTable dtviews = p.selectcompanycustomerdetails();
                cmbname.DataSource = dtviews;
                cmbname.ValueMember = "username";
                cmbname.DisplayMember = "username";



            }
            else
            {
                groupBox3.Visible = false;
                dgv_collection_todays.Visible = false;
                lbl_total.Visible = false;
                label8.Visible = false;
                //groupBox4.Visible = false;

            }
        }

        private void dgv_collection_today_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this collection?", "Biling+", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {



                    //update Amount before deletion



                    c.Username = dgv_collection_todays.CurrentRow.Cells["Column6"].Value.ToString();
                    DataTable dt = p.selectcustomerbyname(c);

                    c.Username = dgv_collection_todays.CurrentRow.Cells["Column6"].Value.ToString();
                    c.Startingamount = c.Startingamount = decimal.Parse(dt.Rows[0][6].ToString()) + decimal.Parse(dgv_collection_todays.CurrentRow.Cells["Column9"].Value.ToString());//old Balance + deleted amout


                    p.updteBalancebyname(c);



                    c.Collctionid = int.Parse(dgv_collection_todays.CurrentRow.Cells["collctionidcolumn"].Value.ToString());

                    p.Deletecollection(c);


                    MessageBox.Show("Collected amount deleted successfully", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    DataTable dtfinancial = p.selectcompany();

                    c.Financialyear = dtfinancial.Rows[0][7].ToString();
                    DataTable dtviw = p.selectinstallmentdetails(c);
                    dgv_collection_todays.AutoGenerateColumns = false;
                    dgv_collection_todays.DataSource = dtviw;
                }

                else if (dialogResult == DialogResult.No)
                {

                }



            }
       
       
       
        }

        private void customerContact_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //(e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // only allow one decimal point
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        }

        private void txtpaas_TextChanged(object sender, EventArgs e)
        {
            if (txtpaas.Text == "Admin@123")
            {


                groupBox3.Visible = true;
                dgv_collection_todays.Visible = true;
                lbl_total.Visible = true;
                label8.Visible = true;
              //  groupBox4.Visible = true;




                DataTable dtfinancial = p.selectcompany();

                c.Financialyear = dtfinancial.Rows[0][7].ToString();
                DataTable dt = p.selectinstallmentdetails(c);
                dgv_collection_todays.AutoGenerateColumns = false;
                dgv_collection_todays.DataSource = dt;


                decimal total_fee_collcn = 0;
                for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
                {
                    total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

                }
                lbl_total.Text = total_fee_collcn.ToString();



                // reffresh


                DataTable dtview = p.selectcompanycustomerdetails();
                //cmbbranch.DataSource = dtview;
                //cmbbranch.ValueMember = "status";
               // cmbbranch.DisplayMember = "status";

                DataTable dtviews = p.selectcompanycustomerdetails();
                cmbname.DataSource = dtviews;
                cmbname.ValueMember = "username";
                cmbname.DisplayMember = "username";





            }
            else
            {
                groupBox3.Visible = false;
                dgv_collection_todays.Visible = false;
                lbl_total.Visible = false;
                label8.Visible = false; 
                //groupBox4.Visible = false;
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

       
        private void locationcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnsearchbranch_Click(object sender, EventArgs e)
        {  
            
            DataTable dtfinancial = p.selectcompany();

      c.Financialyear = dtfinancial.Rows[0][7].ToString();
      c.Branch = cmbbranch.Text;
              DataTable dt= p.selectinstallmentbyname( c);
              dgv_collection_todays.AutoGenerateColumns = false;
              dgv_collection_todays.DataSource = dt;

              decimal total_fee_collcn = 0;
              for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
              {
                  total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

              }
              lbl_total.Text = total_fee_collcn.ToString();

        
        }

        private void btnsearchname_Click(object sender, EventArgs e)
        {
            DataTable dtfinancial = p.selectcompany();

            c.Financialyear = dtfinancial.Rows[0][7].ToString();
            c.Username = cmbname.Text;
            DataTable dt = p.selectinstallmentbynameselct(c);
            dgv_collection_todays.AutoGenerateColumns = false;
            dgv_collection_todays.DataSource = dt;


            decimal total_fee_collcn = 0;
            for (int i = 0; i < dgv_collection_todays.Rows.Count; i++)
            {
                total_fee_collcn += Convert.ToDecimal(dgv_collection_todays.Rows[i].Cells[3].Value);

            }
            lbl_total.Text = total_fee_collcn.ToString();







        }

        private void btn_issue_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("It may take minutes seconds to send SMS according to your internet speed.Some time messeging may be fail..Do you wan to continue?", "Billing+", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {


                    if (dgvCustomer.Rows.Count > 0)
                    {

                        WebClient client = new WebClient();

                        string mb = "";

                        for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                        {
                            mb = mb + dgvCustomer.Rows[i].Cells[5].Value.ToString() + ",";
                        }
                        //      MessageBox.Show(mb.ToString());
                       
                         
                            // string s = "http://sms.moplet.com/api/sendhttp.php?authkey=" + txt_pass.Text + "&mobiles=" + mb + "&message=Dear Parent, Your son /daughter is absent today. Kindly inform the Reason for leave.Thanks and Regards,"+institutionname+"&sender=" + txt_center_id.Text + "&route=4&country=91";
                        string s = "http://smsmymedia.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=3f329a88daa2463c8c5c46442a9981a&message=Dear Customer,You have some pending dues in KTK STORE AYIKKARAPPADI . Remind you to pay the amount more earlier as possible.Thanks and Regards- KTK STORE AYIKKARAPPADI &senderId=KTSTOR&routeId=1&mobileNos=" + mb + "&smsContentType=english";
                          
                            Stream myStream = client.OpenRead(s);


                            StreamReader sr = new StreamReader(myStream);
                            //MessageBox.Show( sr.ReadToEnd().ToString());

                            myStream.Close();
                     
                        // malayalam

                      



                        MessageBox.Show("Messege sent successfully", "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                    }
                    else
                    {

                        MessageBox.Show("There is no record found to send sms", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                    }
                }

                catch (Exception)
                {

                    MessageBox.Show("Can't send SMS,Please check your internet Connection", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_collection_today_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Btnmexport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "CustomerBalanceAmount_BackUp_On_" + SalesDate.Text + ".xls";


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