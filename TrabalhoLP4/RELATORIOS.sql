-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para controlealuno
CREATE DATABASE IF NOT EXISTS `controlealuno` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `controlealuno`;


-- Copiando estrutura para tabela controlealuno.diario
CREATE TABLE IF NOT EXISTS `diario` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Data` date NOT NULL,
  `NomeAluno` varchar(50) NOT NULL,
  `Relatorio` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=144 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela controlealuno.diario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `diario` DISABLE KEYS */;
INSERT INTO `diario` (`Id`, `Data`, `NomeAluno`, `Relatorio`) VALUES
	(143, '2000-12-30', 'oi', 'wert');
/*!40000 ALTER TABLE `diario` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
