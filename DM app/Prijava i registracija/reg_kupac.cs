using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DM_app.Modeli;
namespace DM_app

  
{
    public partial class reg_kupac : MetroFramework.Forms.MetroForm
    {


        public reg_kupac()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            if (metroTextBox8.Text == "" || metroTextBox14.Text == ""|| metroTextBox10.Text == "" || metroTextBox9.Text == "" || metroTextBox11.Text == "" || metroTextBox13.Text == "" || metroTextBox12.Text == "")
                MessageBox.Show("molimo unesite trazena polja");

            else
            {


               
                
                    DB.OpenCon();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", DB.con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Ime", metroTextBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Adresa", metroTextBox10.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Prezime", metroTextBox9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Telefon", metroTextBox13.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Korisnickoime", metroTextBox11.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", metroTextBox12.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@sifra", metroTextBox14.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registracije je uspjesna");
                    DB.CloseCon();
                    Clear();

                
                void Clear()
                {
                    metroTextBox8.Text = metroTextBox10.Text = metroTextBox9.Text = metroTextBox13.Text = metroTextBox12.Text = metroTextBox11.Text = metroTextBox14.Text = "";

                }

                new prijava().Show();
                this.Hide();

            }


            }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {
            // Set to no text.  
            //metroTextBox14.Text = "";
            // The password character is an asterisk.  
            metroTextBox14.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            metroTextBox14.MaxLength = 14;

            string lozinka;
            lozinka = metroTextBox14.Text;

            if (lozinka != "")
            {
                MessageBox.Show("Moja lozinka: " + lozinka);
            }
            else
            {
                MessageBox.Show("Unesi lozinku");
            }

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {
            string ime;
            ime = metroTextBox8.Text;

            if (ime != "")
            {
                MessageBox.Show("Zovem se" + ime);
             }
            else
            {
                MessageBox.Show("Ime nije uneseno");
            }
            
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
      
            string prezime;
            prezime = metroTextBox9.Text;
        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {
            string adresa;
            adresa = metroTextBox10.Text;
        }

        private void metroTextBox13_Click(object sender, EventArgs e)
        {
            string telefon;
            telefon = metroTextBox13.Text;
        }

        private void metroTextBox12_Click(object sender, EventArgs e)
        {
            string email;
            email = metroTextBox12.Text;
           
        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {
            string kime;
            kime = metroTextBox11.Text;
         
        }

        private void povratak_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new registracija().Show();
            this.Hide();
        }
    }
}
