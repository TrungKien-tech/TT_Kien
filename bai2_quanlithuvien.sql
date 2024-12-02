/*
Created		07/11/2024
Modified		07/11/2024
Project		
Model		
Company		
Author		
Version		
Database		MS SQL 7 
*/


Create table [THELOAI] (
	[MATL] Integer NOT NULL,
	[TENTL] Char(20) NOT NULL,
Constraint [pk_THELOAI] Primary Key  ([MATL])
) 
go

Create table [DAUSACH] (
	[MADAUSACH] Integer NOT NULL,
	[SOLUONG] Decimal(10,2) NULL,
	[TENSACH] Char(20) NULL,
	[NAMXB] Datetime NULL,
	[SLHIENCO] Decimal(10,2) NULL,
	[MATL] Integer NOT NULL,
Constraint [pk_DAUSACH] Primary Key  ([MADAUSACH])
) 
go

Create table [NHAXUATBAN] (
	[MANXB] Integer NOT NULL,
	[TENNXB] Char(20) NULL,
	[DIACHINXB] Char(200) NULL,
	[SODTNXB] Integer NULL,
	[MADAUSACH] Integer NOT NULL,
Constraint [pk_NHAXUATBAN] Primary Key  ([MANXB])
) 
go

Create table [CUONSACH] (
	[MASACH] Integer NOT NULL,
	[GIATRISACH] Money NULL,
	[TINHTRANG] Char(200) NULL,
	[MADAUSACH] Integer NOT NULL,
Constraint [pk_CUONSACH] Primary Key  ([MASACH])
) 
go

Create table [NHANVIEN] (
	[MANV] Integer NOT NULL,
	[HOTENNV] Char(20) NULL,
	[PHAI] Bit NULL,
	[NGAYSINH] Datetime NULL,
	[CHUCVU] Varchar(20) NULL,
	[SODT] Integer NULL,
Constraint [pk_NHANVIEN] Primary Key  ([MANV])
) 
go

Create table [PHIEUMUONSACH] (
	[MAPM] Integer NOT NULL,
	[NGAYMUON] Datetime NULL,
	[NGAYTRA] Datetime NULL,
	[MATHE] Integer NOT NULL,
	[MANV] Integer NOT NULL,
Constraint [pk_PHIEUMUONSACH] Primary Key  ([MAPM])
) 
go

Create table [CTPHIEUMUON] (
	[NGAYTRA] Char(10) NULL,
	[TINHTRANGTRA] Char(10) NULL,
	[PHIPHATSINH] Char(10) NULL,
	[MASACH] Integer NOT NULL,
	[MAPM] Integer NOT NULL,
	[MAPHIEUPHAT] Integer NULL,
Constraint [pk_CTPHIEUMUON] Primary Key  ([MASACH],[MAPM])
) 
go

Create table [PHIEUPHAT] (
	[MAPHIEUPHAT] Integer NOT NULL,
	[TONGQUAT] Varchar(200) NULL,
	[MANV] Integer NOT NULL,
Constraint [pk_PHIEUPHAT] Primary Key  ([MAPHIEUPHAT])
) 
go

Create table [THEDOCGIA] (
	[MATHE] Integer NOT NULL,
	[NGAYCAP] Datetime NULL,
	[HANSD] Datetime NULL,
	[MADOCGIA] Integer NOT NULL,
Constraint [pk_THEDOCGIA] Primary Key  ([MATHE])
) 
go

Create table [DOCGIA] (
	[MADOCGIA] Integer NOT NULL,
	[HOTENDOCGIA] Char(20) NULL,
	[DIACHIDOCGIA] Varchar(200) NULL,
	[EMALDOCGIA] Char(50) NULL,
	[NGAYSINH] Datetime NULL,
Constraint [pk_DOCGIA] Primary Key  ([MADOCGIA])
) 
go


Alter table [DAUSACH] add Constraint [PHAN_LOAI] foreign key([MATL]) references [THELOAI] ([MATL]) 
go
Alter table [NHAXUATBAN] add Constraint [XUATBAN] foreign key([MADAUSACH]) references [DAUSACH] ([MADAUSACH]) 
go
Alter table [CUONSACH] add Constraint [THUOCVE] foreign key([MADAUSACH]) references [DAUSACH] ([MADAUSACH]) 
go
Alter table [CTPHIEUMUON] add Constraint [CHOMUON] foreign key([MASACH]) references [CUONSACH] ([MASACH]) 
go
Alter table [PHIEUPHAT] add Constraint [GHI_PHAT] foreign key([MANV]) references [NHANVIEN] ([MANV]) 
go
Alter table [PHIEUMUONSACH] add Constraint [XU_LY] foreign key([MANV]) references [NHANVIEN] ([MANV]) 
go
Alter table [CTPHIEUMUON] add Constraint [BAOGOM] foreign key([MAPM]) references [PHIEUMUONSACH] ([MAPM]) 
go
Alter table [CTPHIEUMUON] add Constraint [CTPHAT] foreign key([MAPHIEUPHAT]) references [PHIEUPHAT] ([MAPHIEUPHAT]) 
go
Alter table [PHIEUMUONSACH] add Constraint [MUON_SACH] foreign key([MATHE]) references [THEDOCGIA] ([MATHE]) 
go
Alter table [THEDOCGIA] add Constraint [CAP_THE] foreign key([MADOCGIA]) references [DOCGIA] ([MADOCGIA]) 
go


Set quoted_identifier on
go

Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


