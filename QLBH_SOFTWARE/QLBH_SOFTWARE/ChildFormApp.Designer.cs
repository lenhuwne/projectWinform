namespace QLBH_SOFTWARE
{
    partial class ChildFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildFormApp));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            txt_searchApp = new Guna.UI2.WinForms.Guna2TextBox();
            panelApp = new Panel();
            listApp = new ListView();
            imageApp = new ImageList(components);
            panel1.SuspendLayout();
            panelApp.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txt_searchApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 42);
            panel1.TabIndex = 0;
            // 
            // txt_searchApp
            // 
            txt_searchApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_searchApp.BackColor = SystemColors.ButtonHighlight;
            txt_searchApp.BorderColor = Color.Black;
            txt_searchApp.BorderRadius = 5;
            txt_searchApp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            txt_searchApp.CustomizableEdges = customizableEdges1;
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
            txt_searchApp.Location = new Point(702, 0);
            txt_searchApp.Name = "txt_searchApp";
            txt_searchApp.PasswordChar = '\0';
            txt_searchApp.PlaceholderForeColor = Color.Gray;
            txt_searchApp.PlaceholderText = "Tìm kiếm sản phẩm";
            txt_searchApp.SelectedText = "";
            txt_searchApp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_searchApp.Size = new Size(351, 39);
            txt_searchApp.TabIndex = 40;
            txt_searchApp.TextChanged += txt_searchApp_TextChanged;
            // 
            // panelApp
            // 
            panelApp.Controls.Add(listApp);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(0, 42);
            panelApp.Name = "panelApp";
            panelApp.Size = new Size(1053, 581);
            panelApp.TabIndex = 1;
            // 
            // listApp
            // 
            listApp.Dock = DockStyle.Fill;
            listApp.LargeImageList = imageApp;
            listApp.Location = new Point(0, 0);
            listApp.Name = "listApp";
            listApp.Size = new Size(1053, 581);
            listApp.TabIndex = 0;
            listApp.UseCompatibleStateImageBehavior = false;
            // 
            // imageApp
            // 
            imageApp.ColorDepth = ColorDepth.Depth8Bit;
            imageApp.ImageSize = new Size(150, 150);
            imageApp.TransparentColor = Color.Transparent;
            // 
            // ChildFormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 623);
            Controls.Add(panelApp);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFormApp";
            Text = "ChildFormApp";
            panel1.ResumeLayout(false);
            panelApp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchApp;
        private Panel panelApp;
        private ListView listApp;
        private ImageList imageApp;
    }
}