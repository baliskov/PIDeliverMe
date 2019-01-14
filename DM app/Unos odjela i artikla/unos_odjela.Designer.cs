namespace DM_app
{
    partial class unos_odjela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unos_odjela));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaPodatakaDeliverMeDataSet = new DM_app.BazaPodatakaDeliverMeDataSet();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new DM_app.BazaPodatakaDeliverMeDataSetTableAdapters.KupacTableAdapter();
            this.odjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odjelTableAdapter = new DM_app.BazaPodatakaDeliverMeDataSetTableAdapters.OdjelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.povratak = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratak)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTile1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTile1.Location = new System.Drawing.Point(13, 115);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(160, 30);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "UNOS ODJELA";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(17, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "1.";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Naziv odjela:";
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(37, 211);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(168, 23);
            this.metroTextBox8.TabIndex = 35;
            this.metroTextBox8.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(240, 211);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 23);
            this.metroButton1.TabIndex = 43;
            this.metroButton1.Text = "Unesi novi odjel";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kupacBindingSource1;
            this.comboBox1.DisplayMember = "email";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 250);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.ValueMember = "UserID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kupacBindingSource1
            // 
            this.kupacBindingSource1.DataMember = "Kupac";
            this.kupacBindingSource1.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // bazaPodatakaDeliverMeDataSet
            // 
            this.bazaPodatakaDeliverMeDataSet.DataSetName = "BazaPodatakaDeliverMeDataSet";
            this.bazaPodatakaDeliverMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "Kupac";
            this.kupacBindingSource.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // odjelBindingSource
            // 
            this.odjelBindingSource.DataMember = "Odjel";
            this.odjelBindingSource.DataSource = this.bazaPodatakaDeliverMeDataSet;
            // 
            // odjelTableAdapter
            // 
            this.odjelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 52;
            this.button1.Text = "Dalje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // povratak
            // 
            this.povratak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.povratak.Image = ((System.Drawing.Image)(resources.GetObject("povratak.Image")));
            this.povratak.InitialImage = ((System.Drawing.Image)(resources.GetObject("povratak.InitialImage")));
            this.povratak.Location = new System.Drawing.Point(471, 158);
            this.povratak.Name = "povratak";
            this.povratak.Size = new System.Drawing.Size(47, 37);
            this.povratak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.povratak.TabIndex = 53;
            this.povratak.TabStop = false;
            this.povratak.Click += new System.EventHandler(this.povratak_Click);
            // 
            // unos_odjela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 338);
            this.Controls.Add(this.povratak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "unos_odjela";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.unos_odjela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaPodatakaDeliverMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povratak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private BazaPodatakaDeliverMeDataSet bazaPodatakaDeliverMeDataSet;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private BazaPodatakaDeliverMeDataSetTableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource odjelBindingSource;
        private BazaPodatakaDeliverMeDataSetTableAdapters.OdjelTableAdapter odjelTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox povratak;
    }
}