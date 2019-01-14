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

namespace DM_app
{
    public partial class unos_asortimana : MetroFramework.Forms.MetroForm
    {

        public unos_asortimana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Odjel' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Prodoavac' table. You can move, or remove it, as needed.
            this.prodoavacTableAdapter.Fill(this.bazaPodatakaDeliverMeDataSet.Prodoavac);
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.bazaPodatakaDeliverMeDataSet.Kupac);
            // TODO: This line of code loads data into the 'bazaPodataka.Kupac' table. You can move, or remove it, as needed.


        }

        private void trgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trgovačkiLanciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void dostavaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox8.Text == "" || metroTextBox1.Text == "")
                MessageBox.Show("molimo unesite trazena polja");

            else
            {
                string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ZEKO\Documents\BazaPodatakaDeliverMe.mdf; Integrated Security = True; Connect Timeout = 30";

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ArtikliAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NazivArtikla", metroTextBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CijenaArtikla", metroTextBox1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Podaci su pohranjeni.");
                    Clear();

                }
                void Clear()
                {
                    metroTextBox8.Text = "";
                    metroTextBox1.Text = "";

                }

                new unos_asortimana().Show();
                this.Hide();

            }
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prodoavacTableAdapter.FillBy(this.bazaPodatakaDeliverMeDataSet.Prodoavac);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new sporedni().Show();
            this.Hide();
        }

        private void povratak_Click(object sender, EventArgs e)
        {
            new unos_odjela().Show();
            this.Hide();
        }
    }
}
