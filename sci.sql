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

 Date: 24/02/2018 14:04:54
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for compras
-- ----------------------------
DROP TABLE IF EXISTS `compras`;
CREATE TABLE `compras`  (
  `folio` int(11) NOT NULL,
  `fecha` datetime(0) NULL DEFAULT NULL,
  `proveedor` int(11) NULL DEFAULT NULL,
  `observaciones` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `total` decimal(12, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`folio`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for comprasdetalle
-- ----------------------------
DROP TABLE IF EXISTS `comprasdetalle`;
CREATE TABLE `comprasdetalle`  (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `compra` int(11) NULL DEFAULT NULL,
  `producto` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `cantidad` decimal(12, 4) NULL DEFAULT NULL,
  `precio` decimal(12, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`numero`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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
-- Records of inventario
-- ----------------------------
INSERT INTO `inventario` VALUES ('1', '1', 'algo', 'pz', 1.00, 10.00, 5.0000, 1.0000, 10.0000);

-- ----------------------------
-- Table structure for remision
-- ----------------------------
DROP TABLE IF EXISTS `remision`;
CREATE TABLE `remision`  (
  `folio` int(11) NOT NULL,
  `fecha` datetime(0) NULL DEFAULT NULL,
  `cliente` int(11) NULL DEFAULT NULL,
  `observaciones` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `total` decimal(12, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`folio`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for remisiondetalle
-- ----------------------------
DROP TABLE IF EXISTS `remisiondetalle`;
CREATE TABLE `remisiondetalle`  (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `remision` int(11) NULL DEFAULT NULL,
  `producto` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `cantidad` decimal(12, 4) NULL DEFAULT NULL,
  `precio` decimal(12, 2) NULL DEFAULT NULL,
  `descuento` decimal(4, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`numero`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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
-- Records of sequence
-- ----------------------------
INSERT INTO `sequence` VALUES ('compra', 1, 1, 9223372036854775807, 3, 0);
INSERT INTO `sequence` VALUES ('remision', 1, 1, 9223372036854775807, 1, 0);

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios`  (
  `user` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `pass` varchar(8) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`user`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('admin', '1234');

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
