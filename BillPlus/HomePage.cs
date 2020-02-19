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
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }
        public void main_back_color()
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    c.BackColor = SystemColors.ActiveCaption;
            }
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
           
























































































































































            
           
            //try
            //{



                main_back_color();                     //set back ground color as GradientActiveCaption
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Aflah\Desktop\29085710.wav");
                //player.Play();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Note :  " + ex.Message, "BillPlus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton_mark_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {

        }
        FrmAddMasters masterEntry;
        private void MasterEntryToolBar_Click(object sender, EventArgs e)
        {
            try
            {
                if (masterEntry == null)
                {
                    masterEntry = new FrmAddMasters();
                    masterEntry.MdiParent = this;
                    masterEntry.FormClosed += new FormClosedEventHandler(masterEntry_FormClosed);
                    masterEntry.Show();

                }
                else
                    masterEntry.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void masterEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///throw new NotImplementedException();
            masterEntry = null;
        }
   

       
        FrmAddProduct prdct;
        private void ToolStripButton_mark_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (prdct == null)
                {
                    prdct = new FrmAddProduct();
                    prdct.MdiParent = this;
                    prdct.FormClosed += new FormClosedEventHandler(prdct_FormClosed);
                    prdct.Show();

                }
                else
                    prdct.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void prdct_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            prdct = null;
        }
        FrmSalesVoucher sales;                        
        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sales == null)
                {
                    sales = new FrmSalesVoucher();
                    sales.MdiParent = this;
                    sales.FormClosed += new FormClosedEventHandler(sales_FormClosed);
                    sales.Show();

                }
                else
                    sales.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            sales = null;
        }
        FrmIncomeandexpenses incm;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (incm == null)
                {
                    incm = new FrmIncomeandexpenses();
                    incm.MdiParent = this;
                    incm.FormClosed += new FormClosedEventHandler(incm_FormClosed);
                    incm.Show();

                }
                else
                    incm.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void incm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            incm = null;
        }
      
        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            

        }

        void prfit_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
       

        FrmSMS sms;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sms == null)
                {
                    sms = new FrmSMS();
                    sms.MdiParent = this;
                    sms.FormClosed += new FormClosedEventHandler(sms_FormClosed);
                    sms.Show();

                }
                else
                    sms.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void sms_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            sms = null;
        }
        FrmCmpnySettings setting;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (setting == null)
                {
                    setting = new FrmCmpnySettings();
                    setting.MdiParent = this;
                    setting.FormClosed += new FormClosedEventHandler(setting_FormClosed);
                    setting.Show();

                }
                else
                    setting.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            setting = null;
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     

        private void fileMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (masterEntry == null)
                {
                    masterEntry = new FrmAddMasters();
                    masterEntry.MdiParent = this;
                    masterEntry.FormClosed += new FormClosedEventHandler(masterEntry_FormClosed);
                    masterEntry.Show();

                }
                else
                    masterEntry.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (prdct == null)
                {
                    prdct = new FrmAddProduct();
                    prdct.MdiParent = this;
                    prdct.FormClosed += new FormClosedEventHandler(prdct_FormClosed);
                    prdct.Show();

                }
                else
                    prdct.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (sales == null)
                {
                    sales = new FrmSalesVoucher();
                    sales.MdiParent = this;
                    sales.FormClosed += new FormClosedEventHandler(sales_FormClosed);
                    sales.Show();

                }
                else
                    sales.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (incm == null)
                {
                    incm = new FrmIncomeandexpenses();
                    incm.MdiParent = this;
                    incm.FormClosed += new FormClosedEventHandler(incm_FormClosed);
                    incm.Show();

                }
                else
                    incm.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sms == null)
                {
                    sms = new FrmSMS();
                    sms.MdiParent = this;
                    sms.FormClosed += new FormClosedEventHandler(sms_FormClosed);
                    sms.Show();

                }
                else
                    sms.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void companySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (setting == null)
                {
                    setting = new FrmCmpnySettings();
                    setting.MdiParent = this;
                    setting.FormClosed += new FormClosedEventHandler(setting_FormClosed);
                    setting.Show();

                }
                else
                    setting.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        FrmSupplier suplr;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (suplr == null)
                {
                    suplr = new FrmSupplier();
                    suplr.MdiParent = this;
                    suplr.FormClosed += new FormClosedEventHandler(suplr_FormClosed);
                    suplr.Show();

                }
                else
                    suplr.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void suplr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            suplr = null;

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (suplr == null)
                {
                    suplr = new FrmSupplier();
                    suplr.MdiParent = this;
                    suplr.FormClosed += new FormClosedEventHandler(suplr_FormClosed);
                    suplr.Show();

                }
                else
                    suplr.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        Frmpurchase purch;
        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (purch == null)
                {
                    purch = new Frmpurchase();
                    purch.MdiParent = this;
                    purch.FormClosed += new FormClosedEventHandler(purch_FormClosed);
                    purch.Show();

                }
                else
                    purch.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void purch_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();purch
            purch = null;
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (purch == null)
                {
                    purch = new Frmpurchase();
                    purch.MdiParent = this;
                    purch.FormClosed += new FormClosedEventHandler(purch_FormClosed);
                    purch.Show();

                }
                else
                    purch.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "EduSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


   
      
      
    }
}
