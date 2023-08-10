using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_SOFTWARE
{
    public partial class Game_Cus : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Game_Cus()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Tim(string ten, string id)
        {
            string sqltim = "SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE IDP LIKE @IDP OR NAMEP LIKE @NAMEP ";
            cmd = new SqlCommand(sqltim, conn);
            cmd.Parameters.AddWithValue("@ID0", id);
            cmd.Parameters.AddWithValue("@NAMEP", ten);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);

        }
        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                Tim(txt_search.Text, txt_search.Text);
                txt_search.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home_Cus home = new Home_Cus();
            home.Show();
            this.Hide();
        }

        private void Game_Cus_Load(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {
        }
    }
}
