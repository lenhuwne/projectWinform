using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_SOFTWARE
{
    public partial class App : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public App()
        {
            InitializeComponent();

        }

        private void btn_all_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '1' or  cateid = '2' or cateid = '3' or cateid = '4' or cateid = '5'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_gpt_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '1' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_hoctap_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '2'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ip_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE  cateid = '4' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_ytb_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE  cateid = '5'", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
            this.dgv_allpro.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_office_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            dt.Clear();
            adt = new SqlDataAdapter("SELECT IDP,NAMEP,PRICE,CATEID FROM PRODUCT WHERE cateid = '3' ", conn);
            adt.Fill(dt);
            dgv_allpro.DataSource = dt;
            dgv_allpro.Columns[0].HeaderText = "ID ";
            dgv_allpro.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_allpro.Columns[2].HeaderText = "Giá ";
            dgv_allpro.Columns[3].HeaderText = "ID loại sp ";
            dgv_allpro.Columns[0].Width = 50;
            dgv_allpro.Columns[1].Width = 380;
            dgv_allpro.Columns[2].Width = 130;
            dgv_allpro.Columns[3].Width = 70;
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
            //Tìm trong nhóm ứng dụng 

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

        private void dgv_allpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_allpro.Rows[e.RowIndex];
            txt_id.Text = Convert.ToString(row.Cells[0].Value);
            txt_tensp.Text = Convert.ToString(row.Cells[1].Value);
            txt_gia.Text = Convert.ToString(row.Cells[2].Value);
            txt_idcat.Text = Convert.ToString(row.Cells[3].Value);
        }

        private void App_Load(object sender, EventArgs e)
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
