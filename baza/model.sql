CREATE TABLE [dbo].[Kupac] (
    [UserID]        INT           IDENTITY (1, 1) NOT NULL,
    [Ime]           NVARCHAR (50) NULL,
    [Prezime]       VARCHAR (50)  NULL,
    [Telefon]       VARCHAR (50)  NULL,
    [Adresa]        VARCHAR (250) NULL,
    [KorisnickoIme] VARCHAR (50)  NULL,
    [sifra]         VARCHAR (50)  NULL,
    [email]         VARCHAR (50)  NULL
);

GO
ALTER TABLE [dbo].[Kupac]
    ADD CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([UserID] ASC);

GO
CREATE PROCEDURE [dbo].[UserAdd]
@Ime VARCHAR (50) NULL, @Prezime VARCHAR (50) NULL, @Telefon VARCHAR (50) NULL, @Adresa VARCHAR (250) NULL, @KorisnickoIme VARCHAR (50) NULL, @email VARCHAR (50) NULL, @sifra VARCHAR (50) NULL
AS
INSERT  INTO Kupac (Ime, Prezime, Telefon, Adresa, KorisnickoIme, email, sifra)
VALUES            (@Ime, @Prezime, @Telefon, @Adresa, @KorisnickoIme, @email, @sifra);

GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO PUBLIC;

GO
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO PUBLIC;

GO
