using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using DM_app.Modeli;
namespace DM_app



{
    public partial class pocetni : MetroFramework.Forms.MetroForm
    {
        public pocetni()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            

            SqlConnection com = DB.con;
            
            string query = " Select * from Kupac Where korisnickoIme = '" + textBox1.Text.Trim() + "'and sifra ='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Glavni objGlavni = new Glavni();
                this.Hide();
                objGlavni.Show();
                            }

            else
            {
                MessageBox.Show("Korisnik nije pronađen, pokušajte ponovo.");


            }

        }

        private void povratak_Click(object sender, EventArgs e)
        {
            new prijava_trgovina().Show();
            this.Hide();
        }
    }
}
