# LAB 05 - WINDOWS FORMS CƠ BẢN

## 1. Thông tin sinh viên

 Họ và tên Nguyễn Trần Khang Thịnh
 Mã số sinh viên 51.01.104.097
 Lớp 2611COMP101904
 Nhóm [Điền số nhóm của bạn]
 Môn học COMP1019 - Lập trình trên Windows
 Tên dự án CourseRegistrationApp

---

## 2. Mục tiêu bài thực hành

Bài thực hành nhằm củng cố kiến thức lập trình Windows Forms bằng C#, thực hành thiết kế giao diện, xử lý sự kiện và kiểm tra dữ liệu đầu vào.

Thông qua bài tập, sinh viên xây dựng ứng dụng đăng ký khóa học với các chức năng quản lý thông tin học viên, lựa chọn khóa học, tính học phí, xác nhận đăng ký, làm mới dữ liệu và xác nhận thoát chương trình.

## 3. Công nghệ sử dụng

 Ngôn ngữ lập trình C#
 Nền tảng Windows Forms
 Môi trường phát triển Microsoft Visual Studio
 Cơ sở dữ liệu Không sử dụng

## 4. Nội dung và yêu cầu thực hiện

### 4.1. Thiết kế giao diện

Giao diện ứng dụng có tiêu đề ĐĂNG KÝ KHÓA HỌC, sử dụng các GroupBox để phân nhóm thông tin học viên và thông tin đăng ký khóa học.

Các thành phần giao diện gồm

 TextBox nhập họ tên và số điện thoại.
 DateTimePicker chọn ngày sinh.
 CheckBox lựa chọn nhận email thông báo.
 ComboBox lựa chọn khóa học.
 RadioButton lựa chọn hình thức học Online hoặc Trực tiếp.
 NumericUpDown lựa chọn số tháng đăng ký.
 Label hiển thị tổng học phí.
 Các nút Đăng ký, Làm mới và Thoát.

Hình 1. Giao diện chính của chương trình

![Giao diện chính](Imagesgiao-dien.png)

### 4.2. Khởi tạo Form và danh sách khóa học

Khi Form được khởi chạy, chương trình nạp danh sách khóa học vào ComboBox, chọn khóa học đầu tiên, thiết lập hình thức học mặc định là Online và giới hạn số tháng đăng ký từ 1 đến 12.

Tổng học phí ban đầu được tính và hiển thị ngay trên giao diện.

Danh sách khóa học gồm

 STT  Tên khóa học             Học phítháng 
 --  -----------------------  ------------ 
   1  C# WinForms cơ bản         800.000 VNĐ 
   2  SQL Server cơ bản          700.000 VNĐ 
   3  Web Frontend cơ bản        750.000 VNĐ 
   4  Lập trình Python cơ bản    650.000 VNĐ 

Hình 2. Danh sách khóa học và giá trị khởi tạo

![Khởi tạo Form](Imageskhoi-tao-form.png)

### 4.3. Tính tổng học phí

Chương trình tự động cập nhật tổng học phí khi người dùng thay đổi khóa học hoặc số tháng đăng ký.

Công thức tính

Tổng học phí = Học phí một tháng × Số tháng đăng ký

Ví dụ khóa học SQL Server cơ bản có học phí 700.000 VNĐtháng. Khi đăng ký trong 3 tháng, tổng học phí là 2.100.000 VNĐ.

Hình 3. Kết quả tính học phí

![Tính học phí](Imagestinh-hoc-phi.png)

### 4.4. Chức năng đăng ký khóa học

Khi nhấn nút Đăng ký, chương trình kiểm tra thông tin bắt buộc trước khi xử lý đăng ký.

Các điều kiện kiểm tra gồm

 Họ tên không được để trống.
 Số điện thoại không được để trống.
 Phải chọn khóa học hợp lệ.

Nếu dữ liệu hợp lệ, chương trình hiển thị phiếu đăng ký bằng MessageBox, bao gồm họ tên, số điện thoại, ngày sinh, khóa học, hình thức học, số tháng đăng ký, tổng học phí và trạng thái nhận email.

Hình 4. Phiếu đăng ký khóa học

![Phiếu đăng ký](Imagesphieu-dang-ky.png)

### 4.5. Kiểm tra dữ liệu đầu vào

Chương trình sử dụng MessageBox để thông báo khi người dùng chưa nhập đầy đủ thông tin bắt buộc.

Trường hợp 1 Họ tên để trống

Khi người dùng nhấn Đăng ký mà chưa nhập họ tên, chương trình hiển thị thông báo yêu cầu nhập họ tên và không tiếp tục xử lý đăng ký.

![Kiểm tra họ tên](Imagesloi-ho-ten.png)

Hình 5. Thông báo khi họ tên để trống

Trường hợp 2 Số điện thoại để trống

Khi người dùng đã nhập họ tên nhưng chưa nhập số điện thoại, chương trình hiển thị thông báo yêu cầu nhập số điện thoại.

![Kiểm tra số điện thoại](Imagesloi-so-dien-thoai.png)

Hình 6. Thông báo khi số điện thoại để trống

### 4.6. Chức năng Làm mới

Khi nhấn nút Làm mới, chương trình khôi phục giao diện về trạng thái ban đầu

 Xóa họ tên và số điện thoại.
 Đưa ngày sinh về ngày hiện tại.
 Bỏ chọn nhận email.
 Chọn lại khóa học đầu tiên.
 Chọn lại hình thức học Online.
 Đưa số tháng đăng ký về 1.
 Cập nhật lại tổng học phí.
 Đưa con trỏ về ô nhập họ tên.

Hình 7. Giao diện sau khi làm mới

![Làm mới](Imageslam-moi.png)

### 4.7. Chức năng Thoát

Khi nhấn nút Thoát, chương trình hiển thị hộp thoại xác nhận với hai lựa chọn Yes và No.

 Yes Đóng Form và kết thúc chương trình.
 No Hủy thao tác thoát và tiếp tục sử dụng chương trình.

Hình 8. Hộp thoại xác nhận thoát chương trình

![Xác nhận thoát](Imagesxac-nhan-thoat.png)

## 5. Tổng kết

Qua bài thực hành, sinh viên đã vận dụng kiến thức C# và Windows Forms để xây dựng ứng dụng đăng ký khóa học với giao diện trực quan, các chức năng xử lý sự kiện, kiểm tra dữ liệu đầu vào, tính toán học phí và hiển thị thông báo bằng MessageBox.

Bài thực hành giúp củng cố kỹ năng thiết kế giao diện, đặt tên điều khiển, xử lý sự kiện và tổ chức mã nguồn trong một ứng dụng Windows Forms cơ bản.

---

Sinh viên thực hiện Nguyễn Trần Khang Thịnh
MSSV 51.01.104.097
Môn học COMP1019 - Lập trình trên Windows
