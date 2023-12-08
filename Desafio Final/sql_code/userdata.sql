CREATE DATABASE `7code`;

USE DATABASE `7code`;

CREATE TABLE `userdata` (
  `id_user` int(11)  PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `nome` varchar(90) DEFAULT NULL,
  `senha` varchar(90) DEFAULT NULL
);