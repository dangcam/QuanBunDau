USE [master]
GO
/****** Object:  Database [QuanBunDau]    Script Date: 05/04/2016 10:11:10 ******/
CREATE DATABASE [QuanBunDau] ON  PRIMARY 
( NAME = N'QuanBunDau', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.DC\MSSQL\DATA\QuanBunDau.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanBunDau_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.DC\MSSQL\DATA\QuanBunDau_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanBunDau] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanBunDau].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanBunDau] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanBunDau] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanBunDau] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanBunDau] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanBunDau] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanBunDau] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanBunDau] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanBunDau] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanBunDau] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanBunDau] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanBunDau] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanBunDau] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanBunDau] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanBunDau] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanBunDau] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanBunDau] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanBunDau] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanBunDau] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanBunDau] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanBunDau] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanBunDau] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanBunDau] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanBunDau] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanBunDau] SET  READ_WRITE
GO
ALTER DATABASE [QuanBunDau] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanBunDau] SET  MULTI_USER
GO
ALTER DATABASE [QuanBunDau] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanBunDau] SET DB_CHAINING OFF
GO
USE [QuanBunDau]
GO
/****** Object:  Table [dbo].[LoaiMatHang]    Script Date: 05/04/2016 10:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMatHang](
	[LoaiMatHang] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_LoaiDoAn] PRIMARY KEY CLUSTERED 
(
	[LoaiMatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/04/2016 10:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[TenDN] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 05/04/2016 10:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[BanAn] [nvarchar](20) NOT NULL,
	[Tang] [int] NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_BanAn] PRIMARY KEY CLUSTERED 
(
	[BanAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SpXoaLoaiMatHang]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpXoaLoaiMatHang]
@LoaiMatHang AS NVARCHAR(20)
AS
BEGIN
	DELETE FROM LoaiMatHang WHERE LoaiMatHang=@LoaiMatHang
END
GO
/****** Object:  StoredProcedure [dbo].[SpXoaBanAn]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpXoaBanAn]
@BanAn AS NVARCHAR(20)
AS
BEGIN
	DELETE FROM BanAn WHERE BanAn=@BanAn
END
GO
/****** Object:  StoredProcedure [dbo].[SpThemNhanVien]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpThemNhanVien]
@TenDN AS NVARCHAR(10),
@MatKhau AS NVARCHAR(MAX),
@TenNV AS NVARCHAR(50),
@SDT AS VARCHAR(20)
AS
BEGIN
	INSERT INTO NhanVien VALUES(@TenDN,@MatKhau,@TenNV,@SDT)
END
GO
/****** Object:  StoredProcedure [dbo].[SpThemLoaiMatHang]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpThemLoaiMatHang]
@LoaiMatHang AS NVARCHAR(20)
AS
BEGIN
	INSERT INTO LoaiMatHang VALUES(@LoaiMatHang)
END
GO
/****** Object:  StoredProcedure [dbo].[SpThemBanAn]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpThemBanAn]
@BanAn AS NVARCHAR(20),
@Tang AS INT
AS
BEGIN
	INSERT INTO BanAn VALUES(@BanAn,@Tang,0)
END
GO
/****** Object:  StoredProcedure [dbo].[SpSuaBanAn]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaBanAn]
@BanAn AS NVARCHAR(20),
@Tang AS INT,
@TrangThai AS BIT,
@Gio AS TIME(6)
AS
BEGIN
	UPDATE BanAn SET Tang=@Tang,TrangThai=@TrangThai WHERE BanAn=@BanAn
END
GO
/****** Object:  StoredProcedure [dbo].[SpSuaNhanVien]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaNhanVien]
@TenDN AS NVARCHAR(10),
@MatKhau AS NVARCHAR(MAX),
@TenNV AS NVARCHAR(50),
@SDT AS VARCHAR(20)
AS
BEGIN
	UPDATE  NhanVien SET 
	MatKhau=@MatKhau,TenNV=TenNV,SDT=@SDT
	WHERE TenDN=@TenDN
END
GO
/****** Object:  StoredProcedure [dbo].[SpSuaMatKhau]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaMatKhau]
@TenDN AS NVARCHAR(10),
@MatKhau AS NVARCHAR(MAX)
AS
BEGIN
	UPDATE  NhanVien SET 
	MatKhau=@MatKhau
	WHERE TenDN=@TenDN
END
GO
/****** Object:  StoredProcedure [dbo].[SpXoaNhanVien]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpXoaNhanVien]
@TenDN AS NVARCHAR(10)
AS
BEGIN
	DELETE FROM NhanVien
	WHERE TenDN=@TenDN
END
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[BanAn] [nvarchar](20) NOT NULL,
	[Ngay] [date] NOT NULL,
	[GioDat] [time](6) NULL,
	[GioThanhToan] [time](6) NULL,
	[TongTien] [decimal](15, 0) NULL,
	[TinhTrang] [int] NULL,
	[LyDoHuy] [nvarchar](100) NULL,
	[NguoiLap] [nvarchar](10) NOT NULL,
	[NguoiTT] [nvarchar](10) NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_HoaDon] ON [dbo].[HoaDon] 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[TenMatHang] [nvarchar](30) NOT NULL,
	[LoaiMatHang] [nvarchar](20) NOT NULL,
	[DonVi] [nvarchar](20) NULL,
	[Gia] [decimal](10, 0) NOT NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[TenMatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonChiTiet]    Script Date: 05/04/2016 10:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonChiTiet](
	[MaHoaDon] [int] NOT NULL,
	[TenMatHang] [nvarchar](30) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [decimal](10, 0) NOT NULL,
 CONSTRAINT [PK_HoaDonChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[TenMatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[getHoaDonNgay]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <28/01/2016>
-- Description:	<getNhapKho>
-- =============================================
CREATE FUNCTION [dbo].[getHoaDonNgay]
(
@Ngay AS DATE
)
RETURNS TABLE 
AS
RETURN
(
	SELECT MaHoaDon,BanAn,GioThanhToan,TongTien,TinhTrang 
	FROM HoaDon 
	WHERE Ngay=@Ngay AND (TinhTrang=1 OR TinhTrang=2)
)
GO
/****** Object:  StoredProcedure [dbo].[SpXoaMatHang]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpXoaMatHang]
@TenMatHang AS NVARCHAR(30)
AS
BEGIN
	DELETE FROM MatHang
	WHERE TenMatHang=@TenMatHang
END
GO
/****** Object:  StoredProcedure [dbo].[SpSuaMatHang]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaMatHang]
@TenMatHang AS NVARCHAR(30),
@LoaiMatHang AS NVARCHAR(20),
@DonVi AS NVARCHAR(20),
@Gia AS DECIMAL(10,0)
AS
BEGIN
	UPDATE MatHang SET LoaiMatHang=@LoaiMatHang,DonVi=@DonVi,Gia=@Gia
	WHERE TenMatHang=@TenMatHang
END
GO
/****** Object:  UserDefinedFunction [dbo].[getHoaDon]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <28/01/2016>
-- Description:	<getNhapKho>
-- =============================================
CREATE FUNCTION [dbo].[getHoaDon]
(
@BanAn AS NVARCHAR(20)
)
RETURNS TABLE 
AS
RETURN
(
	SELECT MaHoaDon,BanAn,Ngay,GioDat FROM HoaDon WHERE TinhTrang = 0 AND BanAn=@BanAn
)
GO
/****** Object:  UserDefinedFunction [dbo].[getBanAn]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <28/01/2016>
-- Description:	<getNhapKho>
-- =============================================
CREATE FUNCTION [dbo].[getBanAn]()
RETURNS TABLE 
AS
RETURN
(
	SELECT BanAn.BanAn AS BanAn, TrangThai,Tang,GioDat AS GioVao
	FROM BanAn LEFT JOIN(SELECT GioDat,BanAn FROM HoaDon WHERE TinhTrang = 0) AS HD
	ON BanAn.BanAn = HD.BanAn
)
GO
/****** Object:  StoredProcedure [dbo].[SpHuyHoaDon]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpHuyHoaDon]
@MaHoaDon AS INT,
@BanAn AS NVARCHAR(20),
@GioThanhToan AS TIME(6),
@TongTien AS DECIMAL(10,0),
@LyDoHuy AS NVARCHAR(100),
@NguoiTT AS NVARCHAR(10)
AS
BEGIN
	
	UPDATE BanAn SET TrangThai=0 WHERE BanAn=@BanAn
	UPDATE HoaDon SET
	GioThanhToan = @GioThanhToan,
	TongTien = @TongTien,
	TinhTrang = 2,
	LyDoHuy=@LyDoHuy,
	NguoiTT = @NguoiTT
	WHERE MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SpDatBanAn]    Script Date: 05/04/2016 10:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpDatBanAn]
@BanAn AS NVARCHAR(20),
@Gio AS TIME(6),
@Ngay AS DATE,
@TenDN AS NVARCHAR(10)
AS
BEGIN
	
	UPDATE BanAn SET TrangThai=1 WHERE BanAn=@BanAn
	INSERT INTO HoaDon
	VALUES (@BanAn,@Ngay,@Gio,NULL,NULL,0,NULL,@TenDN,NULL)
END
GO
/****** Object:  StoredProcedure [dbo].[SpChuyenBanAn]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpChuyenBanAn]
@BanAnTrong AS NVARCHAR(20),
@BanAnCoKhach AS NVARCHAR(20)
AS
BEGIN
	UPDATE BanAn SET TrangThai=1 WHERE BanAn=@BanAnTrong
	UPDATE BanAn SET TrangThai=0 WHERE BanAn=@BanAnCoKhach
	UPDATE HoaDon SET BanAn=@BanAnTrong 
	WHERE BanAn=@BanAnCoKhach AND TinhTrang = 0
END
GO
/****** Object:  StoredProcedure [dbo].[SpTinhTienHoaDon]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpTinhTienHoaDon]
@MaHoaDon AS INT,
@BanAn AS NVARCHAR(20),
@GioThanhToan AS TIME(6),
@TongTien AS DECIMAL(10,0),
@NguoiTT AS NVARCHAR(10)
AS
BEGIN
	
	UPDATE BanAn SET TrangThai=0 WHERE BanAn=@BanAn
	UPDATE HoaDon SET
	GioThanhToan = @GioThanhToan,
	TongTien = @TongTien,
	TinhTrang = 1,
	NguoiTT = @NguoiTT
	WHERE MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SpThemMatHang]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpThemMatHang]
@TenMatHang AS NVARCHAR(30),
@LoaiMatHang AS NVARCHAR(20),
@DonVi AS NVARCHAR(20),
@Gia AS DECIMAL(10,0)
AS
BEGIN
	INSERT INTO MatHang VALUES(@TenMatHang,@LoaiMatHang,@DonVi,@Gia)
END
GO
/****** Object:  StoredProcedure [dbo].[SpXoaChiTietHoaDon]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpXoaChiTietHoaDon]
@MaHoaDon AS INT,
@TenMatHang AS NVARCHAR(30)
AS
BEGIN
	DELETE FROM HoaDonChiTiet
	WHERE TenMatHang=@TenMatHang AND MaHoaDon=@MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SpThemChiTietHoaDon]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpThemChiTietHoaDon]
@MaHoaDon AS INT,
@TenMatHang AS NVARCHAR(30),
@SoLuong AS INT,
@Gia AS DECIMAL(10,0)
AS
BEGIN
	INSERT INTO HoaDonChiTiet
	VALUES (@MaHoaDon,@TenMatHang,@SoLuong,@Gia)
END
GO
/****** Object:  StoredProcedure [dbo].[SpSuaSoLuongHoaDon]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaSoLuongHoaDon]
@MaHoaDon AS INT,
@TenMatHang AS NVARCHAR(30),
@SoLuong AS INT
AS
BEGIN
	UPDATE HoaDonChiTiet
	SET SoLuong=@SoLuong
	WHERE TenMatHang=@TenMatHang AND MaHoaDon=@MaHoaDon
END
GO
/****** Object:  UserDefinedFunction [dbo].[getHoaDonChiTiet]    Script Date: 05/04/2016 10:11:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <28/01/2016>
-- Description:	<getNhapKho>
-- =============================================
CREATE FUNCTION [dbo].[getHoaDonChiTiet]
(
@MaHoaDon AS INT
)
RETURNS TABLE 
AS
RETURN
(
	SELECT HoaDonChiTiet.TenMatHang,DonVi,SoLuong,HoaDonChiTiet.Gia,(SoLuong*HoaDonChiTiet.Gia) AS ThanhTien
	FROM HoaDonChiTiet,MatHang
	WHERE HoaDonChiTiet.MaHoaDon=@MaHoaDon AND HoaDonChiTiet.TenMatHang = MatHang.TenMatHang
)
GO
/****** Object:  ForeignKey [FK_HoaDon_BanAn]    Script Date: 05/04/2016 10:11:22 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BanAn] FOREIGN KEY([BanAn])
REFERENCES [dbo].[BanAn] ([BanAn])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BanAn]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien]    Script Date: 05/04/2016 10:11:22 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[NhanVien] ([TenDN])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  ForeignKey [FK_MatHang_LoaiMatHang]    Script Date: 05/04/2016 10:11:22 ******/
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiMatHang] FOREIGN KEY([LoaiMatHang])
REFERENCES [dbo].[LoaiMatHang] ([LoaiMatHang])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_LoaiMatHang]
GO
/****** Object:  ForeignKey [FK_HoaDonChiTiet_HoaDon]    Script Date: 05/04/2016 10:11:22 ******/
ALTER TABLE [dbo].[HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonChiTiet_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDonChiTiet] CHECK CONSTRAINT [FK_HoaDonChiTiet_HoaDon]
GO
/****** Object:  ForeignKey [FK_HoaDonChiTiet_MatHang]    Script Date: 05/04/2016 10:11:22 ******/
ALTER TABLE [dbo].[HoaDonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonChiTiet_MatHang] FOREIGN KEY([TenMatHang])
REFERENCES [dbo].[MatHang] ([TenMatHang])
GO
ALTER TABLE [dbo].[HoaDonChiTiet] CHECK CONSTRAINT [FK_HoaDonChiTiet_MatHang]
GO
