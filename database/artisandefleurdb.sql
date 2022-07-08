-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 08, 2022 at 03:14 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `artisandefleurdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory`
--

CREATE TABLE `tbl_inventory` (
  `ID` bigint(255) NOT NULL,
  `ProductImage` varchar(255) NOT NULL,
  `ProductCode` varchar(255) NOT NULL,
  `ProductCategory` varchar(255) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `ProductDescription` varchar(255) NOT NULL,
  `ProductStocks` varchar(255) NOT NULL,
  `ProductPrice` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_inventory`
--

INSERT INTO `tbl_inventory` (`ID`, `ProductImage`, `ProductCode`, `ProductCategory`, `ProductName`, `ProductDescription`, `ProductStocks`, `ProductPrice`) VALUES
(1, 'C:\\\\Artisan De Fleur\\\\Resources\\\\Products\\\\P202210001.jpg', 'P202210001', 'DISNEY', 'CINDERELLA NECKLACE', 'CINDERELLA NECKLACE', '45', '1500'),
(2, 'C:\\\\Artisan De Fleur\\\\Resources\\\\Products\\\\P202210002.jpg', 'P202210002', 'DISNEY', 'B&B NECKLACE', 'BELLE NECKLACE', '48', '1300');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transactions`
--

CREATE TABLE `tbl_transactions` (
  `ID` bigint(255) NOT NULL,
  `ReferenceNum` varchar(255) NOT NULL,
  `TransactionNum` int(10) NOT NULL,
  `ProductCode` varchar(255) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `ProductQty` varchar(255) NOT NULL,
  `ProductPrice` varchar(255) NOT NULL,
  `ProductTotal` varchar(255) NOT NULL,
  `BuyDate` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_transactions`
--

INSERT INTO `tbl_transactions` (`ID`, `ReferenceNum`, `TransactionNum`, `ProductCode`, `ProductName`, `ProductQty`, `ProductPrice`, `ProductTotal`, `BuyDate`) VALUES
(39, '202204211001', 1001, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(40, '202204211002', 1002, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(41, '202204211003', 1003, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(42, '202204211004', 1004, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(43, '202204211005', 1005, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(44, '202204211006', 1006, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(45, '202204211007', 1007, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(46, '202204211008', 1008, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(47, '202204211001', 1001, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(48, '202204210', 1002, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(49, '202204212', 1003, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(50, '202204213', 1004, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(55, '202204214', 1005, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(56, '202204215', 1006, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(57, '202204216', 1007, 'P202210001', 'CINDERELLA', '1', '1500', '1500', '2022-04-21'),
(67, '202204221001', 1001, 'P202210002', 'B&B NECKLACE', '1', '1300', '1300', '2022-04-22'),
(68, '202204221001', 1001, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(69, '202204221002', 1002, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(70, '202204221003', 1003, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(71, '202204221004', 1004, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(72, '202204221005', 1005, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(73, '202204221006', 1006, 'P202210002', 'B&B NECKLACE', '2', '1300', '2600', '2022-04-22'),
(74, '202204221007', 1007, 'P202210002', 'B&B NECKLACE', '2', '1300', '2600', '2022-04-22'),
(75, '202204221008', 1008, 'P202210001', 'CINDERELLA NECKLACE', '1', '1500', '1500', '2022-04-22'),
(77, '202204221009', 1009, 'P202210002', 'B&B NECKLACE', '2', '1300', '2600', '2022-04-22'),
(78, '202204221009', 1009, 'P202210001', 'CINDERELLA NECKLACE', '2', '1500', '3000', '2022-04-22'),
(79, '202204221010', 1010, 'P202210001', 'CINDERELLA NECKLACE', '2', '1500', '3000', '2022-04-22');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_useraccounts`
--

CREATE TABLE `tbl_useraccounts` (
  `ID` bigint(255) NOT NULL,
  `AccountCreated` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `UserID` varchar(50) NOT NULL,
  `Uname` varchar(255) NOT NULL,
  `Passwd` varchar(255) NOT NULL,
  `UserType` varchar(50) NOT NULL,
  `Fname` varchar(100) NOT NULL,
  `Lname` varchar(100) NOT NULL,
  `Mname` varchar(100) NOT NULL,
  `Birthdate` varchar(20) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `ContactNumber` varchar(20) NOT NULL,
  `Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_useraccounts`
--

INSERT INTO `tbl_useraccounts` (`ID`, `AccountCreated`, `UserID`, `Uname`, `Passwd`, `UserType`, `Fname`, `Lname`, `Mname`, `Birthdate`, `Gender`, `ContactNumber`, `Address`) VALUES
(1, '2022-04-21 00:34:12', 'AE202210001', 'ADMIN', 'PASS', 'ADMIN', 'JUAN', 'DELA CRUZ', 'ISIDRO', '06/10/2000', 'MALE', '09159443864', 'BAGONG SILANG CALOOCAN CITY'),
(3, '2022-04-22 07:58:49', 'CE202210003', 'CASHIER0003', 'PASSWORD.1', 'CASHIER', 'PEDRO', 'VERSOSA', 'UY', '08/15/1996', 'MALE', '09482671255', 'CAMARIN CALOOCAN CITY'),
(4, '2022-04-22 08:30:16', 'AE202210004', 'ADMIN0004', 'ADMINPASS_01', 'ADMIN', 'BENJIE', 'HERMOSA', 'SY', '06/16/1999', 'MALE', '09458192314', 'TALA CALOOCAN CITY'),
(5, '2022-04-22 08:37:27', 'CE202210005', 'CASHIER0005', 'CASHIER_05', 'CASHIER', 'PRINCESS', 'LOVEIN', 'UY', '06/10/1999', 'FEMALE', '09159443864', 'PH8 BAGONG SILANG CALOOCAN CITY'),
(6, '2022-04-22 08:38:42', 'CE202210006', 'CASHIER0006', 'CASHIER_06', 'CASHIER', 'JOHN', 'DOE', 'MAC', '06/10/1990', 'MALE', '09485154621', 'QUEZON CITY');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_transactions`
--
ALTER TABLE `tbl_transactions`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `ID` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_transactions`
--
ALTER TABLE `tbl_transactions`
  MODIFY `ID` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=80;

--
-- AUTO_INCREMENT for table `tbl_useraccounts`
--
ALTER TABLE `tbl_useraccounts`
  MODIFY `ID` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
