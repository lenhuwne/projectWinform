namespace QLBH_SOFTWARE
{
    partial class ChildFormOffice
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFormOffice));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imageOffice = new ImageList(components);
            txt_searchApp = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            listOffice = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageOffice
            // 
            imageOffice.ColorDepth = ColorDepth.Depth8Bit;
            imageOffice.ImageSize = new Size(150, 150);
            imageOffice.TransparentColor = Color.Transparent;
            // 
            // txt_searchApp
            // 
            txt_searchApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_searchApp.BackColor = SystemColors.ButtonHighlight;
            txt_searchApp.BorderColor = Color.Black;
            txt_searchApp.BorderRadius = 5;
            txt_searchApp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txt_searchApp.CustomizableEdges = customizableEdges1;
            txt_searchApp.DefaultText = "";
            txt_searchApp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_searchApp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_searchApp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_searchApp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_searchApp.FillColor = SystemColors.ButtonHighlight;
            txt_searchApp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_searchApp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchApp.ForeColor = Color.Black;
            txt_searchApp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_searchApp.IconLeft = (Image)resources.GetObject("txt_searchApp.IconLeft");
            txt_searchApp.IconLeftSize = new Size(30, 30);
            txt_searchApp.Location = new Point(2408, 0);
            txt_searchApp.Name = "txt_searchApp";
            txt_searchApp.PasswordChar = '\0';
            txt_searchApp.PlaceholderForeColor = Color.Gray;
            txt_searchApp.PlaceholderText = "Tìm kiếm sản phẩm";
            txt_searchApp.SelectedText = "";
            txt_searchApp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_searchApp.Size = new Size(351, 39);
            txt_searchApp.TabIndex = 40;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.BackColor = SystemColors.ButtonHighlight;
            guna2TextBox1.BorderColor = Color.Black;
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.ButtonHighlight;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = (Image)resources.GetObject("guna2TextBox1.IconLeft");
            guna2TextBox1.IconLeftSize = new Size(30, 30);
            guna2TextBox1.Location = new Point(1555, 0);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.Gray;
            guna2TextBox1.PlaceholderText = "Tìm kiếm sản phẩm";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(351, 39);
            guna2TextBox1.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(guna2TextBox1);
            panel1.Controls.Add(txt_searchApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 42);
            panel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.ButtonHighlight;
            txtSearch.BorderColor = Color.Black;
            txtSearch.BorderRadius = 5;
            txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txtSearch.CustomizableEdges = customizableEdges5;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FillColor = SystemColors.ButtonHighlight;
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.IconLeftSize = new Size(30, 30);
            txtSearch.Location = new Point(702, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Gray;
            txtSearch.PlaceholderText = "Tìm kiếm sản phẩm";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearch.Size = new Size(351, 39);
            txtSearch.TabIndex = 42;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // listOffice
            // 
            listOffice.Dock = DockStyle.Fill;
            listOffice.LargeImageList = imageOffice;
            listOffice.Location = new Point(0, 42);
            listOffice.Name = "listOffice";
            listOffice.Size = new Size(1053, 539);
            listOffice.TabIndex = 5;
            listOffice.UseCompatibleStateImageBehavior = false;
            // 
            // ChildFormOffice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 581);
            Controls.Add(listOffice);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFormOffice";
            Text = "ChildFormOffice";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageOffice;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchApp;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Panel panel1;
        private ListView listOffice;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}