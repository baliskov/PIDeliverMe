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

        private void TrgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Unos_asortimana().Show();
            this.Hide();
        }

        private void DostavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void KontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kontakt();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
    }

        private void UrediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Unos_asortimana().Show();
            this.Hide();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new prijava().Show();
            this.Hide();
        }
    }
}

