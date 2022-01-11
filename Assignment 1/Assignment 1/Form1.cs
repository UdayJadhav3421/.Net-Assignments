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
    public partial class frm_LOGIN : Form
    {
        public frm_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("WELCOME", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Product ANP = new frm_Add_New_Product();
                ANP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password", "Incurrect Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_NOTE.Text = "Enter Currect Username && Password";
                lbl_NOTE.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
       }
    }
}
