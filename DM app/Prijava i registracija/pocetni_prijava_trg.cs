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

        private void pocetni_prijava_trg_Load(object sender, EventArgs e)
        {


    

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection com = DB.con;
            string query = " Select * from Prodoavac Where KorisnickoIme = '" + textBox1.Text.Trim() + "'and sifra ='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                sporedni objsporedni = new sporedni();
                this.Hide();
                objsporedni.Show();
            }








            else
            {
                MessageBox.Show("Korisnik nije pronađen, pokušajte ponovo.");


            }
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new prijava_trgovina().Show();
            this.Hide();
        }
    }
}
