ALTER proc ArtikliAdd


@NazivArtikla varchar(50),
@CijenaArtikla money


	AS
		INSERT INTO Artikli([NazivArtikla],[CijenaArtikla])
		VALUES (@NazivArtikla,@CijenaArtikla)