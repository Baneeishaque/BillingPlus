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
    public partial class FormPrint : Form
    {
        //private CrystalReportCollectamount objRpt;

        public FormPrint()
        {
            InitializeComponent();
        }
     
        //DataSetSalesinvoice objRptsalesinv;
        //private CrystalReporttotatltobepaid objRpt_2;
        public FormPrint(CrystalReportCollectamount objRpt)
        {


            try
            {


                InitializeComponent();
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        public FormPrint(CrystalReportSalesBill objRptsalesinv)
        {


            try
            {


                InitializeComponent();
                crystalReportViewer1.ReportSource = objRptsalesinv;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public FormPrint(CrystalReporttotatltobepaid objRpt_2)
        {
            // TODO: Complete member initialization
           // this.objRpt_2 = objRpt_2;


            try
            {


                InitializeComponent();
                crystalReportViewer1.ReportSource = objRpt_2;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "Billing+", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
