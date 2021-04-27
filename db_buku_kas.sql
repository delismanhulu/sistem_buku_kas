-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Apr 2021 pada 17.30
-- Versi server: 10.4.6-MariaDB
-- Versi PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_buku_kas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_buku_kas`
--

CREATE TABLE `tbl_buku_kas` (
  `KODE` varchar(15) NOT NULL,
  `KODE_USER` varchar(15) DEFAULT NULL,
  `NO_BUKTI` varchar(20) DEFAULT NULL,
  `TANGGAL` date DEFAULT NULL,
  `URAIAN` text DEFAULT NULL,
  `PENERIMAAN` int(11) DEFAULT 0,
  `PENGELUARAN` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_buku_kas`
--

INSERT INTO `tbl_buku_kas` (`KODE`, `KODE_USER`, `NO_BUKTI`, `TANGGAL`, `URAIAN`, `PENERIMAAN`, `PENGELUARAN`) VALUES
('KM21011501', 'delisman', 'KAS01', '2021-01-15', 'TEST KAS MASUK', 2000000, 0),
('KM21011502', 'delisman', 'KAS-003', '2021-01-15', 'TEST - KAS KELUAR', 0, 2000000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_profil`
--

CREATE TABLE `tbl_profil` (
  `KODE` char(1) NOT NULL DEFAULT '',
  `NAMA` varchar(100) DEFAULT NULL,
  `ALAMAT` varchar(255) DEFAULT NULL,
  `TELEPON` varchar(16) DEFAULT NULL,
  `WEB_SITE` varchar(100) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `LOGO` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_profil`
--

INSERT INTO `tbl_profil` (`KODE`, `NAMA`, `ALAMAT`, `TELEPON`, `WEB_SITE`, `EMAIL`, `LOGO`) VALUES
('1', 'PT. DELISMAN HULU', 'Jl. Test Buku Kas', '081375653271', 'layanancoding.com', 'delishulu@gmail.com', NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `KODE_USER` varchar(15) NOT NULL,
  `USER_NAME` varchar(30) DEFAULT NULL,
  `PASSWORD` varchar(200) DEFAULT '',
  `STATUS` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`KODE_USER`, `USER_NAME`, `PASSWORD`, `STATUS`) VALUES
('admin', 'DELISMAN - TEST', '21232f297a57a5a743894a0e4a801fc3', 'Admin'),
('afrini', 'AFRINI GEA', 'c4ca4238a0b923820dcc509a6f75849b', 'User'),
('delisman', 'DELL', '098f6bcd4621d373cade4e832627b4f6', 'Admin'),
('open', 'Open Riusman Hulu', '7cef8a734855777c2a9d0caf42666e69', 'User');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_buku_kas`
--
ALTER TABLE `tbl_buku_kas`
  ADD PRIMARY KEY (`KODE`),
  ADD KEY `kode_kas` (`KODE_USER`);

--
-- Indeks untuk tabel `tbl_profil`
--
ALTER TABLE `tbl_profil`
  ADD PRIMARY KEY (`KODE`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`KODE_USER`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_buku_kas`
--
ALTER TABLE `tbl_buku_kas`
  ADD CONSTRAINT `kode_kas` FOREIGN KEY (`KODE_USER`) REFERENCES `tbl_user` (`KODE_USER`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
