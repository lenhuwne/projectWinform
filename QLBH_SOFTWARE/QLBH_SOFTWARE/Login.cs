using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_SOFTWARE

{

    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        Home_Cus home;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _id = "";
                string _name = "";
                string _isAdmin = "";

                cn.Open();
                cmd = new SqlCommand("select * from ACCOUNT where userName = @name and passWord = @pass", cn);
                cmd.Parameters.AddWithValue("@name", txtemail.Text);
                cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    _name = dr["userName"].ToString();
                    _isAdmin = dr["isAdmin"].ToString();
                    _id = dr["id"].ToString();
                    if (_isAdmin == "admin")
                    {
                        MessageBox.Show("welcom" + _id + " |", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Home home = new Home();
                        home.txtId.Text = _id;
                        home.txtname.Text = _name;
                        this.Hide();
                        home.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("welcom" + _id + " |", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Home_Cus homecus = new Home_Cus();
                        homecus.txtid.Text = _id;
                        homecus.txtName.Text = _name;
                        homecus.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("sai tên đăng nhập hoặc mật khẩu....vui lòng nhập lại", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}