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
    public partial class Game : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Game()
        {
            InitializeComponent();
        }

        private void btn_gpt_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '9'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '6' or  cateid = '7' or cateid = '8' or cateid = '9' or cateid = '10'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_openworld_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '7' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_horror_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '8' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_adventure_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '10'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }



        private void btn_sinhton_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '6' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 120;
            dgv_allpro.Columns[3].Width = 80;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlinsert = "INSERT INTO PRODUCT VALUES (@NAMEP,@PRICE,@IMAGE,@CATEID) ";
            using (cmd = new SqlCommand(sqlinsert, conn))
            {

                cmd.Parameters.AddWithValue("@NAMEP", txt_tensp.Text);
                cmd.Parameters.AddWithValue("@PRICE", txt_gia.Text);
                cmd.Parameters.AddWithValue("@IMAGE", "");
                cmd.Parameters.AddWithValue("@CATEID", txt_idcat.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm SẢN PHẨM thành công!");
                    dt.Clear();
                    adt = new SqlDataAdapter("SELECT * FROM PRODUCT", conn);
                    adt.Fill(dt);
                    dgv_allpro.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_id.Text = "";
                txt_tensp.Text = "";
                txt_gia.Text = "";
                txt_idcat.Text = "";

            }
            conn.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlupdate = "UPDATE PRODUCT SET NAMEP= @NAMEP , GIA =@GIA , CATEID =@CATEID WHERE IDP =@IDP";
            using (cmd = new SqlCommand(sqlupdate, conn))
            {
                cmd.Parameters.AddWithValue("@NAMEP", txt_tensp.Text);
                cmd.Parameters.AddWithValue("@PRICE", txt_gia.Text);
                cmd.Parameters.AddWithValue("@IMAGE", "");
                cmd.Parameters.AddWithValue("@CATEID", txt_idcat.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công ");
                    dt.Clear();
                    adt = new SqlDataAdapter("SELECT * FROM PRODUCT", conn);
                    adt.Fill(dt);
                    dgv_allpro.DataSource = dt;

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                txt_id.Text = "";
                txt_tensp.Text = "";
                txt_gia.Text = "";
                txt_idcat.Text = "";
            }
            conn.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqldelete = "DELETE FROM PRODUCT WHERE IDP = @IDP";
            using (cmd = new SqlCommand(sqldelete, conn))
            {
                cmd.Parameters.AddWithValue("@IDP", txt_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công ");
                dt.Clear();
                adt = new SqlDataAdapter("SELECT * FROM PRODUCT", conn);
                adt.Fill(dt);
                dgv_allpro.DataSource = dt;

            }
            txt_id.Text = "";
            conn.Close();
        }
        private void tim(string tensp, string id)
        {
            //Tìm trong nhóm game

            string sqltimkiem = "SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE IDP LIKE @IDP OR NAMEP LIKE @NAMEP";
            cmd = new SqlCommand(sqltimkiem, conn);
            cmd.Parameters.AddWithValue("@NAMEP", "%" + tensp + "%");
            cmd.Parameters.AddWithValue("@IDP", "%" + id + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rd);
            dgv_allpro.DataSource = dt;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                tim(txt_search.Text, txt_search.Text);
                txt_search.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            lbl_username.Text = TemporaryData.Username;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
