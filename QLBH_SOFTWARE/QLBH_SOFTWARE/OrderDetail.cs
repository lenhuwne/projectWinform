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
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        SqlDataReader dr;
        Order order;
        string transno = "";

        public OrderDetail(Order form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            order = form;
            //loadCash();

        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
        #region Method
        //public void loadCash()
        //{
        //    order.transno = transno;
        //    cn.Open();
        //    cmd = new SqlCommand("SELECT * FROM CASH INNER JOIN ORDERDETAIL ON CASH.transno = ORDERDETAIL.transno where CASH.transno like '" + transno + "'", cn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        dgvDonhang.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), dr[3].ToString(), dr[2].ToString());
        //    }
        //    dr.Close();
        //    cn.Close();
        //}
        #endregion Method
    }
}
