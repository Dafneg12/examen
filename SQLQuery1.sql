USE SistemaAccesos;
GO

CREATE TABLE Domicilios (
    domicilioID INT IDENTITY(1,1) PRIMARY KEY,
    calle NVARCHAR(100),
    numero NVARCHAR(10),
    colonia NVARCHAR(100)
);
GO

CREATE TABLE Residentes (
    id_res INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100),
    apellidos NVARCHAR(100),
    telefono NVARCHAR(20),
    domicilioID INT FOREIGN KEY REFERENCES Domicilios(domicilioID)
);
GO

CREATE TABLE Guardias (
    guardiaID INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100),
    apellidos NVARCHAR(100)
);
GO

CREATE TABLE Invitados (
    id_invitado INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100),
    apellidos NVARCHAR(100),
    id_res INT FOREIGN KEY REFERENCES Residentes(id_res)
);
GO

CREATE TABLE TipoInvitacion (
    id_tipo INT IDENTITY(1,1) PRIMARY KEY,
    descripcion NVARCHAR(50)
);
GO

CREATE TABLE Invitaciones (
    id_invitacion INT IDENTITY(1,1) PRIMARY KEY,
    id_invitado INT FOREIGN KEY REFERENCES Invitados(id_invitado),
    id_tipo INT FOREIGN KEY REFERENCES TipoInvitacion(id_tipo),
    fecha_inicio DATE,
    fecha_fin DATE,
    codigoQR NVARCHAR(MAX),
    estado NVARCHAR(50)
);
GO

CREATE TABLE Accesos (
    id_acceso INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE,
    hora TIME,
    tipo_acceso NVARCHAR(50),
    id_invitacion INT FOREIGN KEY REFERENCES Invitaciones(id_invitacion),
    id_guardia INT FOREIGN KEY REFERENCES Guardias(guardiaID)
);
GO

CREATE TABLE UsuariosResidentes (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    id_residente INT FOREIGN KEY REFERENCES Residentes(id_res),
    correo NVARCHAR(100),
    contraseña NVARCHAR(100)
);
GO

INSERT INTO Guardias (nombre, apellidos) VALUES
('Jonathan Alejandro', 'Alcantar Paredes'),
('Cristopher Leonardo', 'Alvarez Nuñez');
GO

INSERT INTO TipoInvitacion (descripcion) VALUES
('Única'),
('Por fecha'),
('Recurrente');
GO