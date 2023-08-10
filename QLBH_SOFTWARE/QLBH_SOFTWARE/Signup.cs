using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLBH_SOFTWARE
{
    public partial class Signup : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public Signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string email = txt_email.Text;
                    string mk = txt_pass.Text;
                    string user = txt_username.Text;
                    string remk = txt_confirm.Text;


                    if (txt_username.Text == "" || txt_email.Text == "" || txt_pass.Text == "" || txt_confirm.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else if (txt_confirm.Text != txt_pass.Text)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string sql = "Insert into ACCOUNT values ('" + user + "','" + mk + "','" + email + "','0')";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Login lg = new Login();
                        lg.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = !txt_pass.UseSystemPasswordChar;
            if (txt_pass.UseSystemPasswordChar)
            {
                checkBox1.Text = "show";
            }
            else
            {
                checkBox1.Text = "hide";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txt_confirm.UseSystemPasswordChar = !txt_confirm.UseSystemPasswordChar;
            if (txt_confirm.UseSystemPasswordChar)
            {
                checkBox2.Text = "show";
            }
            else
            {
                checkBox2.Text = "hide";
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
