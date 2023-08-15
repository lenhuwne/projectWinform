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
    public partial class Game_Cus : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();
        Cash cash;
        Home_Cus homeC;
        Home home;

        //public Game_Cus(Home_Cus form)
        //{
        //    InitializeComponent();
        //    cn = new SqlConnection(dbcon.connection());
        //    openChildForm(new ChildFormAllG());
        //    homeC = form;
        //}
        public Game_Cus()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            openChildForm(new ChildFormAllG());
            
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }




        private void btn_back_Click(object sender, EventArgs e)
        {
            Home_Cus home = new Home_Cus();
            home.Show();
            this.Hide();
        }

        private void Game_Cus_Load(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {
        }
        #region Method
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panelchilgame.Controls.Remove(activeForm);
                activeForm = null; // Reset activeForm
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchilgame.Controls.Add(childForm);
            panelchilgame.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Method

        private void btn_all_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormAllG());
        }

        private void btn_sinhton_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormSurvi());
        }

        private void btn_openworld_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormGOPW());
        }

        private void btn_horror_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormCT());
        }

        private void btn_hanhdong_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormGHD());
        }

        private void btn_adventure_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildFormGGD());
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            //CashProduct product = new CashProduct(cash);
            //if (homeC != null && !homeC.IsDisposed)
            //{
            //    product.cid = homeC.txtid.Text;
            //}
            //else if (home != null && !home.IsDisposed)
            //{
            //    product.cid = home.txtId.Text;
            //}

            //product.ShowDialog();
        }
    }
}
