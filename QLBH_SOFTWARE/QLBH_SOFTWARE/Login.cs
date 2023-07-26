using System.Data;
using System.Data.SqlClient;
namespace QLBH_SOFTWARE

{

    public partial class Login : Form
    {
        string connect = @"Data Source=ANXEMER;Initial Catalog=DreamyShop;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public Login()
        {
            InitializeComponent();

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string tk = txtemail.Text;
                    string mk = txtpass.Text;
                    string sql = "select * from ACCOUNT where USERNAME ='" + tk + "' and PASSWORD ='" + mk + "' ";
                    cmd = new SqlCommand(sql, conn);
                    SqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        App tc = new App();
                        tc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);

        }





        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
            if (txtpass.UseSystemPasswordChar)
            {
                checkBox1.Text = "show";
            }
            else
            {
                checkBox1.Text = "hide";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup sg = new Signup();
            sg.Show();
            this.Hide();
        }
    }
}