USE EduManagerDB;
GO

-- 1. Liệt kê toàn bộ sinh viên
SELECT * FROM SINHVIEN;

-- 2. Liệt kê sinh viên kèm tên lớp và tên khoa
SELECT s.MaSV, s.HoTen, l.TenLop, k.TenKhoa 
FROM SINHVIEN s 
JOIN LOP l ON s.MaLop = l.MaLop 
JOIN KHOA k ON l.MaKhoa = k.MaKhoa;

-- 3. Tìm sinh viên theo một phần họ tên bằng LIKE
SELECT * FROM SINHVIEN WHERE HoTen LIKE N'%Thịnh%';

-- 4. Liệt kê sinh viên theo mã lớp
SELECT * FROM SINHVIEN WHERE MaLop = '51.CNTT.B';

-- 5. Cập nhật họ tên hoặc lớp của một sinh viên
UPDATE SINHVIEN SET HoTen = N'Nguyễn Trần Khang Thịnh (Đã cập nhật)' WHERE MaSV = '51.01.104.097';

-- 6. Xóa một sinh viên chưa có dữ liệu điểm (Sinh viên 51.01.104.099)
DELETE FROM SINHVIEN WHERE MaSV = '51.01.104.099';

-- 7. Liệt kê điểm của từng sinh viên theo từng môn
SELECT s.HoTen, m.TenMH, k.Diem 
FROM KETQUA k 
JOIN SINHVIEN s ON k.MaSV = s.MaSV 
JOIN MONHOC m ON k.MaMH = m.MaMH;

-- 8. Tính điểm trung bình của từng sinh viên
SELECT s.MaSV, s.HoTen, ROUND(AVG(k.Diem), 2) AS DiemTB 
FROM SINHVIEN s 
JOIN KETQUA k ON s.MaSV = k.MaSV 
GROUP BY s.MaSV, s.HoTen;

-- 9. Thống kê số sinh viên theo từng lớp
SELECT MaLop, COUNT(MaSV) AS SoLuongSV FROM SINHVIEN GROUP BY MaLop;

-- 10. Liệt kê các lớp có từ 2 sinh viên trở lên
SELECT MaLop, COUNT(MaSV) AS SoLuongSV 
FROM SINHVIEN 
GROUP BY MaLop 
HAVING COUNT(MaSV) >= 2;

-- 11. Test lỗi khi thêm sinh viên vào lớp không tồn tại (Sẽ báo lỗi Foreign Key)
-- Mở comment dòng dưới để test:
-- INSERT INTO SINHVIEN VALUES ('99999', N'Test Lỗi', N'Nam', '2000-01-01', 'LOP_AO');

-- 12. Test lỗi khi nhập điểm ngoài khoảng 0 đến 10 (Sẽ báo lỗi Check Constraint)
-- Mở comment dòng dưới để test:
-- INSERT INTO KETQUA VALUES ('51.01.104.097', 'COMP1021', 11.5);