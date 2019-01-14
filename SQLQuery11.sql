ALTER proc OdjelAdd
@NazivOdjela nvarchar(50)


	AS
		INSERT INTO Odjel([NazivOdjela])
		VALUES (@NazivOdjela)