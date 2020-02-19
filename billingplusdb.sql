/*
SQLyog Community v11.51 (64 bit)
MySQL - 5.6.25-enterprise-commercial-advanced-log : Database - billingplusdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`billingplusdb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `billingplusdb`;

/*Table structure for table `tblcategory` */

DROP TABLE IF EXISTS `tblcategory`;

CREATE TABLE `tblcategory` (
  `id` int(100) DEFAULT NULL,
  `categoryname` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblcategory` */

/*Table structure for table `tblcompany` */

DROP TABLE IF EXISTS `tblcompany`;

CREATE TABLE `tblcompany` (
  `companyid` int(100) DEFAULT NULL,
  `companyname` varchar(200) DEFAULT NULL,
  `address` varchar(5000) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `pincode` varchar(100) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `logo` varchar(2000) DEFAULT NULL,
  `financialyear` varchar(100) DEFAULT NULL,
  `currency` varchar(100) DEFAULT NULL,
  `password` varchar(200) DEFAULT NULL,
  `phone` varchar(100) DEFAULT NULL,
  `financialyearfrom` varchar(100) DEFAULT NULL,
  `financialyearto` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblcompany` */

insert  into `tblcompany`(`companyid`,`companyname`,`address`,`state`,`pincode`,`email`,`logo`,`financialyear`,`currency`,`password`,`phone`,`financialyearfrom`,`financialyearto`) values (1,'KTK STORE AYIKKARAPPADI','','KERALA','673637','','','2019-2020','INR	','123','8714236354','2019','2020');

/*Table structure for table `tblincomeandexpenses` */

DROP TABLE IF EXISTS `tblincomeandexpenses`;

CREATE TABLE `tblincomeandexpenses` (
  `id` int(11) DEFAULT NULL,
  `incomeorexpense` varchar(255) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `dateof` datetime DEFAULT NULL,
  `typeof` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `amount` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblincomeandexpenses` */

/*Table structure for table `tblinstallmentcollection` */

DROP TABLE IF EXISTS `tblinstallmentcollection`;

CREATE TABLE `tblinstallmentcollection` (
  `id` int(11) DEFAULT NULL,
  `customername` varchar(255) DEFAULT NULL,
  `mobile` varchar(255) DEFAULT NULL,
  `collectiondate` date DEFAULT NULL,
  `amountcollectingnow` decimal(12,2) DEFAULT NULL,
  `balanceamount` decimal(12,2) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `collectionid` int(11) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblinstallmentcollection` */

insert  into `tblinstallmentcollection`(`id`,`customername`,`mobile`,`collectiondate`,`amountcollectingnow`,`balanceamount`,`status`,`collectionid`,`financialyear`,`remarks`,`branch`) values (5,'SALAVAKKA AYAKARAPPADI','','2019-03-25','70.00','800.00','FROM',2,'2019-2020','','FROM	');

/*Table structure for table `tblinstallmentsupplier` */

DROP TABLE IF EXISTS `tblinstallmentsupplier`;

CREATE TABLE `tblinstallmentsupplier` (
  `id` int(11) DEFAULT NULL,
  `customername` varchar(255) DEFAULT NULL,
  `mobile` varchar(255) DEFAULT NULL,
  `collectiondate` date DEFAULT NULL,
  `amountcollectingnow` decimal(12,2) DEFAULT NULL,
  `balanceamount` decimal(12,2) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `collectionid` int(11) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblinstallmentsupplier` */

/*Table structure for table `tblmaster` */

DROP TABLE IF EXISTS `tblmaster`;

CREATE TABLE `tblmaster` (
  `id` int(11) DEFAULT NULL,
  `username` varchar(500) DEFAULT NULL,
  `address` varchar(2500) DEFAULT NULL,
  `contactno` varchar(200) DEFAULT NULL,
  `accounttype` varchar(200) DEFAULT NULL,
  `financialyear` varchar(200) DEFAULT NULL,
  `startingamount` decimal(12,2) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `closingamount` decimal(12,2) DEFAULT NULL,
  `statusclosing` varchar(100) DEFAULT NULL,
  `adhar` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblmaster` */

insert  into `tblmaster`(`id`,`username`,`address`,`contactno`,`accounttype`,`financialyear`,`startingamount`,`status`,`closingamount`,`statusclosing`,`adhar`,`remarks`) values (1,'HAMZAKKA AYKARAPPADI','','','','2019-2020','2500.00','FROM','0.00','From','',''),(2,'AZEEZKA THAZHATH','','','','2019-2020','900.00','FROM	','0.00','From','',''),(3,'BASHEERAKKA ','','','','2019-2020','1980025.52','FROM	','0.00','From','',''),(4,'MAJEEDHAKA','','','','2019-2020','980.00','FROM	','0.00','From','',''),(5,'SALAVAKKA AYAKARAPPADI','','','','2019-2020','800.00','FROM	','0.00','From','','');

/*Table structure for table `tblproduct` */

DROP TABLE IF EXISTS `tblproduct`;

CREATE TABLE `tblproduct` (
  `id` int(11) DEFAULT NULL,
  `productname` varchar(2000) DEFAULT NULL,
  `productcode` varchar(500) DEFAULT NULL,
  `catogery` varchar(500) DEFAULT NULL,
  `sellingprice` decimal(12,2) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `gst` int(100) DEFAULT NULL,
  `cgst` int(100) DEFAULT NULL,
  `sgst` int(100) DEFAULT NULL,
  `startingstock` double DEFAULT NULL,
  `financialyear` varchar(200) DEFAULT NULL,
  `gstamount` decimal(12,2) DEFAULT NULL,
  `barcodeno` varchar(100) DEFAULT NULL,
  `closingstock` double DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblproduct` */

insert  into `tblproduct`(`id`,`productname`,`productcode`,`catogery`,`sellingprice`,`unit`,`gst`,`cgst`,`sgst`,`startingstock`,`financialyear`,`gstamount`,`barcodeno`,`closingstock`) values (1,'Classmate Note Book 100pg','Classmate Note Book 100pg','26','28.00','NOs',0,0,0,47,'2019-2020','0.00','24',0),(2,'Lux soap 20 ','Lux soap 20 ','25','25.00','NOs',0,0,0,221,'2019-2020','0.00','25',0),(3,'Nirapara Smabar Powder','Nirapara Smabar Powder','30','32.00','NOs',0,0,0,41,'2019-2020','0.00','28',0),(4,'Ponni Rice 2x5','Ponni Rice 2x5','40','45.00','NOs',0,0,0,24,'2019-2020','0.00','25',0),(5,'CM OIL 1L','CMOIL1L','40','45.00','NOs',0,0,0,24,'2019-2020','0.00','38',0),(6,'Sony bar soap 28','Sony bar soap 28','32','34.00','NOs',0,0,0,42,'2019-2020','0.00','30',0),(7,'PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','76','78.00','NOs',0,0,0,27,'2019-2020','0.00','75',0),(8,'SUGAR 1KG','SUGAR 1KG','44','45.00','NOs',0,0,0,24,'2019-2020','0.00','43',0),(9,'SEMIYA 1PCK','SEMIYA 1PCK','20','25.00','NOs',0,0,0,21,'2019-2020','0.00','18',0),(10,'CMOIL1L','CM OIL 1L','0','45.00','NOs',0,0,0,0,'2019-2020','0.00','0',0);

/*Table structure for table `tblpurchasevoucher` */

DROP TABLE IF EXISTS `tblpurchasevoucher`;

CREATE TABLE `tblpurchasevoucher` (
  `salesno` int(11) DEFAULT NULL,
  `id` int(11) DEFAULT NULL,
  `customer` varchar(255) DEFAULT NULL,
  `salesdate` date DEFAULT NULL,
  `productcode` varchar(255) DEFAULT NULL,
  `productname` varchar(255) DEFAULT NULL,
  `quantity` decimal(12,2) DEFAULT NULL,
  `unit` varchar(255) DEFAULT NULL,
  `price` decimal(12,2) DEFAULT NULL,
  `discount` decimal(12,2) DEFAULT NULL,
  `total` decimal(12,2) DEFAULT NULL,
  `paymentmode` varchar(255) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  `balance` decimal(12,2) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `grandtotal` decimal(12,2) DEFAULT NULL,
  `discounttotal` decimal(12,2) DEFAULT NULL,
  `nettotal` decimal(12,2) DEFAULT NULL,
  `paid` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblpurchasevoucher` */

insert  into `tblpurchasevoucher`(`salesno`,`id`,`customer`,`salesdate`,`productcode`,`productname`,`quantity`,`unit`,`price`,`discount`,`total`,`paymentmode`,`financialyear`,`narration`,`balance`,`status`,`grandtotal`,`discounttotal`,`nettotal`,`paid`) values (1,1,'Cash Purchase','2019-03-25','Lux soap 20 ','Lux soap 20 ','1.00','NOs','25.00','0.00','25.00','Cash','2019-2020','','0.00','','100.00','0.00','100.00','100.00'),(1,1,'Cash Purchase','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','75.00','0.00','75.00','Cash','2019-2020','','0.00','','100.00','0.00','100.00','100.00'),(2,1,'GM WHOLE SALE DEALERS','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','75.00','0.00','75.00','Credit','2019-2020','','150.00','','150.00','0.00','150.00','0.00'),(2,1,'GM WHOLE SALE DEALERS','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','75.00','0.00','75.00','Credit','2019-2020','','150.00','','150.00','0.00','150.00','0.00'),(3,1,'SN SUPER MARKET CALICUT','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','75.00','0.00','520.00','Credit','2019-2020','','950.00','','950.00','0.00','950.00','0.00'),(3,1,'SN SUPER MARKET CALICUT','2019-03-25','SUGAR 1KG','SUGAR 1KG','1.00','NOs','43.00','0.00','430.00','Credit','2019-2020','','950.00','','950.00','0.00','950.00','0.00');

/*Table structure for table `tblsalesvoucher` */

DROP TABLE IF EXISTS `tblsalesvoucher`;

CREATE TABLE `tblsalesvoucher` (
  `salesno` int(11) DEFAULT NULL,
  `id` int(11) DEFAULT NULL,
  `customer` varchar(255) DEFAULT NULL,
  `salesdate` date DEFAULT NULL,
  `productcode` varchar(255) DEFAULT NULL,
  `productname` varchar(255) DEFAULT NULL,
  `quantity` decimal(12,2) DEFAULT NULL,
  `unit` varchar(255) DEFAULT NULL,
  `price` decimal(12,2) DEFAULT NULL,
  `discount` decimal(12,2) DEFAULT NULL,
  `total` decimal(12,2) DEFAULT NULL,
  `paymentmode` varchar(255) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  `balance` decimal(12,2) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `grandtotal` decimal(12,2) DEFAULT NULL,
  `discounttotal` decimal(12,2) DEFAULT NULL,
  `nettotal` decimal(12,2) DEFAULT NULL,
  `paid` decimal(12,2) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblsalesvoucher` */

insert  into `tblsalesvoucher`(`salesno`,`id`,`customer`,`salesdate`,`productcode`,`productname`,`quantity`,`unit`,`price`,`discount`,`total`,`paymentmode`,`financialyear`,`narration`,`balance`,`status`,`grandtotal`,`discounttotal`,`nettotal`,`paid`) values (1,4,'AZEEZKA THAZHATH','2019-03-25','Sony bar soap 28','Sony bar soap 28','1.00','NOs','34.00','0.00','34.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(1,4,'AZEEZKA THAZHATH','2019-03-25','Nirapara Smabar Powder','Nirapara Smabar Powder','1.00','NOs','32.00','0.00','32.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(1,4,'AZEEZKA THAZHATH','2019-03-25','Classmate Note Book 100pg','Classmate Note Book 100pg','1.00','NOs','28.00','0.00','28.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(1,4,'AZEEZKA THAZHATH','2019-03-25','Lux soap 20 ','Lux soap 20 ','1.00','NOs','25.00','0.00','25.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(1,4,'AZEEZKA THAZHATH','2019-03-25','CMOIL1L','CM OIL 1L','1.00','NOs','45.00','0.00','45.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(1,1,'AZEEZKA THAZHATH','2019-03-25','Sony bar soap 28','Sony bar soap 28','1.00','NOs','32.00','0.00','32.00','Credit','2019-2020','','100.00','','164.00','0.00','100.00','0.00'),(2,0,'Cash Customer','2019-03-25','SUGAR 1KG','SUGAR 1KG','1.00','NOs','44.00','0.00','44.00','Cash','2019-2020','','0.00','','177.00','0.00','177.00','177.00'),(2,0,'Cash Customer','2019-03-25','SEMIYA 1PCK','SEMIYA 1PCK','1.00','NOs','22.00','0.00','22.00','Cash','2019-2020','','0.00','','177.00','0.00','177.00','177.00'),(2,0,'Cash Customer','2019-03-25','CMOIL1L','CM OIL 1L','1.00','NOs','35.00','0.00','35.00','Cash','2019-2020','','0.00','','177.00','0.00','177.00','177.00'),(2,0,'Cash Customer','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','76.00','0.00','76.00','Cash','2019-2020','','0.00','','177.00','0.00','177.00','177.00'),(3,0,'BASHEERAKKA ','2019-03-25','CM OIL 1L','CMOIL1L','1.00','NOs','45.00','0.00','789456.26','Credit','2019-2020','','1979375.52','','1979375.52','0.00','1979375.52','0.00'),(3,0,'BASHEERAKKA ','2019-03-25','PAYASM PALADA PRADHAMAN','PAYASM PALADA PRADHAMAN','1.00','NOs','78.00','0.00','789654.36','Credit','2019-2020','','1979375.52','','1979375.52','0.00','1979375.52','0.00'),(3,0,'BASHEERAKKA ','2019-03-25','SUGAR 1KG','SUGAR 1KG','1.00','NOs','45.00','0.00','145632.30','Credit','2019-2020','','1979375.52','','1979375.52','0.00','1979375.52','0.00'),(3,0,'BASHEERAKKA ','2019-03-25','SEMIYA 1PCK','SEMIYA 1PCK','1.00','NOs','25.00','0.00','254632.60','Credit','2019-2020','','1979375.52','','1979375.52','0.00','1979375.52','0.00'),(4,0,'Cash Customer','2019-03-25','Classmate Note Book 100pg','Classmate Note Book 100pg','1.00','NOs','28.00','0.00','28.00','Cash','2019-2020','','0.00','','169.00','0.00','169.00','169.00'),(4,0,'Cash Customer','2019-03-25','Ponni Rice 2x5','Ponni Rice 2x5','1.00','NOs','45.00','0.00','45.00','Cash','2019-2020','','0.00','','169.00','0.00','169.00','169.00'),(4,0,'Cash Customer','2019-03-25','Sony bar soap 28','Sony bar soap 28','1.00','NOs','34.00','0.00','34.00','Cash','2019-2020','','0.00','','169.00','0.00','169.00','169.00'),(4,0,'Cash Customer','2019-03-25','Classmate Note Book 100pg','Classmate Note Book 100pg','1.00','NOs','28.00','0.00','28.00','Cash','2019-2020','','0.00','','169.00','0.00','169.00','169.00'),(4,0,'Cash Customer','2019-03-25','Sony bar soap 28','Sony bar soap 28','1.00','NOs','34.00','0.00','34.00','Cash','2019-2020','','0.00','','169.00','0.00','169.00','169.00');

/*Table structure for table `tblsupplier` */

DROP TABLE IF EXISTS `tblsupplier`;

CREATE TABLE `tblsupplier` (
  `id` int(11) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contactno` varchar(255) DEFAULT NULL,
  `accounttype` varchar(255) DEFAULT NULL,
  `financialyear` varchar(255) DEFAULT NULL,
  `startingamount` decimal(12,2) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `closingamount` decimal(12,2) DEFAULT NULL,
  `statusclosing` varchar(100) DEFAULT NULL,
  `adhar` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `tblsupplier` */

insert  into `tblsupplier`(`id`,`username`,`address`,`contactno`,`accounttype`,`financialyear`,`startingamount`,`status`,`closingamount`,`statusclosing`,`adhar`,`remarks`) values (1,'SN SUPER MARKET CALICUT','','3244444444444','','2019-2020','13450.00','TO','0.00','From','',''),(2,'GM WHOLE SALE DEALERS','','','','2019-2020','8850.00','TO','0.00','From','',''),(3,'KR BAKLERS','','','','2019-2020','100.00','TO	','0.00','TO','','');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
