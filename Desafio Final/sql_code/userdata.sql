CREATE DATABASE `7code`;

USE DATABASE `7code`;

CREATE TABLE `userdata` (
  `id_user` int(11)  PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nome` varchar(90) DEFAULT NULL,
  `senha` varchar(90) DEFAULT NULL
);


create table cursos(
cod_curso INT  PRIMARY KEY  NOT NULL, 
nome  varchar(90) NOT NULL,
duracao INT NOT NULL,
preco   decimal(10,2) NOT NULL,
desc_curso  varchar(500) NOT NULL   
);