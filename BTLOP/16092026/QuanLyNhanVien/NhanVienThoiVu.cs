using System;

namespace QuanLyNhanVien
{
    public class NhanVienThoiVu : NhanVien
    {
        // Field
        private double soGioLam;
        private double luongTheoGio;

        // Property - SoGioLam
        public double SoGioLam
        {
            get
            {
                return soGioLam;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "So gio lam khong duoc am!"
                    );
                }

                soGioLam = value;
            }
        }

        // Property - LuongTheoGio
        public double LuongTheoGio
        {
            get
            {
                return luongTheoGio;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Luong theo gio khong duoc am!"
                    );
                }

                luongTheoGio = value;
            }
        }

        // Constructor
        public NhanVienThoiVu(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            double soGioLam,
            double luongTheoGio)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        // Override TinhLuong()
        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        // Override HienThiThongTin()
        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai nhan vien: Thoi vu");
            Console.WriteLine("Ma nhan vien: " + MaNhanVien);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine(
                "So gio lam: " + SoGioLam
            );
            Console.WriteLine(
                "Luong theo gio: " + LuongTheoGio.ToString("N0")
            );
            Console.WriteLine(
                "Tong luong: " + TinhLuong().ToString("N0")
            );
        }
    }
}