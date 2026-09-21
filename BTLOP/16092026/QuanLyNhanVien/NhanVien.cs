using System;

namespace QuanLyNhanVien
{
    public class NhanVien
    {
        // Field
        private string maNhanVien;
        private string hoTen;
        private double luongCoBan;

        // Property - MaNhanVien
        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Ma nhan vien khong duoc rong!"
                    );
                }

                maNhanVien = value;
            }
        }

        // Property - HoTen
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Ho ten khong duoc rong!"
                    );
                }

                hoTen = value;
            }
        }

        // Property - LuongCoBan
        public double LuongCoBan
        {
            get
            {
                return luongCoBan;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Luong co ban phai lon hon 0!"
                    );
                }

                luongCoBan = value;
            }
        }

        // Constructor
        public NhanVien(
            string maNhanVien,
            string hoTen,
            double luongCoBan)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        // Phuong thuc virtual tinh luong
        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }

        // Phuong thuc virtual hien thi thong tin
        public virtual void HienThiThongTin()
        {
            Console.WriteLine("Ma nhan vien: " + MaNhanVien);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine(
                "Luong co ban: " + LuongCoBan.ToString("N0")
            );
            Console.WriteLine(
                "Tong luong: " + TinhLuong().ToString("N0")
            );
        }
    }
}