# LAB 01 - THÔNG TIN SINH VIÊN

## 1. Giới thiệu

Chương trình được xây dựng bằng C# Windows Forms.

Chương trình cho phép người dùng nhập thông tin sinh viên gồm:

- Họ tên
- Năm sinh
- Email
- Giới tính
- Khoa/Lớp

Sau khi nhập đầy đủ thông tin, chương trình kiểm tra dữ liệu và hiển thị thông tin sinh viên.

---

## 2. Giao diện chương trình

![Giao diện chương trình](Images/giao-dien.png)

Giao diện gồm các thành phần:

- Ô nhập họ tên.
- Ô nhập năm sinh.
- Ô nhập Email.
- Nhóm lựa chọn giới tính Nam/Nữ.
- ComboBox lựa chọn khoa/lớp.
- Nút HIỂN THỊ.
- Nút XÓA.
- Nút THOÁT.
- Khung hiển thị kết quả.

---

## 3. Chức năng HIỂN THỊ

Người dùng nhập đầy đủ thông tin và nhấn nút **HIỂN THỊ**.

![Kết quả hiển thị](Images/ket-qua.png)

Chương trình kiểm tra dữ liệu, tính tuổi dựa trên năm sinh và hiển thị:

- Họ tên
- Tuổi
- Email
- Giới tính
- Khoa/Lớp

---

## 4. Kiểm tra dữ liệu

### 4.1. Không nhập họ tên

![Lỗi họ tên](Images/loi-ho-ten.png)

Khi người dùng không nhập họ tên và nhấn **HIỂN THỊ**, chương trình thông báo:

> Vui lòng nhập họ tên!

---

### 4.2. Năm sinh không hợp lệ

![Lỗi năm sinh](Images/loi-nam-sinh.png)

Khi năm sinh không phải số nguyên hoặc nằm ngoài khoảng hợp lệ, chương trình thông báo lỗi và yêu cầu nhập lại.

---

### 4.3. Email không hợp lệ

![Lỗi Email](Images/loi-email.png)

Khi Email không đúng định dạng, chương trình thông báo lỗi và yêu cầu người dùng nhập lại.

---

### 4.4. Chưa chọn giới tính

![Chưa chọn giới tính](Images/loi-gioi-tinh.png)

Khi người dùng chưa chọn **Nam** hoặc **Nữ**, chương trình thông báo yêu cầu chọn giới tính.

---

### 4.5. Chưa chọn khoa/lớp

![Chưa chọn khoa](Images/loi-khoa.png)

Khi người dùng chưa chọn khoa/lớp, chương trình thông báo yêu cầu chọn khoa/lớp.

---

## 5. Chức năng XÓA

![Chức năng Xóa](Images/chuc-nang-xoa.png)

Khi nhấn nút **XÓA**, chương trình sẽ:

- Xóa họ tên.
- Xóa năm sinh.
- Xóa Email.
- Bỏ chọn giới tính.
- Bỏ chọn khoa/lớp.
- Xóa kết quả hiển thị.

Sau khi thực hiện, các ô nhập liệu được đưa về trạng thái ban đầu.

---

## 6. Chức năng THOÁT

![Chức năng Thoát](Images/chuc-nang-thoat.png)

Khi nhấn nút **THOÁT**, chương trình hiển thị hộp thoại xác nhận.

Nếu chọn **Yes**, chương trình kết thúc.

Nếu chọn **No**, chương trình tiếp tục hoạt động.

---

## 7. Danh sách khoa

Chương trình có các khoa:

- Khoa Ngữ Văn
- Khoa Toán - Tin học
- Khoa Công nghệ thông tin
- Khoa Vật lý
- Khoa Hóa học
- Khoa Sinh học
- Khoa Lịch sử
- Khoa Địa lý
- Khoa tiếng Anh
- Khoa tiếng Pháp
- Khoa tiếng Nga
- Khoa tiếng Trung
- Khoa tiếng Nhật
- Khoa tiếng Hàn quốc
- Khoa Giáo dục chính trị
- Khoa Tâm lý học
- Khoa Khoa học Giáo dục
- Khoa Giáo dục Tiểu học
- Khoa Giáo dục Mầm non
- Khoa Giáo dục Quốc phòng
- Khoa Giáo dục đặc biệt
- Khoa Giáo dục Thể chất

---

## 8. Kết luận

Chương trình đáp ứng các chức năng nhập, kiểm tra và hiển thị thông tin sinh viên bằng Windows Forms.

Source code được lưu trữ trên GitHub và có thể mở bằng Visual Studio để chạy chương trình.