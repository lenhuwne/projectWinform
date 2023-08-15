namespace QLBH_SOFTWARE
{
    partial class ChildFormYtb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFormYtb));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imageytb = new ImageList(components);
            panel1 = new Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            listytb = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageytb
            // 
            imageytb.ColorDepth = ColorDepth.Depth8Bit;
            imageytb.ImageSize = new Size(150, 150);
            imageytb.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 51);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.ButtonHighlight;
            txtSearch.BorderColor = Color.Black;
            txtSearch.BorderRadius = 5;
            txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txtSearch.CustomizableEdges = customizableEdges1;
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
            txtSearch.Location = new Point(699, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Gray;
            txtSearch.PlaceholderText = "Tìm kiếm sản phẩm";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(351, 39);
            txtSearch.TabIndex = 42;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // listytb
            // 
            listytb.Dock = DockStyle.Fill;
            listytb.Location = new Point(0, 51);
            listytb.Name = "listytb";
            listytb.Size = new Size(1053, 521);
            listytb.TabIndex = 3;
            listytb.UseCompatibleStateImageBehavior = false;
            // 
            // ChildFormYtb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 572);
            Controls.Add(listytb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFormYtb";
            Text = "ChildFormYtb";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageytb;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private ListView listytb;
    }
}