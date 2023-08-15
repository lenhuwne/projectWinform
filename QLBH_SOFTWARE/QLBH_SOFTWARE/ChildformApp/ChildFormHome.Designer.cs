namespace QLBH_SOFTWARE
{
    partial class ChildFormHome
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
            panel2 = new Panel();
            listhome = new ListView();
            imagehome = new ImageList(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(listhome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 478);
            panel2.TabIndex = 42;
            // 
            // listhome
            // 
            listhome.Dock = DockStyle.Fill;
            listhome.LargeImageList = imagehome;
            listhome.Location = new Point(0, 0);
            listhome.Name = "listhome";
            listhome.Size = new Size(1020, 478);
            listhome.TabIndex = 0;
            listhome.UseCompatibleStateImageBehavior = false;
            // 
            // imagehome
            // 
            imagehome.ColorDepth = ColorDepth.Depth8Bit;
            imagehome.ImageSize = new Size(150, 150);
            imagehome.TransparentColor = Color.Transparent;
            // 
            // ChildFormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 478);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChildFormHome";
            Text = "ChildFormHome";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListView listhome;
        private ImageList imagehome;
    }
}