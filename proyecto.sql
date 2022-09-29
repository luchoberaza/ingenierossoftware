-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 29, 2022 at 01:58 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyecto`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `ID.CLI` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Direccion` varchar(200) NOT NULL,
  `Telefono` varchar(200) NOT NULL,
  `Saldo` float NOT NULL,
  PRIMARY KEY (`ID.CLI`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `compone`
--

DROP TABLE IF EXISTS `compone`;
CREATE TABLE IF NOT EXISTS `compone` (
  `ID.Prod` int(11) NOT NULL,
  `ID.Mat` int(11) NOT NULL,
  `Cantidad` float NOT NULL,
  KEY `ID.Prod` (`ID.Prod`),
  KEY `ID.Mat` (`ID.Mat`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `conforma`
--

DROP TABLE IF EXISTS `conforma`;
CREATE TABLE IF NOT EXISTS `conforma` (
  `ID.Prod` int(11) NOT NULL,
  `Nro.Factura` int(11) NOT NULL,
  `Cantidad` float NOT NULL,
  `Precio` float NOT NULL,
  KEY `ID.Prod` (`ID.Prod`),
  KEY `Nro.Factura` (`Nro.Factura`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
CREATE TABLE IF NOT EXISTS `empleado` (
  `C.I` int(11) NOT NULL,
  `Nombre` varchar(200) NOT NULL,
  `Telefono` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `gasto`
--

DROP TABLE IF EXISTS `gasto`;
CREATE TABLE IF NOT EXISTS `gasto` (
  `ID.Gas` int(11) NOT NULL AUTO_INCREMENT,
  `C.I.Empleado` int(11) NOT NULL,
  `ID.Mat.Materia_Prima` int(11) NOT NULL,
  `Valor` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  PRIMARY KEY (`ID.Gas`),
  KEY `C.I.Empleado` (`C.I.Empleado`),
  KEY `ID.Mat.Materia_Prima` (`ID.Mat.Materia_Prima`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `ID.Mat` int(11) NOT NULL AUTO_INCREMENT,
  `Costo` float NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `Stock` float NOT NULL,
  PRIMARY KEY (`ID.Mat`)
) ENGINE=MyISAM AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `materia_prima`
--

INSERT INTO `materia_prima` (`ID.Mat`, `Costo`, `Descripcion`, `Stock`) VALUES
(33, 65, '65', 65);

-- --------------------------------------------------------

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
CREATE TABLE IF NOT EXISTS `pago` (
  `Nro.Recibo` int(11) NOT NULL AUTO_INCREMENT,
  `ID.Cli.Cliente` int(11) NOT NULL,
  `Importe` float NOT NULL,
  `Fecha` date NOT NULL,
  `Pagado` tinyint(1) NOT NULL,
  PRIMARY KEY (`Nro.Recibo`),
  KEY `ID.Cli.Cliente` (`ID.Cli.Cliente`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `producto_venta`
--

DROP TABLE IF EXISTS `producto_venta`;
CREATE TABLE IF NOT EXISTS `producto_venta` (
  `ID.Prod` int(11) NOT NULL AUTO_INCREMENT,
  `Stock` float NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `PrecioUnitario` float NOT NULL,
  PRIMARY KEY (`ID.Prod`)
) ENGINE=MyISAM AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID.Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(200) NOT NULL,
  `Contraseña` varchar(200) NOT NULL,
  PRIMARY KEY (`ID.Usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`ID.Usuario`, `Username`, `Contraseña`) VALUES
(1, 'geroramo', '123'),
(2, 'poroto123', '123'),
(3, '123', '123'),
(4, 'asd', 'asd'),
(5, 'xz1', 'xz1'),
(6, '123', '123');

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `Nro.Factura` int(11) NOT NULL AUTO_INCREMENT,
  `ID.User.Usuario` int(11) NOT NULL,
  `ID.Cli.Cliente` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Importe` float NOT NULL,
  `Envio` tinyint(1) NOT NULL,
  `Tipo` varchar(200) NOT NULL,
  PRIMARY KEY (`Nro.Factura`),
  KEY `ID.User.Usuario` (`ID.User.Usuario`),
  KEY `ID.Cli.Cliente` (`ID.Cli.Cliente`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
