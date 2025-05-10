-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-05-2025 a las 02:52:01
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_vehiculos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_autenticacion`
--

CREATE TABLE `tbl_autenticacion` (
  `id_usuario` varchar(10) NOT NULL,
  `password` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_autenticacion`
--

INSERT INTO `tbl_autenticacion` (`id_usuario`, `password`) VALUES
('admin', 1234);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_contribuyentes`
--

CREATE TABLE `tbl_contribuyentes` (
  `rut` varchar(9) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `nacionalidad` varchar(20) NOT NULL,
  `comuna` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_contribuyentes`
--

INSERT INTO `tbl_contribuyentes` (`rut`, `nombre`, `apellido`, `nacionalidad`, `comuna`) VALUES
('171112223', 'Miguel', 'Gajardo', 'Chilena', 'NA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vehiculos`
--

CREATE TABLE `tbl_vehiculos` (
  `patente` varchar(6) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `modelo` varchar(20) NOT NULL,
  `anio` varchar(4) NOT NULL,
  `rut_contribuyente` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_autenticacion`
--
ALTER TABLE `tbl_autenticacion`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indices de la tabla `tbl_contribuyentes`
--
ALTER TABLE `tbl_contribuyentes`
  ADD PRIMARY KEY (`rut`);

--
-- Indices de la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD PRIMARY KEY (`patente`),
  ADD KEY `rut_contribuyente` (`rut_contribuyente`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_vehiculos`
--
ALTER TABLE `tbl_vehiculos`
  ADD CONSTRAINT `tbl_vehiculos_ibfk_1` FOREIGN KEY (`rut_contribuyente`) REFERENCES `tbl_contribuyentes` (`rut`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
