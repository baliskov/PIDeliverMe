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
    public partial class Unos_asortimana : MetroFramework.Forms.MetroForm
    {

        public Unos_asortimana()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet1.Odjel' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Odjel' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Prodoavac' table. You can move, or remove it, as needed.
            this.prodoavacTableAdapter.Fill(this.bazaPodatakaDeliverMeDataSet.Prodoavac);
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.bazaPodatakaDeliverMeDataSet.Kupac);
            // TODO: This line of code loads data into the 'bazaPodataka.Kupac' table. You can move, or remove it, as needed.


        }

        private void TrgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrgovačkiLanciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void DostavaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox8.Text == "" || metroTextBox1.Text == "")
                MessageBox.Show("molimo unesite trazena polja");
           
            
            else
            {
               
                {
                    DB.OpenCon();
                    int b = Prijavljeni_korisnik.id_pro;
                    SqlCommand sqlCmd = new SqlCommand("ArtikliAdd", DB.con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@NazivArtikla", metroTextBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CijenaArtikla", metroTextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ProdavacID", b);
                    sqlCmd.ExecuteNonQuery();
                    DB.CloseCon();
                    MessageBox.Show("Podaci su pohranjeni.");
                    Clear();
                  
                }
                void Clear()
                {
                    metroTextBox8.Text = "";
                    metroTextBox1.Text = "";

                }

                new Unos_asortimana().Show();
                this.Hide();

            }
        }

        private void MetroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
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

        private void FillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new sporedni().Show();
            this.Hide();
        }

        private void Povratak_Click(object sender, EventArgs e)
        {
            new Unos_asortimana().Show();
            this.Hide();
        }

        private void FillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.odjelTableAdapter1.FillBy2(this.bazaPodatakaDeliverMeDataSet1.Odjel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void Id_proToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
         
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void FillByToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Unos_asortimana().Show();
            this.Hide();
        }
    }
    }

