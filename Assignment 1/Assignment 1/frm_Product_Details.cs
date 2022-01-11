using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frm_Product_Details : Form
    {
        public frm_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_Product_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Management_System_DBDataSet.Tbl_Product_Details' table. You can move, or remove it, as needed.
            this.tbl_Product_DetailsTableAdapter.Fill(this.product_Management_System_DBDataSet.Tbl_Product_Details);

        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANP = new frm_Add_New_Product();
            ANP.Show();
            this.Hide();
        }
    }
}
