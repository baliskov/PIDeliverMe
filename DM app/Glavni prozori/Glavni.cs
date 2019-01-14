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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        

        private void MetroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void trgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new trgovine().Show();
            this.Hide();

        }

        private void MetroUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new postavke().ShowDialog();
            this.Hide();
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kontakt().ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Košarica().Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
