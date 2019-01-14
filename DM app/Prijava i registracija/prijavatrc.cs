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
    public partial class prijavatrc : MetroFramework.Forms.MetroForm
    {
        public prijavatrc()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new pocetni().Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new sporedni().Show();
            this.Hide();
        }
    }
}
