﻿using System;
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
    public partial class ChildFormAllG : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBContext dbcon = new DBContext();

        private int newWidth = 150; // Kích thước mới của ảnh (độ rộng)
        private int newHeight = 150;
        private List<string> imageUrls = new List<string>();
        public ChildFormAllG()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            load();
        }


        #region Method 
        private void LoadimageToListView()
        {
            listGame.Items.Clear();
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
                        imageGame.Images.Add(image);

                        ListViewItem item = new ListViewItem(description);
                        item.ImageIndex = imageGame.Images.Count - 1;
                        listGame.Items.Add(item);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu không tải được ảnh từ URL
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                }
            }

            // Thiết lập ListView để hiển thị các ảnh và dòng văn bản
            listGame.LargeImageList = imageGame;
        }
        private void selectImageFromDb()
        {
            imageUrls.Clear();
            cmd = new SqlCommand("select * from PRODUCT where cateid >= 6 and nameP like '%" + txtSearch.Text + "%'", cn);
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
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            selectImageFromDb();
            LoadimageToListView();
        }

        #endregion Method


    }
}
