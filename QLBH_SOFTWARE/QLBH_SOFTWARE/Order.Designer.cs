namespace QLBH_SOFTWARE
{
    partial class Order
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btn_exit = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            dgv_order = new DataGridView();
            btn_back = new Guna.UI2.WinForms.Guna2Button();
            btn_search = new Guna.UI2.WinForms.Guna2Button();
            txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            btn_reload = new Guna.UI2.WinForms.Guna2Button();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgv_order).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 3);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(750, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 597);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 597);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 3);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 594);
            panel4.TabIndex = 3;
            // 
            // btn_exit
            // 
            btn_exit.CustomizableEdges = customizableEdges1;
            btn_exit.DisabledState.BorderColor = Color.DarkGray;
            btn_exit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exit.FillColor = SystemColors.ButtonHighlight;
            btn_exit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.White;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageSize = new Size(25, 25);
            btn_exit.Location = new Point(700, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_exit.Size = new Size(50, 47);
            btn_exit.TabIndex = 4;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 5;
            label1.Text = "Đơn hàng ";
            // 
            // dgv_order
            // 
            dgv_order.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_order.BorderStyle = BorderStyle.Fixed3D;
            dgv_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_order.Location = new Point(3, 120);
            dgv_order.Name = "dgv_order";
            dgv_order.RowHeadersWidth = 51;
            dgv_order.RowTemplate.Height = 29;
            dgv_order.Size = new Size(747, 477);
            dgv_order.TabIndex = 6;
            dgv_order.CellBorderStyleChanged += dgv_order_CellBorderStyleChanged;
            // 
            // btn_back
            // 
            btn_back.CustomizableEdges = customizableEdges3;
            btn_back.DisabledState.BorderColor = Color.DarkGray;
            btn_back.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_back.FillColor = SystemColors.ButtonHighlight;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageSize = new Size(25, 25);
            btn_back.Location = new Point(9, 4);
            btn_back.Name = "btn_back";
            btn_back.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_back.Size = new Size(47, 49);
            btn_back.TabIndex = 48;
            // 
            // btn_search
            // 
            btn_search.CustomBorderColor = Color.Black;
            btn_search.CustomizableEdges = customizableEdges5;
            btn_search.DisabledState.BorderColor = Color.DarkGray;
            btn_search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_search.FillColor = Color.Gray;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.ForeColor = Color.White;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageSize = new Size(30, 30);
            btn_search.Location = new Point(584, 64);
            btn_search.Name = "btn_search";
            btn_search.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_search.Size = new Size(48, 45);
            btn_search.TabIndex = 58;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_search.BackColor = SystemColors.ButtonHighlight;
            txt_search.BorderColor = Color.Black;
            txt_search.BorderRadius = 5;
            txt_search.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txt_search.CustomizableEdges = customizableEdges7;
            txt_search.DefaultText = "";
            txt_search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_search.FillColor = SystemColors.ButtonFace;
            txt_search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.IconLeftSize = new Size(38, 30);
            txt_search.Location = new Point(386, 64);
            txt_search.Name = "txt_search";
            txt_search.PasswordChar = '\0';
            txt_search.PlaceholderText = "Tìm kiếm đơn hàng ";
            txt_search.SelectedText = "";
            txt_search.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_search.Size = new Size(236, 45);
            txt_search.TabIndex = 57;
            // 
            // btn_reload
            // 
            btn_reload.CustomizableEdges = customizableEdges9;
            btn_reload.DisabledState.BorderColor = Color.DarkGray;
            btn_reload.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_reload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_reload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_reload.FillColor = Color.Gray;
            btn_reload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reload.ForeColor = Color.White;
            btn_reload.Image = (Image)resources.GetObject("btn_reload.Image");
            btn_reload.ImageSize = new Size(30, 30);
            btn_reload.Location = new Point(647, 64);
            btn_reload.Name = "btn_reload";
            btn_reload.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_reload.Size = new Size(45, 45);
            btn_reload.TabIndex = 59;
            btn_reload.Click += guna2Button1_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 43);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(747, 20);
            guna2Separator1.TabIndex = 60;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(690, 3);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 50);
            guna2vSeparator1.TabIndex = 61;
            // 
            // btn_xoa
            // 
            btn_xoa.CustomizableEdges = customizableEdges11;
            btn_xoa.DisabledState.BorderColor = Color.DarkGray;
            btn_xoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_xoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_xoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_xoa.FillColor = Color.Gray;
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.White;
            btn_xoa.Image = (Image)resources.GetObject("btn_xoa.Image");
            btn_xoa.ImageSize = new Size(30, 30);
            btn_xoa.Location = new Point(700, 64);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btn_xoa.Size = new Size(45, 45);
            btn_xoa.TabIndex = 62;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(753, 600);
            Controls.Add(btn_xoa);
            Controls.Add(guna2vSeparator1);
            Controls.Add(guna2Separator1);
            Controls.Add(btn_reload);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(btn_back);
            Controls.Add(dgv_order);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Label label1;
        private DataGridView dgv_order;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_reload;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
    }
}