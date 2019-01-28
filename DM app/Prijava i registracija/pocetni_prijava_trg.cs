using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DM_app.Modeli;

namespace DM_app
{
    public partial class pocetni_prijava_trg : MetroFramework.Forms.MetroForm
    {
        public pocetni_prijava_trg()
        {
            InitializeComponent();
        }

        private void Pocetni_prijava_trg_Load(object sender, EventArgs e)
        {


    

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            

            string query = " Select * from Prodoavac Where KorisnickoIme = '" + textBox1.Text.Trim() + "'and sifra ='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, DB.con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Prijavljeni_korisnik.id_pro = (int) dtbl.Rows[0]["ProdavacID"];
                sporedni objsporedni = new sporedni();
                this.Hide();
                objsporedni.Show();
            }








            else
            {
                MessageBox.Show("Korisnik nije pronađen, pokušajte ponovo.");


            }
         
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            new prijava_trgovina().Show();
            this.Hide();
        }
    }
}
