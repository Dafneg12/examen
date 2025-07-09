DBCC CHECKIDENT ('Residentes', RESEED, 0);
GO

DBCC CHECKIDENT ('Invitados', RESEED, 0);
GO

DBCC CHECKIDENT ('UsuariosResidentes', RESEED, 0);
GO

DBCC CHECKIDENT ('Accesos', RESEED, 0);
GO

EXEC sp_help 'Accesos';
ALTER TABLE Accesos
ALTER COLUMN fecha DATETIME;

SELECT TOP 1 fecha FROM Accesos;

CREATE TABLE Accesos (
    id_acceso INT PRIMARY KEY IDENTITY(1,1),
    fecha DATETIME,
    tipo_acceso NVARCHAR(50),
    id_residente INT NULL,
    id_invitado INT NULL,
    id_guardia INT NOT NULL,
    FOREIGN KEY (id_residente) REFERENCES Residentes(id_residente),
    FOREIGN KEY (id_invitado) REFERENCES Invitados(id_invitado),
    FOREIGN KEY (id_guardia) REFERENCES Guardias(id_guardia)
);