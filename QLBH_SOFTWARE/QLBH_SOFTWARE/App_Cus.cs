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
    public partial class App_Cus : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        private int newWidth = 150; // Kích thước mới của ảnh (độ rộng)
        private int newHeight = 150;
        private List<string> imageUrls = new List<string>();
        public App_Cus()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home_Cus home = new Home_Cus();
            home.Show();
            this.Hide();
        }

        private void App_Cus_Load(object sender, EventArgs e)
        {

            lbl_username.Text = TemporaryData.Username;
        }
        #region Method
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panelchildapp.Controls.Remove(activeForm);
                activeForm = null; // Reset activeForm
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildapp.Controls.Add(childForm);
            panelchildapp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Method

        private void btn_gpt_Click(object sender, EventArgs e)
        {

            openChildForm(new ChildFormGpt());
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormApp());
        }
    }
}
