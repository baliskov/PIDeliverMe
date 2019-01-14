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
    public partial class unos_odjela : MetroFramework.Forms.MetroForm
    {

        public unos_odjela()
        {
            InitializeComponent();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new unos_asortimana().Show();
            this.Hide();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if ( metroTextBox8.Text == "")
                MessageBox.Show("molimo unesite trazena polja");

            else
            {

                
                using (SqlConnection com = DB.con)
                {
                
                    DB.OpenCon();
                    SqlCommand sqlCmd = new SqlCommand("OdjelAdd", com);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NazivOdjela", metroTextBox8.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    DB.CloseCon();
                    MessageBox.Show("Podaci su pohranjeni.");
                    Clear();

                }
                void Clear()
                {
                    metroTextBox8.Text = "";

                }

                new unos_odjela().Show();
                this.Hide();

            }

            /*new sporedni().Show();
            this.Hide();*/
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void unos_odjela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Odjel' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'bazaPodatakaDeliverMeDataSet.Kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.bazaPodatakaDeliverMeDataSet.Kupac);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new unos_asortimana().Show();
            this.Hide();
        }

        private void povratak_Click(object sender, EventArgs e)
        {
            new reg_trc().Show();
            this.Hide();
        }
    }
}
