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
    public partial class prijava_trgovina : MetroFramework.Forms.MetroForm
    {
        public prijava_trgovina()
        {
            InitializeComponent();
        }

        private void prijava_trgovina_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new pocetni_prijava_trg().Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new pocetni().Show();
            this.Hide();
        }

        private void povratak_Click(object sender, EventArgs e)
        {
            new prijava().Show();
            this.Hide();
        }
    }
}
