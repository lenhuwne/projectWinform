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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH_SOFTWARE
{
    public partial class Home : Form
    {
        string connect = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public string username = "";
        public Home()
        {
            InitializeComponent();
            this.username = username;

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {

        }

        private void btn_App_Click(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void btn_Game_Click(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_username.Text = TemporaryData.Username;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
