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
    public partial class prijava : MetroFramework.Forms.MetroForm
    {
        public prijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            //kod za povezivanje događaja prilikom clicka na button=>otvara nam drugi prozor
            new prijava_trgovina().Show();
            this.Hide();

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            new registracija().Show();
            this.Hide();
        }
    }
}
