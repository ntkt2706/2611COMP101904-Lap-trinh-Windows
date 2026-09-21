using System;

namespace QuanLyNhanVien
{
    public class NhanVienKinhDoanh : NhanVien
    {
        // Field
        private double doanhSo;

        // Property
        public double DoanhSo
        {
            get
            {
                return doanhSo;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Doanh so khong duoc am!"
                    );
                }

                doanhSo = value;
            }
        }

        // Constructor su dung base(...)
        public NhanVienKinhDoanh(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            double doanhSo)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        // Override TinhLuong()
        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        // Override HienThiThongTin()
        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai nhan vien: Kinh doanh");
            Console.WriteLine("Ma nhan vien: " + MaNhanVien);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine(
                "Luong co ban: " + LuongCoBan.ToString("N0")
            );
            Console.WriteLine(
                "Doanh so: " + DoanhSo.ToString("N0")
            );
            Console.WriteLine(
                "Tong luong: " + TinhLuong().ToString("N0")
            );
        }
    }
}