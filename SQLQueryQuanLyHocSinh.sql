CREATE DATABASE QuanLyHocSinh 
USE QuanLyHocSinh
GO

--DROP DATABASE QuanLyHocSinh

---------------------------Tạo bảng---------------------------
GO
CREATE TABLE HOC_SINH
(
	MaHocSinh nvarchar(50),
	HoTen nvarchar(50),
	GioiTinh bit,
	NgaySinh date,
	NoiSinh nvarchar(50),
	DiaChi nvarchar(50),
	DanToc nvarchar(50),
	TonGiao nvarchar(50),
	TenNguoiThan nvarchar(50),
	PRIMARY KEY(MaHocSinh)
);

CREATE TABLE PHAN_CONG
(
	MaPhanCong nvarchar(50),
	MaGiaoVienLop nvarchar(50),
	MaMonHoc nvarchar(50),
	PRIMARY KEY(MaPhanCong)
);

CREATE TABLE DIEM
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaMonHoc nvarchar(50),
	MaHocSinhLop nvarchar(50),
	MaHocKi nvarchar(50),
	MaNamHoc nvarchar(50),
	MaLoai nvarchar(50),
	Diem float,
	
);

CREATE TABLE NGUOI_DUNG
(
	MaNguoiDung nvarchar(50),
	MatKhau nvarchar(50),
	LoaiNguoiDung int,
	PRIMARY KEY(MaNguoiDung)
	
);

CREATE TABLE LOAI_NGUOI_DUNG
(
	MaLoaiNguoiDung int,
	TenLoaiNguoiDung nvarchar(50),
	PRIMARY KEY(MaLoaiNguoiDung)
	
);

CREATE TABLE KHOI_LOP
(
	MaKhoiLop nvarchar(50),
	TenKhoiLop nvarchar(50),
	PRIMARY KEY (MaKhoiLop)
	
);

CREATE TABLE KQ_NAM_HOC
(
	MaHocSinhLop nvarchar(50),
	MaHocLuc nvarchar(50),
	MaHanhKiem nvarchar(50),
	MaNamHoc nvarchar(50),
	DTBCaNam float,
	PRIMARY KEY (MaHocSinhLop,MaNamHoc)
	
);

CREATE TABLE GIAO_VIEN_LOP
(
	MaGiaoVienLop nvarchar(50),
	MaGiaoVien nvarchar(50),
	MaLop nvarchar(50),
	PRIMARY KEY(MaGiaoVienLop)
	
);

CREATE TABLE KQ_HOC_KY
(
	MaHocSinhLop nvarchar(50),
	MaHocKi nvarchar(50),
	MaNamHoc nvarchar(50),
	MaHocLuc nvarchar(50),
	MaHanhKiem nvarchar(50),
	DTBHK float,
	PRIMARY KEY(MaHocSinhLop,MaHocKi,MaNamHoc)
	
);

CREATE TABLE LOAI_DIEM
(
	MaLoai nvarchar(50),
	TenLoai nvarchar(50),
	HeSo int,
	PRIMARY KEY(MaLoai)
	
);

CREATE TABLE NAM_HOC
(
	MaNamHoc nvarchar(50),
	TenNamHoc nvarchar(50),
	PRIMARY KEY(MaNamHoc)
	
);

CREATE TABLE GIAO_VIEN
(
	MaGiaoVien nvarchar(50),
	HoTen nvarchar(50),
	GioiTinh bit,
	NgaySinh date,
	NoiSinh nvarchar(50),
	DiaChi nvarchar(50),
	DienThoai nvarchar(50),
	PRIMARY KEY(MaGiaoVien)
);

CREATE TABLE LOP
(
	MaLop nvarchar(50),
	TenLop nvarchar(50),
	MaKhoiLop nvarchar(50),
	MaNamHoc nvarchar(50),
	SiSo int,
	MaGiaoVienCN nvarchar(50),
	PRIMARY KEY(MaLop)
);

CREATE TABLE HOC_LUC
(
	MaHocLuc nvarchar(50),
	TenHocLuc nvarchar(50),
	PRIMARY KEY(MaHocLuc)
);

CREATE TABLE HOC_KY
(
	MaHocKi nvarchar(50),
	TenHocKi nvarchar(50),
	PRIMARY KEY(MaHocKi)
);

CREATE TABLE KQ_MON_HOC
(
	MaHocSinhLop nvarchar(50),
	MaMonHoc nvarchar(50),
	MaHocKi nvarchar(50),
	MaNamHoc nvarchar(50),
	DTBMonHoc float,
	PRIMARY KEY(MaHocSinhLop,MaMonHoc,MaHocKi,MaNamHoc)
);

CREATE TABLE HOC_SINH_LOP
(
	MaHocSinhLop nvarchar(50),
	MaHocSinh nvarchar(50),
	MaLop nvarchar(50),
	PRIMARY KEY(MaHocSinhLop)
);

CREATE TABLE HANH_KIEM
(
	MaHanhKiem nvarchar(50),
	TenHanhKiem nvarchar(50),
	PRIMARY KEY(MaHanhKiem)
);

CREATE TABLE MON_HOC
(
	MaMonHoc nvarchar(50),
	TenMonHoc nvarchar(50),
	SoTiet int,
	HeSo int,
	PRIMARY KEY(MaMonHoc)
);


-----------------------Khóa Ngoại------------------------
 ALTER TABLE HOC_SINH_LOP ADD FOREIGN KEY (MaHocSinh) REFERENCES HOC_SINH(MaHocSinh);
 ALTER TABLE HOC_SINH_LOP ADD FOREIGN KEY (MaLop) REFERENCES LOP(MaLop);
 ALTER TABLE NGUOI_DUNG ADD FOREIGN KEY (LoaiNguoiDung) REFERENCES LOAI_NGUOI_DUNG(MaLoaiNguoiDung);
 ALTER TABLE GIAO_VIEN_LOP ADD FOREIGN KEY (MaGiaoVien) REFERENCES GIAO_VIEN(MaGiaoVien);
 ALTER TABLE GIAO_VIEN_LOP ADD FOREIGN KEY (MaLop) REFERENCES LOP(MaLop);
 ALTER TABLE PHAN_CONG  ADD FOREIGN KEY (MaGiaoVienLop) REFERENCES GIAO_VIEN_LOP(MaGiaoVienLop);
 ALTER TABLE PHAN_CONG ADD FOREIGN KEY (MaMonHoc) REFERENCES MON_HOC(MaMonHoc);
 ALTER TABLE LOP ADD FOREIGN KEY (MaKhoiLop) REFERENCES KHOI_LOP(MaKhoiLop);
 ALTER TABLE LOP ADD FOREIGN KEY (MaGiaoVienCN) REFERENCES GIAO_VIEN (MaGiaoVien);
 ALTER TABLE LOP ADD FOREIGN KEY (MaNamHoc) REFERENCES NAM_HOC (MaNamHoc);
 ALTER TABLE KQ_MON_HOC ADD FOREIGN KEY (MaMonHoc) REFERENCES MON_HOC(MaMonHoc);
 ALTER TABLE KQ_MON_HOC  ADD FOREIGN KEY (MaHocSinhLop) REFERENCES HOC_SINH_LOP (MaHocSinhLop);
 ALTER TABLE KQ_MON_HOC  ADD FOREIGN KEY (MaHocKi) REFERENCES HOC_KY(MaHocKi);
 ALTER TABLE DIEM ADD FOREIGN KEY (MaHocKi) REFERENCES HOC_KY(MaHocKi);
 ALTER TABLE DIEM ADD FOREIGN KEY (MaLoai) REFERENCES LOAI_DIEM(MaLoai);
 ALTER TABLE DIEM ADD FOREIGN KEY (MaHocSinhLop) REFERENCES HOC_SINH_LOP (MaHocSinhLop);
 ALTER TABLE DIEM ADD FOREIGN KEY (MaMonHoc) REFERENCES MON_HOC (MaMonHoc);
 ALTER TABLE KQ_HOC_KY ADD FOREIGN KEY (MaHocKi) REFERENCES HOC_KY(MaHocKi);
 ALTER TABLE KQ_HOC_KY ADD FOREIGN KEY (MaNamHoc) REFERENCES NAM_HOC(MaNamHoc);
 ALTER TABLE KQ_HOC_KY  ADD FOREIGN KEY (MaHocLuc) REFERENCES HOC_LUC(MaHocLuc);
 ALTER TABLE KQ_HOC_KY ADD FOREIGN KEY (MaHanhKiem) REFERENCES HANH_KIEM (MaHanhKiem);
 ALTER TABLE KQ_HOC_KY ADD FOREIGN KEY (MaHocSinhLop) REFERENCES HOC_SINH_LOP(MaHocSinhLop);
 ALTER TABLE KQ_NAM_HOC  ADD FOREIGN KEY (MaHocLuc) REFERENCES HOC_LUC(MaHocLuc);
 ALTER TABLE KQ_NAM_HOC ADD FOREIGN KEY (MaHanhKiem) REFERENCES HANH_KIEM (MaHanhKiem);
 ALTER TABLE KQ_NAM_HOC ADD FOREIGN KEY (MaHocSinhLop) REFERENCES HOC_SINH_LOP(MaHocSinhLop);
 ALTER TABLE KQ_NAM_HOC ADD FOREIGN KEY (MaNamHoc) REFERENCES NAM_HOC(MaNamHoc);



 ----------------------Nhập liệu--------------------------
 INSERT INTO LOAI_NGUOI_DUNG (MaLoaiNguoiDung, TenLoaiNguoiDung) VALUES
    (1, N'Admin tổng'), 
    (2, N'Người dùng sinh viên'),
	(3, N'Người dùng giáo viên');

  INSERT INTO  HANH_KIEM (MaHanhKiem,TenHanhKiem) VALUES
    (N'Y', N'Yếu'), 
    (N'TB', N'Trung Bình'),
	(N'K', N'Khá'),
	(N'T', N'Tốt');

  INSERT INTO  HOC_LUC (MaHocLuc,TenHocLuc) VALUES
    (N'Y', N'Yếu'), 
    (N'TB', N'Trung Bình'),
	(N'K', N'Khá'),
	(N'G', N'Giỏi');

 INSERT INTO  NAM_HOC(MaNamHoc,TenNamHoc) VALUES
    (N'017', N'2017'),
	(N'018', N'2018'),
	(N'019', N'2019');

 INSERT INTO  HOC_KY (MaHocKi,TenHocKi) VALUES
    (N'1', N'Học kỳ I'), 
    (N'2', N'Học kỳ II')
	 
 INSERT INTO  KHOI_LOP(MaKhoiLop,TenKhoiLop) VALUES
    (N'K10', N'Khối lớp 10'), 
    (N'K11', N'Khối lớp 11'),
	(N'K12', N'Khối lớp 12');

 INSERT INTO  MON_HOC(MaMonHoc,TenMonHoc,SoTiet, HeSo) VALUES
    (N'TO', N'Toán',45,3), 
    (N'VA', N'Văn',45,3),
	(N'LI', N'Vật Lí',45,3),
	(N'HO', N'Hóa',45,3),
	(N'TA',N'Tiếng Anh',45,1);

 INSERT INTO  LOAI_DIEM(MaLoai,TenLoai,HeSo) VALUES
    (N'Miệng', N'Điểm kiểm tra miệng', 1), 
    (N'15', N'Điểm kiểm tra 15 phút', 1), 
    (N'1T', N'Điểm kiểm tra 1 Tiết',2),
	(N'HK', N'Điểm kiểm tra học kì',3);
	
 INSERT INTO GIAO_VIEN (MaGiaoVien,	HoTen, GioiTinh, NgaySinh, NoiSinh, DiaChi, DienThoai) VALUES
    (N'T011001', N'Trương Tấn Sang', 1,'1989-01-26', N'Kiên Giang', N'182 Lương Định Của', N'0984833673'), 
    (N'T008002', N'Hồ Thị Lan', 0,'1979-01-26', N'Hà Giang', N'178 Nguyễn Trãi', N'0983833673');

 INSERT INTO  LOP (MaLop,TenLop,MaKhoiLop,MaNamHoc,SiSo,MaGiaoVienCN) VALUES
    (N'K12A1', N'Lớp 12A1',N'K12',N'019',35,N'T011001'), 
    (N'K11A2', N'Lớp 11A2',N'K11',N'019',35,N'T008002')
	--
 INSERT INTO HOC_SINH (MaHocSinh, HoTen, GioiTinh, NgaySinh, NoiSinh, DiaChi, DanToc, TonGiao, TenNguoiThan) VALUES
    (N'S017001', N'Hoàng Gia An', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S018002', N'Huỳnh Gia Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt');
	
 INSERT INTO  HOC_SINH_LOP (MaHocSinhLop,MaHocSinh,MaLop) VALUES
    (N'S12A101', N'S017001',N'K12A1'), 
    (N'S11A201', N'S018002',N'K11A2');

INSERT INTO  GIAO_VIEN_LOP (MaGiaoVienLop,MaGiaoVien,MaLop) VALUES
    (N'T12A101', N'T011001',N'K12A1'), 
    (N'T11A201', N'T008002',N'K11A2');

 INSERT INTO  PHAN_CONG (MaPhanCong,MaGiaoVienLop,MaMonHoc) VALUES
    (N'P12A1T1', N'T12A101',N'TO'), 
    (N'P11A2T1', N'T11A201',N'TA');

 INSERT INTO  NGUOI_DUNG(MaNguoiDung,MatKhau, LoaiNguoiDung) VALUES
    (N'Admin', N'1', 1), 
	(N'S017001', N'1', 2),
	(N'S018002', N'1', 2), 
    (N'T011001', N'1', 3),
	(N'T008002', N'1', 3);

	-- Học sinh có mã số S017001 là học sinh lớp 12
	-- Học sinh có mã số S018001 là học sinh lớp 11
INSERT INTO  DIEM(MaMonHoc, MaHocSinhLop, MaHocKi, MaNamHoc, MaLoai, Diem) VALUES
	--Điểm của học sinh có mã số S017001 vào năm học 2017, lớp 10, học kỳ 1
    (N'TO', N'S12A101',N'1',N'017',N'Miệng',9.5), 
	(N'TO', N'S12A101',N'1',N'017',N'15',7), 
	(N'TO', N'S12A101',N'1',N'017',N'1T',10), 
	(N'TO', N'S12A101',N'1',N'017',N'HK',9.5),
	(N'HO', N'S12A101',N'1',N'017',N'Miệng',5.5), 
	(N'HO', N'S12A101',N'1',N'017',N'15',7), 
	(N'HO', N'S12A101',N'1',N'017',N'1T',10), 
	(N'HO', N'S12A101',N'1',N'017',N'HK',9.5),
	(N'TA', N'S12A101',N'1',N'017',N'Miệng',9), 
	(N'TA', N'S12A101',N'1',N'017',N'15',7), 
	(N'TA', N'S12A101',N'1',N'017',N'1T',10), 
	(N'TA', N'S12A101',N'1',N'017',N'HK',6),
	(N'LI', N'S12A101',N'1',N'017',N'Miệng',9.5), 
	(N'LI', N'S12A101',N'1',N'017',N'15',7), 
	(N'LI', N'S12A101',N'1',N'017',N'1T',6), 
	(N'LI', N'S12A101',N'1',N'017',N'HK',9.5),
	(N'VA', N'S12A101',N'1',N'017',N'Miệng',5), 
	(N'VA', N'S12A101',N'1',N'017',N'15',4), 
	(N'VA', N'S12A101',N'1',N'017',N'1T',1), 
	(N'VA', N'S12A101',N'1',N'017',N'HK',5),
	--Điểm của học sinh có mã số S017001 vào năm học 2017, lớp 10, học kỳ 2
	(N'TO', N'S12A101',N'2',N'017',N'Miệng',5), 
	(N'TO', N'S12A101',N'2',N'017',N'15',9), 
	(N'TO', N'S12A101',N'2',N'017',N'1T',10), 
	(N'TO', N'S12A101',N'2',N'017',N'HK',5),
	(N'HO', N'S12A101',N'2',N'017',N'Miệng',7), 
	(N'HO', N'S12A101',N'2',N'017',N'15',7.5), 
	(N'HO', N'S12A101',N'2',N'017',N'1T',10), 
	(N'HO', N'S12A101',N'2',N'017',N'HK',9),
	(N'TA', N'S12A101',N'2',N'017',N'Miệng',9), 
	(N'TA', N'S12A101',N'2',N'017',N'15',9), 
	(N'TA', N'S12A101',N'2',N'017',N'1T',10), 
	(N'TA', N'S12A101',N'2',N'017',N'HK',2),
	(N'LI', N'S12A101',N'2',N'017',N'Miệng',5.5), 
	(N'LI', N'S12A101',N'2',N'017',N'15',7), 
	(N'LI', N'S12A101',N'2',N'017',N'1T',6), 
	(N'LI', N'S12A101',N'2',N'017',N'HK',5),
	(N'VA', N'S12A101',N'2',N'017',N'Miệng',10), 
	(N'VA', N'S12A101',N'2',N'017',N'15',10), 
	(N'VA', N'S12A101',N'2',N'017',N'1T',1), 
	(N'VA', N'S12A101',N'2',N'017',N'HK',6),
	--Điểm của học sinh có mã số S017001 vào năm học 2018, lớp 11, học kỳ 2
	(N'TO', N'S12A101',N'2',N'018',N'Miệng',5), 
	(N'TO', N'S12A101',N'2',N'018',N'15',7), 
	(N'TO', N'S12A101',N'2',N'018',N'1T',1), 
	(N'TO', N'S12A101',N'2',N'018',N'HK',9.5),
	(N'HO', N'S12A101',N'2',N'018',N'Miệng',5), 
	(N'HO', N'S12A101',N'2',N'018',N'15',7.5), 
	(N'HO', N'S12A101',N'2',N'018',N'1T',10), 
	(N'HO', N'S12A101',N'2',N'018',N'HK',5),
	(N'TA', N'S12A101',N'2',N'018',N'Miệng',9.5), 
	(N'TA', N'S12A101',N'2',N'018',N'15',7.5), 
	(N'TA', N'S12A101',N'2',N'018',N'1T',10), 
	(N'TA', N'S12A101',N'2',N'018',N'HK',6),
	(N'LI', N'S12A101',N'2',N'018',N'Miệng',5), 
	(N'LI', N'S12A101',N'2',N'018',N'15',9), 
	(N'LI', N'S12A101',N'2',N'018',N'1T',6), 
	(N'LI', N'S12A101',N'2',N'018',N'HK',5),
	(N'VA', N'S12A101',N'2',N'018',N'Miệng',5), 
	(N'VA', N'S12A101',N'2',N'018',N'15',4.5), 
	(N'VA', N'S12A101',N'2',N'018',N'1T',4), 
	(N'VA', N'S12A101',N'2',N'018',N'HK',10),
	--Điểm của học sinh có mã số S017001 vào năm học 2019, lớp 12, học kỳ 1
    (N'TO', N'S12A101',N'1',N'019',N'Miệng',9), 
	(N'TO', N'S12A101',N'1',N'019',N'15',7), 
	(N'TO', N'S12A101',N'1',N'019',N'1T',1), 
	(N'TO', N'S12A101',N'1',N'019',N'HK',9),
	(N'HO', N'S12A101',N'1',N'019',N'Miệng',9.5), 
	(N'HO', N'S12A101',N'1',N'019',N'15',7.5), 
	(N'HO', N'S12A101',N'1',N'019',N'1T',6), 
	(N'HO', N'S12A101',N'1',N'019',N'HK',9.5),
	(N'TA', N'S12A101',N'1',N'019',N'Miệng',9), 
	(N'TA', N'S12A101',N'1',N'019',N'15',7), 
	(N'TA', N'S12A101',N'1',N'019',N'1T',2), 
	(N'TA', N'S12A101',N'1',N'019',N'HK',8),
	(N'LI', N'S12A101',N'1',N'019',N'Miệng',9), 
	(N'LI', N'S12A101',N'1',N'019',N'15',7), 
	(N'LI', N'S12A101',N'1',N'019',N'1T',6), 
	(N'LI', N'S12A101',N'1',N'019',N'HK',9),
	(N'VA', N'S12A101',N'1',N'019',N'Miệng',5), 
	(N'VA', N'S12A101',N'1',N'019',N'15',4.5), 
	(N'VA', N'S12A101',N'1',N'019',N'1T',7), 
	(N'VA', N'S12A101',N'1',N'019',N'HK',9),

	--Điểm của học sinh có mã số S018001 vào năm học 2018, lớp 10, học kỳ 1
	(N'TO', N'S11A201',N'1',N'018',N'Miệng',5), 
	(N'TO', N'S11A201',N'1',N'018',N'15',8), 
	(N'TO', N'S11A201',N'1',N'018',N'1T',10), 
	(N'TO', N'S11A201',N'1',N'018',N'HK',7),
	(N'HO', N'S11A201',N'1',N'018',N'Miệng',4), 
	(N'HO', N'S11A201',N'1',N'018',N'15',8), 
	(N'HO', N'S11A201',N'1',N'018',N'1T',10), 
	(N'HO', N'S11A201',N'1',N'018',N'HK',9.5),
	(N'TA', N'S11A201',N'1',N'018',N'Miệng',10), 
	(N'TA', N'S11A201',N'1',N'018',N'15',7.5), 
	(N'TA', N'S11A201',N'1',N'018',N'1T',1), 
	(N'TA', N'S11A201',N'1',N'018',N'HK',6),
	(N'LI', N'S11A201',N'1',N'018',N'Miệng',3), 
	(N'LI', N'S11A201',N'1',N'018',N'15',7), 
	(N'LI', N'S11A201',N'1',N'018',N'1T',5), 
	(N'LI', N'S11A201',N'1',N'018',N'HK',9),
	(N'VA', N'S11A201',N'1',N'018',N'Miệng',5.5), 
	(N'VA', N'S11A201',N'1',N'018',N'15',4), 
	(N'VA', N'S11A201',N'1',N'018',N'1T',9), 
	(N'VA', N'S11A201',N'1',N'018',N'HK',5.5),
    --Điểm của học sinh có mã số S018001 vào năm học 2018, lớp 10, học kỳ 2
	(N'TO', N'S11A201',N'2',N'018',N'Miệng',5), 
	(N'TO', N'S11A201',N'2',N'018',N'15',6.5), 
	(N'TO', N'S11A201',N'2',N'018',N'1T',10), 
	(N'TO', N'S11A201',N'2',N'018',N'HK',10),
	(N'HO', N'S11A201',N'2',N'018',N'Miệng',5), 
	(N'HO', N'S11A201',N'2',N'018',N'15',8), 
	(N'HO', N'S11A201',N'2',N'018',N'1T',1), 
	(N'HO', N'S11A201',N'2',N'018',N'HK',9),
	(N'TA', N'S11A201',N'2',N'018',N'Miệng',10), 
	(N'TA', N'S11A201',N'2',N'018',N'15',7), 
	(N'TA', N'S11A201',N'2',N'018',N'1T',1), 
	(N'TA', N'S11A201',N'2',N'018',N'HK',6),
	(N'LI', N'S11A201',N'2',N'018',N'Miệng',9), 
	(N'LI', N'S11A201',N'2',N'018',N'15',7.5), 
	(N'LI', N'S11A201',N'2',N'018',N'1T',6.5), 
	(N'LI', N'S11A201',N'2',N'018',N'HK',9.5),
	(N'VA', N'S11A201',N'2',N'018',N'Miệng',5), 
	(N'VA', N'S11A201',N'2',N'018',N'15',4), 
	(N'VA', N'S11A201',N'2',N'018',N'1T',9), 
	(N'VA', N'S11A201',N'2',N'018',N'HK',10),
	--Điểm của học sinh có mã số S018001 vào năm học 2019, lớp 11, học kỳ 1
	(N'TO', N'S11A201',N'1',N'019',N'Miệng',5), 
	(N'TO', N'S11A201',N'1',N'019',N'15',8), 
	(N'TO', N'S11A201',N'1',N'019',N'1T',10), 
	(N'TO', N'S11A201',N'1',N'019',N'HK',10),
	(N'HO', N'S11A201',N'1',N'019',N'Miệng',10), 
	(N'HO', N'S11A201',N'1',N'019',N'15',8), 
	(N'HO', N'S11A201',N'1',N'019',N'1T',3), 
	(N'HO', N'S11A201',N'1',N'019',N'HK',9),
	(N'TA', N'S11A201',N'1',N'019',N'Miệng',10), 
	(N'TA', N'S11A201',N'1',N'019',N'15',7), 
	(N'TA', N'S11A201',N'1',N'019',N'1T',1), 
	(N'TA', N'S11A201',N'1',N'019',N'HK',2),
	(N'LI', N'S11A201',N'1',N'019',N'Miệng',3), 
	(N'LI', N'S11A201',N'1',N'019',N'15',3), 
	(N'LI', N'S11A201',N'1',N'019',N'1T',5), 
	(N'LI', N'S11A201',N'1',N'019',N'HK',5),
	(N'VA', N'S11A201',N'1',N'019',N'Miệng',5), 
	(N'VA', N'S11A201',N'1',N'019',N'15',4.5), 
	(N'VA', N'S11A201',N'1',N'019',N'1T',10), 
	(N'VA', N'S11A201',N'1',N'019',N'HK',5)

INSERT INTO  KQ_MON_HOC(MaHocSinhLop, MaMonHoc, MaHocKi, MaNamHoc,DTBMonHoc) VALUES
	('S12A101', 'TO', '1', '017', 7.5),
	('S12A101', 'HO', '1', '017', 8.5),
	('S12A101', 'TA', '1', '017', 7),
	('S12A101', 'LI', '1', '017', 6),
	('S12A101', 'VA', '1', '017', 8.1),
	('S12A101', 'TO', '2', '017', 5),
	('S12A101', 'HO', '2', '017', 8),
	('S12A101', 'TA', '2', '017', 7.3),
	('S12A101', 'LI', '2', '017', 6),
	('S12A101', 'VA', '2', '017', 8),
	('S12A101', 'TO', '2', '018', 8.6),
	('S12A101', 'HO', '2', '018', 6.5),
	('S12A101', 'TA', '2', '018', 7.5),
	('S12A101', 'LI', '2', '018', 7.3),
	('S12A101', 'VA', '2', '018', 8),
	('S12A101', 'TO', '1', '019', 5),
	('S12A101', 'HO', '1', '019', 8),
	('S12A101', 'TA', '1', '019', 7),
	('S12A101', 'LI', '1', '019', 6),
	('S12A101', 'VA', '1', '019', 8.9),

	('S11A201', 'TO', '1', '018', 7),
	('S11A201', 'HO', '1', '018', 6.5),
	('S11A201', 'TA', '1', '018', 7.2),
	('S11A201', 'LI', '1', '018', 6),
	('S11A201', 'VA', '1', '018', 8),	
	('S11A201', 'TO', '2', '018', 7.8),
	('S11A201', 'HO', '2', '018', 5),
	('S11A201', 'TA', '2', '018', 7),
	('S11A201', 'LI', '2', '018', 6),
	('S11A201', 'VA', '2', '018', 8),
	('S11A201', 'TO', '1', '019', 8.5),
	('S11A201', 'HO', '1', '019', 7.2),
	('S11A201', 'TA', '1', '019', 7.5),
	('S11A201', 'LI', '1', '019', 6.4),
	('S11A201', 'VA', '1', '019', 8.4)

INSERT INTO  KQ_HOC_KY(MaHocSinhLop, MaHocKi, MaNamHoc, MaHocLuc, MaHanhKiem, DTBHK) VALUES
	('S12A101', '1', '017', 'K', 'T', 7.4),
	('S12A101', '2', '017', 'K', 'T', 7.9),
	('S12A101', '2', '018', 'G', 'T', 8.4),
	('S12A101', '1', '019', 'K', 'T', 7),

	('S11A201', '1', '018', 'G', 'T', 9.4),
	('S11A201', '2', '018', 'K', 'T', 7),
	('S11A201', '1', '019', 'TB', 'T', 6.4)

INSERT INTO  KQ_NAM_HOC(MaHocSinhLop, MaHocLuc, MaHanhKiem, MaNamHoc,DTBCaNam) VALUES
	('S12A101', 'G', 'T', '017', 8),
	('S12A101', 'TB', 'T', '018', 6),

	('S11A201', 'K', 'T', '018', 7.3)

-------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------Truy vấn-----------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------

--Truy vấn lấy thông tin học sinh ra để load vào table tại fStudentInformation với thông tin đầy đủ
GO
CREATE PROC	usp_GetStudentInformationByStudentCode @MaHocSinh varchar(50)
AS
BEGIN
	SELECT *
	FROM HOC_SINH
	WHERE MaHocSinh=@MaHocSinh
END


--Truy vấn lấy điểm của học sinh dựa vào mã học sinh, mã học kỳ và mã năm học
GO
CREATE PROC	usp_GetStudentPoint @MaHocSinh nvarchar(50), @MaHocKi nvarchar(50), @MaNamHoc nvarchar(50)
AS
BEGIN
	SELECT D.Diem, MH.TenMonHoc, KQMH.DTBMonHoc, KQHK.DTBHK, D.MaLoai
	FROM DIEM D, HOC_SINH_LOP HSL, MON_HOC MH, KQ_MON_HOC KQMH, KQ_HOC_KY KQHK
	WHERE HSL.MaHocSinh = @MaHocSinh AND D.MaHocKi = @MaHocKi AND D.MaNamHoc = @MaNamHoc AND D.MaHocSinhLop = HSL.MaHocSinhLop
		AND MH.MaMonHoc = D.MaMonHoc AND D.MaHocSinhLop = KQMH.MaHocSinhLop AND D.MaMonHoc = KQMH.MaMonHoc
		AND D.MaHocKi = KQMH.MaHocKi AND D.MaNamHoc = KQMH.MaNamHoc AND D.MaHocSinhLop = KQHK.MaHocSinhLop
		AND D.MaHocKi = KQHK.MaHocKi AND D.MaNamHoc = KQHK.MaNamHoc
END


--Thay đổi thông tin cá nhân học sinh
CREATE PROC usp_UpdateStudentInformation
@MaHocSinh nvarchar(50), @HoTen nvarchar(50), @GioiTinh bit,
@NgaySinh date, @QueQuan nvarchar(50), @DiaChi nvarchar(50),
@DanToc nvarchar(50), @TonGiao nvarchar(50), @NguoiThan nvarchar(50)
AS
BEGIN
	UPDATE HOC_SINH SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, NoiSinh = @QueQuan, DiaChi = @DiaChi, DanToc = @DanToc, TonGiao = @TonGiao, TenNguoiThan = @NguoiThan WHERE MaHocSinh = @MaHocSinh
END
