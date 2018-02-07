-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-02-2018 a las 11:00:26
-- Versión del servidor: 10.1.26-MariaDB
-- Versión de PHP: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pokemon-center`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `center`
--

CREATE TABLE `center` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `center`
--

INSERT INTO `center` (`id`, `name`) VALUES
(1, 'Ciudad Verde');
INSERT INTO `center` (`id`, `name`) VALUES
(2, 'Pueblo Paleta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nurse`
--

CREATE TABLE `nurse` (
  `id` int(11) NOT NULL,
  `id_center` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `nurse`
--

INSERT INTO `nurse` (`id`, `id_center`, `username`, `password`) VALUES
(2, 1, 'pepe', '1234'),
(3, 1, 'pepeton', '1234'),
(4, 1, 'SergioPuta', 'soyTonto'),
(5, 1, 'puyiyo', '1234'),
(7, 1, 'Jorge', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pokemon`
--

CREATE TABLE `pokemon` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `race` varchar(20) NOT NULL,
  `chip` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `pokemon`
--

INSERT INTO `pokemon` (`id`, `name`, `gender`, `type`, `race`, `chip`) VALUES
(1, 'qwer', 'qer', 'qwr', 'qwer', 21342223);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `shop`
--

CREATE TABLE `shop` (
  `idproduct` int(11) NOT NULL,
  `img` varchar(11) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `price` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `shop`
--

INSERT INTO `shop` (`idproduct`, `img`, `name`, `price`, `total`) VALUES
(1, '', 'Potion', 300, 83),
(2, '', 'Super Potion', 350, 36),
(3, '', 'Hyper Potion', 750, 29),
(4, '', 'Max Potion', 2500, 45),
(5, '', 'Antidote', 100, 28),
(6, '', 'Burn Heal', 250, 35),
(7, '', 'Awakening', 250, 39),
(8, '', 'Parlyze Heal', 250, 29),
(9, '', 'Revive', 1500, 69),
(10, '', 'Max Revive', 3200, 43);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trainer`
--

CREATE TABLE `trainer` (
  `id` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `surname` varchar(32) NOT NULL,
  `dni` int(11) NOT NULL,
  `phone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `trainer`
--

INSERT INTO `trainer` (`id`, `name`, `surname`, `dni`, `phone`) VALUES
(1, 'ash', 'ketchum', 3412324, '23421142'),
(2, 'erwqr', 'qwerq', 324324, '23423');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trainer_pokemon`
--

CREATE TABLE `trainer_pokemon` (
  `id_trainer` int(11) NOT NULL,
  `id_pokemon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `visit_trainer_center`
--

CREATE TABLE `visit_trainer_center` (
  `date` int(8) NOT NULL,
  `id_center` int(11) NOT NULL,
  `id_trainer` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `center`
--
ALTER TABLE `center`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `nurse`
--
ALTER TABLE `nurse`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_center` (`id_center`) USING BTREE;

--
-- Indices de la tabla `pokemon`
--
ALTER TABLE `pokemon`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `shop`
--
ALTER TABLE `shop`
  ADD PRIMARY KEY (`idproduct`);

--
-- Indices de la tabla `trainer`
--
ALTER TABLE `trainer`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `trainer_pokemon`
--
ALTER TABLE `trainer_pokemon`
  ADD KEY `pokemon_fk_1` (`id_pokemon`),
  ADD KEY `trainer_fk_2` (`id_trainer`);

--
-- Indices de la tabla `visit_trainer_center`
--
ALTER TABLE `visit_trainer_center`
  ADD KEY `center_fk_1` (`id_center`),
  ADD KEY `trainer_fk_1` (`id_trainer`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `center`
--
ALTER TABLE `center`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `nurse`
--
ALTER TABLE `nurse`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `pokemon`
--
ALTER TABLE `pokemon`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `shop`
--
ALTER TABLE `shop`
  MODIFY `idproduct` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `trainer`
--
ALTER TABLE `trainer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `nurse`
--
ALTER TABLE `nurse`
  ADD CONSTRAINT `nurse_ibfk_1` FOREIGN KEY (`id_center`) REFERENCES `center` (`id`);

--
-- Filtros para la tabla `trainer_pokemon`
--
ALTER TABLE `trainer_pokemon`
  ADD CONSTRAINT `pokemon_fk_1` FOREIGN KEY (`id_pokemon`) REFERENCES `pokemon` (`id`),
  ADD CONSTRAINT `trainer_fk_2` FOREIGN KEY (`id_trainer`) REFERENCES `trainer` (`id`);

--
-- Filtros para la tabla `visit_trainer_center`
--
ALTER TABLE `visit_trainer_center`
  ADD CONSTRAINT `center_fk_1` FOREIGN KEY (`id_center`) REFERENCES `center` (`id`),
  ADD CONSTRAINT `trainer_fk_1` FOREIGN KEY (`id_trainer`) REFERENCES `trainer` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
