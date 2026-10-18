USE EduManagerDB;
GO

-- Nhập 2 Khoa
INSERT INTO KHOA VALUES 
('CNTT', N'Công nghệ Thông tin'), 
('TOAN', N'Toán - Tin học');

-- Nhập 3 Lớp
INSERT INTO LOP VALUES 
('51.CNTT.A', N'Lớp CNTT A khóa 51', 'CNTT'), 
('51.CNTT.B', N'Lớp CNTT B khóa 51', 'CNTT'), 
('51.TOAN.A', N'Lớp Toán A khóa 51', 'TOAN');

-- Nhập 7 Sinh viên (Đưa KayTy vào danh sách và 1 bạn chưa có điểm để test lệnh Xóa)
INSERT INTO SINHVIEN VALUES
('51.01.104.097', N'Nguyễn Trần Khang Thịnh', N'Nam', '2007-06-27', '51.CNTT.B'),
('51.01.104.001', N'Nguyễn Văn An', N'Nam', '2007-01-15', '51.CNTT.A'),
('51.01.104.002', N'Trần Thị Bình', N'Nữ', '2007-02-20', '51.CNTT.B'),
('51.01.104.003', N'Lê Văn Cường', N'Nam', '2007-03-05', '51.TOAN.A'),
('51.01.104.004', N'Phạm Thị Dung', N'Nữ', '2007-04-10', '51.TOAN.A'),
('51.01.104.005', N'Hoàng Văn Em', N'Nam', '2007-05-25', '51.CNTT.A'),
('51.01.104.099', N'Sinh Viên Test Xóa', N'Nam', '2007-12-12', '51.CNTT.A');

-- Nhập 4 Môn học
INSERT INTO MONHOC VALUES
('COMP1019', N'Lập trình trên Windows', 3),
('COMP1020', N'Cơ sở dữ liệu', 4),
('MATH1001', N'Toán rời rạc', 3),
('COMP1021', N'Cấu trúc dữ liệu', 3);

-- Nhập 8 Kết quả học tập
INSERT INTO KETQUA VALUES
('51.01.104.097', 'COMP1019', 9.5),
('51.01.104.097', 'COMP1020', 9.0),
('51.01.104.001', 'COMP1019', 8.0),
('51.01.104.001', 'MATH1001', 7.5),
('51.01.104.002', 'COMP1020', 8.5),
('51.01.104.003', 'MATH1001', 6.0),
('51.01.104.004', 'COMP1021', 9.0),
('51.01.104.005', 'COMP1021', 8.0);

-- Nhập 2 Tài khoản
INSERT INTO TAIKHOAN VALUES
('admin', 'admin123', N'Quản trị viên'),
('khangthinh', 'password123', N'Sinh viên');
GO