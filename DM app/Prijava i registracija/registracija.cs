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
    public partial class registracija :MetroFramework.Forms.MetroForm
    {
        public registracija()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new reg_kupac().Show();
         
            this.Hide();
        }
    
        private void metroButton2_Click(object sender, EventArgs e)
        {
            new reg_trc().Show();
            this.Hide();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void povratak_Click(object sender, EventArgs e)
        {
            new prijava().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new prijava().Show();
            this.Hide();
        }
    }
}
