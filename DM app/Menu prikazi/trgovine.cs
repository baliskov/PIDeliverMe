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
    public partial class trgovine : MetroFramework.Forms.MetroForm
    {
        DMEntities entities = new DMEntities();

        public trgovine()
        {
            InitializeComponent();
            
        }
        

        private void Trgovine_Load(object sender, EventArgs e)
        {
            
            
            metroComboBox1.DataSource = entities.Prodoavacs.ToList();

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string b = metroComboBox1.SelectedValue.ToString();
            
            String a = metroComboBox1.Text;
            // MessageBox.Show(b);
            int fid;
            bool parseOK = Int32.TryParse(metroComboBox1.SelectedValue.ToString(), out fid); //prebacivanje objekta selectedValue u int
            advancedDataGridView1.DataSource = entities.Artiklis.Where(x => x.ProdavacID == fid).ToList();
        }

        private void AdvancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
          
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = advancedDataGridView1.Rows[e.RowIndex];
                metroTextBox4.Text = dgvRow.Cells[0].Value.ToString();
                metroTextBox1.Text = dgvRow.Cells[1].Value.ToString();
                metroTextBox2.Text = dgvRow.Cells[2].Value.ToString();
                ProdavacID.Text = dgvRow.Cells[3].Value.ToString();

            }
        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdvancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        { 
            DB.OpenCon();


            int c = PrijavljeniKupac.id_kup;
        
            SqlCommand sqlCmd = new SqlCommand("KosaricaAdd", DB.con);
            string TrenutnaVrijednost = metroTextBox3.Text;
            if (TrenutnaVrijednost != "0")

            {

                string a = metroTextBox2.Text.ToString();
                string b = metroTextBox3.Text.ToString();

                float Cijena = float.Parse(a);
                float Kolicina = float.Parse(b);

                float Iznos = Cijena * Kolicina;
                metroLabel5.Text = Iznos.ToString();
                metroTextBox5.Text = Iznos.ToString();





                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Artikla", metroTextBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NazivArtikla", metroTextBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CijenaArtikla", metroTextBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@UserID", c);
                sqlCmd.Parameters.AddWithValue("@Kollicina", metroTextBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ProdavacID", ProdavacID.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Suma", metroTextBox5.Text.Trim());
                

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Stavljeno u košaricu. Iznos: " + metroLabel5.Text + " kn.");
                DB.CloseCon();
                Clear();


                void Clear()
                {
                    metroTextBox4.Text = metroTextBox1.Text = metroTextBox2.Text = metroTextBox3.Text = metroLabel5.Text = "";

                }


            }
            else
            {
                MessageBox.Show("Unesi količinu. Minimalna mora iznositi 1");
                DB.CloseCon();

            }
        }

        private void MetroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            new Glavni().Show();
            this.Hide();
        }

        private void ProdavacID_Click(object sender, EventArgs e)
        {

        }
    }
}
