using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_1
{
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQTNRN5\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void con_open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void con_close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        void clear_control()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();

            tb_Product_ID.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();

            if(tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Insert Into Tbl_Product_Details values(@PID,@PName,@PPrice,@SPrice)";

                cmd.Parameters.Add("PID",SqlDbType.Int).Value = tb_Product_ID.Text;
                cmd.Parameters.Add("PName",SqlDbType.VarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("PPrice",SqlDbType.Money).Value = tb_Purchase_Price.Text;
                cmd.Parameters.Add("SPrice",SqlDbType.Money).Value = tb_Purchase_Price.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                clear_control();
            }
            else
            {
                MessageBox.Show("Please Enter Currect Infomation","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clear_control();
            }
            con_close();
        }

        private void btn_View_All_Product_Click(object sender, EventArgs e)
        {
            frm_Product_Details PD = new frm_Product_Details();
            PD.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_control();
        }
    }
}
