-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 11-11-2022 a las 22:39:27
-- Versión del servidor: 5.7.36
-- Versión de PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto`
--
DROP DATABASE IF EXISTS `proyecto`;
CREATE DATABASE `proyecto`;
USE `proyecto`;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalleventa`
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
-- Estructura de tabla para la tabla `elaboracion`
--

DROP TABLE IF EXISTS `elaboracion`;
CREATE TABLE IF NOT EXISTS `elaboracion` (
  `IdElaboracion` int(11) NOT NULL AUTO_INCREMENT,
  `IdMatPrim` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Cantidad` float NOT NULL,
  PRIMARY KEY (`IdElaboracion`),
  KEY `IdMatPrim` (`IdMatPrim`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gasto`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_prima`
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_venta`
--

DROP TABLE IF EXISTS `producto_venta`;
CREATE TABLE IF NOT EXISTS `producto_venta` (
  `ID.Prod` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `Stock` float NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `PrecioUnitario` float NOT NULL,
  `CostoUnitario` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID.Prod`),
  KEY `IdUsuario` (`IdUsuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID.Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(200) NOT NULL,
  `Contraseña` blob NOT NULL,
  `Denominacion` varchar(50) DEFAULT NULL,
  `RUT` varchar(12) DEFAULT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Foto` longblob,
  PRIMARY KEY (`ID.Usuario`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

DROP USER IF EXISTS 'usuario'@'%';
CREATE USER 'usuario'@'%' IDENTIFIED WITH mysql_native_password BY 'user';
GRANT SELECT, INSERT, UPDATE, DELETE ON `proyecto`.* TO 'usuario'@'%';

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
