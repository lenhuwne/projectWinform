namespace QLBH_SOFTWARE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dataGridViewsp = new DataGridView();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            btntimkiem = new Button();
            label1 = new Label();
            txtmasp = new TextBox();
            txtmaloaisp = new TextBox();
            label2 = new Label();
            txttensp = new TextBox();
            label3 = new Label();
            txtsoluong = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsp).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewsp
            // 
            dataGridViewsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsp.Location = new Point(330, 18);
            dataGridViewsp.Name = "dataGridViewsp";
            dataGridViewsp.RowHeadersWidth = 51;
            dataGridViewsp.RowTemplate.Height = 29;
            dataGridViewsp.Size = new Size(581, 338);
            dataGridViewsp.TabIndex = 0;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(456, 418);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 1;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(578, 418);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 2;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(703, 418);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(825, 418);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 4;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(334, 418);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 5;
            btntimkiem.Text = "Tìm kiếm ";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(88, 51);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã sản phẩm";
            // 
            // txtmasp
            // 
            txtmasp.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtmasp.Location = new Point(88, 82);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(174, 27);
            txtmasp.TabIndex = 7;
            // 
            // txtmaloaisp
            // 
            txtmaloaisp.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtmaloaisp.Location = new Point(88, 157);
            txtmaloaisp.Name = "txtmaloaisp";
            txtmaloaisp.Size = new Size(174, 27);
            txtmaloaisp.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(88, 126);
            label2.Name = "label2";
            label2.Size = new Size(144, 19);
            label2.TabIndex = 8;
            label2.Text = "Mã loại sản phẩm";
            // 
            // txttensp
            // 
            txttensp.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txttensp.Location = new Point(88, 234);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(174, 27);
            txttensp.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(88, 203);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 10;
            label3.Text = "Tên sản phẩm";
            // 
            // txtsoluong
            // 
            txtsoluong.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtsoluong.Location = new Point(88, 306);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(174, 27);
            txtsoluong.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(88, 275);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 12;
            label4.Text = "Số lượng ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.centrix;
            ClientSize = new Size(933, 486);
            Controls.Add(txtsoluong);
            Controls.Add(label4);
            Controls.Add(txttensp);
            Controls.Add(label3);
            Controls.Add(txtmaloaisp);
            Controls.Add(label2);
            Controls.Add(txtmasp);
            Controls.Add(label1);
            Controls.Add(btntimkiem);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(dataGridViewsp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm ";
            ((System.ComponentModel.ISupportInitialize)dataGridViewsp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewsp;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthoat;
        private Button btntimkiem;
        private Label label1;
        private TextBox txtmasp;
        private TextBox txtmaloaisp;
        private Label label2;
        private TextBox txttensp;
        private Label label3;
        private TextBox txtsoluong;
        private Label label4;
    }
}