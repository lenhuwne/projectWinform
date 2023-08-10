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
    public partial class Customer : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn; 
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            adt = new SqlDataAdapter("select idorder,dateorder,totalorder from [order]", conn);
            adt.Fill(dt);
            dgv_khachhang.DataSource = dt;
            dgv_khachhang.Columns[0].HeaderText = "ID";
            dgv_khachhang.Columns[1].HeaderText = "Tên";
            dgv_khachhang.Columns[2].HeaderText = "Số điện thoại";
            dgv_khachhang.Columns[3].HeaderText = "Email";
            dgv_khachhang.Columns[0].Width = 50;
            dgv_khachhang.Columns[1].Width = 250;
            dgv_khachhang.Columns[2].Width = 250;
            dgv_khachhang.Columns[3].Width = 250;
            //dgv_order.Columns[3].HeaderText = "ID nhân viên";
            this.dgv_khachhang.DefaultCellStyle.Font = new Font("UTM avo", 10);
            this.dgv_khachhang.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
        private void tim(string id, string ten)
        {
            string sqltim = "SELECT * FROM CUSTOMER WHERE IDCUS LIKE @ID  OR nameCustomer LIKE @NAME ";
            cmd.Parameters.AddWithValue("@ID", "%"+id +"%");
            cmd.Parameters.AddWithValue("@NAME", "% "+ten +"%");    
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
