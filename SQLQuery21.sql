ALTER proc ArtikliAdd


@NazivArtikla varchar(50),
@CijenaArtikla float


	AS
		INSERT INTO Artikli([NazivArtikla],[CijenaArtikla])
		VALUES (@NazivArtikla,@CijenaArtikla)