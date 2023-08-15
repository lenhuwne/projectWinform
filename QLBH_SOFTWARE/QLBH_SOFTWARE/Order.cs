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
using System.Reflection;
using System.Security.Policy;

namespace QLBH_SOFTWARE
{
    public partial class Order : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        Home home;
        SqlDataReader dr;
        


        public Order()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            string transno;
            foreach (DataGridViewRow dr in dgvDonhang.Rows)
            {
                transno = dr.Cells[1].Value.ToString();

            }
            
            loadOrder();
            //loadCash();

        }

        private void Order_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection(connect);
            //adt = new SqlDataAdapter("select idorder,dateorder,totalorder from [order]", conn);
            //adt.Fill(dt);
            //dgv_order.DataSource = dt;
            //dgv_order.Columns[0].HeaderText = "ID";
            //dgv_order.Columns[1].HeaderText = "Ngày";
            //dgv_order.Columns[2].HeaderText = "Tổng";
            //dgv_order.Columns[0].Width = 180;
            //dgv_order.Columns[1].Width = 250;
            //dgv_order.Columns[2].Width = 250;
            ////dgv_order.Columns[3].HeaderText = "ID nhân viên";
            //this.dgv_order.DefaultCellStyle.Font = new Font("UTM avo", 10);
            //this.dgv_order.CellBorderStyle = DataGridViewCellBorderStyle.None;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    conn.Open();

            //    tim(txt_search.Text);
            //    txt_search.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            //}
            //conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //conn = new SqlConnection(connect);
            //adt = new SqlDataAdapter("select idorder,dateorder,totalorder from [order]", conn);
            //adt.Fill(dt);
            //dgv_order.DataSource = dt;
            //dgv_order.Columns[0].HeaderText = "ID";
            //dgv_order.Columns[1].HeaderText = "Ngày";
            //dgv_order.Columns[2].HeaderText = "Tổng";
            //dgv_order.Columns[0].Width = 180;
            //dgv_order.Columns[1].Width = 200;
            //dgv_order.Columns[2].Width = 200;
            ////dgv_order.Columns[3].HeaderText = "ID nhân viên";
            //this.dgv_order.DefaultCellStyle.Font = new Font("UTM avo", 10);
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
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            loadOrder();
        }
        #region Method
        public void loadOrder()
        {
            dgvDonhang.Rows.Clear();
            cmd = new SqlCommand("SELECT * from ORDERDETAIL WHERE nameCus like N'%" + txt_search.Text + "%' or cusId like '%" + txt_search.Text + "%' or transno like '%" + txt_search.Text + "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                dgvDonhang.Rows.Add(dr[0].ToString(), dr[7].ToString(), dr[5].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[6].ToString());
            }
            cn.Close();
            dr.Close();
        }
        

        #endregion MEthod


        private void dgvDonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string colname = dgvDonhang.Columns[e.ColumnIndex].Name;

            if (colname == "view")
            {


                OrderDetail detail = new OrderDetail(this);
                detail.lbl_ten.Text = dgvDonhang.Rows[e.RowIndex].Cells[3].Value.ToString();
                detail.lbl_email.Text = dgvDonhang.Rows[e.RowIndex].Cells[5].Value.ToString();
                detail.lbl_sdt.Text = dgvDonhang.Rows[e.RowIndex].Cells[4].Value.ToString();
                detail.txtTransno.Text = dgvDonhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                detail.loadCash();
                detail.Show();
                
                
            }
        }
    }
}
