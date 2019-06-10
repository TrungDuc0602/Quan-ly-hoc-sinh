CREATE DATABASE QuanLyHocSinh 
USE QuanLyHocSinh
GO


--DROP TABLE QuanLyHocSinh

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

CREATE TABLE DAN_TOC
(
	MaDanToc nvarchar(50),
	TenDanToc nvarchar(50),
	PRIMARY KEY(MaDanToc)
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

CREATE TABLE TON_GIAO
(
	MaTonGiao nvarchar(50),
	TenTonGiao nvarchar(50),
	PRIMARY KEY(MaTonGiao)
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
 ALTER TABLE HOC_SINH ADD FOREIGN KEY (DanToc) REFERENCES DAN_TOC (MaDanToc);
 ALTER TABLE HOC_SINH ADD FOREIGN KEY (TonGiao) REFERENCES TON_GIAO(MaTonGiao) ;
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

  INSERT INTO DAN_TOC (MaDanToc,TenDanToc) VALUES
    (N'Kinh', N'Dân tộc Kinh'), 
    (N'Thái', N'Dân tộc Thái');

 INSERT INTO TON_GIAO (MaTonGiao,TenTonGiao) VALUES
    (N'Phật', N'Phật Giáo'), 
    (N'Chúa', N'Thiên Chúa Giáo'),
	(N'Không',N'Không có đạo'),
	(N'Khác',N'Theo đạo khác');

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
    (N'016', N'2016'), 
    (N'017', N'2017'),
	(N'018', N'2018'),
	(N'019', N'2019');

 INSERT INTO  HOC_KY (MaHocKi,TenHocKi) VALUES
    (N'1', N'I'), 
    (N'2', N'II'),
	(N'3', N'Hè');
	 
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
    (N'K10A1', N'Lớp 10A1',N'K10',N'016',35,N'T011001'), 
    (N'K10A2', N'Lớp 10A2',N'K10',N'016',35,N'T008002')
	--
 INSERT INTO HOC_SINH (MaHocSinh,	HoTen,GioiTinh,NgaySinh, NoiSinh, DiaChi,DanToc,TonGiao,TenNguoiThan) VALUES
    (N'S016001', N'Hoàng Gia An', 1,'2003-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S016002', N'Huỳnh Gia Nghi', 0, '2003-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt');
	
 INSERT INTO  HOC_SINH_LOP (MaHocSinhLop,MaHocSinh,MaLop) VALUES
    (N'S10A101', N'S016001',N'K10A1'), 
    (N'S10A201', N'S016002',N'K10A2');

INSERT INTO  GIAO_VIEN_LOP (MaGiaoVienLop,MaGiaoVien,MaLop) VALUES
    (N'T10A101', N'T011001',N'K10A1'), 
    (N'T10A201', N'T008002',N'K10A2');

 INSERT INTO  PHAN_CONG (MaPhanCong,MaGiaoVienLop,MaMonHoc) VALUES
    (N'P10A1T1', N'T10A101',N'TO'), 
    (N'P10A2T1', N'T10A201',N'TA');

 INSERT INTO  NGUOI_DUNG(MaNguoiDung,MatKhau, LoaiNguoiDung) VALUES
    (N'Admin', N'1', 1), 
	(N'S016001', N'1', 2),
	(N'S016002', N'1', 2), 
    (N'T011001', N'1', 3),
	(N'T008002', N'1', 3);

INSERT INTO  DIEM(MaMonHoc,MaHocSinhLop,MaHocKi,MaNamHoc,MaLoai,Diem) VALUES
    (N'TO', N'S10A101',N'1',N'016',N'15',9.5), 
	(N'TO', N'S10A101',N'1',N'016',N'1T',7), 
	(N'TO', N'S10A101',N'1',N'016',N'Miệng',10), 
	(N'TO', N'S10A101',N'1',N'016',N'HK',9.5),
	(N'HO', N'S10A101',N'1',N'016',N'15',5.5), 
	(N'HO', N'S10A101',N'1',N'016',N'1T',7), 
	(N'HO', N'S10A101',N'1',N'016',N'Miệng',10), 
	(N'HO', N'S10A101',N'1',N'016',N'HK',9.5),
	(N'TA', N'S10A101',N'1',N'016',N'15',9), 
	(N'TA', N'S10A101',N'1',N'016',N'1T',7), 
	(N'TA', N'S10A101',N'1',N'016',N'Miệng',10), 
	(N'TA', N'S10A101',N'1',N'016',N'HK',6),
	(N'LI', N'S10A101',N'1',N'016',N'15',9.5), 
	(N'LI', N'S10A101',N'1',N'016',N'1T',7), 
	(N'LI', N'S10A101',N'1',N'016',N'Miệng',6), 
	(N'LI', N'S10A101',N'1',N'016',N'HK',9.5),
	(N'VA', N'S10A101',N'1',N'016',N'15',5), 
	(N'VA', N'S10A101',N'1',N'016',N'1T',4), 
	(N'VA', N'S10A101',N'1',N'016',N'Miệng',1), 
	(N'VA', N'S10A101',N'1',N'016',N'HK',5),

	(N'TO', N'S10A201',N'1',N'016',N'15',4.5), 
	(N'TO', N'S10A201',N'1',N'016',N'1T',6), 
	(N'TO', N'S10A201',N'1',N'016',N'Miệng',10), 
	(N'TO', N'S10A201',N'1',N'016',N'HK',9),
	(N'HO', N'S10A201',N'1',N'016',N'15',5), 
	(N'HO', N'S10A201',N'1',N'016',N'1T',8), 
	(N'HO', N'S10A201',N'1',N'016',N'Miệng',10), 
	(N'HO', N'S10A201',N'1',N'016',N'HK',9),
	(N'TA', N'S10A201',N'1',N'016',N'15',1), 
	(N'TA', N'S10A201',N'1',N'016',N'1T',7), 
	(N'TA', N'S10A201',N'1',N'016',N'Miệng',1), 
	(N'TA', N'S10A201',N'1',N'016',N'HK',6),
	(N'LI', N'S10A201',N'1',N'016',N'15',3), 
	(N'LI', N'S10A201',N'1',N'016',N'1T',7), 
	(N'LI', N'S10A201',N'1',N'016',N'Miệng',6.5), 
	(N'LI', N'S10A201',N'1',N'016',N'HK',9.5),
	(N'VA', N'S10A201',N'1',N'016',N'15',5.5), 
	(N'VA', N'S10A201',N'1',N'016',N'1T',4.4), 
	(N'VA', N'S10A201',N'1',N'016',N'Miệng',10), 
	(N'VA', N'S10A201',N'1',N'016',N'HK',5),
    

-------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------Truy vấn-----------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------


--Truy vấn lấy thông tin học sinh ra để load vào table tại fStudentInformation với thông tin đầy đủ
GO
CREATE PROC	usp_GetStudentInformationByStudentCode @MaHocSinh varchar(50)
AS
BEGIN
	SELECT *
	FROM HOC_SINH, DAN_TOC, TON_GIAO
	WHERE MaHocSinh=@MaHocSinh AND HOC_SINH.TonGiao = TON_GIAO.MaTonGiao AND HOC_SINH.DanToc = DAN_TOC.MaDanToc
END


--Xuất ra toàn bộ điểm của học sinh có mã số S10A101
SELECT HSL.MaHocSinh, L.TenLop, HK.TenHocKi, NH.TenNamHoc, MH.TenMonHoc, LD.TenLoai, D.Diem
SELECT *
FROM DIEM D, LOAI_DIEM LD, MON_HOC MH, HOC_SINH_LOP HSL, HOC_KY HK, LOP L, NAM_HOC NH
WHERE HSL.MaHocSinh = 'S016001' AND D.MaHocSinhLop = HSL.MaHocSinh AND HSL.MaLop = L.MaLop AND D.MaHocKi = HK.MaHocKi AND D.MaLoai = LD.MaLoai
		AND D.MaMonHoc = MH.MaMonHoc AND D.MaNamHoc = NH.MaNamHoc



