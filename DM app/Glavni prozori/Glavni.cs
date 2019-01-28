using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_app
{
    public partial class Glavni : MetroFramework.Forms.MetroForm
    {
        public Glavni()
        {
            InitializeComponent();
        }

        private void Glavni_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        

        private void MetroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void TrgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new trgovine().Show();
            this.Hide();

        }

        private void MetroUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Postavke().ShowDialog();
            this.Hide();
        }

        private void KontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kontakt().ShowDialog();
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            new Košarica().Show();
            this.Hide();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void NarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new narud().Show();
            this.Hide();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prijava().Show();
            this.Hide();
        }
    }
}
