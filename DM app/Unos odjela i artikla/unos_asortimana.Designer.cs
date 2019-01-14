namespace DM_app
{
    partial class unos_asortimana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unos_asortimana));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodoavacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDeliverMeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDeliverMeDataSet = new DM_app.BazaPodatakaDeliverMeDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odjelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.odjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new DM_app.BazaPodatakaDeliverMeDataSetTableAdapters.KupacTableAdapter();
            this.prodoavacTableAdapter = new DM_app.BazaPodatakaDeliverMeDataSetTableAdapters.ProdoavacTableAdapter();
            this.odjelTableAdapter = new DM_app.BazaPodatakaDeliverMeDataSetTableAdapters.OdjelTableAdapter();
            this.odjelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odjelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.povratak = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodoavacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratak)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTile1.Location = new System.Drawing.Point(4, 111);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(210, 30);
            this.metroTile1.TabIndex = 52;
            this.metroTile1.Text = "Unos artikla";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(33, 197);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(168, 23);
            this.metroTextBox8.TabIndex = 53;
            this.metroTextBox8.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Naziv proizvoda:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(235, 222);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(82, 26);
            this.metroButton2.TabIndex = 55;
            this.metroButton2.Text = "Dodaj";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(33, 257);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(168, 23);
            this.metroTextBox1.TabIndex = 57;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 236);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Cijena artikla";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // prodoavacBindingSource
            // 
            this.prodoavacBindingSource.DataMember = "Prodoavac";
            this.prodoavacBindingSource.DataSource = this.bazaPodatakaDeliverMeDataSetBindingSource;
            // 
            // bazaPodatakaDeliverMeDataSetBindingSource
            // 
            this.bazaPodatakaDeliverMeDataSetBindingSource.DataSource = this.bazaPodatakaDeliverMeDataSet;
            this.bazaPodatakaDeliverMeDataSetBindingSource.Position = 0;
            // 
            // bazaPodatakaDeliverMeDataSet
            // 
            this.bazaPodatakaDeliverMeDataSet.DataSetName = "BazaPodatakaDeliverMeDataSet";
            this.bazaPodatakaDeliverMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // odjelBindingSource2
            // 
            this.odjelBindingSource2.DataMember = "Odjel";
            this.odjelBindingSource2.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // odjelBindingSource
            // 
            this.odjelBindingSource.DataMember = "Odjel";
            this.odjelBindingSource.DataSource = this.bazaPodatakaDeliverMeDataSetBindingSource;
            // 
            // kupacBindingSource1
            // 
            this.kupacBindingSource1.DataMember = "Kupac";
            this.kupacBindingSource1.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // prodoavacTableAdapter
            // 
            this.prodoavacTableAdapter.ClearBeforeFill = true;
            // 
            // odjelTableAdapter
            // 
            this.odjelTableAdapter.ClearBeforeFill = true;
            // 
            // odjelBindingSource1
            // 
            this.odjelBindingSource1.DataMember = "Odjel";
            this.odjelBindingSource1.DataSource = this.bazaPodatakaDeliverMeDataSetBindingSource;
            // 
            // odjelBindingSource3
            // 
            this.odjelBindingSource3.DataMember = "Odjel";
            this.odjelBindingSource3.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(404, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 60;
            this.button1.Text = "Dalje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // povratak
            // 
            this.povratak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.povratak.Image = ((System.Drawing.Image)(resources.GetObject("povratak.Image")));
            this.povratak.InitialImage = ((System.Drawing.Image)(resources.GetObject("povratak.InitialImage")));
            this.povratak.Location = new System.Drawing.Point(518, 158);
            this.povratak.Name = "povratak";
            this.povratak.Size = new System.Drawing.Size(47, 37);
            this.povratak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.povratak.TabIndex = 61;
            this.povratak.TabStop = false;
            this.povratak.Click += new System.EventHandler(this.povratak_Click);
            // 
            // unos_asortimana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.povratak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "unos_asortimana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodoavacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private System.Windows.Forms.BindingSource bazaPodatakaDeliverMeDataSetBindingSource;
        private BazaPodatakaDeliverMeDataSet bazaPodatakaDeliverMeDataSet;
        private System.Windows.Forms.BindingSource kupacBindingSource1;
        private BazaPodatakaDeliverMeDataSetTableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource prodoavacBindingSource;
        private BazaPodatakaDeliverMeDataSetTableAdapters.ProdoavacTableAdapter prodoavacTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource odjelBindingSource;
        private BazaPodatakaDeliverMeDataSetTableAdapters.OdjelTableAdapter odjelTableAdapter;
        private System.Windows.Forms.BindingSource odjelBindingSource2;
        private System.Windows.Forms.BindingSource odjelBindingSource1;
        private System.Windows.Forms.BindingSource odjelBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox povratak;
    }
}