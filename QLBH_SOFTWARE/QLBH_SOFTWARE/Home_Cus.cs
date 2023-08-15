using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_SOFTWARE
{
    public partial class Home_Cus : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        public Home_Cus()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            openChildForm(new ChildFormHome());
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_App_Click(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
            App_Cus app_Cus = new App_Cus();
            app_Cus.Show();
            this.Hide();
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
            Game_Cus game_Cus = new Game_Cus();
            game_Cus.Show();
            this.Hide();
        }

        private void Home_Cus_Load(object sender, EventArgs e)
        {
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            lbl_username.Text = TemporaryData.Username;
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
        #region Method
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Method

        private void btn_giohang_Click(object sender, EventArgs e)
        {
            openChildForm(new Cash(this));
        }
    }
}
