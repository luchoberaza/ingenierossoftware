-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 03, 2022 at 02:32 PM
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
  `IdUsuario` int(11) NOT NULL,
  `Nombre` varchar(200) NOT NULL,
  `Direccion` varchar(200) NOT NULL,
  `Telefono` varchar(200) NOT NULL,
  `Saldo` float NOT NULL,
  PRIMARY KEY (`ID.CLI`),
  KEY `IdUsuario` (`IdUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`ID.CLI`, `IdUsuario`, `Nombre`, `Direccion`, `Telefono`, `Saldo`) VALUES
(1, 1, 'Pedro Picapiedra', 'Jurasico 352', '098999999', 0),
(2, 1, 'Carola Baldassari', 'Julio Herrera y Obes 851', 'el del santi', 0),
(3, 1, 'Juan Gabriel', 'Chinchurreta', '099999999', 10);

-- --------------------------------------------------------

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
CREATE TABLE IF NOT EXISTS `detalleventa` (
  `IdDetalleVenta` int(11) NOT NULL AUTO_INCREMENT,
  `IdVenta` int(11) NOT NULL,
  `IdProd` int(11) NOT NULL,
  `PrecioVenta` float NOT NULL,
  `Cantidad` float NOT NULL,
  `SubTotal` float NOT NULL,
  PRIMARY KEY (`IdDetalleVenta`),
  KEY `IdVenta` (`IdVenta`),
  KEY `IdProd` (`IdProd`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `elaboracion`
--

DROP TABLE IF EXISTS `elaboracion`;
CREATE TABLE IF NOT EXISTS `elaboracion` (
  `IdElaboracion` int(11) NOT NULL AUTO_INCREMENT,
  `IdMatPrim` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Cantidad` float NOT NULL,
  PRIMARY KEY (`IdElaboracion`),
  KEY `IdMatPrim` (`IdMatPrim`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `elaboracion`
--

INSERT INTO `elaboracion` (`IdElaboracion`, `IdMatPrim`, `Fecha`, `Cantidad`) VALUES
(1, 1, '2022-11-02', 10),
(2, 2, '2022-11-02', 100),
(3, 1, '2022-11-02', 100),
(4, 1, '2022-11-02', 10),
(5, 2, '2022-11-02', 10),
(6, 2, '2022-11-02', 5);

-- --------------------------------------------------------

--
-- Table structure for table `gasto`
--

DROP TABLE IF EXISTS `gasto`;
CREATE TABLE IF NOT EXISTS `gasto` (
  `IdGasto` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `Valor` float NOT NULL,
  `Concepto` varchar(100) NOT NULL,
  `Fecha` date NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  PRIMARY KEY (`IdGasto`),
  KEY `IdUsuario` (`IdUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gasto`
--

INSERT INTO `gasto` (`IdGasto`, `IdUsuario`, `Valor`, `Concepto`, `Fecha`, `Tipo`) VALUES
(2, 1, 1000, 'Firulais', '2022-11-01', 'Compra de insumos'),
(3, 1, 2000, 'Cartuchos de tinta', '2022-11-01', 'Compra de insumos'),
(4, 1, 3000, 'Pan rallado 20kg', '2022-07-14', 'Compra de materia prima');

-- --------------------------------------------------------

--
-- Table structure for table `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `ID.Mat` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `Costo` float NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `Stock` float NOT NULL,
  PRIMARY KEY (`ID.Mat`),
  KEY `IdUsuario` (`IdUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `materia_prima`
--

INSERT INTO `materia_prima` (`ID.Mat`, `IdUsuario`, `Costo`, `Descripcion`, `Stock`) VALUES
(1, 1, 50, 'Pan rallado', 40),
(2, 1, 40, 'ORegano', 480);

-- --------------------------------------------------------

--
-- Table structure for table `producto_venta`
--

DROP TABLE IF EXISTS `producto_venta`;
CREATE TABLE IF NOT EXISTS `producto_venta` (
  `ID.Prod` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `Stock` float NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `PrecioUnitario` float NOT NULL,
  PRIMARY KEY (`ID.Prod`),
  KEY `IdUsuario` (`IdUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `producto_venta`
--

INSERT INTO `producto_venta` (`ID.Prod`, `IdUsuario`, `Stock`, `Descripcion`, `PrecioUnitario`) VALUES
(2, 1, 4, 'Milanesa al pan', 200),
(3, 1, 13, 'Coca', 100),
(4, 1, 0, 'Papas Fritas', 200);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID.Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(200) NOT NULL,
  `Contraseña` varchar(200) NOT NULL,
  `Denominacion` varchar(50) DEFAULT NULL,
  `RUT` varchar(12) DEFAULT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Foto` longblob,
  PRIMARY KEY (`ID.Usuario`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`ID.Usuario`, `Username`, `Contraseña`, `Denominacion`, `RUT`, `Direccion`, `Telefono`, `Foto`) VALUES
(1, 'asd', 'asd', NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `IdVenta` int(11) NOT NULL AUTO_INCREMENT,
  `IDUsuario` int(11) NOT NULL,
  `IDCliente` int(11) DEFAULT NULL,
  `TipoDocumento` varchar(50) NOT NULL,
  `Fecha` date NOT NULL,
  `Importe` float NOT NULL,
  `Envio` tinyint(1) NOT NULL,
  `Cambio` float DEFAULT NULL,
  PRIMARY KEY (`IdVenta`),
  KEY `ID.Usuario` (`IDUsuario`) USING BTREE,
  KEY `ID.CLI` (`IDCliente`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `venta`
--

INSERT INTO `venta` (`IdVenta`, `IDUsuario`, `IDCliente`, `TipoDocumento`, `Fecha`, `Importe`, `Envio`, `Cambio`) VALUES
(14, 1, 2, 'eTicket Contado', '2022-11-03', 100, 1, 100),
(13, 1, 2, 'eTicket Contado', '2022-11-03', 100, 1, 100),
(12, 1, 1, 'eTicket Contado', '2022-11-03', 200, 1, 300),
(11, 1, 1, 'eTicket Contado', '2022-11-03', 200, 1, 300),
(10, 1, 1, 'eTicket Contado', '2022-11-03', 200, 1, 300),
(9, 1, 1, 'eTicket Contado', '2022-11-03', 200, 1, 300);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
