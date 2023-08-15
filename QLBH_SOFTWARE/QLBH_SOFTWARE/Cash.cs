using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_SOFTWARE
{
    public partial class Cash : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        Home_Cus homeC;
        Home home;
        Login formL;
        SqlDataReader dr;
        public Cash(Home_Cus form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            homeC = form;
            getTransno();
            loadCash();
        }
       
        public Cash(Home form)
        {
            InitializeComponent();
            home = form;
            cn = new SqlConnection(dbcon.connection());
            getTransno();
            loadCash();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            CashProduct product = new CashProduct(this);
            if (homeC != null && !homeC.IsDisposed)
            {
                product.cid = homeC.txtid.Text;
            }
            else if (home != null && !home.IsDisposed)
            {
                product.cid = home.txtId.Text;
            }

            product.ShowDialog();
        }
        private void btn_dathang_Click(object sender, EventArgs e)
        {
            string cid = "";
            foreach (DataGridViewRow dr in dgvDonhang.Rows)
            {
                cid = dr.Cells[2].Value.ToString();

            }
            try
            {
                cmd = new SqlCommand("insert into ORDERDETAIL(nameCus,phonenumber,emailCus,cusId,total,transno,statusOrder) values (@name,@phome,@email,@cusid,@total,@transno,@status)", cn);
                cmd.Parameters.AddWithValue("@name", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@phome", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@cusid", cid);
                cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lbTotal.Text));
                cmd.Parameters.AddWithValue("@transno", lbTransaction.Text);
                cmd.Parameters.AddWithValue("@status", '0');
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Đơn hàng của m đã thêm", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDonhang.Rows.Clear();
            clear();
        }
        #region Method
        public void getTransno()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count = 0;
                string transno;

                cn.Open();
                cmd = new SqlCommand("select top 1 transno from CASH where transno like '" + sdate + "%' order by cashId DESC", cn);
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(0, 4));
                    lbTransaction.Text = sdate + (count + 1);
                }
                else
                {
                    transno =  "1001";
                    lbTransaction.Text = transno;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvDonhang.Columns[e.ColumnIndex].Name;
        removeitem:
            if (colname == "delete")
            {
                cn.Open();
                cmd = new SqlCommand("delete from CASH where cashId like '" + dgvDonhang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                dr = cmd.ExecuteReader();
                cn.Close();
            }
            else if (colname == "increase")
            {
                cn.Open();
                cmd = new SqlCommand("update CASH set quantity = quantity +" + 1 + "where cashId like '" + dgvDonhang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                dr = cmd.ExecuteReader();
                cn.Close();
            }
            else if (colname == "decrease")
            {
                if (int.Parse(dgvDonhang.Rows[e.RowIndex].Cells[5].Value.ToString()) == 1)
                {
                    colname = "delete";
                    goto removeitem;
                }
                cn.Open();
                cmd = new SqlCommand("update CASH set quantity = quantity - " + 1 + "where cashId like '" + dgvDonhang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                dr = cmd.ExecuteReader();
                cn.Close();
            }
            loadCash();
        }
        public void loadCash()
        {
            try
            {
                int i = 0;
                double total = 0;
                dgvDonhang.Rows.Clear();
                cmd = new SqlCommand("SELECT cashId,pId,pName,quantity,price,total,c.id from CASH left join ACCOUNT c on CASH.CusId  = c.id where transno like '" + lbTransaction.Text + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvDonhang.Rows.Add(i, dr[0].ToString(), dr[6].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    total += double.Parse(dr[5].ToString());
                }
                dr.Close();
                cn.Close();
                lbTotal.Text = total.ToString("#,##0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            txt_email.Clear();
            txt_hoten.Clear();
            txt_sdt.Clear();
        }
        #endregion Method



    }
}
