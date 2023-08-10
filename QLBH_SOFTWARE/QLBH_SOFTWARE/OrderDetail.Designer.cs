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
            dgv_order = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_order).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(648, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 580);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 2);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 2);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 576);
            panel4.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 43);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(650, 20);
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
            btn_exit.Location = new Point(597, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_exit.Size = new Size(50, 47);
            btn_exit.TabIndex = 62;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(590, 2);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 51);
            guna2vSeparator1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 64;
            label1.Text = "Đơn hàng ";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("UTM Avo", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_id.Location = new Point(138, 9);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(90, 34);
            lbl_id.TabIndex = 65;
            lbl_id.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 76);
            label3.Name = "label3";
            label3.Size = new Size(215, 27);
            label3.TabIndex = 66;
            label3.Text = "Thông tin thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM Avo", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 126);
            label4.Name = "label4";
            label4.Size = new Size(45, 24);
            label4.TabIndex = 67;
            label4.Text = "Tên ";
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.Font = new Font("UTM Avo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ten.ForeColor = SystemColors.Highlight;
            lbl_ten.Location = new Point(30, 156);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(60, 23);
            lbl_ten.TabIndex = 68;
            lbl_ten.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UTM Avo", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 186);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 69;
            label6.Text = "Số điện thoại";
            // 
            // lbl_sdt
            // 
            lbl_sdt.AutoSize = true;
            lbl_sdt.Font = new Font("UTM Avo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sdt.ForeColor = SystemColors.Highlight;
            lbl_sdt.Location = new Point(30, 218);
            lbl_sdt.Name = "lbl_sdt";
            lbl_sdt.Size = new Size(60, 23);
            lbl_sdt.TabIndex = 70;
            lbl_sdt.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UTM Avo", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 248);
            label8.Name = "label8";
            label8.Size = new Size(57, 24);
            label8.TabIndex = 71;
            label8.Text = "Email";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("UTM Avo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.ForeColor = SystemColors.Highlight;
            lbl_email.Location = new Point(30, 280);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(60, 23);
            lbl_email.TabIndex = 72;
            lbl_email.Text = "label9";
            // 
            // dgv_order
            // 
            dgv_order.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_order.BorderStyle = BorderStyle.None;
            dgv_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_order.Location = new Point(30, 340);
            dgv_order.Name = "dgv_order";
            dgv_order.RowHeadersVisible = false;
            dgv_order.RowHeadersWidth = 51;
            dgv_order.RowTemplate.Height = 29;
            dgv_order.Size = new Size(596, 195);
            dgv_order.TabIndex = 73;
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(650, 580);
            Controls.Add(dgv_order);
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
            Name = "OrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetail";
            Load += OrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_order).EndInit();
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
        private Label lbl_ten;
        private Label label6;
        private Label lbl_sdt;
        private Label label8;
        private Label lbl_email;
        private DataGridView dgv_order;
    }
}