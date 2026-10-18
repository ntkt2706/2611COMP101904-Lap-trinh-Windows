# BÁO CÁO THỰC HÀNH LAB 11 - COMP1019
**Môn học:** Lập trình trên Windows  
**Giảng viên:** ThS. Lê Thanh Thoại  

## 1. Thông tin cá nhân
- **Họ và tên:** Nguyễn Trần Khang Thịnh
- **Mã số sinh viên:** 51.01.104.097
- **Lớp:** 51.CNTT.B

## 2. Tổng quan Project
Dự án `Lab11_EduManager` là ứng dụng Windows Forms kết nối trực tiếp với cơ sở dữ liệu SQL Server (`EduManagerDB`) thông qua công nghệ ADO.NET (`Microsoft.Data.SqlClient`). Ứng dụng giải quyết bài toán quản lý danh sách Lớp học, thực hiện trọn vẹn các nghiệp vụ CRUD và xử lý chặt chẽ các ràng buộc toàn vẹn dữ liệu.

## 3. Các chức năng đã triển khai (Đáp ứng Yêu cầu F1 - F8)
- **F1 & F2 (Hiển thị & Binding):** Tự động tải danh sách lớp học lên `DataGridView` ngay khi Form khởi động. Click chọn dòng bất kỳ để tự động đưa dữ liệu lên các TextBox tương ứng (đồng thời khóa mã lớp để bảo vệ Primary Key).
- **F3 (Thêm mới):** Kiểm tra tính hợp lệ của dữ liệu đầu vào (không rỗng). Thực hiện truy vấn kiểm tra chống trùng lặp `MaLop` trước khi thực thi `INSERT`.
- **F4 (Cập nhật):** Cho phép chỉnh sửa `TenLop` dựa trên `MaLop` đang được chọn.
- **F5 (Xóa dữ liệu an toàn):** Tích hợp hộp thoại xác nhận (Confirm Dialog) trước khi xóa. Đặc biệt, đã bắt ngoại lệ `SqlException` (Mã lỗi 547) để chặn việc xóa các Lớp đang có Sinh viên tham chiếu, đảm bảo không vi phạm ràng buộc khóa ngoại (Foreign Key).
- **F6 & F7 (Tìm kiếm & Làm mới):** Hỗ trợ tìm kiếm linh hoạt (LIKE) theo cả Mã lớp và Tên lớp. Nút làm mới giúp reset toàn bộ trạng thái Form về ban đầu.
- **F8 (Bảo mật & UI/UX):** 
  - Toàn bộ câu lệnh tương tác CSDL đều sử dụng `SqlParameter`, loại bỏ hoàn toàn rủi ro SQL Injection. 
  - Giao diện được thiết kế động bằng `TableLayoutPanel` và `FlowLayoutPanel`, đảm bảo Form không bị xô lệch, cắt chữ bất chấp tỷ lệ Scale màn hình của Windows.

## 4. Cấu trúc CSDL và Chuỗi kết nối
- **File đính kèm:** Đã bao gồm các script khởi tạo CSDL từ Lab 10 để giảng viên tiện chấm bài:
  - `01_CreateDatabase.sql`: Script tạo cấu trúc bảng, khóa chính, khóa ngoại và ràng buộc (CHECK).
  - `02_InsertSampleData.sql`: Script nạp dữ liệu mẫu ban đầu.
- **Chuỗi kết nối (Connection String) đang sử dụng trên máy cá nhân:**
  ```csharp
  Server=.;Database=EduManagerDB;Integrated Security=True;TrustServerCertificate=True;