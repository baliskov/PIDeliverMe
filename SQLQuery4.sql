ALTER proc ProdavacAdd


@NazivFirme varchar(50),
@OIB int,
@Vlasnik varchar(250),
@Telefon varchar(50),
@email varchar(50),
@sifra varchar(50),
@KorisnickoIme varchar(50)

	AS
		INSERT INTO Prodoavac(NazivFirme,OIB,Vlasnik,Telefon,KorisnickoIme,email,sifra)
		VALUES (@NazivFirme,@OIB,@Vlasnik,@Telefon,@KorisnickoIme,@email,@sifra)