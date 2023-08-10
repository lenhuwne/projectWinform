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
    public partial class OrderDetail : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public OrderDetail()
        {
            InitializeComponent();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            dgv_order.Columns[0].HeaderText = "Sản phẩm";
            dgv_order.Columns[1].HeaderText = "Số lượng";
            dgv_order.Columns[2].HeaderText = "Giá";
            dgv_order.Columns[0].Width = 250;
            dgv_order.Columns[1].Width = 40;
            dgv_order.Columns[2].Width = 50;
            this.dgv_order.DefaultCellStyle.Font = new Font("UTM avo", 10);
            this.dgv_order.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
    }
}
