USE master;
GO

-- Ép ngắt tất cả các kết nối đang kẹt và xóa database cũ
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'EduManagerDB')
BEGIN
    ALTER DATABASE EduManagerDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EduManagerDB;
END
GO

-- 1. Tạo Database mới
CREATE DATABASE EduManagerDB;
GO

USE EduManagerDB;
GO

-- 2. Tạo bảng KHOA
CREATE TABLE KHOA (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);

-- 3. Tạo bảng LOP (Tham chiếu đến KHOA)
CREATE TABLE LOP (
    MaLop VARCHAR(15) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    MaKhoa VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);

-- 4. Tạo bảng SINHVIEN (Tham chiếu đến LOP, Ràng buộc Giới tính)
CREATE TABLE SINHVIEN (
    MaSV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    NgaySinh DATE,
    MaLop VARCHAR(15) NOT NULL,
    FOREIGN KEY (MaLop) REFERENCES LOP(MaLop)
);

-- 5. Tạo bảng MONHOC (Ràng buộc Số tín chỉ > 0)
CREATE TABLE MONHOC (
    MaMH VARCHAR(15) PRIMARY KEY,
    TenMH NVARCHAR(100) NOT NULL,
    SoTinChi INT CHECK (SoTinChi > 0)
);

-- 6. Tạo bảng KETQUA (Tham chiếu SINHVIEN, MONHOC; Ràng buộc Điểm 0-10)
CREATE TABLE KETQUA (
    MaSV VARCHAR(20),
    MaMH VARCHAR(15),
    Diem FLOAT CHECK (Diem >= 0 AND Diem <= 10),
    PRIMARY KEY (MaSV, MaMH),
    FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV),
    FOREIGN KEY (MaMH) REFERENCES MONHOC(MaMH)
);

-- 7. Tạo bảng TAIKHOAN
CREATE TABLE TAIKHOAN (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255) NOT NULL,
    Quyen NVARCHAR(50)
);
GO