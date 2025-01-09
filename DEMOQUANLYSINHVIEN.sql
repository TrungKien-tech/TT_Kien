create database DEMOQUANLISINHVIEN
go

use DEMOQUANLISINHVIEN
go



create table DANGNHAP
(
	ID int identity(1,1) primary key,
	TAIKHOAN VARCHAR(20) not null,
	MATKHAU varchar(20) not null,
	VAITRO varchar(20),

)

create table SINHVIEN
(
	MASV varchar(30) PRIMARY KEY,
	HOTEN NVARCHAR(100),
	NGAYSINH DATE,
	GIOITINH BIT,
	LOP NVARCHAR(50),
	CHUYENNGANH NVARCHAR(100),
	DIENTHOAI VARCHAR(15),
	EMAIL VARCHAR(100),
)


create table GIANGVIEN
(
	MAGV varchar(30) primary key,
	HOTEN NVARCHAR(100),
	GIOITINH BIT,
	NGAYSINH DATE,
	DIENTHOAI VARCHAR(15),
	EMAIL VARCHAR(100),

)

create table MONHOC
(
	MAMH INT IDENTITY(1,1) PRIMARY KEY,
	TENMH NVARCHAR(100),
	SOTINCHI INT,
	MAGV varchar(30),
	FOREIGN KEY (MAGV) REFERENCES GIANGVIEN(MAGV)

)

create table DANGKYMONHOC
(
	MADK varchar(30) PRIMARY KEY,
	TENMONHOC nvarchar(30),
	MASV varchar(30),
	HOTEN NVARCHAR(100),
	MAGV varchar(30),
	NGAYDANGKY DATE default getdate(),
	FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV),
	FOREIGN KEY(MAGV) REFERENCES GIANGVIEN(MAGV),
)

--dữ liệu đăng nhập
insert into DANGNHAP(TAIKHOAN,MATKHAU,VAITRO)
values
('admin','admin123','Admin'),
('sinhvien','sv2012','Sinhvien'),
('giangvien','gv2010','Giangvien');

-- dữ liệu sinh viên
INSERT INTO SINHVIEN (MASV,HOTEN, NGAYSINH, GIOITINH, LOP, CHUYENNGANH, DIENTHOAI, EMAIL)
VALUES 
('SV001',N'Nguyễn Văn An', '2001-05-15', 1, N'CNTT01', N'Công nghệ thông tin', '0374815397', 'nguyenvanan@gmail.com'),
('SV002',N'Lê Thị Hồng Nhung', '2002-08-22', 0, N'CNTT02', N'Công nghệ thông tin', '0736985214', 'lethihongnhung@gmail.com'),
('SV003',N'Trần Văn Tú', '2000-03-10', 1, N'KT01', N'Kinh tế', '0478596321', 'tranvantu@gmail.com'),
('SV004',N'Phạm Thị Minh Hằng', '2001-11-05', 0, N'KT02', N'Kinh tế', '0145236987', 'phamthiminhhang@gmail.com'),
('SV005',N'Hoàng Văn Tọa', '1999-12-30', 1, N'CNTT01', N'Công nghệ thông tin', '0748596321', 'hoangvantoa@gmail.com');

-- dữ liệu giảng viên

INSERT INTO GIANGVIEN (MAGV,HOTEN, GIOITINH, NGAYSINH, DIENTHOAI, EMAIL)
VALUES 
('GV001',N'Nguyễn Thị Mai', 0, '1987-06-30', '0374815397', 'thumai87@gmail.com'),
('GV002',N'Hà Anh Tuấn', 1, '1990-07-31', '0674815397', 'anhtuan@gmail.com'),
('GV003',N'Nguyễn Trọng Sang', 1, '1980-02-15', '0145854729', 'sangtrongpq@gmail.com'),
('GV004',N'Nguyễn Thu Hà', 0, '1997-07-20', '0365478592', 'nguyenthithuha@gmail.com'),
('GV005',N'Trần Trung Kiên', 1, '1996-06-30', '0336458975', 'trungkien@gmail.com');


--dữ liệu môn học

INSERT INTO MONHOC (TENMH, SOTINCHI, MAGV)
VALUES 
(N'Tin học cơ sở', 3,'GV001'),
(N'Lập trình C#', 4, 'GV002'),
(N'Cơ sở dữ liệu', 3, 'GV003'),
(N'Tài chính doanh nghiệp', 2, 'GV004'),
(N'Lập trình Web', 4, 'GV005');


select *from SINHVIEN;
select *from GIANGVIEN;
select *from MONHOC;
select *from DANGKYMONHOC;





