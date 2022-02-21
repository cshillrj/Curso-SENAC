-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 21, 2022 at 07:50 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `turismo`
--

-- --------------------------------------------------------

--
-- Table structure for table `pacotesturisticos`
--

CREATE TABLE `pacotesturisticos` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(200) DEFAULT NULL,
  `Origem` varchar(100) DEFAULT NULL,
  `Destino` varchar(100) DEFAULT NULL,
  `Atrativos` varchar(200) DEFAULT NULL,
  `Saida` date DEFAULT NULL,
  `Retorno` date DEFAULT NULL,
  `Usuario` int(11) DEFAULT NULL,
  `Operacoes` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pacotesturisticos`
--

INSERT INTO `pacotesturisticos` (`Id`, `Nome`, `Origem`, `Destino`, `Atrativos`, `Saida`, `Retorno`, `Usuario`, `Operacoes`) VALUES
(2, 'Caribe', 'Rio de Janeiro', 'Cancun', 'Praias e cassinos', '2022-02-19', '2022-02-26', 1, NULL),
(7, 'Florida', 'Rio de Janeiro', 'Miami', 'Praias e compras', '2022-05-07', '2022-05-14', 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(200) DEFAULT NULL,
  `Login` varchar(30) DEFAULT NULL,
  `Senha` varchar(30) DEFAULT NULL,
  `DataNasc` date DEFAULT NULL,
  `Operacoes` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `Login`, `Senha`, `DataNasc`, `Operacoes`) VALUES
(1, 'Cristiano Hill', 'cshill', '123456', '2022-02-03', NULL),
(4, 'Francisco', 'fran1234', '121454', '1992-08-26', NULL),
(6, 'Maria', 'MariaRJ', '020304', '1992-01-28', NULL),
(8, 'Pedro', 'pe007rj', '040506', '2004-05-03', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pacotesturisticos`
--
ALTER TABLE `pacotesturisticos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Usuario` (`Usuario`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pacotesturisticos`
--
ALTER TABLE `pacotesturisticos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pacotesturisticos`
--
ALTER TABLE `pacotesturisticos`
  ADD CONSTRAINT `pacotesturisticos_ibfk_1` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
