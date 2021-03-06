USE [master]
GO
/****** Object:  Database [QLBH_CK]    Script Date: 9/9/2018 09:09:23 ******/
CREATE DATABASE [QLBH_CK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_CK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBH_CK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_CK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QLBH_CK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_CK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH_CK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH_CK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH_CK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH_CK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH_CK] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH_CK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH_CK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH_CK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_CK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH_CK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH_CK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH_CK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH_CK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH_CK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH_CK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH_CK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH_CK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH_CK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH_CK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH_CK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH_CK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH_CK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH_CK] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH_CK] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH_CK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH_CK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH_CK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH_CK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH_CK', N'ON'
GO
USE [QLBH_CK]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 9/9/2018 09:09:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBP] [varchar](10) NOT NULL,
	[TenBP] [nvarchar](50) NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCNANG]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCNANG](
	[id] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaCha] [varchar](10) NULL,
	[TenTrongHeThong] [varchar](100) NULL,
 CONSTRAINT [PK_CHUCNANG] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPHIEUNHAP]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUNHAP](
	[MaChiTietNhap] [varchar](10) NOT NULL,
	[MaPhieuNhap] [varchar](10) NULL,
	[MaSP] [varchar](10) NULL,
	[DonGiaSP] [float] NULL,
	[ThanhTien] [float] NULL,
	[Thue] [float] NULL,
	[SoLuongMua] [int] NULL,
 CONSTRAINT [PK_CTPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaChiTietNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPHIEUXUAT]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUXUAT](
	[MaChiTietXuat] [varchar](10) NOT NULL,
	[MaPhieuXuat] [varchar](10) NULL,
	[MaSP] [varchar](10) NULL,
	[MaKho] [varchar](10) NULL,
	[DonGiaSP] [float] NULL,
	[ThanhTien] [float] NULL,
	[Thue] [float] NULL,
	[SoLuongMua] [int] NULL,
 CONSTRAINT [PK_CTPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaChiTietXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIEUKHOAN]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEUKHOAN](
	[MaDieuKhoan] [varchar](10) NOT NULL,
	[TenDieuKhoan] [nvarchar](50) NULL,
 CONSTRAINT [PK_DIEUKHOAN] PRIMARY KEY CLUSTERED 
(
	[MaDieuKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[MaDonViTinh] [varchar](10) NOT NULL,
	[TenDonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HINHTHUCTHANHTOAN]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HINHTHUCTHANHTOAN](
	[MaHinhThuc] [varchar](10) NOT NULL,
	[TenHinhThuc] [nvarchar](50) NULL,
	[SoTKCty] [varchar](14) NULL,
 CONSTRAINT [PK_HINHTHUCTHANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MaHinhThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](12) NULL,
	[MaKhuVuc] [varchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MaKho] [varchar](10) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[MaKhuVuc] [varchar](10) NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKhuVuc] [varchar](10) NOT NULL,
	[TenKhuVuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [varchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](12) NULL,
	[MaKhuVuc] [varchar](10) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[DienThoai] [nchar](12) NULL,
	[MaBP] [varchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMHANG](
	[MaNhomHang] [varchar](10) NOT NULL,
	[TenNhomHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHOMHANG] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUCHUYENKHO]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUCHUYENKHO](
	[MaPhieuChuyen] [varchar](10) NOT NULL,
	[MaKhoNhan] [varchar](10) NULL,
	[MaKhoXuat] [varchar](10) NULL,
	[NguoiChuyen] [varchar](10) NULL,
	[NguoiNhan] [varchar](10) NULL,
	[Ngay] [datetime] NULL,
 CONSTRAINT [PK_PHIEUCHUYENKHO] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKho] [varchar](10) NULL,
	[MaNhaCungCap] [varchar](10) NULL,
	[MaHinhThucThanhToan] [varchar](10) NULL,
	[MaDKThanhToan] [varchar](10) NULL,
	[TongTienThanhToan] [float] NULL,
	[HanThanhToan] [datetime] NULL,
	[TienTraTruoc] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[MaPhieuThuTien] [varchar](10) NOT NULL,
	[Ngay] [datetime] NULL,
	[MaPhieuXuat] [varchar](10) NULL,
 CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [varchar](10) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKhachHang] [varchar](10) NULL,
	[MaHinhThucThanhToan] [varchar](10) NULL,
	[MaDKThanhToan] [varchar](10) NULL,
	[TongTienThanhToan] [float] NULL,
	[HanThanhToan] [datetime] NULL,
	[TienTraTruoc] [float] NULL,
	[NgayGiao] [datetime] NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[ID] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaDonViTinh] [varchar](10) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[MaKho] [varchar](10) NULL,
	[MaNhaCungCap] [varchar](10) NULL,
	[MaNhomHang] [varchar](10) NULL,
	[GiaLucNhap] [float] NULL,
	[HinhAnh] [nvarchar](100) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenTaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[MaNV] [varchar](10) NULL,
	[MaVaiTro] [varchar](10) NULL,
	[NhoTaiKhoan] [bit] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYGIA]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYGIA](
	[MaTyGia] [varchar](10) NOT NULL,
	[TenTyGia] [nvarchar](50) NULL,
	[QuyDoiTienViet] [float] NULL,
 CONSTRAINT [PK_TYGIA] PRIMARY KEY CLUSTERED 
(
	[MaTyGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAITRO]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO](
	[MaVaiTro] [varchar](10) NOT NULL,
	[TenVaiTro] [nvarchar](50) NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAITROCHUCNANG]    Script Date: 9/9/2018 09:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITROCHUCNANG](
	[id] [varchar](10) NOT NULL,
	[MaVaiTro] [varchar](10) NULL,
	[MaChucNang] [varchar](10) NULL,
	[TruyXuat] [bit] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
 CONSTRAINT [PK_VAITROCHUCNANG] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP01', N'Phòng Kinh Doanh')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP02', N'Phòng Kế Hoạch')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP03', N'Phòng Đối Ngoại')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP04', N'Phòng Kế Toán')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP05', N'Phòng Bảo Vệ')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP06', N'Phòng Nhân Sự')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP]) VALUES (N'BP07', N'Phòng Thông Tin')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'1', N'Hệ Thống', N'0', N'ribbonPageHeThong')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'10', N'Sao Lưu', N'9', N'barButtonItemSaoLuu')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'11', N'Phục Hồi', N'9', N'barButtonItemPhucHoi')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'12', N'Danh Mục', N'0', N'ribbonPageDanhMuc')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'13', N'Đối Tác', N'12', N'ribbonPageGroupDoiTac')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'14', N'Khu Vực', N'13', N'barButtonItemKhuVuc')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'15', N'Khách Hàng', N'13', N'barButtonItemKhachHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'16', N'Nhà Cung Cấp', N'13', N'barButtonItemNhaCungCap')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'17', N'Kho Hàng', N'12', N'ribbonPageGroupKhoHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'18', N'Kho Hàng', N'17', N'barButtonItemKhoHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'19', N'Đơn Vị Tính', N'17', N'barButtonItemDonViTinh')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'2', N'Hệ Thống', N'1', N'ribbonPageGroupHeThong')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'20', N'Nhóm Hàng', N'17', N'barButtonItemNhomHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'21', N'Hàng Hóa', N'17', N'barButtonItemHangHoa')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'22', N'Tỷ Giá', N'17', N'barButtonItemTyGia')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'23', N'Tổ Chức', N'12', N'ribbonPageGroupToChuc')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'24', N'Bộ Phận', N'23', N'barButtonItemBoPhan')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'25', N'Nhân Viên', N'23', N'barButtonItemNhanVien')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'26', N'Chức Năng', N'0', N'ribbonPageChucNang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'27', N'Nhập - Xuất', N'26', N'ribbonPageGroupNhapXuat')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'28', N'Mua Hàng', N'27', N'barButtonItemMuaHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'29', N'Bán Hàng', N'27', N'barButtonItemBanHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'3', N'Kết Thúc', N'2', N'barButtonItemKetThuc')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'30', N'Kho Hàng', N'26', N'ribbonPageGroupCNKhoHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'31', N'Tồn Kho', N'30', N'barButtonItemTonKho')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'32', N'Chuyển Kho', N'30', N'barButtonItemChuyenKho')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'33', N'Công Nợ', N'26', N'ribbonPageGroupCongNo')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'34', N'Thu Tiền', N'33', N'barButtonItemThuTien')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'35', N'Trả Tiền', N'33', N'barButtonItemTraTien')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'36', N'Báo Cáo', N'26', N'ribbonPageGroupBaoCao')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'37', N'Báo Cáo Kho Hàng', N'36', N'barButtonItemBaoCaoKhoHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'38', N'Báo Cáo Bán Hàng', N'36', N'barButtonItemBaoCaoBanHang')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'39', N'Trợ Giúp', N'0', N'ribbonPageTroGiup')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'4', N'Thông Tin', N'2', N'barButtonItemThongTin')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'40', N'Trợ Giúp', N'39', N'ribbonPageGroupTroGiup')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'41', N'Liên Hệ', N'40', N'barButtonItemLienHe')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'42', N'Thông Tin', N'39', N'ribbonPageGroupThongTin')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'43', N'Đăng Ký', N'42', N'barButtonItemDangKy')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'44', N'Thông Tin', N'42', N'barButtonItemTGThongTin')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'5', N'Bảo Mật', N'1', N'ribbonPageGroupBaoMat')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'6', N'Phân Quyền', N'5', N'barButtonItemPhanQuyen')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'7', N'Đổi Mật Khẩu', N'5', N'barButtonItemDoiMatKhau')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'8', N'Nhật Ký Hoạt Động', N'5', N'barButtonItemNhatKyHeThong')
INSERT [dbo].[CHUCNANG] ([id], [Ten], [MaCha], [TenTrongHeThong]) VALUES (N'9', N'Dữ Liệu', N'1', N'ribbonPageGroupDuLieu')
INSERT [dbo].[CTPHIEUNHAP] ([MaChiTietNhap], [MaPhieuNhap], [MaSP], [DonGiaSP], [ThanhTien], [Thue], [SoLuongMua]) VALUES (N'CTPN1', N'ml', N'SP01', 22490000, 24739000, 0.1, 1)
INSERT [dbo].[CTPHIEUNHAP] ([MaChiTietNhap], [MaPhieuNhap], [MaSP], [DonGiaSP], [ThanhTien], [Thue], [SoLuongMua]) VALUES (N'CTPN2', N'Pn2', N'SP06', 9790000, 21538000, 0.1, 2)
INSERT [dbo].[CTPHIEUNHAP] ([MaChiTietNhap], [MaPhieuNhap], [MaSP], [DonGiaSP], [ThanhTien], [Thue], [SoLuongMua]) VALUES (N'CTPN3', N'Pn2', N'SP08', 19999000, 43997800, 0.1, 2)
INSERT [dbo].[CTPHIEUXUAT] ([MaChiTietXuat], [MaPhieuXuat], [MaSP], [MaKho], [DonGiaSP], [ThanhTien], [Thue], [SoLuongMua]) VALUES (N'CTPX1', N'mmm', N'SP05', N'K05', 15990000, 35178000, 0.1, 2)
INSERT [dbo].[CTPHIEUXUAT] ([MaChiTietXuat], [MaPhieuXuat], [MaSP], [MaKho], [DonGiaSP], [ThanhTien], [Thue], [SoLuongMua]) VALUES (N'CTPX2', N'mmm', N'SP09', N'K10', 300000, 6600000, 0.1, 20)
INSERT [dbo].[DIEUKHOAN] ([MaDieuKhoan], [TenDieuKhoan]) VALUES (N'DK01', N'Công Nợ')
INSERT [dbo].[DIEUKHOAN] ([MaDieuKhoan], [TenDieuKhoan]) VALUES (N'DK02', N'Thanh Toán Ngay')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT01', N'Cái')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT02', N'Kg')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT03', N'Chai')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT04', N'Dây')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT05', N'Lon')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT06', N'Hộp')
INSERT [dbo].[DONVITINH] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT07', N'Thùng')
INSERT [dbo].[HINHTHUCTHANHTOAN] ([MaHinhThuc], [TenHinhThuc], [SoTKCty]) VALUES (N'HT01', N'Tiền Mặt', NULL)
INSERT [dbo].[HINHTHUCTHANHTOAN] ([MaHinhThuc], [TenHinhThuc], [SoTKCty]) VALUES (N'HT02', N'Chuyển Khoản', N'123456789')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH01', N'Trần Văn Ơn', N'Tổ 7, Phường 10,Quận 10, Tp Thái Nguyên', N'111111111   ', N'KV01')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH02', N'Trần Văn Giàu', N'Tổ 9, Ấp 3, Xã Sơn Tây,Huyện Kali,Tỉnh Quãng Ninh', N'222222222   ', N'KV01')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH03', N'Trần Văn Ớt', N'Hiệp Thành, Vĩnh Trạch,Hà Nội', N'333333333   ', N'KV02')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH04', N'Phạm Văn Tí', N'Bắc Từ Liêm,Hà Nội', N'444444444   ', N'KV02')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH05', N'Phạm Trí Quốc ', N'Ung Gia Khiêm,Đông Anh,Hà Nội', N'555555555   ', N'KV02')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH06', N'Nguyễn Văn Gọi', N'Khu Phố 3,Phường 5,Quận 10,TP Thừa-Thiên Huế', N'666666666   ', N'KV03')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH07', N'Đinh Trí Nhất', N'Thái Hòa,Vĩ Lạc,Đà Nẵng ', N'777777777   ', N'KV03')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH08', N'Văn Thị Thấm', N'257,Nguyễn Văn Cừ,Q5,TP Hồ Chí Minh', N'888888888   ', N'KV04')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH09', N'Võ Quang Ân', N'225,Phan Văn Trị,Q.Gò Vấp,TP Hồ Chí Minh', N'999999999   ', N'KV04')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'KH10', N'Trịnh Ơn Gọi', N'225,Thanh Mị,Quận Ninh Kiều, TP Cần Thơ', N'101011010   ', N'KV05')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K01', N'Kho 1A2', N'KV01')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K02', N'Kho 2A3', N'KV01')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K03', N'Kho 3A4', N'KV02')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K04', N'Kho 4A3', N'KV02')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K05', N'Kho 5A6', N'KV03')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K06', N'Kho 6A7', N'KV03')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K07', N'Kho 7A8', N'KV04')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K08', N'Kho 8A7', N'KV04')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K09', N'Kho 9A10', N'KV05')
INSERT [dbo].[KHO] ([MaKho], [TenKho], [MaKhuVuc]) VALUES (N'K10', N'Kho 10A9', N'KV05')
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc]) VALUES (N'KV01', N'TP Hải Phòng')
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc]) VALUES (N'KV02', N'Hà Nội')
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc]) VALUES (N'KV03', N'Đà Nẵng')
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc]) VALUES (N'KV04', N'TP Hồ Chí Minh')
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc]) VALUES (N'KV05', N'TP Cần Thơ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC01', N'Cty Toàn Cầu', N'12,Trần Thái Tông,Q5,TP Hải Phòng', N'888888888   ', N'KV01')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC02', N'Cty XNK 1', N'12,Thủ Khoa Nghĩa,Quận Ninh Kiều,TP Hải Phòng', N'444444444   ', N'KV01')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC03', N'Cty TNHH Trí Dũng', N'12,Ba Đình,Hà Nội', N'777777777   ', N'KV02')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC04', N'Cty TNHH2', N'223,Từ Liêm,Hà Nội', N'666666666   ', N'KV02')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC05', N'Cty XNK 2', N'Đảo Lý Sơn', N'555555555   ', N'KV03')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC06', N'Cty Cung Ứng Thiết bị điện tử 2', N'123,CMT8,Q5,Đà Nẵng', N'333333333   ', N'KV03')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC07', N'Cty XNK @ DV An Nguyên', N'12,An Dương Vương,Q.Bình Tân,TP Hồ Chí Minh', N'101010101   ', N'KV04')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC08', N'Cty TGDD Miền Nam', N'23,Tô Hiến Thành,Q10,TP Hồ Chí Minh', N'999999999   ', N'KV04')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC09', N'Cty Cung Ứng Thiết bị điện tử 1', N'256,Võ Văn Kiệt,Q2,Tp. Cần Thơ', N'222222222   ', N'KV05')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [MaKhuVuc]) VALUES (N'NCC10', N'Cty TNHH 1', N'128,Nguyễn Văn Cừ,Q5,TP Cần Thơ', N'111111111   ', N'KV05')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [MaBP]) VALUES (N'NV01', N'Huỳnh Ái Liên', N'Nữ', CAST(N'1998-10-11T00:00:00.000' AS DateTime), N'111111111   ', N'BP06')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [MaBP]) VALUES (N'NV02', N'Đinh Công Luân', N'Nam', CAST(N'1999-05-09T00:00:00.000' AS DateTime), N'222222222   ', N'BP05')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [MaBP]) VALUES (N'NV03', N'Bùi Hữu Nghĩa', N'Nam', CAST(N'1998-06-02T00:00:00.000' AS DateTime), N'333333333   ', N'BP02')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [MaBP]) VALUES (N'NV04', N'Lê Vũ Nguyên', N'Nam', CAST(N'2000-12-30T00:00:00.000' AS DateTime), N'444444444   ', N'BP05')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [MaBP]) VALUES (N'NV05', N'Đinh Nghĩa Nhân', N'Nam', CAST(N'2017-11-30T00:00:00.000' AS DateTime), N'555555555   ', N'BP07')
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang]) VALUES (N'NH01', N'Điện Thoại')
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang]) VALUES (N'NH02', N'Máy Tính Bảng')
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang]) VALUES (N'NH03', N'Laptop')
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang]) VALUES (N'NH04', N'Phụ Kiện')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaKho], [MaNhaCungCap], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc]) VALUES (N'ml', CAST(N'2018-01-09T15:19:05.000' AS DateTime), N'NV03', N'K04', N'NCC03', N'HT02', N'DK01', 101277000, CAST(N'2018-01-29T15:19:05.000' AS DateTime), 12000)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNV], [MaKho], [MaNhaCungCap], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc]) VALUES (N'Pn2', CAST(N'2018-01-09T15:27:36.000' AS DateTime), N'NV04', N'K04', N'NCC02', N'HT01', N'DK02', 65535800, CAST(N'2018-01-09T15:27:36.000' AS DateTime), 666)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'mm', CAST(N'2018-01-09T17:56:51.000' AS DateTime), N'NV02', N'KH03', N'HT02', N'DK01', 43997800, CAST(N'2018-01-09T17:56:51.000' AS DateTime), 111, CAST(N'2018-01-09T17:56:51.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'mmm', CAST(N'2018-01-09T19:56:59.000' AS DateTime), N'NV02', N'KH03', N'HT02', N'DK01', 41778000, CAST(N'2018-01-09T19:56:59.000' AS DateTime), 7777, CAST(N'2018-01-09T19:56:59.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'PN06', CAST(N'2018-01-09T18:27:25.000' AS DateTime), N'NV03', N'KH03', N'HT02', N'DK01', 255167000, CAST(N'2018-01-09T18:27:25.000' AS DateTime), 6666, CAST(N'2018-01-09T18:27:25.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'PN0o', CAST(N'2018-01-09T18:29:09.000' AS DateTime), N'NV02', N'KH02', N'HT01', N'DK01', 266178000, CAST(N'2018-01-23T18:29:10.000' AS DateTime), 888, CAST(N'2018-01-09T18:29:09.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'PNO4', CAST(N'2018-01-09T18:24:59.000' AS DateTime), N'NV02', N'KH05', N'HT01', N'DK01', 185838400, CAST(N'2018-01-09T18:24:59.000' AS DateTime), 5000, CAST(N'2018-01-09T18:24:59.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'pp', CAST(N'2018-01-09T18:37:25.000' AS DateTime), N'NV02', N'KH04', N'HT02', N'DK01', 336534000, CAST(N'2018-01-09T18:37:25.000' AS DateTime), 888888, CAST(N'2018-01-18T18:37:25.000' AS DateTime))
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaNV], [MaKhachHang], [MaHinhThucThanhToan], [MaDKThanhToan], [TongTienThanhToan], [HanThanhToan], [TienTraTruoc], [NgayGiao]) VALUES (N'PX01', CAST(N'2018-01-09T18:23:18.000' AS DateTime), N'NV02', N'KH03', N'HT02', N'DK01', 225439500, CAST(N'2018-01-09T18:23:19.000' AS DateTime), 23000, CAST(N'2018-01-09T18:23:18.000' AS DateTime))
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'1', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 200, N'K01', N'NCC01', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'10', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 1110, N'K10', N'NCC10', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'100', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 2000, N'K10', N'NCC10', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'101', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 20, N'K01', N'NCC01', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'102', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 10, N'K02', N'NCC02', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'103', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 50, N'K03', N'NCC03', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'104', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 25, N'K04', N'NCC04', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'105', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 20, N'K05', N'NCC05', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'106', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 60, N'K06', N'NCC06', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'107', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 50, N'K07', N'NCC07', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'108', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 60, N'K08', N'NCC08', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'109', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ ', 10, N'K09', N'NCC09', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'11', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 1000, N'K01', N'NCC01', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'110', N'SP11', N'Macbook Pro Touch 256GB', N'DVT01', N'Mỹ', 5, N'K10', N'NCC10', N'NH03', 42000000, N'011.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'111', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 20, N'K01', N'NCC01', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'112', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 10, N'K02', N'NCC02', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'113', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 50, N'K03', N'NCC03', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'114', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 30, N'K04', N'NCC04', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'115', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 12, N'K05', N'NCC05', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'116', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 40, N'K06', N'NCC06', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'117', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 50, N'K07', N'NCC07', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'118', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 200, N'K08', N'NCC08', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'119', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 100, N'K09', N'NCC09', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'12', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 1000, N'K02', N'NCC02', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'120', N'SP12', N'Laptop Dell XPS13 9365-K7DWW1', N'DVT01', N'Mỹ', 10, N'K10', N'NCC10', N'NH03', 54000000, N'012.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'121', N'SP13', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 10, N'K01', N'NCC01', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'122', N'SP13', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 40, N'K02', N'NCC02', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'123', N'SP13', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 50, N'K03', N'NCC03', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'124', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 60, N'K04', N'NCC04', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'125', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 20, N'K05', N'NCC05', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'126', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 50, N'K06', N'NCC06', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'127', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 60, N'K07', N'NCC07', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'128', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 500, N'K08', N'NCC08', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'129', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 20, N'K09', N'NCC09', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'13', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 10000, N'K03', N'NCC03', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'130', N'SP14', N'Laptop HP EliteBook X360 1030 G2', N'DVT01', N'Mỹ', 60, N'K10', N'NCC10', N'NH03', 35000000, N'013.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'131', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 50, N'K01', N'NCC01', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'132', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 60, N'K02', N'NCC02', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'133', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 50, N'K03', N'NCC03', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'134', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 60, N'K04', N'NCC04', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'135', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 60, N'K05', N'NCC05', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'136', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 50, N'K06', N'NCC06', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'137', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 100, N'K07', N'NCC07', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'138', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 20, N'K08', N'NCC08', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'139', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 50, N'K09', N'NCC09', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'14', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 20000, N'K04', N'NCC04', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'140', N'SP15', N'Laptop Dell Inspiron 15 7559-N7559B', N'DVT01', N'Mỹ', 20, N'K10', N'NCC10', N'NH03', 23000000, N'014.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'141', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 30, N'K01', N'NCC01', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'142', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 50, N'K02', N'NCC02', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'143', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 60, N'K03', N'NCC03', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'144', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 60, N'K04', N'NCC04', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'145', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 50, N'K05', N'NCC05', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'146', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 25, N'K06', N'NCC06', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'147', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 100, N'K07', N'NCC07', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'148', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 200, N'K08', N'NCC08', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'149', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 300, N'K09', N'NCC09', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'15', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 1000, N'K05', N'NCC05', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'150', N'SP16', N'Laptop Lenovo IdeaPad 120S 11IAP N3350', N'DVT01', N'Mỹ', 5000, N'K10', N'NCC10', N'NH03', 5000000, N'015.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'151', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 2000, N'K01', N'NCC01', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'152', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 30000, N'K02', N'NCC02', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'153', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 2500, N'K03', N'NCC03', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'154', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 3210, N'K04', N'NCC04', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'155', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 5600, N'K05', N'NCC05', N'NH04', 29000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'156', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 1234, N'K06', N'NCC06', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'157', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 12456, N'K07', N'NCC07', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'158', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 4000, N'K08', N'NCC08', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'159', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 2000, N'K09', N'NCC09', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'16', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 100, N'K06', N'NCC06', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'160', N'SP17', N'USB OTG 3.0 16 GB Sandisk SDDD3', N'DVT01', N'Mỹ', 5000, N'K10', N'NCC10', N'NH04', 290000, N'016.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'161', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 500, N'K01', N'NCC01', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'162', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 600, N'K02', N'NCC02', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'163', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 1000, N'K03', N'NCC03', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'164', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 2000, N'K04', N'NCC04', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'165', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 500, N'K05', N'NCC05', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'166', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 600, N'K06', N'NCC06', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'167', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 8000, N'K07', N'NCC07', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'168', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 600, N'K08', N'NCC08', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'169', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 800, N'K09', N'NCC09', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'17', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 1000, N'K07', N'NCC07', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'170', N'SP18', N'Tai nghe Sony MDR-EX150AP', N'DVT01', N'Nhật Bản', 200, N'K10', N'NCC10', N'NH04', 390000, N'017.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'171', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 200, N'K01', N'NCC01', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'172', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 200, N'K02', N'NCC02', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'173', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 500, N'K03', N'NCC03', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'174', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 500, N'K04', N'NCC04', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'175', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 400, N'K05', N'NCC05', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'176', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 600, N'K06', N'NCC06', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'177', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 200, N'K07', N'NCC07', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'178', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 600, N'K08', N'NCC08', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'179', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 680, N'K09', N'NCC09', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'18', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 10000, N'K08', N'NCC08', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'180', N'SP19', N'Tai nghe nhét trong Samsung IG935B', N'DVT01', N'Hàn Quốc', 600, N'K10', N'NCC10', N'NH04', 300000, N'018.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'19', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 250, N'K09', N'NCC09', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'2', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 2000, N'K02', N'NCC02', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'20', N'SP02', N'Điện thoại iPhone X 256GB', N'DVT01', N'Mỹ', 800, N'K10', N'NCC10', N'NH01', 34790000, N'001.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'21', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 100, N'K01', N'NCC01', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'22', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 200, N'K02', N'NCC02', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'23', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 50000, N'K03', N'NCC03', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'24', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 60000, N'K04', N'NCC04', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'25', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 2000, N'K05', N'NCC05', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'26', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 3000, N'K06', N'NCC06', N'NH01', 20990000, N'002.png')
GO
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'27', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 60000, N'K07', N'NCC07', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'28', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 20000, N'K08', N'NCC08', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'29', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ ', 1000, N'K09', N'NCC09', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'3', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 15000, N'K03', N'NCC03', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'30', N'SP03', N'Điện thoại iPhone 8 64GB', N'DVT01', N'Mỹ', 200, N'K10', N'NCC10', N'NH01', 20990000, N'002.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'31', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 1050, N'K01', N'NCC01', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'32', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 200, N'K02', N'NCC02', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'33', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 15600, N'K03', N'NCC03', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'34', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 20300, N'K04', N'NCC04', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'35', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 2200, N'K05', N'NCC05', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'36', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 100, N'K06', N'NCC06', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'37', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 1000, N'K07', N'NCC07', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'38', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 2000, N'K08', N'NCC08', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'39', N'SP04', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 200, N'K09', N'NCC09', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'4', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 20000, N'K04', N'NCC04', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'40', N'SP05', N'Điện thoại Sony Xperia XZ1', N'DVT01', N'Nhật Bản', 1500, N'K10', N'NCC10', N'NH01', 15990000, N'004.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'41', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 200, N'K01', N'NCC01', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'42', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 200, N'K02', N'NCC02', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'43', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 5000, N'K03', N'NCC03', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'44', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 2000, N'K04', N'NCC04', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'45', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 198, N'K05', N'NCC05', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'46', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 2500, N'K06', N'NCC06', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'47', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 50000, N'K07', N'NCC07', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'48', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 10000, N'K08', N'NCC08', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'49', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 200, N'K09', N'NCC09', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'5', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 1503, N'K05', N'NCC05', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'50', N'SP05', N'Điện thoại Samsung Galaxy J7+', N'DVT01', N'Hàn Quốc', 500, N'K10', N'NCC10', N'NH01', 8690000, N'005.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'51', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 1000, N'K01', N'NCC01', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'52', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 200, N'K02', N'NCC02', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'53', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 20000, N'K03', N'NCC03', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'54', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 1000, N'K04', N'NCC04', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'55', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 100, N'K05', N'NCC05', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'56', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 10000, N'K06', N'NCC06', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'57', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 10000, N'K07', N'NCC07', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'58', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 2000, N'K08', N'NCC08', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'59', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 100, N'K09', N'NCC09', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'6', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 1020, N'K06', N'NCC06', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'60', N'SP06', N'Điện thoại Bphone 2017', N'DVT01', N'Việt Nam', 1230, N'K10', N'NCC10', N'NH01', 9790000, N'006.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'61', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 100, N'K01', N'NCC01', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'62', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 130, N'K02', N'NCC02', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'63', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 50, N'K03', N'NCC03', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'64', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 500, N'K04', N'NCC04', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'65', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 123, N'K05', N'NCC05', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'66', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 20, N'K06', N'NCC06', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'67', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 50, N'K07', N'NCC07', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'68', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 60, N'K08', N'NCC08', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'69', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 20, N'K09', N'NCC09', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'7', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 2050, N'K07', N'NCC07', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'70', N'SP07', N'iPad Pro 10.5 inch Wifi Cellular 64GB', N'DVT01', N'Mỹ', 20, N'K10', N'NCC10', N'NH02', 19999000, N'007.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'71', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 200, N'K01', N'NCC01', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'72', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 10, N'K02', N'NCC02', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'73', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 120, N'K03', N'NCC03', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'74', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 200, N'K04', N'NCC04', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'75', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 200, N'K05', N'NCC05', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'76', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 100, N'K06', N'NCC06', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'77', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 150, N'K07', N'NCC07', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'78', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 200, N'K08', N'NCC08', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'79', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 10, N'K09', N'NCC09', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'8', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 2500, N'K08', N'NCC08', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'80', N'SP08', N'Samsung Galaxy Book 10.6 inch', N'DVT01', N'Hàn Quốc', 20, N'K10', N'NCC10', N'NH02', 19999000, N'008.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'81', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 500, N'K01', N'NCC01', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'82', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 500, N'K02', N'NCC02', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'83', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 2000, N'K03', N'NCC03', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'84', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 200, N'K04', N'NCC04', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'85', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 100, N'K05', N'NCC05', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'86', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 200, N'K06', N'NCC06', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'87', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 2000, N'K07', N'NCC07', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'88', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 2000, N'K08', N'NCC08', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'89', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 300, N'K09', N'NCC09', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'9', N'SP01', N'Điện thoại Samsung Galaxy Note 8', N'DVT01', N'Hàn Quốc', 1100, N'K09', N'NCC09', N'NH01', 22490000, N'003.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'90', N'SP09', N' Huawei MediaPad T1 8.0', N'DVT01', N'Trung Quốc', 480, N'K10', N'NCC10', N'NH02', 300000, N'009.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'91', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 100, N'K01', N'NCC01', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'92', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 100, N'K02', N'NCC02', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'93', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 2000, N'K03', N'NCC03', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'94', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 2500, N'K04', N'NCC04', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'95', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 3000, N'K05', N'NCC05', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'96', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 2000, N'K06', N'NCC06', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'97', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 3250, N'K07', N'NCC07', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'98', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 35200, N'K08', N'NCC08', N'NH02', 300000, N'010.png')
INSERT [dbo].[SANPHAM] ([ID], [MaSP], [TenSP], [MaDonViTinh], [XuatXu], [SoLuongTon], [MaKho], [MaNhaCungCap], [MaNhomHang], [GiaLucNhap], [HinhAnh]) VALUES (N'99', N'SP10', N'Lenovo Phab 2', N'DVT01', N'Trung Quốc', 3600, N'K09', N'NCC09', N'NH02', 300000, N'010.png')
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [MatKhau], [MaNV], [MaVaiTro], [NhoTaiKhoan]) VALUES (N'CongLuan', N'456', N'NV02', N'VT02', 0)
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [MatKhau], [MaNV], [MaVaiTro], [NhoTaiKhoan]) VALUES (N'HuuNghia', N'123', N'NV03', N'VT01', 0)
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [MatKhau], [MaNV], [MaVaiTro], [NhoTaiKhoan]) VALUES (N'VuNguyen', N'789', N'NV04', N'VT03', 0)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'CAD', N'Đôla Canada', 18223)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'EUR', N'Euro châu Âu', 27402)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'GBP', N'Bảng Anh', 30819)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'HKD', N'Đôla Hong Kong', 2927)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'JPY', N'Yên Nhật', 202)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'USD', N' Đôla Mỹ', 22745)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [QuyDoiTienViet]) VALUES (N'VND', N'Việt Nam Đồng', 1)
INSERT [dbo].[VAITRO] ([MaVaiTro], [TenVaiTro]) VALUES (N'VT01      ', N'Admin')
INSERT [dbo].[VAITRO] ([MaVaiTro], [TenVaiTro]) VALUES (N'VT02      ', N'Quản Lý')
INSERT [dbo].[VAITRO] ([MaVaiTro], [TenVaiTro]) VALUES (N'VT03      ', N'Nhân Viên')
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'1', N'VT01', N'1', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'10', N'VT01', N'10', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'11', N'VT01', N'11', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'12', N'VT01', N'12', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'13', N'VT01', N'13', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'14', N'VT01', N'14', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'15', N'VT01', N'15', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'16', N'VT01', N'16', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'17', N'VT01', N'17', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'18', N'VT01', N'18', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'19', N'VT01', N'19', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'2', N'VT01', N'2', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'20', N'VT01', N'20', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'21', N'VT01', N'21', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'22', N'VT01', N'22', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'23', N'VT01', N'23', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'24', N'VT01', N'24', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'25', N'VT01', N'25', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'26', N'VT01', N'26', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'27', N'VT01', N'27', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'28', N'VT01', N'28', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'29', N'VT01', N'29', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'3', N'VT01', N'3', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'30', N'VT01', N'30', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'31', N'VT01', N'31', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'32', N'VT01', N'32', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'33', N'VT01', N'33', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'34', N'VT01', N'34', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'35', N'VT01', N'35', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'36', N'VT01', N'36', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'37', N'VT01', N'37', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'38', N'VT01', N'38', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'39', N'VT01', N'39', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'4', N'VT01', N'4', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'40', N'VT01', N'40', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'41', N'VT01', N'41', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'42', N'VT01', N'42', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'43', N'VT01', N'43', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'44', N'VT01', N'44', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'45', N'VT02', N'1', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'46', N'VT02', N'2', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'47', N'VT02', N'3', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'48', N'VT02', N'4', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'49', N'VT02', N'5', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'5', N'VT01', N'5', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'50', N'VT02', N'7', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'51', N'VT02', N'12', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'52', N'VT02', N'13', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'53', N'VT02', N'14', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'54', N'VT02', N'15', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'55', N'VT02', N'16', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'56', N'VT02', N'17', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'57', N'VT02', N'18', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'58', N'VT02', N'19', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'59', N'VT02', N'20', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'6', N'VT01', N'6', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'60', N'VT02', N'21', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'61', N'VT02', N'22', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'62', N'VT02', N'23', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'63', N'VT02', N'24', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'64', N'VT02', N'25', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'65', N'VT02', N'26', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'66', N'VT02', N'27', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'67', N'VT02', N'28', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'68', N'VT02', N'29', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'69', N'VT02', N'30', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'7', N'VT01', N'7', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'70', N'VT02', N'31', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'71', N'VT02', N'32', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'72', N'VT02', N'33', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'73', N'VT02', N'34', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'74', N'VT02', N'35', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'75', N'VT02', N'36', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'76', N'VT02', N'37', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'77', N'VT02', N'38', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'78', N'VT02', N'39', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'79', N'VT02', N'40', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'8', N'VT01', N'8', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'80', N'VT02', N'41', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'81', N'VT02', N'42', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'82', N'VT02', N'43', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'83', N'VT02', N'44', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'84', N'VT03', N'26', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'85', N'VT03', N'27', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'86', N'VT03', N'29', 1, 1, 1, 1)
INSERT [dbo].[VAITROCHUCNANG] ([id], [MaVaiTro], [MaChucNang], [TruyXuat], [Them], [Xoa], [Sua]) VALUES (N'9', N'VT01', N'9', 1, 1, 1, 1)
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP] CHECK CONSTRAINT [FK_CTPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CTPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUXUAT_KHO] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[CTPHIEUXUAT] CHECK CONSTRAINT [FK_CTPHIEUXUAT_KHO]
GO
ALTER TABLE [dbo].[CTPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CTPHIEUXUAT] CHECK CONSTRAINT [FK_CTPHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_KHUVUC] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_KHUVUC]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_KHUVUC] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_KHUVUC]
GO
ALTER TABLE [dbo].[NHACUNGCAP]  WITH CHECK ADD  CONSTRAINT [FK_NHACUNGCAP_KHUVUC] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[NHACUNGCAP] CHECK CONSTRAINT [FK_NHACUNGCAP_KHUVUC]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BOPHAN] ([MaBP])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHO] FOREIGN KEY([MaKhoNhan])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHO]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHO1] FOREIGN KEY([MaKhoXuat])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHO1]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN] FOREIGN KEY([NguoiChuyen])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1] FOREIGN KEY([NguoiNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_DIEUKHOAN] FOREIGN KEY([MaDKThanhToan])
REFERENCES [dbo].[DIEUKHOAN] ([MaDieuKhoan])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_DIEUKHOAN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_HINHTHUCTHANHTOAN] FOREIGN KEY([MaHinhThucThanhToan])
REFERENCES [dbo].[HINHTHUCTHANHTOAN] ([MaHinhThuc])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_HINHTHUCTHANHTOAN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_PHIEUXUAT] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_PHIEUXUAT]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_DIEUKHOAN] FOREIGN KEY([MaDKThanhToan])
REFERENCES [dbo].[DIEUKHOAN] ([MaDieuKhoan])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_DIEUKHOAN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_HINHTHUCTHANHTOAN] FOREIGN KEY([MaHinhThucThanhToan])
REFERENCES [dbo].[HINHTHUCTHANHTOAN] ([MaHinhThuc])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_HINHTHUCTHANHTOAN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NHANVIEN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_DONVITINH] FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[DONVITINH] ([MaDonViTinh])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_DONVITINH]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_KHO] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_KHO]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHACUNGCAP] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_NHACUNGCAP]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHOMHANG] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NHOMHANG] ([MaNhomHang])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_NHOMHANG]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_VAITRO] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VAITRO] ([MaVaiTro])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_VAITRO]
GO
ALTER TABLE [dbo].[VAITROCHUCNANG]  WITH CHECK ADD  CONSTRAINT [FK_VAITROCHUCNANG_CHUCNANG] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[CHUCNANG] ([id])
GO
ALTER TABLE [dbo].[VAITROCHUCNANG] CHECK CONSTRAINT [FK_VAITROCHUCNANG_CHUCNANG]
GO
ALTER TABLE [dbo].[VAITROCHUCNANG]  WITH CHECK ADD  CONSTRAINT [FK_VAITROCHUCNANG_VAITRO] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VAITRO] ([MaVaiTro])
GO
ALTER TABLE [dbo].[VAITROCHUCNANG] CHECK CONSTRAINT [FK_VAITROCHUCNANG_VAITRO]
GO
USE [master]
GO
ALTER DATABASE [QLBH_CK] SET  READ_WRITE 
GO
