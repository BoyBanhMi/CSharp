/*************************
** BOYBANHMI           **
**    F4               **
** PHAN MEM QUAN LY XE **/

drop database qlxe1;
create database qlxe1;
use qlxe1
create table tb_Login 
(
	userid nvarchar(10) primary key not null,
	pass nvarchar(10) not null,
	role nvarchar(10) not null
)
create table tb_role
(
	MaCV nvarchar(10) not null primary key,
	tenCV nvarchar(10) not null
)
create  table tb_NhanVien
(
	MaNhanVien nvarchar(10) primary key NOT NULL,
	HoNhanVien nvarchar(50) NOT NULL,
	TenNhanVien nvarchar(50) NOT NULL,
	GioiTinh bit NULL,
	NgaySinh datetime NULL,
	DiaChi nvarchar(50) NULL,
	DienThoai char(20) NULL,
	Email char(50) NULL,
	BangCap nvarchar(50) NULL,
	CMND char(50) NULL,
	NgayVaoLam datetime NULL
)
CREATE TABLE tb_KhachHang(
	MaKhachHang nvarchar(10) primary key NOT NULL,
	HoKhachHang nvarchar(50) NULL,
	TenKhachHang nvarchar(50) NOT NULL,
	NgaySinh datetime NULL,
	GioiTinh bit NULL,
	DiaChi nvarchar(50) NULL,
	CMND char(50) NOT NULL,
	DienThoai char(50) NULL,
	Email char(50) NULL
)
CREATE TABLE tb_Xe(
	MaXe nvarchar(10) primary key NOT NULL,
	TenXe nvarchar(50) NOT NULL,
	NgaySanXuat datetime NULL,
	HangXe nvarchar(50) NULL,
	BienKiemSoat char(10) NULL,
	SucChua nvarchar(50) NULL,
	LoaiXe nvarchar(50) NULL,
	NgayMuaXe datetime NULL,
	TinhTrangXe nvarchar(50) NULL
)
CREATE TABLE tb_LaiXe(
	Malaixe nvarchar(10) primary key NOT NULL,
	TenLaiXe nvarchar(50) NOT NULL,
	NgaySinh datetime NULL,
	GioiTinh char(10) NULL,
	DiaChi nvarchar(50) NULL,
	DienThoai char(50) NULL,
	CMND int NULL,
	Email char(50) NULL,
	NgayNhanViec datetime NULL,
	TinhTrangLaiXe nvarchar(50) NULL
)
CREATE TABLE tb_HopDong(
	MaHopDong nvarchar(10) primary key NOT NULL,
	TenHopDong nvarchar(50) NULL,
	NgayLapHopDong datetime NULL,
	MaNhanVien nvarchar(10) NULL,
	MaKhachHang nvarchar(10) NULL,
	HanThanhToan datetime NULL,
	TinhTrangThanhToan bit NULL,
	MaXe nvarchar(10) NULL,
	Malaixe nvarchar(10) NULL,
	Gia money NULL,
	TienCoc money NULL,
	FOREIGN KEY (MaNhanVien) REFERENCES tb_NhanVien(MaNhanVien),
	FOREIGN KEY (MaKhachHang) REFERENCES tb_KhachHang(MaKhachHang),
	FOREIGN KEY (MaLaiXe) REFERENCES tb_LaiXe(MaLaiXe),
	FOREIGN KEY (MaXe) REFERENCES tb_Xe(MaXe)
)
CREATE TABLE tb_PhieuTra(
	MaNV nvarchar(10) primary key NOT NULL,
	MaKH nvarchar(10) NOT NULL,
	MaHD nvarchar(10) NOT NULL,
	NgayLapHD date NOT NULL,
	NgayTraHD date NOT NULL,
	TienThanhToan money NOT NULL,
	TinhTrang bit NULL,
	GhiChu nvarchar(50) NULL,
	FOREIGN KEY (MaNV) REFERENCES tb_NhanVien(MaNhanVien),
	FOREIGN KEY (MaKH) REFERENCES tb_KhachHang(MaKhachHang),
	FOREIGN KEY (MaHD) REFERENCES tb_HopDong(MaHopDong)
)


CREATE TABLE tb_ChiTietPhieuTra(
	MaChiTietPhieuTra nvarchar(10) primary key NOT NULL,
	MaHopDong nvarchar(10) NOT NULL,
	MaLaiXe nvarchar(10) NULL,
	MaXe nvarchar(10) NOT NULL,
	NgayTraXeThucTe datetime NULL,
	TienTraXeMuonTheoNgay decimal(18, 0) NULL,
	TinhTrangHongHoc nvarchar(50) NULL,
	ChiPhiBoiThuong decimal(18, 0) NULL,
	TinhTrangTraXe bit NULL,
	FOREIGN KEY (MaHopDong) REFERENCES tb_HopDong(MaHopDong),
	FOREIGN KEY (MaLaiXe) REFERENCES tb_LaiXe(MaLaiXe),
	FOREIGN KEY (MaXe) REFERENCES tb_Xe(MaXe)
)
CREATE TABLE tb_ChiTietHopDong(
	MaChiTietHopDong nvarchar(10) primary key NOT NULL,
	MaHopDong nvarchar(10) NOT NULL,
	MaXe nvarchar(10) NOT NULL ,
	TinhTrangLaiXe bit NULL,
	MaLaiXe nvarchar(10) NULL,
	TinhTrangHD bit NULL,
	HanTraXe datetime NULL,
	TienThueXe decimal(18, 0) NULL,
	TienDatCoc decimal(18, 0) NULL,
	SoTienConNo decimal(18, 0) NULL,
	FOREIGN KEY (MaXe) REFERENCES tb_Xe(MaXe),
	FOREIGN KEY (MaLaiXe) REFERENCES tb_LaiXe(MaLaiXe),
	FOREIGN KEY (MaHopDong) REFERENCES tb_HopDong(MaHopDong)
)
insert into tb_Login values('admin','admin','admin');
insert into tb_role values('CV001','admin'),('CV002',N'Nhân Viên');
