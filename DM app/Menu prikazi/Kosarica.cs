using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DM_app.Modeli;
using Tulpep.NotificationWindow;

namespace DM_app
{
    public partial class Košarica : MetroFramework.Forms.MetroForm
    {
        DMEntities entities = new DMEntities();
        public Košarica()
        {
            InitializeComponent();
        }

        private void Košarica_Load(object sender, EventArgs e)
        {


            string a = PrijavljeniKupac.id_kup.ToString(); // stavljamo id pod string kako bi mogli upotrijebiti varijablu tipa string za usporedbu.
#pragma warning disable IDE0018 // Inline variable declaration
            int fid;
#pragma warning restore IDE0018 // Inline variable declaration
            bool praseOK = Int32.TryParse(a, out fid);
            advancedDataGridView1.DataSource = entities.Stavka_kosarice.Where(x => x.UserID == fid).ToList();

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Opaska";
            popup.ContentText = "Ako želiš naručiti artikl, označi ga desnim klikom te pritisni -Naruči-.";
            popup.Popup();

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrgovačkiLanciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            new Glavni().Show();
            this.Hide();
        }

        private void MetroLink3_Click(object sender, EventArgs e)
        {



        }

        private void AdvancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {




            DB.OpenCon();
            SqlCommand sqlCommand = new SqlCommand("NarudzbaAdd", DB.con);
            SqlCommand sqlCmd = sqlCommand;



            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@NazivArtikla", a.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@CijenaArtikla", b.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Id_kosarice", d.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Kollicina", k.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@UserID", c.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Nacin_dostave", metroRadioButton1.Text.ToString());
            sqlCmd.Parameters.AddWithValue("@Nacin_placanja", metroRadioButton3.Text.ToString());
            sqlCmd.ExecuteNonQuery();

            DB.CloseCon();


           
                
                
                
            



        



    

            
           
            MessageBox.Show("Narudzba Uspjesna");
            
        }

        private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ObrišiKošaricu_Click(object sender, EventArgs e)
        {
            DB.OpenCon();
            SqlCommand sc1 = new SqlCommand("ObrisiKosaricu", DB.con)
            {
                CommandType = CommandType.StoredProcedure
            };
            sc1.ExecuteNonQuery();
            DB.CloseCon();

            MessageBox.Show("Košarica je obrisana");

            new Košarica().Show();
            this.Hide();
        }

        private void AdvancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = advancedDataGridView1.Rows[e.RowIndex];
            a.Text = dgvRow.Cells[0].Value.ToString();
            b.Text = dgvRow.Cells[1].Value.ToString();
            c.Text = dgvRow.Cells[2].Value.ToString();
            d.Text = dgvRow.Cells[3].Value.ToString();
            k.Text = dgvRow.Cells[4].Value.ToString();


        }

        private void K_Click(object sender, EventArgs e)
        {

        }
    }
}
