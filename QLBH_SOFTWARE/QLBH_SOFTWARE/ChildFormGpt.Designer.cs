namespace QLBH_SOFTWARE
{
    partial class ChildFormGpt
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFormGpt));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imageGpt = new ImageList(components);
            imageApp = new ImageList(components);
            panelApp = new Panel();
            listGpt = new ListView();
            txt_searchApp = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            txtSeatchGpt = new Guna.UI2.WinForms.Guna2TextBox();
            panelApp.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageGpt
            // 
            imageGpt.ColorDepth = ColorDepth.Depth8Bit;
            imageGpt.ImageSize = new Size(150, 150);
            imageGpt.TransparentColor = Color.Transparent;
            // 
            // imageApp
            // 
            imageApp.ColorDepth = ColorDepth.Depth8Bit;
            imageApp.ImageSize = new Size(150, 150);
            imageApp.TransparentColor = Color.Transparent;
            // 
            // panelApp
            // 
            panelApp.Controls.Add(listGpt);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(0, 0);
            panelApp.Name = "panelApp";
            panelApp.Size = new Size(1053, 623);
            panelApp.TabIndex = 3;
            // 
            // listGpt
            // 
            listGpt.Dock = DockStyle.Fill;
            listGpt.LargeImageList = imageGpt;
            listGpt.Location = new Point(0, 0);
            listGpt.Name = "listGpt";
            listGpt.Size = new Size(1053, 623);
            listGpt.TabIndex = 0;
            listGpt.UseCompatibleStateImageBehavior = false;
            // 
            // txt_searchApp
            // 
            txt_searchApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_searchApp.BackColor = SystemColors.ButtonHighlight;
            txt_searchApp.BorderColor = Color.Black;
            txt_searchApp.BorderRadius = 5;
            txt_searchApp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txt_searchApp.CustomizableEdges = customizableEdges5;
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
            txt_searchApp.Location = new Point(1518, 0);
            txt_searchApp.Name = "txt_searchApp";
            txt_searchApp.PasswordChar = '\0';
            txt_searchApp.PlaceholderForeColor = Color.Gray;
            txt_searchApp.PlaceholderText = "Tìm kiếm sản phẩm";
            txt_searchApp.SelectedText = "";
            txt_searchApp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_searchApp.Size = new Size(351, 39);
            txt_searchApp.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtSeatchGpt);
            panel1.Controls.Add(txt_searchApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 42);
            panel1.TabIndex = 2;
            // 
            // txtSeatchGpt
            // 
            txtSeatchGpt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSeatchGpt.BackColor = SystemColors.ButtonHighlight;
            txtSeatchGpt.BorderColor = Color.Black;
            txtSeatchGpt.BorderRadius = 5;
            txtSeatchGpt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txtSeatchGpt.CustomizableEdges = customizableEdges7;
            txtSeatchGpt.DefaultText = "";
            txtSeatchGpt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSeatchGpt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSeatchGpt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSeatchGpt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSeatchGpt.FillColor = SystemColors.ButtonHighlight;
            txtSeatchGpt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeatchGpt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeatchGpt.ForeColor = Color.Black;
            txtSeatchGpt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeatchGpt.IconLeft = (Image)resources.GetObject("txtSeatchGpt.IconLeft");
            txtSeatchGpt.IconLeftSize = new Size(30, 30);
            txtSeatchGpt.Location = new Point(702, 0);
            txtSeatchGpt.Name = "txtSeatchGpt";
            txtSeatchGpt.PasswordChar = '\0';
            txtSeatchGpt.PlaceholderForeColor = Color.Gray;
            txtSeatchGpt.PlaceholderText = "Tìm kiếm sản phẩm";
            txtSeatchGpt.SelectedText = "";
            txtSeatchGpt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSeatchGpt.Size = new Size(351, 39);
            txtSeatchGpt.TabIndex = 43;
            // 
            // ChildFormGpt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 623);
            Controls.Add(panel1);
            Controls.Add(panelApp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFormGpt";
            Text = "ChildFormGpt";
            panelApp.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageGpt;
        private Panel panelApp;
        private ImageList imageApp;
        private ListView listGpt;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchApp;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSeatchGpt;
    }
}