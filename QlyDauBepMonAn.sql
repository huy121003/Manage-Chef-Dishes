
USE [master]
GO
/****** Object:  Database [QLDauBep_MonAn]    Script Date: 10/20/2023 6:18:58 PM ******/
CREATE DATABASE [QLDauBep_MonAn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDauBep_MonAn', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLDauBep_MonAn.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDauBep_MonAn_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLDauBep_MonAn_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLDauBep_MonAn] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDauBep_MonAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDauBep_MonAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLDauBep_MonAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDauBep_MonAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDauBep_MonAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLDauBep_MonAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDauBep_MonAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDauBep_MonAn] SET  MULTI_USER 
GO
ALTER DATABASE [QLDauBep_MonAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDauBep_MonAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDauBep_MonAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDauBep_MonAn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDauBep_MonAn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDauBep_MonAn] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDauBep_MonAn] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLDauBep_MonAn] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLDauBep_MonAn]
GO
/****** Object:  Table [dbo].[LoginAdmin]    Script Date: 10/20/2023 6:18:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginAdmin](
	[UserName] [varchar](10) NOT NULL,
	[PassWord] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_LoginAdmin] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChiTietThucDon]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietThucDon](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaDauBep] [nvarchar](10) NOT NULL,
	[MaThucDon] [nvarchar](10) NOT NULL,
	[MaLoai] [nvarchar](10) NOT NULL,
	[SoLuong] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [pk_tChiTietThucDon_MaMonAn_MaThucDon] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaLoai] ASC,
	[MaDauBep] ASC,
	[MaThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCongDung]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCongDung](
	[MaCongDung] [nvarchar](10) NOT NULL,
	[TenCongDung] [nvarchar](100) NULL,
 CONSTRAINT [pk_tCongDung_MaCongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDauBep]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDauBep](
	[MaDauBep] [nvarchar](10) NOT NULL,
	[TenDauBep] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [bit] NULL,
	[SoDienThoai] [varchar](12) NULL,
	[NoiHoc] [nvarchar](100) NULL,
	[TrinhDo] [nvarchar](100) NULL,
 CONSTRAINT [pk_tDauBep_MaDauBep] PRIMARY KEY CLUSTERED 
(
	[MaDauBep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDauBepMonAn]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDauBepMonAn](
	[MaDauBep] [nvarchar](10) NOT NULL,
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaXepLoai] [nvarchar](10) NOT NULL,
 CONSTRAINT [pk_tDauBepMonAn_MaDauBep_MaMonAn_MaXepLoai] PRIMARY KEY CLUSTERED 
(
	[MaDauBep] ASC,
	[MaMonAn] ASC,
	[MaXepLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tDonViTinh]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDonViTinh](
	[MaDonViTinh] [nvarchar](10) NOT NULL,
	[TenDonViTinh] [nvarchar](100) NULL,
 CONSTRAINT [pk_tDonViTinh_MaDonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKhachHang]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhachHang](
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [nvarchar](12) NULL,
 CONSTRAINT [pk_tKhachHang_MaKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tLoai]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tLoai](
	[MaLoai] [nvarchar](10) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
 CONSTRAINT [pk_tLoai_MaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tMonAn]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tMonAn](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaLoai] [nvarchar](10) NOT NULL,
	[MaCongDung] [nvarchar](10) NULL,
	[TenMonAn] [nvarchar](100) NULL,
	[DonGia] [float] NULL,
	[CachLam] [nvarchar](1000) NULL,
	[YeuCau] [nvarchar](1000) NULL,
 CONSTRAINT [pk_tMonAn_MaMonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNguyenLieu]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNguyenLieu](
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[MaDonViTinh] [nvarchar](10) NULL,
	[MaCongDung] [nvarchar](10) NULL,
	[TenNguyenLieu] [nvarchar](100) NULL,
	[YeuCau] [nvarchar](100) NULL,
	[DonGia] [float] NULL,
	[DinhDuong] [nvarchar](100) NULL,
 CONSTRAINT [pk_tNguyenLieu_MaNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNguyenLieuMonAn]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNguyenLieuMonAn](
	[MaMonAn] [nvarchar](10) NOT NULL,
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [pk_tNguyenLieuMonAn_MaMonAn_MaNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThucDon]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tThucDon](
	[MaThucDon] [nvarchar](10) NOT NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[NgayDatBan] [datetime] NULL,
	[ThueVAT] [float] NULL,
	[GiamGia] [float] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [pk_tThucDon_MaThucDon] PRIMARY KEY CLUSTERED 
(
	[MaThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tXepLoai]    Script Date: 10/20/2023 6:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tXepLoai](
	[MaXepLoai] [nvarchar](10) NOT NULL,
	[TenXepLoai] [nvarchar](100) NULL,
 CONSTRAINT [pk_tXepLoai_MaXepLoai] PRIMARY KEY CLUSTERED 
(
	[MaXepLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'aaaaaa', N'aaaaaa', N'aaaaa@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'giangho', N'123456', N'minhgiang@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'hieungu', N'123456', N'hieungu@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'huyhihi', N'123456', N'huyhihi@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'juliet', N'123456', N'juliet@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'quanghuy', N'123456', N'quanghuy2003.hh@gmail.com')
INSERT [dbo].[LoginAdmin] ([UserName], [PassWord], [Email]) VALUES (N'quanghuyy', N'123456', N'huy@gmail.com')
GO
INSERT [dbo].[tChiTietThucDon] ([MaMonAn], [MaDauBep], [MaThucDon], [MaLoai], [SoLuong], [ThanhTien]) VALUES (N'MA01', N'DB04', N'TD01', N'L01', 1, 177000)
INSERT [dbo].[tChiTietThucDon] ([MaMonAn], [MaDauBep], [MaThucDon], [MaLoai], [SoLuong], [ThanhTien]) VALUES (N'MA06', N'DB02', N'TD01', N'L02', 1, 400000)
GO
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD01', N'Khoáng chất, chất xơ')
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD02', N'Protein')
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD03', N'Dinh dưỡng')
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD04', N'Vitamin')
GO
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB01', N'Nguyễn Văn Dương', NULL, 0, N'0348291824', N'Trường Cao đẳng Nghệ thuật ẩm thực Sài Gòn ', N'A')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB02', N'Dương Đình Vũ', NULL, 0, N'0932931922', N'Học viện Nấu ăn Quốc tế Le Monde', N'A')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB03', N'Phan Thị Thưởng', NULL, 1, N'0932849121', N'Trường Đào tạo Nghề Khách sạn và Du lịch', N'B')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB04', N'Nguyễn Thị Hồng', NULL, 1, N'0342949103', N'Trường Cao đẳng Kinh tế - Công nghệ Hải Dương', N'A')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB05', N'Lê Văn Hải', NULL, 0, N'0348294193', N'Trường Cao đẳng Nghề Việt Giao ', N'C')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB06', N'Hoàng Văn Thông', NULL, 0, N'0428319423', N'Học viện Nghệ thuật ẩm thực Việt Giao', N'B')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB07', N'Phan Thị Mai', NULL, 1, N'0193492423', N'Trường Trung cấp Du lịch và Nghệ thuật ẩm thực Đà Nẵng', N'B')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB08', N'Đinh Minh Cương', NULL, 0, N'0382492313', N'Học viện Nấu ăn Quốc tế Le Monde', N'C')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB09', N'Nguyễn Văn Nam', NULL, 0, N'0924291392', N'Trường Đào tạo Nghề Khách sạn và Du lịch', N'A')
INSERT [dbo].[tDauBep] ([MaDauBep], [TenDauBep], [DiaChi], [GioiTinh], [SoDienThoai], [NoiHoc], [TrinhDo]) VALUES (N'DB10', N'Hoàng Thị Chúc', NULL, 1, N'0932482923', N'Trường Cao đẳng Nghệ thuật ẩm thực Sài Gòn', N'B')
GO
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB01', N'MA05', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB02', N'MA06', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB02', N'MA08', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB03', N'MA03', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB03', N'MA04', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB04', N'MA01', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB04', N'MA02', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB05', N'MA12', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB05', N'MA13', N'XL03')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB06', N'MA10', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB06', N'MA11', N'XL03')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB07', N'MA14', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB07', N'MA15', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB07', N'MA16', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB08', N'MA17', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB08', N'MA18', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB09', N'MA07', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB09', N'MA09', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB10', N'MA19', N'XL02')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB10', N'MA20', N'XL01')
INSERT [dbo].[tDauBepMonAn] ([MaDauBep], [MaMonAn], [MaXepLoai]) VALUES (N'DB10', N'MA21', N'XL01')
GO
INSERT [dbo].[tDonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'', N'')
INSERT [dbo].[tDonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DV01', N'Gram')
INSERT [dbo].[tDonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DV02', N'Kilogram')
INSERT [dbo].[tDonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DV03', N'Mớ')
INSERT [dbo].[tDonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DV04', N'Qủa')
GO
INSERT [dbo].[tKhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH01', N'Đinh Văn Nông', NULL, N'0321391291')
INSERT [dbo].[tKhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH02', N'Nông Văn Dương', NULL, N'0491283291')
INSERT [dbo].[tKhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH03', N'Nguyễn Thị Thương', NULL, N'0342819244')
INSERT [dbo].[tKhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH04', N'Nguyễn Ngọc Thương', NULL, N'0528293013')
INSERT [dbo].[tKhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai]) VALUES (N'KH05', N'Lê Thị Hoài', NULL, N'0942739123')
GO
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L01', N'Món canh')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L02', N'Món chính')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L03', N'Món xào')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L04', N'Món luộc')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L05', N'Thức uống')
GO
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA01', N'L01', N'CD03', N'Cá bớp nấu canh chua', 177000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA02', N'L01', N'CD03', N'Canh bầu nấu thịt bằm', 103000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA03', N'L01', N'CD03', N'Canh bầu nấu tôm', 103000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA04', N'L01', N'CD03', N'Canh bí nấu thịt bằm', 103000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA05', N'L02', N'CD03', N'Cá bớp kho ớt xanh', 242000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA06', N'L02', N'CD02', N'Gà luộc', 400000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA07', N'L02', N'CD03', N'Cá bớp kho dưa', 242000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA08', N'L02', N'CD03', N'Mực hấp', 203000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA09', N'L02', N'CD02', N'Thịt xíu', 151000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA10', N'L03', N'CD01', N'Bò xào cần tây', 150000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA11', N'L03', N'CD01', N'Cải bẹ xanh xào tỏi', 60000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA12', N'L03', N'CD01', N'Cải ngọt xào tỏi', 60000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA13', N'L03', N'CD01', N'Rau muống xào tỏi', 60000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA14', N'L04', N'CD01', N'Rau muống luộc ', 50000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA15', N'L04', N'CD01', N'Rau lang luộc', 50000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA16', N'L04', N'CD01', N'Mướp luộc', 50000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA17', N'L05', N'CD04', N'Cam vắt', 40000, N'', NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA18', N'L05', N'CD04', N'Đá chanh', 60000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA19', N'L05', N'CD04', N'Nước ép thơm', 50000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA20', N'L05', N'CD04', N'Nước ép dưa hấu', 50000, NULL, NULL)
INSERT [dbo].[tMonAn] ([MaMonAn], [MaLoai], [MaCongDung], [TenMonAn], [DonGia], [CachLam], [YeuCau]) VALUES (N'MA21', N'L05', N'CD04', N'Nước ép táo', 50000, NULL, NULL)
GO
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL01', N'DV02', N'CD01', N'Cà rốt', N'', 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL02', N'DV02', N'CD02', N'Cá bớp', N'', 300000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL03', N'DV02', N'CD01', N'Ớt', N'', 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL04', N'DV02', N'CD01', N'Bầu', N'', 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL05', N'DV02', N'CD02', N'Thịt heo', N'', 180000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL06', N'DV02', N'CD01', N'Hành tây', N'', 15000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL07', N'DV02', N'CD02', N'Tôm sú', N'', 250000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL08', N'DV02', N'CD01', N'Bí', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL09', N'DV02', N'CD01', N'Hành tím', NULL, 100000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL10', N'DV02', N'CD02', N'Gà', NULL, 230000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL11', N'DV02', N'CD01', N'Dưa chua', NULL, 50000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL12', N'DV02', N'CD02', N'Mực ống', NULL, 280000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL13', N'DV02', N'CD01', N'Gừng', NULL, 40000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL14', N'DV04', N'CD03', N'Trứng gà', NULL, 3000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL15', N'DV02', N'CD03', N'Thịt bò', NULL, 200000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL16', N'DV02', N'CD01', N'Cần tây', NULL, 60000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL17', N'DV02', N'CD01', N'Tỏi', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL18', N'DV02', N'CD01', N'Cải bẹ xanh', NULL, 15000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL19', N'DV02', N'CD01', N'Cải ngọt', NULL, 10000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL20', N'DV02', N'CD01', N'Rau muống', NULL, 15000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL21', N'DV02', N'CD01', N'Qủa mướp', NULL, 20000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL22', N'DV02', N'CD01', N'Rau lang', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL23', N'DV02', N'CD01', N'Cam sành', NULL, 50000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL24', N'DV02', N'CD01', N'Chanh', NULL, 20000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL25', N'DV02', N'CD01', N'Thơm', NULL, 5000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL26', N'DV02', N'CD01', N'Dưa hấu', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL27', N'DV02', N'CD01', N'Táo', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL28', N'DV02', N'CD01', N'Cà chua', NULL, 30000, NULL)
INSERT [dbo].[tNguyenLieu] ([MaNguyenLieu], [MaDonViTinh], [MaCongDung], [TenNguyenLieu], [YeuCau], [DonGia], [DinhDuong]) VALUES (N'NL29', N'DV02', N'CD01', N'Me', NULL, 30000, NULL)
GO
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA01', N'NL01', 2)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA01', N'NL02', 1)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA01', N'NL03', 1)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA01', N'NL28', 1)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA01', N'NL29', 1)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA02', N'NL01', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA02', N'NL04', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA02', N'NL05', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA02', N'NL06', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA03', N'NL04', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA03', N'NL07', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA04', N'NL03', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA04', N'NL05', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA04', N'NL08', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA05', N'NL01', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA05', N'NL02', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA05', N'NL03', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA05', N'NL09', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA06', N'NL06', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA06', N'NL10', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA06', N'NL13', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA07', N'NL02', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA07', N'NL11', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA07', N'NL17', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA08', N'NL12', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA09', N'NL05', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA09', N'NL14', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA10', N'NL15', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA10', N'NL16', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA10', N'NL17', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA11', N'NL17', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA11', N'NL18', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA12', N'NL17', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA12', N'NL19', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA13', N'NL17', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA13', N'NL20', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA14', N'NL20', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA15', N'NL22', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA16', N'NL21', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA17', N'NL23', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA18', N'NL24', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA19', N'NL25', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA20', N'NL26', NULL)
INSERT [dbo].[tNguyenLieuMonAn] ([MaMonAn], [MaNguyenLieu], [SoLuong]) VALUES (N'MA21', N'NL27', NULL)
GO
INSERT [dbo].[tThucDon] ([MaThucDon], [MaKhachHang], [NgayDatBan], [ThueVAT], [GiamGia], [TongTien]) VALUES (N'TD01', N'KH01', CAST(N'2023-10-17T00:00:00.000' AS DateTime), 10, 0, 634700)
GO
INSERT [dbo].[tXepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL01', N'A')
INSERT [dbo].[tXepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL02', N'B')
INSERT [dbo].[tXepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL03', N'C')
INSERT [dbo].[tXepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL04', N'D')
GO
ALTER TABLE [dbo].[tChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [fk_tDauBep_tChiTietThucDon_MaDauBep] FOREIGN KEY([MaDauBep])
REFERENCES [dbo].[tDauBep] ([MaDauBep])
GO
ALTER TABLE [dbo].[tChiTietThucDon] CHECK CONSTRAINT [fk_tDauBep_tChiTietThucDon_MaDauBep]
GO
ALTER TABLE [dbo].[tChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [fk_tLoai_tChiTietThucDon_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[tChiTietThucDon] CHECK CONSTRAINT [fk_tLoai_tChiTietThucDon_MaLoai]
GO
ALTER TABLE [dbo].[tChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [fk_tMonAn_tChiTietThucDon_MaMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[tMonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[tChiTietThucDon] CHECK CONSTRAINT [fk_tMonAn_tChiTietThucDon_MaMonAn]
GO
ALTER TABLE [dbo].[tChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [fk_tThucDon_tChiTietThucDon_MaThucDon] FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[tThucDon] ([MaThucDon])
GO
ALTER TABLE [dbo].[tChiTietThucDon] CHECK CONSTRAINT [fk_tThucDon_tChiTietThucDon_MaThucDon]
GO
ALTER TABLE [dbo].[tDauBepMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tDauBep_tDauBepMonAn_MaDauBep] FOREIGN KEY([MaDauBep])
REFERENCES [dbo].[tDauBep] ([MaDauBep])
GO
ALTER TABLE [dbo].[tDauBepMonAn] CHECK CONSTRAINT [fk_tDauBep_tDauBepMonAn_MaDauBep]
GO
ALTER TABLE [dbo].[tDauBepMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tMonAn_tDauBepMonAn_MaMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[tMonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[tDauBepMonAn] CHECK CONSTRAINT [fk_tMonAn_tDauBepMonAn_MaMonAn]
GO
ALTER TABLE [dbo].[tDauBepMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tXepLoai_tDauBepMonAn_MaXepLoai] FOREIGN KEY([MaXepLoai])
REFERENCES [dbo].[tXepLoai] ([MaXepLoai])
GO
ALTER TABLE [dbo].[tDauBepMonAn] CHECK CONSTRAINT [fk_tXepLoai_tDauBepMonAn_MaXepLoai]
GO
ALTER TABLE [dbo].[tMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tCongDung_tMonAn_MaCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[tCongDung] ([MaCongDung])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tMonAn] CHECK CONSTRAINT [fk_tCongDung_tMonAn_MaCongDung]
GO
ALTER TABLE [dbo].[tMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tLoai_tMonAn_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[tMonAn] CHECK CONSTRAINT [fk_tLoai_tMonAn_MaLoai]
GO
ALTER TABLE [dbo].[tNguyenLieu]  WITH CHECK ADD  CONSTRAINT [fk_tCongDung_tNguyenLieu_MaCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[tCongDung] ([MaCongDung])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tNguyenLieu] CHECK CONSTRAINT [fk_tCongDung_tNguyenLieu_MaCongDung]
GO
ALTER TABLE [dbo].[tNguyenLieu]  WITH CHECK ADD  CONSTRAINT [fk_tDonViTinh_tMonAn_MaDonViTinh] FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[tDonViTinh] ([MaDonViTinh])
GO
ALTER TABLE [dbo].[tNguyenLieu] CHECK CONSTRAINT [fk_tDonViTinh_tMonAn_MaDonViTinh]
GO
ALTER TABLE [dbo].[tNguyenLieuMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tMonAn_tNguyenLieuMonAn_MaMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[tMonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[tNguyenLieuMonAn] CHECK CONSTRAINT [fk_tMonAn_tNguyenLieuMonAn_MaMonAn]
GO
ALTER TABLE [dbo].[tNguyenLieuMonAn]  WITH CHECK ADD  CONSTRAINT [fk_tNguyenLieu_tNguyenLieuMonAn_MaNguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[tNguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[tNguyenLieuMonAn] CHECK CONSTRAINT [fk_tNguyenLieu_tNguyenLieuMonAn_MaNguyenLieu]
GO
ALTER TABLE [dbo].[tThucDon]  WITH CHECK ADD  CONSTRAINT [fk_tKhachHang_tThucDon_MaKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tKhachHang] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tThucDon] CHECK CONSTRAINT [fk_tKhachHang_tThucDon_MaKhachHang]
GO
USE [master]
GO
ALTER DATABASE [QLDauBep_MonAn] SET  READ_WRITE 
GO
