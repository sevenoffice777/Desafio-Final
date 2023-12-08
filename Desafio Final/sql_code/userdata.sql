-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 05-Dez-2023 às 16:56
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `7code`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `userdata`
--

CREATE DATABASE ``7code`;

USE DATABASE `7code`;
 
CREATE TABLE `userdata` (
  `id_user` int(11) NOT NULL,
  `nome` varchar(90) DEFAULT NULL,
  `senha` varchar(90) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `userdata`
--

INSERT INTO `userdata` (`id_user`, `nome`, `senha`) VALUES
(1, 'samuel', 'samuel123'),
(2, 'caio', 'caio123');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `userdata`
--
ALTER TABLE `userdata`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `userdata`
--
ALTER TABLE `userdata`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
