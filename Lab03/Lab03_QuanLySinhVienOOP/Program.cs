using System;
using System.Collections.Generic;

namespace Lab03_QuanLySinhVienOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            QuanLySinhVien qlsv = new QuanLySinhVien();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim sinh vien theo ma");
                Console.WriteLine("4. Tim sinh vien theo ten");
                Console.WriteLine("5. Sua diem trung binh");
                Console.WriteLine("6. Xoa sinh vien");
                Console.WriteLine("7. Sap xep theo diem giam dan");
                Console.WriteLine("8. Loc sinh vien dat");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                string choice = Console.ReadLine();
                Console.WriteLine("-----------------------------");

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Nhập mã sinh viên: ");
                            string ma = Console.ReadLine();
                            Console.Write("Nhập họ tên: ");
                            string ten = Console.ReadLine();
                            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                            DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            Console.Write("Nhập mã lớp: ");
                            string lop = Console.ReadLine();
                            Console.Write("Nhập điểm trung bình (0-10): ");
                            double diem = double.Parse(Console.ReadLine());

                            SinhVien sv = new SinhVien(ma, ten, ngaySinh, lop, diem);
                            qlsv.Them(sv);
                            Console.WriteLine("=> Thêm sinh viên thành công!");
                            break;

                        case "2":
                            XuatDanhSach(qlsv.LayDanhSach());
                            break;

                        case "3":
                            Console.Write("Nhập mã sinh viên cần tìm: ");
                            var svTim = qlsv.TimTheoMa(Console.ReadLine());
                            if (svTim != null) Console.WriteLine(svTim.LayThongTin());
                            else Console.WriteLine("=> Không tìm thấy sinh viên.");
                            break;

                        case "4":
                            Console.Write("Nhập từ khóa tên cần tìm: ");
                            var dsTim = qlsv.TimTheoTen(Console.ReadLine());
                            XuatDanhSach(dsTim, "Không tìm thấy sinh viên nào khớp với từ khóa.");
                            break;

                        case "5":
                            Console.Write("Nhập mã sinh viên cần sửa điểm: ");
                            string maSua = Console.ReadLine();
                            Console.Write("Nhập điểm mới: ");
                            double diemMoi = double.Parse(Console.ReadLine());

                            if (qlsv.SuaDiem(maSua, diemMoi)) Console.WriteLine("=> Cập nhật điểm thành công!");
                            else Console.WriteLine("=> Không tìm thấy mã sinh viên này.");
                            break;

                        case "6":
                            Console.Write("Nhập mã sinh viên cần xóa: ");
                            if (qlsv.Xoa(Console.ReadLine())) Console.WriteLine("=> Đã xóa sinh viên.");
                            else Console.WriteLine("=> Không tìm thấy mã sinh viên này.");
                            break;

                        case "7":
                            XuatDanhSach(qlsv.SapXepTheoDiem());
                            break;

                        case "8":
                            XuatDanhSach(qlsv.LocSinhVienDat(), "Không có sinh viên nào đạt (điểm >= 5).");
                            break;

                        case "0":
                            isRunning = false;
                            Console.WriteLine("=> Đã thoát chương trình.");
                            break;

                        default:
                            Console.WriteLine("=> Lựa chọn không hợp lệ!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("=> [LỖI] Dữ liệu nhập sai định dạng (ví dụ: nhập chữ vào phần số hoặc sai ngày).");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"=> [LỖI DỮ LIỆU] {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"=> [LỖI NGHIỆP VỤ] {ex.Message}");
                }
            }
        }

        static void XuatDanhSach(List<SinhVien> ds, string thongBaoRong = "Danh sách trống.")
        {
            if (ds.Count == 0)
            {
                Console.WriteLine($"=> {thongBaoRong}");
                return;
            }
            foreach (var sv in ds)
            {
                Console.WriteLine(sv.LayThongTin());
            }
        }
    }
}