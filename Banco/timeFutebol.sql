CREATE DATABASE IF NOT EXISTS timeFutebol;
USE timeFutebol;

CREATE TABLE IF NOT EXISTS times(
	idtime INTEGER PRIMARY KEY AUTO_INCREMENT,
	nome_oficial VARCHAR(150) NOT NULL,
	nome_fantasia VARCHAR(70) NOT NULL,
	endereco VARCHAR(100) NOT NULL,
	dt_fundacao DATE NOT NULL,
	escudo VARCHAR(100),
	telefone CHAR(13) NOT NULL,
	email VARCHAR(70) NOT NULL,
	estadio VARCHAR(70) 
);

CREATE TABLE IF NOT EXISTS jogadores(
	idjogador INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    dt_nascimento DATE NOT NULL,
    sexo CHAR(3) NOT NULL,
    cpf CHAR(11) NOT NULL UNIQUE,
    rg CHAR(7) NOT NULL UNIQUE,
    email VARCHAR(70) NOT NULL,
    peso DOUBLE,
    altura DOUBLE,
    telefone CHAR(13) NOT NULL,
    nacionalidade VARCHAR(70) NOT NULL,
    apelido VARCHAR(50),
    posicao VARCHAR(50) NOT NULL,
    n_camisa INTEGER NOT NULL,
    foto VARCHAR(70),
    time_anterior VARCHAR(100),
    data_hora_inicio DATETIME NOT NULL,
    data_hora_fim DATETIME NOT NULL,
    fk_idtime INTEGER,
    FOREIGN KEY (fk_idtime) REFERENCES times(idtime)
    );
   
ALTER TABLE jogadores CHANGE data_hora_fim data_hora_fim DATETIME;
    
desc jogadores;
desc times;
ALTER TABLE jogadores CHANGE endereco endereco VARCHAR(100) NOT NULL;
