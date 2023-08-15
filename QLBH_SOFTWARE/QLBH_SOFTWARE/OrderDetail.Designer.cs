namespace QLBH_SOFTWARE
{
    partial class OrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetail));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            btn_exit = new Guna.UI2.WinForms.Guna2Button();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            label1 = new Label();
            lbl_id = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_ten = new Label();
            label6 = new Label();
            lbl_sdt = new Label();
            label8 = new Label();
            lbl_email = new Label();
            dgvDonhang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDonhang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(906, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 394);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 2);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 392);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(906, 2);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 390);
            panel4.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 32);
            guna2Separator1.Margin = new Padding(3, 2, 3, 2);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(906, 16);
            guna2Separator1.TabIndex = 61;
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
            btn_exit.Location = new Point(864, 2);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_exit.Size = new Size(44, 35);
            btn_exit.TabIndex = 62;
            btn_exit.Click += btn_exit_Click;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(850, 2);
            guna2vSeparator1.Margin = new Padding(3, 2, 3, 2);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(9, 38);
            guna2vSeparator1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 64;
            label1.Text = "Đơn hàng ";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_id.Location = new Point(121, 7);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(66, 24);
            lbl_id.TabIndex = 65;
            lbl_id.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 57);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 66;
            label3.Text = "Thông tin thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 94);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 67;
            label4.Text = "Tên ";
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ten.ForeColor = SystemColors.Highlight;
            lbl_ten.Location = new Point(26, 117);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(46, 17);
            lbl_ten.TabIndex = 68;
            lbl_ten.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 140);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 69;
            label6.Text = "Số điện thoại";
            // 
            // lbl_sdt
            // 
            lbl_sdt.AutoSize = true;
            lbl_sdt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sdt.ForeColor = SystemColors.Highlight;
            lbl_sdt.Location = new Point(26, 164);
            lbl_sdt.Name = "lbl_sdt";
            lbl_sdt.Size = new Size(46, 17);
            lbl_sdt.TabIndex = 70;
            lbl_sdt.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 186);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 71;
            label8.Text = "Email";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.ForeColor = SystemColors.Highlight;
            lbl_email.Location = new Point(26, 210);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 17);
            lbl_email.TabIndex = 72;
            lbl_email.Text = "label9";
            // 
            // dgvDonhang
            // 
            dgvDonhang.AllowUserToAddRows = false;
            dgvDonhang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDonhang.BorderStyle = BorderStyle.Fixed3D;
            dgvDonhang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDonhang.ColumnHeadersHeight = 30;
            dgvDonhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDonhang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column6, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDonhang.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDonhang.EnableHeadersVisualStyles = false;
            dgvDonhang.GridColor = SystemColors.ActiveCaptionText;
            dgvDonhang.Location = new Point(188, 52);
            dgvDonhang.Margin = new Padding(3, 2, 3, 2);
            dgvDonhang.Name = "dgvDonhang";
            dgvDonhang.RowHeadersVisible = false;
            dgvDonhang.RowHeadersWidth = 51;
            dgvDonhang.RowTemplate.Height = 29;
            dgvDonhang.Size = new Size(692, 326);
            dgvDonhang.TabIndex = 73;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 46;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "ID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 41;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 56;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 55;
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(908, 394);
            Controls.Add(dgvDonhang);
            Controls.Add(lbl_email);
            Controls.Add(label8);
            Controls.Add(lbl_sdt);
            Controls.Add(label6);
            Controls.Add(lbl_ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_id);
            Controls.Add(label1);
            Controls.Add(guna2vSeparator1);
            Controls.Add(btn_exit);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(guna2Separator1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetail";
            Load += OrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Label label1;
        private Label lbl_id;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        public DataGridView dgvDonhang;
        public Label lbl_ten;
        public Label lbl_sdt;
        public Label lbl_email;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}