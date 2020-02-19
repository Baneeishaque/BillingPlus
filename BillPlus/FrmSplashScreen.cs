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
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        Timer tmr;
    
        private void FrmSplashScreen_Shown(object sender, EventArgs e)
        {
            try
            {


                tmr = new Timer();
                //set time interval 3 sec
                tmr.Interval = 2000;
                //starts the timer
                tmr.Start();
                tmr.Tick += tmr_Tick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note :  " + ex.Message, "BillPlus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            HomePage mf = new HomePage();
            mf.Show();
            //hide this form
            this.Hide();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }

    }
}
