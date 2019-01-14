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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZBORNIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trgovačkiLanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZBORNIKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 142);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(332, 35);
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
            this.kontaktToolStripMenuItem});
            this.iZBORNIKToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iZBORNIKToolStripMenuItem.Name = "iZBORNIKToolStripMenuItem";
            this.iZBORNIKToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.iZBORNIKToolStripMenuItem.Text = "IZBORNIK";
            // 
            // trgovačkiLanciToolStripMenuItem
            // 
            this.trgovačkiLanciToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trgovačkiLanciToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.trgovačkiLanciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urediToolStripMenuItem});
            this.trgovačkiLanciToolStripMenuItem.Name = "trgovačkiLanciToolStripMenuItem";
            this.trgovačkiLanciToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.trgovačkiLanciToolStripMenuItem.Text = "Odjeli";
            this.trgovačkiLanciToolStripMenuItem.Click += new System.EventHandler(this.trgovačkiLanciToolStripMenuItem_Click);
            // 
            // dostavaToolStripMenuItem
            // 
            this.dostavaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.dostavaToolStripMenuItem.Name = "dostavaToolStripMenuItem";
            this.dostavaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.dostavaToolStripMenuItem.Text = "Narudzbe";
            this.dostavaToolStripMenuItem.Click += new System.EventHandler(this.dostavaToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kontaktToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.kontaktToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(166, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox1.Location = new System.Drawing.Point(948, 142);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroTextBox1.Size = new System.Drawing.Size(219, 35);
            this.metroTextBox1.TabIndex = 22;
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.urediToolStripMenuItem.Text = "Uredi";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // sporedni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 692);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sporedni";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZBORNIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trgovačkiLanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
    }
}