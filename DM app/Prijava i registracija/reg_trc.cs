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
    public partial class reg_trc :MetroFramework.Forms.MetroForm
    {
        public reg_trc()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox8.Text == "" || metroTextBox14.Text == "" || metroTextBox10.Text == "" || metroTextBox9.Text == "" || metroTextBox11.Text == "" || metroTextBox13.Text == "" || metroTextBox12.Text == "")
                MessageBox.Show("molimo unesite trazena polja");

            else
            {


                
                
                   DB.OpenCon();
                    SqlCommand sqlCmd = new SqlCommand("ProdavacAdd", DB.con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NazivFirme", metroTextBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Vlasnik", metroTextBox10.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OIB", metroTextBox9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Telefon", metroTextBox13.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@KorisnickoIme", metroTextBox11.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", metroTextBox12.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@sifra", metroTextBox14.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    DB.CloseCon();
                    MessageBox.Show("Registracije je uspjesna");
                    Clear();
                   

                
                void Clear()
                {
                    metroTextBox8.Text = metroTextBox10.Text = metroTextBox9.Text = metroTextBox13.Text = metroTextBox12.Text = metroTextBox11.Text = metroTextBox14.Text = "";

                }

                new pocetni_prijava_trg().Show();
                this.Hide();

            }
        }

        private void reg_trc_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox13_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {

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
