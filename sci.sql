/*
 Navicat Premium Data Transfer

 Source Server         : wamp
 Source Server Type    : MySQL
 Source Server Version : 50719
 Source Host           : localhost:3306
 Source Schema         : sci

 Target Server Type    : MySQL
 Target Server Version : 50719
 File Encoding         : 65001

 Date: 26/02/2018 13:00:00
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for articulos
-- ----------------------------
DROP TABLE IF EXISTS `articulos`;
CREATE TABLE `articulos`  (
  `idArticulo` int(11) NOT NULL DEFAULT 0,
  `Codigo` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `idCategoria` int(11) NULL DEFAULT NULL,
  `Descripcion` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Marca` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `idUnidad` int(11) NULL DEFAULT NULL,
  `Cantidad` int(11) NULL DEFAULT NULL,
  `PCompra` decimal(10, 2) NULL DEFAULT NULL,
  `PVenta` decimal(10, 2) NULL DEFAULT NULL,
  `Min` int(11) NULL DEFAULT NULL,
  `Max` int(11) NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idArticulo`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for categorias
-- ----------------------------
DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias`  (
  `idCategoria` int(11) NOT NULL DEFAULT 0,
  `Nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idCategoria`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes`  (
  `idCliente` int(11) NOT NULL DEFAULT 0,
  `Nombre` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Direccion` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Nacimiento` date NULL DEFAULT NULL,
  `Peso` smallint(6) NULL DEFAULT NULL,
  `Tel` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Emergencia` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `eMail` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Facebook` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Registro` datetime(0) NULL DEFAULT NULL,
  `Obs` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idCliente`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for compras
-- ----------------------------
DROP TABLE IF EXISTS `compras`;
CREATE TABLE `compras`  (
  `idCompra` int(11) NOT NULL DEFAULT 0,
  `Fecha` datetime(0) NULL DEFAULT NULL,
  `Total` decimal(10, 2) NULL DEFAULT NULL,
  `User` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idCompra`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for comprasdetalle
-- ----------------------------
DROP TABLE IF EXISTS `comprasdetalle`;
CREATE TABLE `comprasdetalle`  (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `idCompra` int(11) NULL DEFAULT NULL,
  `idArticulo` int(11) NULL DEFAULT NULL,
  `Precio` decimal(10, 2) NULL DEFAULT NULL,
  `Cantidad` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`idDetalle`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 27 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for empresa
-- ----------------------------
DROP TABLE IF EXISTS `empresa`;
CREATE TABLE `empresa`  (
  `Id` int(11) NOT NULL DEFAULT 0,
  `Nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Calle` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `No` varchar(6) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Colonia` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Telefono` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Ciudad` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Horario` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `RFC` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for formaspago
-- ----------------------------
DROP TABLE IF EXISTS `formaspago`;
CREATE TABLE `formaspago`  (
  `idFormaPago` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Credito` tinyint(4) NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idFormaPago`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for inventario
-- ----------------------------
DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario`  (
  `clave` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `codigo` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `unidad` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `factor` decimal(6, 2) NULL DEFAULT NULL,
  `precio` decimal(12, 2) NULL DEFAULT NULL,
  `existencia` decimal(12, 4) NULL DEFAULT NULL,
  `min` decimal(12, 4) NULL DEFAULT NULL,
  `max` decimal(12, 4) NULL DEFAULT NULL,
  PRIMARY KEY (`clave`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for notas
-- ----------------------------
DROP TABLE IF EXISTS `notas`;
CREATE TABLE `notas`  (
  `idNota` int(11) NOT NULL DEFAULT 0,
  `Fecha` datetime(0) NULL DEFAULT NULL,
  `Total` decimal(10, 2) NULL DEFAULT NULL,
  `Paga` decimal(10, 2) NULL DEFAULT NULL,
  `idFormaPago` int(11) NULL DEFAULT NULL,
  `User` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idNota`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for notasdetalle
-- ----------------------------
DROP TABLE IF EXISTS `notasdetalle`;
CREATE TABLE `notasdetalle`  (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `idNota` int(11) NULL DEFAULT NULL,
  `idArticulo` int(11) NULL DEFAULT NULL,
  `Precio` decimal(10, 2) NULL DEFAULT NULL,
  `Cantidad` int(11) NULL DEFAULT NULL,
  `Descuento` decimal(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`idDetalle`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3439 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for permisos
-- ----------------------------
DROP TABLE IF EXISTS `permisos`;
CREATE TABLE `permisos`  (
  `idPermiso` char(4) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '0',
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idPermiso`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for roles
-- ----------------------------
DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles`  (
  `idRol` smallint(6) NOT NULL DEFAULT 0,
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Permisos` varchar(1000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idRol`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sequence
-- ----------------------------
DROP TABLE IF EXISTS `sequence`;
CREATE TABLE `sequence`  (
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `increment` int(11) NOT NULL DEFAULT 1,
  `min_value` int(11) NOT NULL DEFAULT 1,
  `max_value` bigint(20) NOT NULL DEFAULT 9223372036854775807,
  `cur_value` bigint(20) NULL DEFAULT 1,
  `cycle` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`name`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for unidades
-- ----------------------------
DROP TABLE IF EXISTS `unidades`;
CREATE TABLE `unidades`  (
  `idUnidad` int(11) NOT NULL DEFAULT 0,
  `Nombre` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Valor` smallint(6) NULL DEFAULT NULL,
  `Status` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`idUnidad`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios`  (
  `User` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',
  `Pass` varchar(64) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `idRol` smallint(6) NULL DEFAULT NULL,
  `Nombre` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Dir` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Tel` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Mail` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Facebook` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Status` varchar(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Registro` datetime(0) NULL DEFAULT NULL,
  `Obs` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sesion` tinyint(4) NULL DEFAULT NULL,
  PRIMARY KEY (`User`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Function structure for curval
-- ----------------------------
DROP FUNCTION IF EXISTS `curval`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `curval`(`seq_name` varchar(100)) RETURNS bigint(20)
BEGIN
    DECLARE cur_val bigint;
 
    SELECT
        cur_value INTO cur_val
    FROM
        sequence
    WHERE
        name = seq_name;
 
    
    RETURN cur_val;
END
;;
delimiter ;

-- ----------------------------
-- Function structure for nextval
-- ----------------------------
DROP FUNCTION IF EXISTS `nextval`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `nextval`(`seq_name` varchar(100)) RETURNS bigint(20)
BEGIN
    DECLARE cur_val bigint;
 
    SELECT
        cur_value INTO cur_val
    FROM
        sequence
    WHERE
        name = seq_name;
 
    IF cur_val IS NOT NULL THEN
        UPDATE
            sequence
        SET
            cur_value = IF (
                (cur_value + increment) > max_value OR (cur_value + increment) < min_value,
                IF (
                    cycle = TRUE,
                    IF (
                        (cur_value + increment) > max_value,
                        min_value, 
                        max_value 
                    ),
                    NULL
                ),
                cur_value + increment
            )
        WHERE
            name = seq_name;
    END IF; 
    RETURN cur_val;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
