using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_SOFTWARE
{
    public partial class ChildFormOffice : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();

        private int newWidth = 150; // Kích thước mới của ảnh (độ rộng)
        private int newHeight = 150;
        private List<string> imageUrls = new List<string>();
        public ChildFormOffice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            load();
        }
        #region Method
        private void selectImageFromDb()
        {
            imageUrls.Clear();
            cmd = new SqlCommand("select * from PRODUCT where cateid = 2 and nameP like '%" + txt_searchApp.Text + "%'", cn);
            cn.Open();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string iamgeUrl = rd[3].ToString();
                    string nameGame = rd[1].ToString();


                    imageUrls.Add(iamgeUrl + "," + nameGame);
                }
                rd.Close();
                cn.Close();
            }

        }
        private void LoadimageToListView()
        {
            listOffice.Items.Clear();
            foreach (string imageData in imageUrls)
            {
                string[] data = imageData.Split(',');
                if (data.Length == 2)
                {
                    string imageUrl = data[0];
                    string description = data[1];

                    try
                    {
                        WebClient webClient = new WebClient();
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        Image image = Image.FromStream(new System.IO.MemoryStream(imageBytes));
                        imageOffice.Images.Add(image);

                        ListViewItem item = new ListViewItem(description);
                        item.ImageIndex = imageOffice.Images.Count - 1;
                        listOffice.Items.Add(item);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu không tải được ảnh từ URL
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                }
            }

            // Thiết lập ListView để hiển thị các ảnh và dòng văn bản
            listOffice.LargeImageList = imageOffice;

        }
        private void load()
        {
            selectImageFromDb();
            LoadimageToListView();
        }

        #endregion Method

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
