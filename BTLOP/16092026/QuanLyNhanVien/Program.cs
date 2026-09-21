using System;
using System.Collections.Generic;

namespace QuanLyNhanVien
{
    internal class Program
    {
        // Danh sach nhan vien
        static List<NhanVien> danhSach =
            new List<NhanVien>();

        static void Main(string[] args)
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Console.InputEncoding =
                System.Text.Encoding.UTF8;

            NhapDanhSachNhanVien();

            int luaChon;

            do
            {
                HienThiMenu();

                luaChon = NhapSoNguyen(
                    "Nhap lua chon: "
                );

                switch (luaChon)
                {
                    case 1:
                        XuatDanhSach();
                        break;

                    case 2:
                        TimNhanVienTheoMa();
                        break;

                    case 3:
                        TimNhanVienLuongCaoNhat();
                        break;

                    case 4:
                        TinhTongLuong();
                        break;

                    case 0:
                        Console.WriteLine(
                            "Da thoat chuong trinh!"
                        );
                        break;

                    default:
                        Console.WriteLine(
                            "Lua chon khong hop le!"
                        );
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine(
                        "\nNhan phim bat ky de tiep tuc..."
                    );

                    Console.ReadKey();

                    Console.Clear();
                }

            } while (luaChon != 0);
        }


        // ==================================
        // HIEN THI MENU
        // ==================================

        static void HienThiMenu()
        {
            Console.WriteLine(
                "\n========== MENU =========="
            );

            Console.WriteLine(
                "1. Xuat danh sach nhan vien"
            );

            Console.WriteLine(
                "2. Tim nhan vien theo ma"
            );

            Console.WriteLine(
                "3. Tim nhan vien co luong cao nhat"
            );

            Console.WriteLine(
                "4. Tinh tong luong cong ty phai tra"
            );

            Console.WriteLine("0. Thoat");

            Console.WriteLine(
                "=========================="
            );
        }


        // ==================================
        // NHAP DANH SACH NHAN VIEN
        // ==================================

        static void NhapDanhSachNhanVien()
        {
            Console.WriteLine(
                "===== NHAP DANH SACH NHAN VIEN ====="
            );

            int soLuong;

            do
            {
                soLuong = NhapSoNguyen(
                    "Nhap so luong nhan vien (>= 5): "
                );

                if (soLuong < 5)
                {
                    Console.WriteLine(
                        "Phai nhap it nhat 5 nhan vien!"
                    );
                }

            } while (soLuong < 5);


            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(
                    "\n--- Nhan vien thu " + (i + 1) + " ---"
                );

                NhapMotNhanVien();
            }
        }


        // ==================================
        // NHAP MOT NHAN VIEN
        // ==================================

        static void NhapMotNhanVien()
        {
            int loai;

            do
            {
                Console.WriteLine(
                    "1. Nhan vien van phong"
                );

                Console.WriteLine(
                    "2. Nhan vien kinh doanh"
                );

                Console.WriteLine(
                    "3. Nhan vien thoi vu (Bonus)"
                );

                loai = NhapSoNguyen(
                    "Nhap loai nhan vien: "
                );

                if (loai < 1 || loai > 3)
                {
                    Console.WriteLine(
                        "Loai nhan vien khong hop le!"
                    );
                }

            } while (loai < 1 || loai > 3);


            string maNhanVien = NhapChuoi(
                "Nhap ma nhan vien: "
            );

            string hoTen = NhapChuoi(
                "Nhap ho ten: "
            );

            double luongCoBan = NhapSoThucDuong(
                "Nhap luong co ban (> 0): "
            );


            if (loai == 1)
            {
                int soNgayLamViec =
                    NhapSoNgayLamViec();

                NhanVienVanPhong nv =
                    new NhanVienVanPhong(
                        maNhanVien,
                        hoTen,
                        luongCoBan,
                        soNgayLamViec
                    );

                danhSach.Add(nv);
            }
            else if (loai == 2)
            {
                double doanhSo =
                    NhapDoanhSo();

                NhanVienKinhDoanh nv =
                    new NhanVienKinhDoanh(
                        maNhanVien,
                        hoTen,
                        luongCoBan,
                        doanhSo
                    );

                danhSach.Add(nv);
            }
            else
            {
                double soGioLam =
                    NhapSoGioLam();

                double luongTheoGio =
                    NhapLuongTheoGio();

                NhanVienThoiVu nv =
                    new NhanVienThoiVu(
                        maNhanVien,
                        hoTen,
                        luongCoBan,
                        soGioLam,
                        luongTheoGio
                    );

                danhSach.Add(nv);
            }
        }


        // ==================================
        // NHAP SO NGUYEN
        // ==================================

        static int NhapSoNguyen(string thongBao)
        {
            int ketQua;

            while (true)
            {
                Console.Write(thongBao);

                bool hopLe = int.TryParse(
                    Console.ReadLine(),
                    out ketQua
                );

                if (hopLe)
                {
                    return ketQua;
                }

                Console.WriteLine(
                    "Vui long nhap so nguyen hop le!"
                );
            }
        }


        // ==================================
        // NHAP SO THUC DUONG
        // ==================================

        static double NhapSoThucDuong(string thongBao)
        {
            double ketQua;

            while (true)
            {
                Console.Write(thongBao);

                bool hopLe = double.TryParse(
                    Console.ReadLine(),
                    out ketQua
                );

                if (hopLe && ketQua > 0)
                {
                    return ketQua;
                }

                Console.WriteLine(
                    "Vui long nhap so lon hon 0!"
                );
            }
        }


        // ==================================
        // NHAP CHUOI
        // ==================================

        static string NhapChuoi(string thongBao)
        {
            string ketQua;

            while (true)
            {
                Console.Write(thongBao);

                ketQua = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(ketQua))
                {
                    return ketQua.Trim();
                }

                Console.WriteLine(
                    "Khong duoc de trong!"
                );
            }
        }


        // ==================================
        // NHAP SO NGAY LAM VIEC
        // ==================================

        static int NhapSoNgayLamViec()
        {
            int soNgay;

            do
            {
                soNgay = NhapSoNguyen(
                    "Nhap so ngay lam viec (0-31): "
                );

                if (soNgay < 0 || soNgay > 31)
                {
                    Console.WriteLine(
                        "So ngay phai tu 0 den 31!"
                    );
                }

            } while (soNgay < 0 || soNgay > 31);

            return soNgay;
        }


        // ==================================
        // NHAP DOANH SO
        // ==================================

        static double NhapDoanhSo()
        {
            double doanhSo;

            do
            {
                Console.Write(
                    "Nhap doanh so (>= 0): "
                );

                bool hopLe = double.TryParse(
                    Console.ReadLine(),
                    out doanhSo
                );

                if (!hopLe || doanhSo < 0)
                {
                    Console.WriteLine(
                        "Doanh so phai >= 0!"
                    );

                    doanhSo = -1;
                }

            } while (doanhSo < 0);

            return doanhSo;
        }


        // ==================================
        // NHAP SO GIO LAM
        // ==================================

        static double NhapSoGioLam()
        {
            double soGioLam;

            do
            {
                Console.Write(
                    "Nhap so gio lam (>= 0): "
                );

                bool hopLe = double.TryParse(
                    Console.ReadLine(),
                    out soGioLam
                );

                if (!hopLe || soGioLam < 0)
                {
                    Console.WriteLine(
                        "So gio lam phai >= 0!"
                    );

                    soGioLam = -1;
                }

            } while (soGioLam < 0);

            return soGioLam;
        }


        // ==================================
        // NHAP LUONG THEO GIO
        // ==================================

        static double NhapLuongTheoGio()
        {
            double luongTheoGio;

            do
            {
                Console.Write(
                    "Nhap luong theo gio (>= 0): "
                );

                bool hopLe = double.TryParse(
                    Console.ReadLine(),
                    out luongTheoGio
                );

                if (!hopLe || luongTheoGio < 0)
                {
                    Console.WriteLine(
                        "Luong theo gio phai >= 0!"
                    );

                    luongTheoGio = -1;
                }

            } while (luongTheoGio < 0);

            return luongTheoGio;
        }


        // ==================================
        // 1. XUAT DANH SACH
        // ==================================

        static void XuatDanhSach()
        {
            Console.WriteLine(
                "\n===== DANH SACH NHAN VIEN ====="
            );

            if (danhSach.Count == 0)
            {
                Console.WriteLine(
                    "Danh sach nhan vien rong!"
                );

                return;
            }

            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.WriteLine(
                    "\nNhan vien thu " + (i + 1)
                );

                danhSach[i].HienThiThongTin();

                Console.WriteLine(
                    "------------------------------"
                );
            }
        }


        // ==================================
        // 2. TIM NHAN VIEN THEO MA
        // ==================================

        static void TimNhanVienTheoMa()
        {
            string maCanTim = NhapChuoi(
                "\nNhap ma nhan vien can tim: "
            );

            bool timThay = false;

            for (int i = 0; i < danhSach.Count; i++)
            {
                if (danhSach[i].MaNhanVien
                    .Equals(
                        maCanTim,
                        StringComparison.OrdinalIgnoreCase
                    ))
                {
                    Console.WriteLine(
                        "\n===== THONG TIN NHAN VIEN ====="
                    );

                    danhSach[i].HienThiThongTin();

                    timThay = true;
                }
            }

            if (timThay == false)
            {
                Console.WriteLine(
                    "Khong tim thay nhan vien!"
                );
            }
        }


        // ==================================
        // 3. TIM LUONG CAO NHAT
        // ==================================

        static void TimNhanVienLuongCaoNhat()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine(
                    "Danh sach nhan vien rong!"
                );

                return;
            }

            // Buoc 1: Tim luong cao nhat
            double luongCaoNhat =
                danhSach[0].TinhLuong();

            for (int i = 1; i < danhSach.Count; i++)
            {
                double luongHienTai =
                    danhSach[i].TinhLuong();

                if (luongHienTai > luongCaoNhat)
                {
                    luongCaoNhat = luongHienTai;
                }
            }

            Console.WriteLine(
                "\n===== NHAN VIEN CO LUONG CAO NHAT ====="
            );

            Console.WriteLine(
                "Muc luong cao nhat: "
                + luongCaoNhat.ToString("N0")
            );

            // Buoc 2: Hien thi nhan vien co luong cao nhat
            for (int i = 0; i < danhSach.Count; i++)
            {
                if (danhSach[i].TinhLuong()
                    == luongCaoNhat)
                {
                    danhSach[i].HienThiThongTin();

                    Console.WriteLine(
                        "------------------------------"
                    );
                }
            }
        }


        // ==================================
        // 4. TINH TONG LUONG
        // ==================================

        static void TinhTongLuong()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine(
                    "Danh sach nhan vien rong!"
                );

                return;
            }

            double tongLuong = 0;

            for (int i = 0; i < danhSach.Count; i++)
            {
                tongLuong += danhSach[i].TinhLuong();
            }

            Console.WriteLine(
                "\n===== TONG LUONG CONG TY ====="
            );

            Console.WriteLine(
                "Tong luong phai tra: "
                + tongLuong.ToString("N0")
            );
        }
    }
}