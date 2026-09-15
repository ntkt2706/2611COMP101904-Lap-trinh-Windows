# LAB 02 - QUẢN LÝ MẢNG SỐ NGUYÊN

## 1. Giới thiệu

Chương trình Console được xây dựng bằng C#, dùng để nhập, xuất và xử lý mảng số nguyên thông qua menu.

---

## 2. Menu chương trình

![Menu chương trình](Images/01-menu.png)

Chương trình gồm các chức năng:

- Nhập mảng
- Xuất mảng
- Tính tổng
- Tìm Max/Min
- Đếm số chẵn/lẻ
- Sắp xếp tăng dần
- Tìm kiếm phần tử
- Thoát chương trình

---

## 3. Nhập mảng

Người dùng nhập số lượng phần tử `n` và các phần tử của mảng.

![Nhập mảng](Images/02-nhap-mang.png)

---

## 4. Xuất mảng

Hiển thị các phần tử đã nhập trong mảng.

![Xuất mảng](Images/03-xuat-mang.png)

---

## 5. Tính tổng

Chương trình tính tổng tất cả các phần tử trong mảng.

![Tính tổng](Images/04-tinh-tong.png)

---

## 6. Tìm Max/Min

Tìm và hiển thị giá trị lớn nhất và nhỏ nhất trong mảng.

![Tìm Max Min](Images/05-max-min.png)

---

## 7. Đếm số chẵn/lẻ

Đếm số lượng phần tử chẵn và số lượng phần tử lẻ trong mảng.

![Đếm chẵn lẻ](Images/06-dem-chan-le.png)

---

## 8. Sắp xếp tăng dần

Sắp xếp các phần tử trong mảng theo thứ tự tăng dần.

![Sắp xếp tăng dần](Images/07-sap-xep.png)

---

## 9. Tìm kiếm

Nhập giá trị `x` và tìm vị trí xuất hiện đầu tiên của `x` trong mảng.

![Tìm kiếm](Images/08-tim-kiem.png)

### Trường hợp không tìm thấy

![Không tìm thấy](Images/09-khong-tim-thay.png)

---

## 10. Kiểm tra dữ liệu

Chương trình kiểm tra dữ liệu nhập, đảm bảo số lượng phần tử phải là số nguyên dương.

![Lỗi số lượng phần tử](Images/10-loi-so-luong.png)

Chương trình cũng xử lý dữ liệu nhập không hợp lệ và yêu cầu người dùng nhập lại.

![Thoát chương trình](Images/11-thoat.png)

---

## 11. Các phương thức chính

Chương trình được chia thành các phương thức:

- `NhapSoNguyen()`
- `NhapSoNguyenDuong()`
- `NhapMang()`
- `XuatMang()`
- `TinhTong()`
- `TimMax()`
- `TimMin()`
- `DemChan()`
- `DemLe()`
- `SapXepTangDan()`
- `TimKiem()`
- `HienThiMenu()`

---

## 12. Kết luận

Lab02 hoàn thành các chức năng quản lý và xử lý mảng số nguyên bằng C# Console.

Chương trình có menu điều khiển, kiểm tra dữ liệu nhập và sử dụng các phương thức riêng cho từng chức năng.