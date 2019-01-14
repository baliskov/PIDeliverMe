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
            this.dostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pIDeliverMeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.pictureBox1.Location = new System.Drawing.Point(2, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZBORNIKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 93);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(149, 33);
            this.menuStrip1.TabIndex = 14;
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
            this.trgovačkiLanciToolStripMenuItem.Name = "trgovačkiLanciToolStripMenuItem";
            this.trgovačkiLanciToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.trgovačkiLanciToolStripMenuItem.Text = "Trgovački lanci";
            this.trgovačkiLanciToolStripMenuItem.Click += new System.EventHandler(this.trgovačkiLanciToolStripMenuItem_Click);
            // 
            // dostavaToolStripMenuItem
            // 
            this.dostavaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.dostavaToolStripMenuItem.Name = "dostavaToolStripMenuItem";
            this.dostavaToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.dostavaToolStripMenuItem.Text = "Dostava";
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kontaktToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.kontaktToolStripMenuItem_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox1.Location = new System.Drawing.Point(643, 77);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroTextBox1.Size = new System.Drawing.Size(146, 23);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.Click += new System.EventHandler(this.MetroTextBox1_Click);
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(111, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(562, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 39);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
          
            // 
            // Glavni
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroScrollBar1);
            this.Controls.Add(this.metroTextBox1);
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource pIDeliverMeDataSetBindingSource;
    }
}