CREATE DATABASE eventplus;

USE eventplus;

DROP DATABASE eventplus;
DROP DATABASE eventplus;

CREATE TABLE TipoUsuario (
	IdTipoUsuario UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Titulo VARCHAR(100) NOT NULL
);

CREATE TABLE TipoEvento (
    IdTipoEvento UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Titulo VARCHAR(100) NOT NULL
); 

CREATE TABLE Instituicao (
    IdInstituicao UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    CNPJ VARCHAR(14) NOT NULL UNIQUE,
    NomeFantasia VARCHAR(100) NOT NULL,
    Endereco VARCHAR(100) NOT NULL
);

CREATE TABLE Usuario (
    IdUsuario UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    IdTipoUsuario UNIQUEIDENTIFIER NOT NULL,
    Nome VARCHAR(250) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(60) NOT NULL,
    FOREIGN KEY (IdTipoUsuario) REFERENCES TipoUsuario(IdTipoUsuario)
);

CREATE TABLE Evento (
    IdEvento UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    IdTipoEvento UNIQUEIDENTIFIER NOT NULL,
    IdInstituicao UNIQUEIDENTIFIER NOT NULL,
    NomeEvento VARCHAR(100) NOT NULL,
    Descricao VARCHAR (MAX) NOT NULL,
    DataEvento DATE NOT NULL DEFAULT GETDATE(),
    UrlImagem VARCHAR(100) NOT NULL,
    CONSTRAINT FKTipoEvento FOREIGN KEY (IdTipoEvento) REFERENCES TipoEvento(IdTipoEvento),
    CONSTRAINT FKInstituicao FOREIGN KEY (IdInstituicao) REFERENCES Instituicao(IdInstituicao)
);

CREATE TABLE Comentario (
    IdComentario UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    IdUsuario UNIQUEIDENTIFIER NOT NULL,
    IdEvento UNIQUEIDENTIFIER NOT NULL,
    Descricao VARCHAR(250) NOT NULL,
    DataComentario DATE NOT NULL DEFAULT GETDATE(),
    Exibe BIT NOT NULL DEFAULT 1,
    CONSTRAINT FKUsuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FKEvento FOREIGN KEY (IdEvento) REFERENCES Evento(IdEvento)
);

CREATE TABLE Presenca (
    IdPresenca UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    IdUsuario UNIQUEIDENTIFIER NOT NULL,
    IdEvento UNIQUEIDENTIFIER NOT NULL,
    Situacao BIT NOT NULL DEFAULT 0,
    CONSTRAINT FKUsuario1 FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    CONSTRAINT FKEvento1 FOREIGN KEY (IdEvento) REFERENCES Evento(IdEvento)
);

INSERT INTO TipoUsuario (Titulo) VALUES 
('Administrador');
SELECT * FROM TipoUsuario;

INSERT INTO TipoEvento (Titulo) VALUES 
('Musica');
SELECT * FROM TipoEvento;

INSERT INTO Instituicao (CNPJ, NomeFantasia, Endereco) VALUES 
('12345678910121', 'LAMOT', 'Unimed');
SELECT * FROM Instituicao;

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha) VALUES 
('F6542E8C-CD45-4661-AB21-348D8EE79F08', 'Laufey', '1laufey@gmail.com', 'laufeymeimei');
SELECT * FROM Usuario;

INSERT INTO Evento (IdTipoEvento, IdInstituicao, NomeEvento, Descricao, DataEvento, UrlImagem) VALUES 
('8CF7D578-6991-4D59-AEBB-4F94B4B94313', '63B6D5AF-A5D5-4DCC-97A2-E08E9003159F', 'Laufey - A Matter of Time Tour', 'Maior cantora islandesa de Jazz e Pop no Brasil', '2026-09-09', 'https://unsplash.com/pt-br/fotografias/relogios-castanhos-e-brancos-FlHdnPO6dlw');
SELECT * FROM Evento;

INSERT INTO Comentario (IdUsuario, IdEvento, Descricao, DataComentario, Exibe) VALUES 
('F13B52E9-4E36-431C-9F9D-0BCE0D78054A', '2A84FCA7-38A2-4C34-A194-8E5D9ABD1587', 'Maior escolha da vida dela fazer esse tour', '2026-10-09', 0);
SELECT * FROM Comentario;

INSERT INTO Presenca (IdUsuario, IdEvento, Situacao) VALUES 
('F13B52E9-4E36-431C-9F9D-0BCE0D78054A', '2A84FCA7-38A2-4C34-A194-8E5D9ABD1587', 1);
SELECT * FROM Presenca;




