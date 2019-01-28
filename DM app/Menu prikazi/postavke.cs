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
    public partial class Postavke : MetroFramework.Forms.MetroForm
    {
        public Postavke()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Postavke_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton7_Click(object sender, EventArgs e)
        {
            
            new Glavni().Show();
            this.Hide();
        }
    }
}
