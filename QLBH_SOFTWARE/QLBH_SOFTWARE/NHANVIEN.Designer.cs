namespace QLBH_SOFTWARE
{
    partial class Nhân_viên
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
            dataGridViewnv = new DataGridView();
            txtngaysinh = new TextBox();
            label4 = new Label();
            txtgtnv = new TextBox();
            label3 = new Label();
            txttennv = new TextBox();
            label2 = new Label();
            txtmanv = new TextBox();
            label1 = new Label();
            txtdtnv = new TextBox();
            label5 = new Label();
            txtemailnv = new TextBox();
            label6 = new Label();
            btntimkiem = new Button();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnv).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewnv
            // 
            dataGridViewnv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewnv.Location = new Point(12, 18);
            dataGridViewnv.Name = "dataGridViewnv";
            dataGridViewnv.RowHeadersWidth = 51;
            dataGridViewnv.RowTemplate.Height = 29;
            dataGridViewnv.Size = new Size(581, 338);
            dataGridViewnv.TabIndex = 1;
            // 
            // txtngaysinh
            // 
            txtngaysinh.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtngaysinh.Location = new Point(624, 211);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(174, 27);
            txtngaysinh.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(624, 189);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 20;
            label4.Text = "Ngày sinh";
            // 
            // txtgtnv
            // 
            txtgtnv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtgtnv.Location = new Point(624, 159);
            txtgtnv.Name = "txtgtnv";
            txtgtnv.Size = new Size(174, 27);
            txtgtnv.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(624, 137);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 18;
            label3.Text = "Giới tính";
            // 
            // txttennv
            // 
            txttennv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txttennv.Location = new Point(624, 107);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(174, 27);
            txttennv.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(624, 85);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 16;
            label2.Text = "Họ tên nhân viên";
            label2.Click += label2_Click;
            // 
            // txtmanv
            // 
            txtmanv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtmanv.Location = new Point(624, 55);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(174, 27);
            txtmanv.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(624, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 14;
            label1.Text = "Mã nhân viên";
            // 
            // txtdtnv
            // 
            txtdtnv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtdtnv.Location = new Point(624, 263);
            txtdtnv.Name = "txtdtnv";
            txtdtnv.Size = new Size(174, 27);
            txtdtnv.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(624, 241);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 22;
            label5.Text = "Điện thoại";
            // 
            // txtemailnv
            // 
            txtemailnv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtemailnv.Location = new Point(624, 315);
            txtemailnv.Name = "txtemailnv";
            txtemailnv.Size = new Size(174, 27);
            txtemailnv.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(624, 293);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 24;
            label6.Text = "Email";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(12, 393);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 30;
            btntimkiem.Text = "Tìm kiếm ";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(499, 393);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 29;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(386, 393);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 28;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(257, 393);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 27;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(136, 393);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 26;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // Nhân_viên
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 486);
            Controls.Add(btntimkiem);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtemailnv);
            Controls.Add(label6);
            Controls.Add(txtdtnv);
            Controls.Add(label5);
            Controls.Add(txtngaysinh);
            Controls.Add(label4);
            Controls.Add(txtgtnv);
            Controls.Add(label3);
            Controls.Add(txttennv);
            Controls.Add(label2);
            Controls.Add(txtmanv);
            Controls.Add(label1);
            Controls.Add(dataGridViewnv);
            MinimizeBox = false;
            Name = "Nhân_viên";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân_viên";
            ((System.ComponentModel.ISupportInitialize)dataGridViewnv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewnv;
        private TextBox txtngaysinh;
        private Label label4;
        private TextBox txtgtnv;
        private Label label3;
        private TextBox txttennv;
        private Label label2;
        private TextBox txtmanv;
        private Label label1;
        private TextBox txtdtnv;
        private Label label5;
        private TextBox txtemailnv;
        private Label label6;
        private Button btntimkiem;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
    }
}