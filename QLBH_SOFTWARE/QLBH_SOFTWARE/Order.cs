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
    public partial class Order : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            adt = new SqlDataAdapter("select idorder,dateorder,totalorder from [order]", conn);
            adt.Fill(dt);
            dgv_order.DataSource = dt;
            dgv_order.Columns[0].HeaderText = "ID";
            dgv_order.Columns[1].HeaderText = "Ngày";
            dgv_order.Columns[2].HeaderText = "Tổng";
            dgv_order.Columns[0].Width = 180;
            dgv_order.Columns[1].Width = 250;
            dgv_order.Columns[2].Width = 250;
            //dgv_order.Columns[3].HeaderText = "ID nhân viên";
            this.dgv_order.DefaultCellStyle.Font = new Font("UTM avo", 10);
            this.dgv_order.CellBorderStyle = DataGridViewCellBorderStyle.None;

        }
        private void tim(string id)
        {
            string sqltim = "select idorder,dateorder,totalorder from [order] where idorder like @id ";
            cmd = new SqlCommand(sqltim, conn);
            cmd.Parameters.AddWithValue("@id", "%" + id + "%");
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(rdr);
            dgv_order.DataSource = dt;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                tim(txt_search.Text);
                txt_search.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            adt = new SqlDataAdapter("select idorder,dateorder,totalorder from [order]", conn);
            adt.Fill(dt);
            dgv_order.DataSource = dt;
            dgv_order.Columns[0].HeaderText = "ID";
            dgv_order.Columns[1].HeaderText = "Ngày";
            dgv_order.Columns[2].HeaderText = "Tổng";
            dgv_order.Columns[0].Width = 180;
            dgv_order.Columns[1].Width = 200;
            dgv_order.Columns[2].Width = 200;
            //dgv_order.Columns[3].HeaderText = "ID nhân viên";
            this.dgv_order.DefaultCellStyle.Font = new Font("UTM avo", 10);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void dgv_order_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
