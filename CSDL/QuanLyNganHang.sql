﻿USE master
---------------------------Tao Database Quan Ly Ngan Hang
CREATE DATABASE QLNH
GO
--Su dung database
USE QLNH
GO
-- DROP DATABASE QLNH
---------------------------Tao Table
--Bang ChiNhanh
CREATE TABLE CHINHANH(MACN CHAR(10) NOT NULL,
						TENCHINHANH NVARCHAR(50),
						DIACHI NVARCHAR(50))
GO
--Bang NhanVien
CREATE TABLE NHANVIEN(MANV CHAR(10) NOT NULL,
						TENNV NVARCHAR(30),
						GIOITINH NVARCHAR(5),
						NGAYSINH DATE,
						CHUC NVARCHAR(50),
						LUONG FLOAT,
						DIACHI NVARCHAR(50),
						SDT INT,
						MAPB INT,
						MACN CHAR(10))
GO
--BANG BIENLAI
CREATE TABLE BIENLAI(MABL CHAR(10) NOT NULL,
						LOAIBL NVARCHAR(30),
						SOTIEN FLOAT,
						NGAYLAP DATE,
						MANV CHAR(10), 
						MaKH CHAR(10))
GO
--BANG HOTRO
CREATE TABLE HOTRO(MAKH CHAR(10) NOT NULL,
					DVHT NVARCHAR(50),
					MANV CHAR(10) NOT NULL,
					MAKM CHAR(10))
GO
--BANG KHACH HANG
CREATE TABLE KHACHHANG(MAKH CHAR(10) NOT NULL,
						TENKH NVARCHAR(30),
						SDT INT,
						GIOITINH NVARCHAR(5),
						DCHI NVARCHAR(50),
						NSINH DATE)
GO
--BANG TAI KHOAN
CREATE TABLE TAIKHOAN(MATK CHAR(10) NOT NULL,
						SODU FLOAT,
						NGAYLAP DATE,
						MAKH CHAR(10),
						LOAITK CHAR(10),
						LOAITIEN CHAR(10),
						MANV CHAR(10))
GO
--BANG PHONG BAN
CREATE TABLE PHONGBAN(MAPB INT NOT NULL,
						TENPB NVARCHAR(15),
						TRPHONG CHAR(10))
GO
--BANG LOAI TAI KHOAN
CREATE TABLE LOAITAIKHOAN(MALOAI CHAR(10) NOT NULL,
							TENNH NVARCHAR(30))
GO
--BANG TIENTE
CREATE TABLE TIENTE(MATT CHAR(10) NOT NULL,
					TENTT NVARCHAR(30))
GO
--BANG KHUYENMAI
CREATE TABLE KHUYENMAI (MAKM CHAR(10) NOT NULL,           
						TENKM NVARCHAR(50),               
						NGAYBATDAU DATE,                 
						NGAYKETTHUC DATE,                                
						DIEUKIEN NVARCHAR(100))
GO
--BANG TAIKHOANDANGNHAP
CREATE TABLE TKDANGNHAP(TENDN CHAR(10) NOT NULL,
						MATKHAU NVARCHAR(50) NOT NULL,
						QUYEN NVARCHAR(20) NOT NULL,
						MANV CHAR(10))
Go
--BANG NOIQUY
CREATE TABLE NOIQUY(MANQ CHAR(10) NOT NULL,
					MOTA NVARCHAR(100),
					MUCPHAT FLOAT,
					GHICHU NVARCHAR(225))
GO
--BANG VIPHAM
CREATE TABLE VIPHAM(MAVP CHAR(10) NOT NULL,
					MANV CHAR(10),
					MANQ CHAR(10),
					NGAYVIPHAM DATE,
					TIENPHAT FLOAT,
					SOLANVIPHAM INT,
					GHICHU NVARCHAR(225))
GO
------------------------------------CAC RBTV
--------RANG BUOC KHOA CHINH
--KHOA CHINH NOI QUY
ALTER TABLE NOIQUY
ADD CONSTRAINT PK_NQ PRIMARY KEY(MANQ)
GO
--KHOA CHINH VI PHAM
ALTER TABLE VIPHAM
ADD CONSTRAINT PK_VP PRIMARY KEY(MAVP)
GO
--KHOA CHINH TAI KHOAN DANG NHAP
ALTER TABLE TKDANGNHAP
ADD CONSTRAINT PK_DN PRIMARY KEY(TENDN)
GO
--KHOA CHINH CHI NHANH
ALTER TABLE CHINHANH
ADD CONSTRAINT PK_CN PRIMARY KEY(MACN)
GO
--KHOA CHINH TIENTE
ALTER TABLE TIENTE
ADD CONSTRAINT PK_TT PRIMARY KEY(MATT)
GO
--KHOA CHINH NHANVIEN
ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NV PRIMARY KEY(MANV)
GO
--KHOA CHINH CHO BIENLAI
ALTER TABLE BIENLAI
ADD CONSTRAINT PK_BL PRIMARY KEY(MABL)
GO
--KHOA CHINH CHO HO TRO
ALTER TABLE HOTRO
ADD CONSTRAINT PK_HT PRIMARY KEY(MAKH, MANV)
GO
--KHOA CHINH CHO KHACH HANG
ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_KH PRIMARY KEY(MAKH)
GO
--KHOA CHINH CHO TAIKHOANG
ALTER TABLE TAIKHOAN
ADD CONSTRAINT PK_TK PRIMARY KEY(MATK)
GO
--KHOA CHINH CHO PHONG BAN
ALTER TABLE PHONGBAN
ADD CONSTRAINT PK_PB PRIMARY KEY(MAPB)
GO
--KHOA CHINH CHO MA LOAI KHACH HANG
ALTER TABLE LOAITAIKHOAN
ADD CONSTRAINT PK_LTK PRIMARY KEY(MALOAI)
GO
-- KHÓA CHÍNH CHO KHUYEN MAI
ALTER TABLE KHUYENMAI
ADD CONSTRAINT PK_KM PRIMARY KEY (MAKM)
GO
-----------RANG BUOC KHOA NGOAI
-- NHANVIEN VOI CHINHANH
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_CN FOREIGN KEY(MACN)
REFERENCES CHINHANH(MACN)
GO
--TAIKHOAN VOI TIENTE
ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TK_TT FOREIGN KEY(LOAITIEN)
REFERENCES TIENTE(MATT)
GO
--PHONGBAN VOI NHAN VIEN
ALTER TABLE PHONGBAN
ADD CONSTRAINT FK_PB_NV FOREIGN KEY(TRPHONG)
REFERENCES NHANVIEN(MANV)
GO
--NHAN VIEN VOI PHONG BAN
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_PB FOREIGN KEY(MAPB)
REFERENCES PHONGBAN(MAPB)
GO
--BIENLAI VOI NHANVIEN
ALTER TABLE BIENLAI
ADD CONSTRAINT FK_BL_NV FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV)
GO
--BIENLAI VOI KHACH HANG
ALTER TABLE BIENLAI
ADD CONSTRAINT FK_BL_KH FOREIGN KEY(MAKH)
REFERENCES KHACHHANG(MAKH)
GO
--HOTRO VOI NHANVIEN
ALTER TABLE HOTRO
ADD CONSTRAINT FK_HT_NV FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV)
GO
--HOTRO VOI KHACHHANG
ALTER TABLE HOTRO
ADD CONSTRAINT FK_HT_KH FOREIGN KEY(MAKH)
REFERENCES KHACHHANG(MAKH)
GO
-- HOTRO VOI KHUYENMAI
ALTER TABLE HOTRO
ADD CONSTRAINT FK_HT_KM FOREIGN KEY (MAKM)
REFERENCES KHUYENMAI(MAKM)
GO
--TAIKHOAN VOI LOAITAIKHOAN
ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TK_LTK FOREIGN KEY(LOAITK)
REFERENCES LOAITAIKHOAN(MALOAI)
GO
--TAIKHOAN VOI NHANVIEN
ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TK_NV FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV)
GO
--TAIKHOAN VOI KHACHHANG
ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TK_KH FOREIGN KEY(MAKH)
REFERENCES KHACHHANG(MAKH)
GO
-- TAIKHOANDANGNHAP VỚI NHÂNVIEN
ALTER TABLE TKDANGNHAP
ADD CONSTRAINT FK_DN_NV FOREIGN KEY (MANV)
REFERENCES NHANVIEN(MANV)
GO
-- Vi phạm VOI nhân viên
ALTER TABLE VIPHAM
ADD CONSTRAINT FK_VP_NV FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV)
GO

-- Vi phạm VOI nội quy
ALTER TABLE VIPHAM
ADD CONSTRAINT FK_VP_NQ FOREIGN KEY(MANQ)
REFERENCES NOIQUY(MANQ)
GO
---------RANG BUOC DUY NHAT
ALTER TABLE PHONGBAN ADD CONSTRAINT TenPhong unique(TENPB)
GO
ALTER TABLE NHANVIEN ADD CONSTRAINT Sdt UNIQUE(SDT)
GO
ALTER TABLE KHACHHANG ADD CONSTRAINT SdtKH UNIQUE(SDT)
GO
ALTER TABLE TKDANGNHAP ADD CONSTRAINT UQ_TKDN_MANV UNIQUE (MANV)
GO
---------RANG BUOC MIEN GIA TRI
ALTER TABLE NHANVIEN
ADD CONSTRAINT CK_GT CHECK(GIOITINH=N'NAM' OR GIOITINH=N'NỮ')
GO
ALTER TABLE KHACHHANG
ADD CONSTRAINT CK_GTKH CHECK(GIOITINH=N'NAM' OR GIOITINH=N'NỮ')
GO
---------RANG BUOC MAC DINH
ALTER TABLE NHANVIEN
ADD CONSTRAINT DF_Luong DEFAULT 0 FOR LUONG