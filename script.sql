USE [master]
GO
/****** Object:  Database [dbPengungsi]    Script Date: 01/02/2018 13:27:16 ******/
CREATE DATABASE [dbPengungsi] ON  PRIMARY 
( NAME = N'dbPengungsi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbPengungsi.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbPengungsi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbPengungsi_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbPengungsi] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPengungsi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbPengungsi] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbPengungsi] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbPengungsi] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbPengungsi] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbPengungsi] SET ARITHABORT OFF
GO
ALTER DATABASE [dbPengungsi] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbPengungsi] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbPengungsi] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbPengungsi] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbPengungsi] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbPengungsi] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbPengungsi] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbPengungsi] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbPengungsi] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbPengungsi] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbPengungsi] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbPengungsi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbPengungsi] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbPengungsi] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbPengungsi] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbPengungsi] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbPengungsi] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbPengungsi] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbPengungsi] SET  READ_WRITE
GO
ALTER DATABASE [dbPengungsi] SET RECOVERY FULL
GO
ALTER DATABASE [dbPengungsi] SET  MULTI_USER
GO
ALTER DATABASE [dbPengungsi] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbPengungsi] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbPengungsi', N'ON'
GO
USE [dbPengungsi]
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](10) NULL,
 CONSTRAINT [PK_tb_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT INTO tb_user values ('admin','admin');
/****** Object:  Table [dbo].[tb_tunai]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tunai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NULL,
	[nama] [varchar](50) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](12) NULL,
	[jumlah] [int] NULL,
 CONSTRAINT [PK_tb_tunai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
insert into tb_tunai values ('1/1/2018', 'Asri', 'manggis', '', 5000000);
insert into tb_tunai values ('2/1/2018', 'Gandayasa', 'manggis', '', 1000000);
/****** Object:  Table [dbo].[tb_tempat]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tempat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](12) NULL,
 CONSTRAINT [PK_tb_tempat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_relawan]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_relawan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[jenis_kelamin] [varchar](10) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](12) NULL,
	[tempat] [varchar](50) NULL,
 CONSTRAINT [PK_tb_relawan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_penitipan]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_penitipan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NULL,
	[nama] [varchar](50) NULL,
	[jenis_kelamin] [varchar](10) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](12) NULL,
	[peliharaan] [varchar](20) NULL,
	[banyak] [int] NULL,
 CONSTRAINT [PK_tb_penitipan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_pengungsi]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_pengungsi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[jenis_kelamin] [varchar](10) NULL,
	[alamat] [text] NULL,
	[pekerjaan] [varchar](20) NULL,
	[tgl_lahir] [date] NULL,
	[umur] [int] NULL,
	[telp] [varchar](12) NULL,
	[tempat] [varchar](50) NULL,
	[tgl_masuk] [date] NULL,
 CONSTRAINT [PK_tb_pengungsi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_penggunaan_tunai]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_penggunaan_tunai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NULL,
	[pembelian] [varchar](50) NULL,
	[harga] [int] NULL,
	[banyak] [int] NULL,
 CONSTRAINT [PK_tb_penggunaan_tunai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
insert into tb_penggunaan_tunai values ('1/1/2018', 'kipas', 50000, 3);
insert into tb_penggunaan_tunai values ('2/1/2018', 'sandal', 10000, 3);
/****** Object:  Table [dbo].[tb_penggunaan_logistik]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_penggunaan_logistik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NULL,
	[beras] [int] NULL,
	[mie] [int] NULL,
	[masker] [int] NULL,
	[aqua] [int] NULL,
	[nasi] [int] NULL,
	[susu] [int] NULL,
	[selimut] [int] NULL,
	[roti] [int] NULL,
	[lain] [text] NULL,
 CONSTRAINT [PK_tb_penggunaan_logistik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_logistik]    Script Date: 01/02/2018 13:27:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
insert into tb_penggunaan_logistik values('1/01/2018', 10, 1, 1, 1, 1, 1, 1, 1, '');
insert into tb_penggunaan_logistik values('2/01/2018', 10, 10, 1, 1, 1, 1, 1, 1, '');
CREATE TABLE [dbo].[tb_logistik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NULL,
	[nama] [varchar](50) NULL,
	[alamat] [text] NULL,
	[telp] [varchar](12) NULL,
	[beras] [int] NULL,
	[mie] [int] NULL,
	[masker] [int] NULL,
	[aqua] [int] NULL,
	[nasi] [int] NULL,
	[susu] [int] NULL,
	[selimut] [int] NULL,
	[roti] [int] NULL,
	[lain] [text] NULL,
 CONSTRAINT [PK_tb_logistik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
insert into tb_logistik values('1/01/2018', 'Asri', 'manggis', '', 100, 100, 100, 100, 100, 100, 100, 100, '');
insert into tb_logistik values('1/01/2018', 'Gandayasa', 'manggis', '', 200, 100, 100, 100, 100, 100, 100, 100, '');



