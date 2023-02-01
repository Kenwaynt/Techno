CREATE DATABASE CompuA
Use CompuA

CREATE TABLE Ingreso(
Usuario varchar(150), 
Contraseña varchar(150),
Rol varchar(150)
)

INSERT INTO Ingreso VALUES('Melvin','123A','Administrador')
INSERT INTO Ingreso VALUES('Anthony','123B','Secretario')
INSERT INTO Ingreso VALUES('Henrry','123C','cliente')

SELECT *FROM Ingreso

CREATE TABLE VistaUsuario(
Usuario varchar(150), 
Rol varchar(150)
)

INSERT INTO VistaUsuario VALUES('Melvin','Administrador')
INSERT INTO VistaUsuario VALUES('Anthony','Secretario')
INSERT INTO VistaUsuario VALUES('Henrry','cliente')

SELECT *FROM VistaUsuario

DROP TABLE Ingreso
