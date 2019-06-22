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

CREATE TABLE HOC_SINH_LOP
(
	MaHocSinhLop nvarchar(50),
	MaHocSinh nvarchar(50),
	MaNamHoc nvarchar(50),
	MaLop nvarchar(50),
	PRIMARY KEY(MaHocSinhLop)
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
	PRIMARY KEY(MaNguoiDung)
	
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
	MaNamHoc nvarchar(50),
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
	MaNamHoc nvarchar(50),
	SiSo int,
	MaGiaoVienCN nvarchar(50),
	PRIMARY KEY(MaLop, MaNamHoc)
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
 ALTER TABLE HOC_SINH_LOP ADD FOREIGN KEY (MaLop, MaNamHoc) REFERENCES LOP(MaLop, MaNamHoc);
 ALTER TABLE HOC_SINH_LOP ADD FOREIGN KEY (MaNamHoc) REFERENCES NAM_HOC(MaNamHoc);
 ALTER TABLE GIAO_VIEN_LOP ADD FOREIGN KEY (MaGiaoVien) REFERENCES GIAO_VIEN(MaGiaoVien);

 ALTER TABLE GIAO_VIEN_LOP ADD FOREIGN KEY (MaLop, MaNamHoc) REFERENCES LOP(MaLop, MaNamHoc);

 ALTER TABLE PHAN_CONG  ADD FOREIGN KEY (MaGiaoVienLop) REFERENCES GIAO_VIEN_LOP(MaGiaoVienLop);
 ALTER TABLE PHAN_CONG ADD FOREIGN KEY (MaMonHoc) REFERENCES MON_HOC(MaMonHoc);
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

 INSERT INTO  MON_HOC(MaMonHoc,TenMonHoc,SoTiet, HeSo) VALUES
    (N'TO', N'Toán',45,3), 
    (N'VA', N'Văn',45,3),
	(N'LI', N'Vật Lí',45,3),
	(N'HO', N'Hóa',45,3),
	(N'TA',N'Tiếng Anh',45,1);

 INSERT INTO  LOAI_DIEM(MaLoai,TenLoai,HeSo) VALUES
    (N'Miệng', N'Điểm kiểm tra miệng', 1), 
    (N'15p', N'Điểm kiểm tra 15 phút', 1), 
    (N'1T', N'Điểm kiểm tra 1 Tiết',2),
	(N'HK', N'Điểm kiểm tra học kì',3);
	
 INSERT INTO GIAO_VIEN (MaGiaoVien,	HoTen, GioiTinh, NgaySinh, NoiSinh, DiaChi, DienThoai) VALUES
    (N'T011001', N'Trương Tấn Sang', 1,'1989-01-26', N'Kiên Giang', N'182 Lương Định Của', N'0984833673'), 
    (N'T008002', N'Hồ Thị Lan', 0,'1979-01-26', N'Hà Giang', N'178 Nguyễn Trãi', N'0983833673'),
	(N'T008003', N'Nguyễn Văn Chung', 1,'1979-05-26', N'Bắc Giang', N'178 Nguyễn Văn Cừ', N'0983833673'),
	(N'T008004', N'Đỗ Thị Hạnh', 0,'1979-10-26', N'HCM', N'222 Nguyễn Trãi', N'0983833673');

 INSERT INTO  LOP (MaLop,TenLop,MaNamHoc,SiSo,MaGiaoVienCN) VALUES
    (N'K12A1', N'12A1',N'019',4,N'T011001'),
	(N'K11A1', N'11A1',N'018',4,N'T011001'),
	(N'K10A1', N'10A1',N'017',4,N'T011001'),

    (N'K11A1', N'11A1',N'019',3,N'T008002'),
	(N'K10A1', N'10A1',N'018',3,N'T008002');

 INSERT INTO HOC_SINH (MaHocSinh, HoTen, GioiTinh, NgaySinh, NoiSinh, DiaChi, DanToc, TonGiao, TenNguoiThan) VALUES
    (N'S017001', N'Hoàng Gia An', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S017002', N'Huỳnh Gia Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt'),
	(N'S017003', N'Trung Đức', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S017004', N'Bảo Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt'),

	(N'S018001', N'Gia An', 0,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S018002', N'Huỳnh Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt'),
	(N'S018003', N'Nguyễn Anh An', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S018004', N'Lâm Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt');

	/*
	(N'S017005', N'Hoàng Gia An', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S017006', N'Huỳnh Gia Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt'),
	(N'S017007', N'Trung Đức', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S017008', N'Bảo Nghi', 0, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt'),
	(N'S019002', N'Phú Quốc', 1,'2004-01-26', N'Hà Giang', N'182 Lê Đại Hành', N'Kinh', N'Không', N'Hoàng Hữu Thái'), 
    (N'S019003', N'Bùi Hiền', 1, '2005-03-26', N'Tiền Giang', N'182 An Dương Vương', N'Kinh', N'Phật', N'Lê Hữu Đạt');
	 */
	
 INSERT INTO  GIAO_VIEN_LOP (MaGiaoVienLop,MaGiaoVien,MaLop, MaNamHoc) VALUES
    (N'T12A101', N'T011001', N'K12A1', '019'), 

	(N'T11A101', N'T011001', N'K11A1', '018'),
	 
	(N'T11A202', N'T011001', N'K10A1', '017'),

	(N'T10A201', N'T008002',N'K11A1', '019');

 INSERT INTO  PHAN_CONG (MaPhanCong,MaGiaoVienLop,MaMonHoc) VALUES
    (N'P12A1T1', N'T12A101',N'TO'), 
    (N'P11A2T1', N'T11A101',N'TA');

 INSERT INTO  NGUOI_DUNG(MaNguoiDung,MatKhau) VALUES
    (N'Admin', N'1'), 
	(N'S017001', N'1'),
	(N'S018002', N'1'), 
    (N'T011001', N'1'),
	(N'T008002', N'1');

INSERT INTO KQ_HOC_KY (MaHocSinhLop,	MaHocKi,	MaNamHoc,	MaHocLuc,	MaHanhKiem,	DTBHK) VALUES
('S10A101',	'1',	'017',	'TB',	'T',	6),
('S10A101',	'2',	'017',	'G',	'T',	8),
('S11A101',	'1',	'018',	'K',	'T',	6.5),
('S11A101',	'2',	'018',	'TB',	'T',	6),
('S12A101',	'1',	'019',	'G',	'T',	9.5),
('S12A101',	'2',	'019',	'G',	'T',	8),
('S10A102',	'1',	'017',	'K',	'T',	7),
('S10A102',	'2',	'017',	'TB',	'T',	6),
('S11A102',	'1',	'018',	'G',	'T',	8),
('S11A102',	'2',	'018',	'G',	'T',	9),
('S12A102',	'1',	'019',	'TB',	'T',	6),
('S12A102',	'2',	'019',	'K',	'T',	7.7),
('S10A103',	'1',	'017',	'K',	'T',	7),
('S10A103',	'2',	'017',	'TB',	'T',	6),
('S11A103',	'1',	'018',	'K',	'T',	7),
('S11A103',	'2',	'018',	'G',	'T',	10),
('S12A103',	'1',	'019',	'G',	'T',	9),
('S12A103',	'2',	'019',	'G',	'T',	8),
('S10A104',	'1',	'017',	'TB',	'T',	6),
('S10A104',	'2',	'017',	'G',	'T',	8),
('S11A104',	'1',	'018',	'K',	'T',	6),
('S11A104',	'2',	'018',	'K',	'T',	5),
('S12A104',	'1',	'019',	'K',	'T',	5),
('S12A104',	'2',	'019',	'TB',	'T',	6),
('S11A105',	'1',	'019',	'K',	'T',	7),
('S11A105',	'2',	'019',	'G',	'T',	9),
('S11A106',	'1',	'019',	'G',	'T',	9),
('S11A106',	'2',	'019',	'TB',	'T',	5),
('S11A107',	'1',	'019',	'K',	'T',	7),
('S11A107',	'2',    '019',	'G',	'T',	9),
('S11A108',	'1',	'019',	'G',    'T',	8),
('S11A108',	'2',	'019',	'G',	'T',	9);

INSERT INTO KQ_NAM_HOC (MaHocSinhLop,	MaHocLuc,	MaHanhKiem,	MaNamHoc,	DTBCaNam) VALUES
('S10A101',	'K',	'T',	'017',	7.7),
('S11A101',	'TB',	'T',	'018',	6),
('S12A101',	'G',	'T',	'019',	8.4),
('S10A102',	'G',	'T',	'017',	9.1),
('S11A102',	'K',	'T',	'018',	7.4),
('S12A102',	'K',	'T',	'019',	7.8),
('S10A103',	'K',	'T',	'017',	7.4),
('S11A103',	'K',	'T',	'018',	7.9),
('S12A103',	'K',	'T',	'019',	6.9),
('S10A104',	'K',	'T',	'017',	7),
('S11A104',	'K',	'T',	'018',	7.8),
('S12A104',	'G',	'T',	'019',	9.1),
('S11A105',	'G',	'T',	'019',	8),
('S11A106',	'G',	'T',	'019',	8),
('S11A107',	'K',	'T',	'019',	7.6),
('S11A108',	'K',	'T',	'019',	7.3);

	-- Học sinh có mã số S017001, S017002, S017003, S017004 là học sinh lớp 12A1
	-- Học sinh có mã số S017005, S017006, S017007, S017008 là học sinh lớp 12A2
	-- Học sinh có mã số S018001, S018002, S018003 là học sinh lớp 11A1
	-- Học sinh có mã số S019001, S019002, S019003 là học sinh lớp 10A1

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


--Thêm một học sinh mới
CREATE PROC usp_AddNewStudent @TenHocSinh nvarchar(50), @MaHocSinh nvarchar(50), @TenLop nvarchar(50), @MaHocSinhLop nvarchar(50)
AS
BEGIN
	 INSERT INTO HOC_SINH (MaHocSinh, HoTen, GioiTinh, NgaySinh, NoiSinh, DiaChi, DanToc, TonGiao, TenNguoiThan) VALUES
     (@MaHocSinh, @TenHocSinh, null,null, null, null, null, null, null);

	 EXEC usp_AddClassStudent @MaHocSinhLop, @MaHocSinh, @TenLop

	 EXEC usp_AddAccountStudent @MaHocSinh

END


--Hàm phụ, lấy ra Mã lớp học từ bảng LOP_HOP để nhập cho MaHocSinhLop bảng HOC_SINH_LOP
CREATE PROC usp_GetIDClassStudent @TenLop nvarchar(50), @MaLopHoc nvarchar(50) out
AS
BEGIN
	  SELECT @MaLopHoc=MaLop FROM LOP WHERE TenLop = @TenLop
END


--Cập nhật tên đăng nhập và mật khẩu cho học sinh mới thêm
CREATE PROC usp_AddAccountStudent @MaHocSinh nvarchar(50)
AS
BEGIN
	INSERT INTO  NGUOI_DUNG(MaNguoiDung,MatKhau) VALUES
    (@MaHocSinh, @MaHocSinh)
END


--Cập nhật lớp cho học sinh mới thêm
CREATE PROC usp_AddClassStudent @MaHocSinhLop nvarchar(50), @MaHocSinh nvarchar(50), @TenLop nvarchar(50)
AS
BEGIN
	DECLARE @MaLop nvarchar(50)
	EXEC usp_GetIDClassStudent @Tenlop, @MaLop

	INSERT INTO  HOC_SINH_LOP (MaHocSinhLop,MaHocSinh,MaLop) VALUES
    (@MaHocSinhLop, @MaHocSinh, @MaLop);
END

-- Thêm một tài khoản người dùng mới
GO
CREATE PROC usp_AddAccount @MaNguoiDung nvarchar(50), @MatKhau nvarchar(50)
AS
BEGIN
	INSERT INTO  NGUOI_DUNG(MaNguoiDung,MatKhau) VALUES
    (@MaNguoiDung, @MatKhau)
END

-- Chỉnh sửa mật khẩu người dùng
GO
CREATE PROC usp_EditAccount @MaNguoiDung nvarchar(50), @MatKhau nvarchar(50)
AS
BEGIN
	UPDATE  NGUOI_DUNG SET MatKhau= @MatKhau WHERE MaNguoiDung = @MaNguoiDung
END

-- Xóa tài khoản người dùng
GO
CREATE PROC usp_DeleteAccount @MaNguoiDung nvarchar(50)
AS
BEGIN
	DELETE FROM  NGUOI_DUNG WHERE MaNguoiDung = @MaNguoiDung
END

-- Thêm Giáo viên
GO
CREATE PROC usp_AddTeacher @MaGiaoVien nvarchar(50),@HoTen nvarchar(50),@GioiTinh bit,@NgaySinh date,@NoiSinh nvarchar(50),@DiaChi nvarchar(50),@DienThoai nvarchar(50)
AS
BEGIN
	 INSERT INTO GIAO_VIEN(MaGiaoVien,HoTen,GioiTinh,NgaySinh,NoiSinh,DiaChi ,DienThoai) VALUES
     (@MaGiaoVien,@HoTen,@GioiTinh,@NgaySinh,@NoiSinh,@DiaChi,@DienThoai);
END

-- Cập nhập giáo viên
GO
CREATE PROC usp_UpdateTeacher @MaGiaoVien nvarchar(50),@HoTen nvarchar(50),@GioiTinh bit,@NgaySinh date,@NoiSinh nvarchar(50),@DiaChi nvarchar(50),@DienThoai nvarchar(50)
AS
BEGIN
	 UPDATE GIAO_VIEN SET  HoTen= @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NoiSinh = @NoiSinh,DiaChi = @DiaChi , DienThoai = @DienThoai Where MaGiaoVien = @MaGiaoVien
END

-- Xoa phan cong
GO
CREATE PROC usp_DeleteAssigned @MaPhanCong nvarchar(50)
AS
BEGIN
	 DELETE FROM PHAN_CONG WHERE MaPhanCong = @MaPhanCong
END

-- Xoa giao vien lop
GO
CREATE PROC usp_DeleteTeacherOfClass @MaGiaoVienLop nvarchar(50)
AS
BEGIN
	DECLARE @MaPhanCong nvarchar(50)
    SELECT @MaPhanCong=MaPhanCong FROM PHAN_CONG WHERE MaGiaoVienLop = @MaGiaoVienLop
	EXEC usp_DeleteAssigned @MaPhanCong
	 DELETE FROM GIAO_VIEN_LOP WHERE MaGiaoVienLop = @MaGiaoVienLop
	 
END

-- Xoa giao vien
GO
CREATE PROC usp_DeleteTeacher @MaGiaoVien nvarchar(50)
AS
BEGIN
DECLARE @MaGiaoVienLop nvarchar(50)
    SELECT @MaGiaoVienLop=MaGiaoVienLop FROM GIAO_VIEN_LOP WHERE MaGiaoVien = @MaGiaoVien
	EXEC usp_DeleteTeacherOfClass @MaGiaoVienLop
	 DELETE FROM GIAO_VIEN WHERE MaGiaoVien = @MaGiaoVien
END


-- Thêm giáo viên lớp
GO
CREATE PROC usp_AddTeacherOfStudent @MaGiaoVienLop nvarchar(50),@MaGiaoVien nvarchar(50),@MaLop nvarchar(50),@MaNamHoc nvarchar(50)
AS
BEGIN
	 INSERT INTO GIAO_VIEN_LOP(MaGiaoVienLop,MaGiaoVien,MaLop,MaNamHoc) VALUES
     (@MaGiaoVienLop,@MaGiaoVien,@MaLop,@MaNamHoc);
END

-- Cập nhập giáo viên lop
GO
CREATE PROC usp_UpdateTeacherOfClass @MaGiaoVienLop nvarchar(50),@MaGiaoVien nvarchar(50),@MaLop nvarchar(50),@MaNamHoc nvarchar(50)
AS
BEGIN
	 UPDATE GIAO_VIEN_LOP SET  MaGiaoVien= @MaGiaoVien, MaLop = @MaLop, MaNamHoc = @MaNamHoc Where MaGiaoVienLop = @MaGiaoVienLop
END




-- Thêm phân công
GO
CREATE PROC usp_AddAssigned @MaPhanCong nvarchar(50),@MaGiaoVienLop nvarchar(50),@MaMonHoc nvarchar(50)
AS
BEGIN
	 INSERT INTO PHAN_CONG(MaPhanCong,MaGiaoVienLop,MaMonHoc) VALUES
     (@MaPhanCong,@MaGiaoVienLop,@MaMonHoc);
END

-- Cập nhập phan cong
GO
CREATE PROC usp_UpdateAssigned @MaPhanCong nvarchar(50),@MaGiaoVienLop nvarchar(50),@MaMonHoc nvarchar(50)
AS
BEGIN
	 UPDATE PHAN_CONG SET  MaGiaoVienLop= @MaGiaoVienLop, MaMonHoc = @MaMonHoc Where MaPhanCong = @MaPhanCong
END

-- Them 1 hs
CREATE PROC usp_AddStudent
@MaHocSinh nvarchar(50), @HoTen nvarchar(50), @GioiTinh bit,
@NgaySinh date, @QueQuan nvarchar(50), @DiaChi nvarchar(50),
@DanToc nvarchar(50), @TonGiao nvarchar(50), @NguoiThan nvarchar(50)
AS
BEGIN
	INSERT INTO HOC_SINH ( MaHocSinh,HoTen,NgaySinh, GioiTinh,  NoiSinh, DiaChi , DanToc, TonGiao , TenNguoiThan)VALUES
	( @HoTen,  @NgaySinh,@GioiTinh,@QueQuan, @DiaChi, @DanToc, @TonGiao, @NguoiThan,@MaHocSinh)
END