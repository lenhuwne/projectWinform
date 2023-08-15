namespace QLBH_SOFTWARE
{
    partial class ChildFromHoctap
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFromHoctap));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imageHoctap = new ImageList(components);
            panel1 = new Panel();
            listHoctap = new ListView();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageHoctap
            // 
            imageHoctap.ColorDepth = ColorDepth.Depth8Bit;
            imageHoctap.ImageSize = new Size(150, 150);
            imageHoctap.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 42);
            panel1.TabIndex = 1;
            // 
            // listHoctap
            // 
            listHoctap.Dock = DockStyle.Fill;
            listHoctap.LargeImageList = imageHoctap;
            listHoctap.Location = new Point(0, 42);
            listHoctap.Name = "listHoctap";
            listHoctap.Size = new Size(1053, 539);
            listHoctap.TabIndex = 2;
            listHoctap.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.ButtonHighlight;
            txtSearch.BorderColor = Color.Black;
            txtSearch.BorderRadius = 5;
            txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txtSearch.CustomizableEdges = customizableEdges3;
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
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(351, 39);
            txtSearch.TabIndex = 41;
            // 
            // ChildFromHoctap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 581);
            Controls.Add(listHoctap);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFromHoctap";
            Text = "Hoctap";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageHoctap;
        private Panel panel1;
        private ListView listHoctap;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}