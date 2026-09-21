using System;
using System.Collections.Generic;

namespace Lab03_QuanLySinhVienOOP
{
    internal class Program
    {
        static QuanLySinhVien quanLy = new QuanLySinhVien();

        static void Main(string[] args)
        {
            int luaChon;

            do
            {
                HienThiMenu();
                luaChon = NhapSoNguyen("Chon chuc nang: ");

                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;

                    case 2:
                        XuatDanhSach(quanLy.LayDanhSach());
                        break;

                    case 3:
                        TimTheoMa();
                        break;

                    case 4:
                        TimTheoTen();
                        break;

                    case 5:
                        SuaDiem();
                        break;

                    case 6:
                        XoaSinhVien();
                        break;

                    case 7:
                        XuatDanhSach(
                            quanLy.SapXepTheoDiem());
                        break;

                    case 8:
                        XuatDanhSach(
                            quanLy.LocSinhVienDat());
                        break;

                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine("\nNhan Enter de tiep tuc...");
                    Console.ReadLine();
                }

            } while (luaChon != 0);
        }

        // Hien thi menu
        static void HienThiMenu()
        {
            Console.Clear();

            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("=============================");
        }

        // Them sinh vien
        static void ThemSinhVien()
        {
            Console.WriteLine("\n--- THEM SINH VIEN ---");

            Console.Write("Nhap ma sinh vien: ");
            string maSinhVien = Console.ReadLine() ?? "";

            if (quanLy.TimTheoMa(maSinhVien) != null)
            {
                Console.WriteLine("Ma sinh vien da ton tai!");
                return;
            }

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine() ?? "";

            DateTime ngaySinh = NhapNgaySinh();

            Console.Write("Nhap ma lop: ");
            string maLop = Console.ReadLine() ?? "";

            double diemTrungBinh = NhapDiem();

            try
            {
                SinhVien sinhVien = new SinhVien(
                    maSinhVien,
                    hoTen,
                    ngaySinh,
                    maLop,
                    diemTrungBinh);

                if (quanLy.Them(sinhVien))
                {
                    Console.WriteLine("Them sinh vien thanh cong!");
                }
                else
                {
                    Console.WriteLine("Them that bai!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }

        // Xuat danh sach
        static void XuatDanhSach(List<SinhVien> danhSach)
        {
            Console.WriteLine("\n--- DANH SACH SINH VIEN ---");

            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            foreach (SinhVien sinhVien in danhSach)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(sinhVien.LayThongTin());
            }
        }

        // Tim theo ma
        static void TimTheoMa()
        {
            Console.Write("\nNhap ma sinh vien can tim: ");
            string maSinhVien = Console.ReadLine() ?? "";

            SinhVien? sinhVien = quanLy.TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
            else
            {
                Console.WriteLine(sinhVien.LayThongTin());
            }
        }

        // Tim theo ten
        static void TimTheoTen()
        {
            Console.Write("\nNhap tu khoa ho ten: ");
            string tuKhoa = Console.ReadLine() ?? "";

            List<SinhVien> danhSach = quanLy.TimTheoTen(tuKhoa);

            if (danhSach.Count == 0)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
            else
            {
                XuatDanhSach(danhSach);
            }
        }

        // Sua diem
        static void SuaDiem()
        {
            Console.Write("\nNhap ma sinh vien: ");
            string maSinhVien = Console.ReadLine() ?? "";

            SinhVien? sinhVien = quanLy.TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
                return;
            }

            double diemMoi = NhapDiem();

            try
            {
                if (quanLy.SuaDiem(maSinhVien, diemMoi))
                {
                    Console.WriteLine("Sua diem thanh cong!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }

        // Xoa sinh vien
        static void XoaSinhVien()
        {
            Console.Write("\nNhap ma sinh vien can xoa: ");
            string maSinhVien = Console.ReadLine() ?? "";

            if (quanLy.Xoa(maSinhVien))
            {
                Console.WriteLine("Xoa sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }

        // Nhap diem
        static double NhapDiem()
        {
            double diem;

            while (true)
            {
                Console.Write("Nhap diem trung binh (0-10): ");

                if (double.TryParse(
                    Console.ReadLine(), out diem))
                {
                    if (diem >= 0 && diem <= 10)
                    {
                        return diem;
                    }
                }

                Console.WriteLine(
                    "Diem khong hop le! Vui long nhap lai.");
            }
        }

        // Nhap ngay sinh
        static DateTime NhapNgaySinh()
        {
            DateTime ngaySinh;

            while (true)
            {
                Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");

                if (DateTime.TryParse(
                    Console.ReadLine(), out ngaySinh))
                {
                    return ngaySinh;
                }

                Console.WriteLine("Ngay sinh khong hop le!");
            }
        }

        // Nhap so nguyen
        static int NhapSoNguyen(string thongBao)
        {
            int so;

            while (true)
            {
                Console.Write(thongBao);

                if (int.TryParse(
                    Console.ReadLine(), out so))
                {
                    return so;
                }

                Console.WriteLine("Vui long nhap so nguyen!");
            }
        }
    }
}