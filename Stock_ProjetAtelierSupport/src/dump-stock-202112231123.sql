-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: stock
-- ------------------------------------------------------
-- Server version	5.5.5-10.3.32-MariaDB-0ubuntu0.20.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `connexion`
--

DROP TABLE IF EXISTS `connexion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `connexion` (
  `idConnexion` int(11) NOT NULL AUTO_INCREMENT,
  `idPersonne` int(11) NOT NULL,
  `CleDeConnexion` varchar(255) NOT NULL,
  PRIMARY KEY (`idConnexion`),
  KEY `connexion_FK` (`idPersonne`),
  CONSTRAINT `connexion_FK` FOREIGN KEY (`idPersonne`) REFERENCES `personne` (`idPersonne`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=165 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `connexion`
--

LOCK TABLES `connexion` WRITE;
/*!40000 ALTER TABLE `connexion` DISABLE KEYS */;
/*!40000 ALTER TABLE `connexion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emprunt`
--

DROP TABLE IF EXISTS `emprunt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `emprunt` (
  `idPersonne` int(11) NOT NULL,
  `idModele` int(11) NOT NULL,
  KEY `emprunt_FK` (`idModele`),
  KEY `emprunt_FK_1` (`idPersonne`),
  CONSTRAINT `emprunt_FK` FOREIGN KEY (`idModele`) REFERENCES `modele` (`idModele`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `emprunt_FK_1` FOREIGN KEY (`idPersonne`) REFERENCES `personne` (`idPersonne`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emprunt`
--

LOCK TABLES `emprunt` WRITE;
/*!40000 ALTER TABLE `emprunt` DISABLE KEYS */;
INSERT INTO `emprunt` VALUES (1,2),(3,4),(1,11),(1,11),(1,8);
/*!40000 ALTER TABLE `emprunt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade` (
  `idGrade` int(11) NOT NULL AUTO_INCREMENT,
  `nomGrade` varchar(100) NOT NULL,
  PRIMARY KEY (`idGrade`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,'Président'),(2,'Ministre'),(3,'Maire'),(4,'Fonctionnaire');
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modele`
--

DROP TABLE IF EXISTS `modele`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modele` (
  `idModele` int(11) NOT NULL AUTO_INCREMENT,
  `nomModele` varchar(100) NOT NULL,
  `idTypeObjet` int(11) NOT NULL,
  PRIMARY KEY (`idModele`),
  KEY `modele_FK` (`idTypeObjet`),
  CONSTRAINT `modele_FK` FOREIGN KEY (`idTypeObjet`) REFERENCES `typeObjet` (`idTypeObjet`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modele`
--

LOCK TABLES `modele` WRITE;
/*!40000 ALTER TABLE `modele` DISABLE KEYS */;
INSERT INTO `modele` VALUES (1,'HP LaserJet Pro M125nw',3),(2,'iPhone X',2),(3,'iPhone 11',2),(4,'iPhone 12',2),(5,'iPhone 13',2),(6,'QC20',9),(7,'SoundSport',9),(8,'CloudX',8),(9,'Ethernet 10m',6),(10,'Asus Strix',5),(11,'HP ASIOP',1),(12,'PS5',7);
/*!40000 ALTER TABLE `modele` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personne`
--

DROP TABLE IF EXISTS `personne`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personne` (
  `idPersonne` int(11) NOT NULL AUTO_INCREMENT,
  `nomPersonne` varchar(100) NOT NULL,
  `prenomPersonne` varchar(100) NOT NULL,
  `dateNaissance` date DEFAULT NULL,
  `idGrade` int(11) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`idPersonne`),
  KEY `personne_FK` (`idGrade`),
  CONSTRAINT `personne_FK` FOREIGN KEY (`idGrade`) REFERENCES `grade` (`idGrade`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personne`
--

LOCK TABLES `personne` WRITE;
/*!40000 ALTER TABLE `personne` DISABLE KEYS */;
INSERT INTO `personne` VALUES (1,'Svoboda','Karel',NULL,4,'karel.svbd@eduge.ch','5138501ef1c5348a24760999abd12cc4f848d9c2'),(2,'Ferreira','José',NULL,1,'jose.frrrd3@eduge.ch','5138501ef1c5348a24760999abd12cc4f848d9c2'),(3,'Serna','Georges',NULL,3,'georges.srn@eduge.ch','5138501ef1c5348a24760999abd12cc4f848d9c2'),(4,'Younes','Amir',NULL,2,'amir.yns@eduge.ch','5138501ef1c5348a24760999abd12cc4f848d9c2'),(5,'Laborde','Robin',NULL,3,'robin.lbrd@eduge.ch','');
/*!40000 ALTER TABLE `personne` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typeObjet`
--

DROP TABLE IF EXISTS `typeObjet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typeObjet` (
  `idTypeObjet` int(11) NOT NULL AUTO_INCREMENT,
  `nomTypeObjet` varchar(100) NOT NULL,
  PRIMARY KEY (`idTypeObjet`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typeObjet`
--

LOCK TABLES `typeObjet` WRITE;
/*!40000 ALTER TABLE `typeObjet` DISABLE KEYS */;
INSERT INTO `typeObjet` VALUES (1,'PC'),(2,'Téléphone'),(3,'Imprimante'),(4,'Écran'),(5,'PC Portable'),(6,'Câble'),(7,'Console'),(8,'Casque'),(9,'Écouteurs');
/*!40000 ALTER TABLE `typeObjet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'stock'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-23 11:23:02
