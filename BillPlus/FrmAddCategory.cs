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
    public partial class frmAddcategory : Form
    {
        public frmAddcategory()
        {
            InitializeComponent();
        }
        containerclass c = new containerclass();
        provider p = new provider();
        private void FrmAddAccountHeads_Load(object sender, EventArgs e)
        {
            DataTable dt = p.selectfromcategory();
            dgvcategory.AutoGenerateColumns = false;
            dgvcategory.DataSource = dt;

          

        }

        private void saveAccountHead_Click(object sender, EventArgs e)
        {
            if (categoryname.Text != "")
            {
               
                DataTable dt = p.selectmaxidcategory();
                if (dt.Rows[0][0].ToString() == "")
                {
                    c.Id = 1;

                }
                else
                {
                    int idValue = (int.Parse(dt.Rows[0][0].ToString())) + 1;
                    c.Id = idValue;
                }

                c.Username = categoryname.Text;
                p.insertintotlcategory(c);

                MessageBox.Show("Category addedd successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                DataTable dts = p.selectfromcategory();
                dgvcategory.AutoGenerateColumns = false;
                dgvcategory.DataSource = dts;
            }
            else
            {
                MessageBox.Show("Please enter new category", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

        
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete?", "BillingPlus+", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                    c.Id = int.Parse(dgvcategory.CurrentRow.Cells["idcolumn"].Value.ToString());
                    p.deletefromcategory(c);
                    MessageBox.Show("Category deleted successfully", "BillingPlus+", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    DataTable dt = p.selectfromcategory();
                    dgvcategory.AutoGenerateColumns = false;
                    dgvcategory.DataSource = dt;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }


            }
        }
          
        
    }
}
