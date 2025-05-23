IF DB_ID('teste_agenda') IS NULL
BEGIN
    CREATE DATABASE teste_agenda;
END
GO


CREATE TABLE usuarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    ds_nome VARCHAR(100) NOT NULL,
    ds_email VARCHAR(100) NOT NULL UNIQUE,
    ds_senha VARCHAR(255) NOT NULL,
    fl_adm BIT NOT NULL,
    fl_ativo BIT DEFAULT 1,
    dt_criado DATETIME DEFAULT GETDATE(),
    dt_atualizado DATETIME DEFAULT GETDATE(),

);

CREATE  TABLE [status] (
	id INT PRIMARY KEY,
	ds_status VARCHAR(20)
);
GO
INSERT INTO [status] (id, ds_status)
VALUES (1, 'Pendente')
		,(2, 'Concluído')
		,(3, 'Excluído');
GO

CREATE TABLE agenda (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT NOT NULL,
    ds_titulo VARCHAR(150) NOT NULL,
    ds_descricao TEXT NULL,
    dt_agenda DATE NOT NULL,
	ds_hora VARCHAR(10) NOT NULL,
    id_status INT DEFAULT 1, 
    dt_criado DATETIME DEFAULT GETDATE(),
    dt_atualizado DATETIME DEFAULT GETDATE(),
    fl_ativo BIT DEFAULT 1, 


    FOREIGN KEY (id_usuario) REFERENCES usuarios(id),
	FOREIGN KEY (id_status) REFERENCES [status](id)
);

CREATE INDEX idx_agenda_usuario_data ON agenda(id_usuario, dt_agenda);