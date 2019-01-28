CREATE PROC UserAdd

@UserID int,
@Ime varchar(50),
@Prezime varchar(50),
@Telefon varchar(50),
@Adresa	 varchar(250),
@KorisnickoIme varchar(50),
@email varchar(50),
@sifra varchar(50)

	AS
		INSERT INTO Kupac(Ime,Prezime,Telefon,Adresa,KorisnickoIme,email,sifra)
		VALUES (@Ime,@Prezime,@Telefon,@Adresa,@KorisnickoIme,@email,@sifra)

		commit;