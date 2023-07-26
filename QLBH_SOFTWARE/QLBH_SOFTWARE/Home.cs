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
        string connect = @"Data Source=ANXEMER;Initial Catalog=DreamyShop;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        public Home()
        {
            InitializeComponent();
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
            LoadData();
        }
    private void LoadData()
    {
        string connectionString = @"Data Source=ANXEMER;Initial Catalog=DreamyShop;Integrated Security=True";
        string query = "SELECT * FROM Game";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        item.SubItems.Add(reader[i].ToString());
                    }
                    listView1.Items.Add(item);
                }
            }
        }
    }
    }
}
