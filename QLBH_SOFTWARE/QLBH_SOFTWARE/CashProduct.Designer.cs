namespace QLBH_SOFTWARE
{
    partial class CashProduct
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            dgvProduct = new DataGridView();
            panel3 = new Panel();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            desription = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            select = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 18);
            panel1.TabIndex = 0;
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtsearch.BackColor = SystemColors.ButtonHighlight;
            txtsearch.BorderColor = Color.Black;
            txtsearch.BorderRadius = 5;
            txtsearch.BorderThickness = 0;
            txtsearch.CustomizableEdges = customizableEdges5;
            txtsearch.DefaultText = "";
            txtsearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtsearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtsearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtsearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtsearch.FillColor = SystemColors.ButtonHighlight;
            txtsearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtsearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtsearch.ForeColor = Color.Black;
            txtsearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtsearch.IconLeft = (Image)resources.GetObject("txtsearch.IconLeft");
            txtsearch.IconLeftSize = new Size(30, 30);
            txtsearch.Location = new Point(283, 12);
            txtsearch.Name = "txtsearch";
            txtsearch.PasswordChar = '\0';
            txtsearch.PlaceholderForeColor = Color.Gray;
            txtsearch.PlaceholderText = "Tìm kiếm sản phẩm";
            txtsearch.SelectedText = "";
            txtsearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtsearch.Size = new Size(382, 39);
            txtsearch.TabIndex = 41;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { id, name, category, desription, price, select });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProduct.Dock = DockStyle.Top;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = SystemColors.ActiveCaptionText;
            dgvProduct.Location = new Point(0, 18);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(1000, 383);
            dgvProduct.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(btnCash);
            panel3.Controls.Add(txtsearch);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 118);
            panel3.TabIndex = 42;
            // 
            // btnCash
            // 
            btnCash.AutoRoundedCorners = true;
            btnCash.BorderRadius = 21;
            btnCash.CustomizableEdges = customizableEdges7;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.FillColor = Color.White;
            btnCash.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCash.ForeColor = Color.Black;
            btnCash.HoverState.BorderColor = Color.Black;
            btnCash.HoverState.FillColor = Color.Black;
            btnCash.HoverState.ForeColor = Color.White;
            btnCash.Location = new Point(829, 6);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCash.Size = new Size(159, 45);
            btnCash.TabIndex = 42;
            btnCash.Text = "ADD";
            btnCash.Click += btnCash_Click;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 51;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 96;
            // 
            // desription
            // 
            desription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            desription.HeaderText = "Descroption";
            desription.MinimumWidth = 6;
            desription.Name = "desription";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            price.DefaultCellStyle = dataGridViewCellStyle5;
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 68;
            // 
            // select
            // 
            select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            select.HeaderText = "Select";
            select.MinimumWidth = 6;
            select.Name = "select";
            select.Width = 53;
            // 
            // CashProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 463);
            Controls.Add(panel3);
            Controls.Add(dgvProduct);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashProduct";
            Text = "CashProduct";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private DataGridView dgvProduct;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn desription;
        private DataGridViewTextBoxColumn price;
        private DataGridViewCheckBoxColumn select;
    }
}