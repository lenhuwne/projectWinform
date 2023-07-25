namespace QLBH_SOFTWARE
{
    partial class AllProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            dgv_all = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            fileSystemWatcher1 = new FileSystemWatcher();
            fontDialog1 = new FontDialog();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_all).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Controls.Add(guna2Button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 34);
            panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-3, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(42, 34);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 3;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.Desktop;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(1006, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(43, 35);
            guna2Button1.TabIndex = 3;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_search);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 55);
            panel2.TabIndex = 1;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_search.BorderColor = Color.Black;
            txt_search.BorderRadius = 20;
            txt_search.CustomizableEdges = customizableEdges11;
            txt_search.DefaultText = "";
            txt_search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.IconLeft = (Image)resources.GetObject("txt_search.IconLeft");
            txt_search.Location = new Point(796, 6);
            txt_search.Name = "txt_search";
            txt_search.PasswordChar = '\0';
            txt_search.PlaceholderText = "Search";
            txt_search.SelectedText = "";
            txt_search.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txt_search.Size = new Size(250, 42);
            txt_search.TabIndex = 0;
            // 
            // dgv_all
            // 
            dgv_all.AllowUserToAddRows = false;
            dgv_all.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_all.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv_all.Dock = DockStyle.Top;
            dgv_all.Location = new Point(0, 89);
            dgv_all.Name = "dgv_all";
            dgv_all.RowHeadersVisible = false;
            dgv_all.RowHeadersWidth = 51;
            dgv_all.RowTemplate.Height = 29;
            dgv_all.Size = new Size(1049, 245);
            dgv_all.TabIndex = 2;
            dgv_all.CellContentClick += dgv_all_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 62;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Loại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Image";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 57;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Test";
            label1.Click += label1_Click;
            // 
            // AllProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1049, 333);
            Controls.Add(dgv_all);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AllProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllProduct";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_all).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private DataGridView dgv_all;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private FontDialog fontDialog1;
        private Label label1;
    }
}