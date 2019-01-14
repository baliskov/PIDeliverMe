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
    public partial class sporedni : MetroFramework.Forms.MetroForm
    {
        public sporedni()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new unos_odjela().Show();
            this.Hide();
        }

        private void dostavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new narud().Show();
            this.Hide();
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kontakt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
    }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new unos_odjela().Show();
            this.Hide();
        }
    }
}

