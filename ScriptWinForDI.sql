create database DBDonoCaoWinForDI
go

use DBDonoCaoWinForDI
go

CREATE TABLE tblDono(
DonoId int PRIMARY KEY IDENTITY(1,1),
NomeDono varchar (30),
CPF varchar (15),
Telefone varchar (15)
)

CREATE TABLE tblCao(
CaoId int PRIMARY KEY IDENTITY(1,1),
NomeCao varchar (100),
Raca varchar (100),
DonoId int 
CONSTRAINT fk_DonoId FOREIGN KEY (DonoId) REFERENCES tblDono (DonoId)
)