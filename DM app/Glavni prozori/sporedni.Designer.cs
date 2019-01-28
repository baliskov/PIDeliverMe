namespace DM_app
{
    partial class sporedni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sporedni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZBORNIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trgovačkiLanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iZBORNIKToolStripMenuItem
            // 
            this.iZBORNIKToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iZBORNIKToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iZBORNIKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trgovačkiLanciToolStripMenuItem,
            this.dostavaToolStripMenuItem,
            this.kontaktToolStripMenuItem,
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
            this.trgovačkiLanciToolStripMenuItem.Text = "Unos proizvoda";
            this.trgovačkiLanciToolStripMenuItem.Click += new System.EventHandler(this.TrgovačkiLanciToolStripMenuItem_Click);
            // 
            // dostavaToolStripMenuItem
            // 
            this.dostavaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dostavaToolStripMenuItem.Name = "dostavaToolStripMenuItem";
            this.dostavaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dostavaToolStripMenuItem.Text = "Narudzbe";
            this.dostavaToolStripMenuItem.Click += new System.EventHandler(this.DostavaToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kontaktToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.KontaktToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // sporedni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "sporedni";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZBORNIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trgovačkiLanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
    }
}