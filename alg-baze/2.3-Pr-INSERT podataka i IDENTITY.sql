--Upis podataka u tablicu
INSERT INTO Polaznici
VALUES
(1,'Mirko', 'Spirko', 'Zagreb')

insert into polaznici 
values
(2, 'Jura','Klafura', 'Vara�din')

--Upis NULL vrijednosti
INSERT INTO Polaznici
VALUES
(3,'Pero','�dero', NULL)
--ili
INSERT INTO Polaznici
(Sifra, Ime, Prezime)
VALUES
(4,'Ava','Karabati�')

--AUTO inkrement Primarnog klju�a
--Obri�i tablicu Upisi
--Obri�i tablicu Polaznici
--Kreiraj tablicu polaznici sa svim constraintima i PK i FK
--Kreiraj tablicu upisi  sa svim constraintima i PK i FK
DROP TABLE Upisi
DROP TABLE Polaznici
CREATE TABLE Polaznici
(
	Sifra				INT 
						PRIMARY KEY 
						CHECK(Sifra between 1 and 1000)
						IDENTITY(1,1),
	Ime					varchar(20) not null,
	Prezime				varchar(20) not null,
	MjestoStanovanja	varchar(50)
)

CREATE TABLE Upisi
(
	SifraPolaznika		int
						foreign key
						references Polaznici(Sifra),
	SifraSeminara		CHAR(3)
						foreign key
						references Seminari(Sifra)
	CONSTRAINT PKSifra primary key(SifraPolaznika, SifraSeminara)
)

--Moramo ponovno napuniti tablicu
INSERT INTO Polaznici VALUES('Mirko','Spirko', 'Zagreb')
INSERT INTO Polaznici VALUES('Jura','Klafura', 'Vara�din')
INSERT INTO Polaznici(Ime, Prezime) VALUES('Pero','�dero')
INSERT INTO Polaznici VALUES('Ava','Karabati�', 'Smederevo')