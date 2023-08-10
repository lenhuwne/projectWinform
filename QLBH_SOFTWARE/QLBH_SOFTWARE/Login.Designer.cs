namespace QLBH_SOFTWARE
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            txtemail = new TextBox();
            txtpass = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            checkBox1 = new CheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(543, 173);
            label1.Name = "label1";
            label1.Size = new Size(186, 31);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ControlLightLight;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtemail.Location = new Point(543, 230);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(367, 39);
            txtemail.TabIndex = 1;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.ControlLightLight;
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Cursor = Cursors.IBeam;
            txtpass.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(543, 332);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(367, 39);
            txtpass.TabIndex = 3;
            txtpass.UseSystemPasswordChar = true;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(543, 286);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("UTM Avo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(778, 445);
            button1.Name = "button1";
            button1.Size = new Size(132, 51);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(-5, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 704);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Location = new Point(358, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 689);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 450);
            label5.Name = "label5";
            label5.Size = new Size(289, 38);
            label5.TabIndex = 17;
            label5.Text = "CENTRIX SOFTWARE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(97, 396);
            label6.Name = "label6";
            label6.Size = new Size(182, 38);
            label6.TabIndex = 18;
            label6.Text = "WELCOM TO";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = Color.Black;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(35, 101);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.Padding = new Padding(1);
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(300, 300);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 16;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(543, 374);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonHighlight;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(1027, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(50, 45);
            guna2Button1.TabIndex = 10;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("UTM Avo", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(543, 445);
            button2.Name = "button2";
            button2.Size = new Size(121, 51);
            button2.TabIndex = 11;
            button2.Text = "Đăng ký ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1078, 2);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1077, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 676);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Desktop;
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(1, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 676);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Desktop;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 677);
            panel6.Name = "panel6";
            panel6.Size = new Size(1074, 2);
            panel6.TabIndex = 15;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(1021, 4);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 45);
            guna2vSeparator1.TabIndex = 33;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(355, 44);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(721, 10);
            guna2Separator1.TabIndex = 34;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1080, 680);
            Controls.Add(guna2vSeparator1);
            Controls.Add(guna2Separator1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(guna2Button1);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(txtemail);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtemail;
        private TextBox txtpass;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}