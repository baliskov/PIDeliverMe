
SqlConnection sqIcon = new SqlConnection(@"")
string query =" Select * from Kupac Where korisnicko ime = '" + metroTextBox8.text.Trim() + "'and sifra='" + metroTextBox14.Text.Trim() + "'";
SqlDataAdapter sda=new SqlDataAdapter(query, sqlcon);
DataTable dtbl * new DataTable();
sda.Fill(dtbl);

If (dtbl.Row.count==1)
{
	imeformsa objime =new fremain();
	this.hide();
	objime.Shoq();
}

else
	MessageBox.Show("Korisnik nije pronađen, pokušajte ponovo.");