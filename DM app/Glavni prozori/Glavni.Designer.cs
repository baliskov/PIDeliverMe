namespace DM_app
{
    partial class Glavni
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZBORNIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trgovačkiLanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pIDeliverMeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDeliverMeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZBORNIKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 134);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(106, 26);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iZBORNIKToolStripMenuItem
            // 
            this.iZBORNIKToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iZBORNIKToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iZBORNIKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trgovačkiLanciToolStripMenuItem,
            this.kontaktToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.iZBORNIKToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iZBORNIKToolStripMenuItem.Name = "iZBORNIKToolStripMenuItem";
            this.iZBORNIKToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.iZBORNIKToolStripMenuItem.Text = "IZBORNIK";
            // 
            // trgovačkiLanciToolStripMenuItem
            // 
            this.trgovačkiLanciToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trgovačkiLanciToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.trgovačkiLanciToolStripMenuItem.Name = "trgovačkiLanciToolStripMenuItem";
            this.trgovačkiLanciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trgovačkiLanciToolStripMenuItem.Text = "Trgovine";
            this.trgovačkiLanciToolStripMenuItem.Click += new System.EventHandler(this.TrgovačkiLanciToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kontaktToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.KontaktToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Click += new System.EventHandler(this.NarudžbeToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(357, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 39);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Wheat;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.Location = new System.Drawing.Point(357, 173);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 22;
            this.metroTile1.Text = "Košarica";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // Glavni
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(455, 470);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavni";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Glavni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDeliverMeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZBORNIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource pIDeliverMeDataSetBindingSource;
        private System.Windows.Forms.ToolStripMenuItem trgovačkiLanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
    }
}