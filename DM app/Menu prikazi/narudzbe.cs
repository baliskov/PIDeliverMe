using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
namespace DM_app
{
    public partial class narud : MetroFramework.Forms.MetroForm
    {
        public narud()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gg.Narudzba' table. You can move, or remove it, as needed.
            this.narudzbaTableAdapter3.Fill(this.gg.Narudzba);
            PopupNotifier popup = new PopupNotifier();
          
            popup.TitleText = "Opaska";
            popup.ContentText ="Prodavać će vas kontaktirati u najkraćem mogućem vremenu.";
            popup.Popup();


        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdvancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            new Glavni().Show();
            this.Hide();
        }
    }
}
