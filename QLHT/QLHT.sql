CREATE TABLE NganhHoc
(
	MaNganh varchar(6) NOT NULL PRIMARY KEY,
	TenNganh vargraphic(40) NOT NULL
);
CREATE TABLE LopHoc
(
	MaLop varchar(8) NOT NULL PRIMARY KEY,
	TenLop vargraphic (40)
);
CREATE TABLE MonHoc
(
	MaMH varchar(6) NOT NULL PRIMARY KEY,
	TenMH vargraphic (40) NOT NULL,
	SoDVHT smallint
);

CREATE TABLE SinhVien
(
	MaSV vargraphic(7) NOT NULL PRIMARY KEY,
	HoSV vargraphic(30) NOT NULL,
	TenSV vargraphic(10) NOT NULL,
	MatKhau vargraphic(30) NOT NULL,
	AnhSV vargraphic(30),
	NgaySinh date,
	GioiTinh smallint,
	NoiSinh vargraphic(20),
	Email vargraphic(30),
	MaNganh varchar(6) NOT NULL FOREIGN1 REFERENCES NganhHoc(MaNganh) ON DELETE CASCADE,
	MaLop varchar(8) NOT NULL FOREIGN2 REFERENCES LopHoc(MaLop) ON DELETE CASCADE
);
CREATE TABLE KetQua
(
	MaSV vargraphic(7) NOT NULL FOREIGN1 REFERENCES SinhVien(MaSV) ON DELETE CASCADE,
	MaMH varchar(8) NOT NULL FOREIGN2 REFERENCES MonHoc(MaMH) ON DELETE CASCADE,
	DiemKT float,
	DiemThi  float,
	CONSTRAINT PK PRIMARY KEY(MaSV,MaMH)
);

CREATE TABLE QuanTri(TenDN varchar(40) NOT NULL PRIMARY KEY, MatKhau varchar(40) NOT NULL,HoTen vargraphic(40) NOT NULL, Admin smallint);

CREATE TABLE MenuHeThong(Id int NOT NULL PRIMARY KEY, Menu vargraphic(40) NOT NULL, LinkWeb varchar(40));

INSERT INTO NganhHoc VALUES('DCNTT','Đại học Công nghệ thông tin'),('DVT','Đại học Điện tử - Viễn thông');
INSERT INTO LopHoc VALUES('DHCN1A','Đại học Công nghệ 1A'),('DHCN1B','Đại học Công nghệ 1B'),
						('DHCN1C','Đại học Công nghệ 1C');
INSERT INTO MonHoc VALUES('4210','Lập trình C#',4),('4303','Phát triển ứng dụng mạng và CSDL',4);
INSERT INTO MonHoc VALUES('4208','Lập trình Java',4),('4305','Phát triển phần mềm mã nguồn mở',4);
INSERT INTO MonHoc VALUES('4217','Quản lý dự án CNTT',4),('4308','Triển khai bảo trì hệ thống mạng',4);
INSERT INTO MonHoc VALUES('2306','Lý thuyết thông tin',3),('4204','Cơ sở dữ liệu',4);
INSERT INTO MonHoc VALUES('4203','Cấu trúc dữ liệu và giải thuật',4),('4301','Mạng máy tính',4);
INSERT INTO MonHoc VALUES('4209','Lập trình hướng đối tượng',4),('1301','Tiếng Anh cơ bản (Phần 4)',15);
INSERT INTO SinhVien VALUES('14DC001','Vũ Ngọc','An','123','DHNT.png','1996-01-01',1,'Khánh Hoà','vungocan@gmail.com','DCNTT','DHCN1A'),
							('14DC104','Ngô Mậu','Bảo','123','YenSao.png','1996-2-2',1,'Khánh Hoà','ngomaubao@gmail.com','DCNTT','DHCN1B'),
							('14DC004','Nguyễn Văn','Cảnh','123','14ĐC004',NULL,1,NULL,NULL,'DCNTT','DHCN1C');
INSERT INTO SinhVien VALUES('14DC002','Thái Quốc','Anh','123','DHNT.png','1996-01-01',1,'Khánh Hoà','thaiquocanh@gmail.com','DCNTT','DHCN1A');							
INSERT INTO KetQua VALUES('14DC001','4210',5,6),('14DC001','4303',7.5,8);
INSERT INTO KetQua VALUES('14DC001','4208',7,8),('14DC001','4305',7.5,8);
INSERT INTO KetQua VALUES('14DC001','4217',7,7),('14DC001','4308',8,8);
INSERT INTO KetQua VALUES('14DC001','2306',6,7),('14DC001','4204',9,8);
INSERT INTO KetQua VALUES('14DC001','4203',7,8),('14DC001','4301',8,8);
INSERT INTO KetQua VALUES('14DC001','4209',NULL,NULL),('14DC001','1301',NULL,NULL);
INSERT INTO MenuHeThong VALUES(1,'Ngành học','NganhHoc.aspx'),(2,'Lớp học','LopHoc.aspx'),(3,'Môn học','MonHoc.aspx');
INSERT INTO MenuHeThong VALUES(4,'Sinh viên','SinhVien.aspx'),(5,'Nhập điểm từng sinh viên','KetQua.aspx'),(6,'Quản trị người dùng','QuanTri.aspx'),(7,'Nhập điểm theo môn học','NhapDiemMonHoc.aspx');
INSERT INTO MenuHeThong VALUES(8,'Danh sách SV theo lớp','DSSinhVienTheoLop.aspx'),(9,'Danh sách SV theo ngành','DSSinhVienTheoNganh.aspx');
INSERT INTO MenuHeThong VALUES(10,'Bảng điểm sinh viên','BangDiemSV.aspx'),(11,'Bảng điểm theo môn học','BangDiemMH.aspx');
INSERT INTO QuanTri VALUES('thanhbc','123','Bùi Chí Thành',1);