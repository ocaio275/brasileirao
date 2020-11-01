-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 01, 2020 at 06:01 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `brasileirao`
--

-- --------------------------------------------------------

--
-- Table structure for table `tabela`
--

CREATE TABLE `tabela` (
  `classificacoes` char(2) DEFAULT NULL,
  `times` varchar(15) DEFAULT NULL,
  `pontos` int(11) DEFAULT NULL,
  `jogos` int(11) DEFAULT NULL,
  `vitorias` int(11) DEFAULT NULL,
  `empates` int(11) DEFAULT NULL,
  `derrotas` int(11) DEFAULT NULL,
  `gp` int(11) DEFAULT NULL,
  `gc` int(11) DEFAULT NULL,
  `sg` int(11) DEFAULT NULL,
  `porcent` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
