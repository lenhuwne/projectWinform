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
        public void loadCash()
        {
            int i = 0;
            dgvCash.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM CASH where transno like '" + txtTransno.Text + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCash.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }
        #endregion Method
    }
}
