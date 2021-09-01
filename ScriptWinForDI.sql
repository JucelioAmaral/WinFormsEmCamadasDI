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

-- Ajuste para deletar em cascata o dono e seu cão.
ALTER TABLE dbo.tblCao
  DROP CONSTRAINT fk_DonoId;
ALTER TABLE dbo.tblCao
  ADD CONSTRAINT fk_DonoId
    FOREIGN KEY ( DonoId )
    REFERENCES tblDono ( DonoId )
    ON DELETE CASCADE;