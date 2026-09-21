using System;

namespace QuanLyNhanVien
{
    public class NhanVienVanPhong : NhanVien
    {
        // Field
        private int soNgayLamViec;

        // Property
        public int SoNgayLamViec
        {
            get
            {
                return soNgayLamViec;
            }
            set
            {
                if (value < 0 || value > 31)
                {
                    throw new ArgumentException(
                        "So ngay lam viec phai tu 0 den 31!"
                    );
                }

                soNgayLamViec = value;
            }
        }

        // Constructor su dung base(...)
        public NhanVienVanPhong(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            int soNgayLamViec)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        // Override TinhLuong()
        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        // Override HienThiThongTin()
        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai nhan vien: Van phong");
            Console.WriteLine("Ma nhan vien: " + MaNhanVien);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine(
                "Luong co ban: " + LuongCoBan.ToString("N0")
            );
            Console.WriteLine(
                "So ngay lam viec: " + SoNgayLamViec
            );
            Console.WriteLine(
                "Tong luong: " + TinhLuong().ToString("N0")
            );
        }
    }
}