using System;

namespace Lab03_QuanLySinhVienOOP
{
    public class SinhVien : Nguoi
    {
        public string MaSinhVien { get; set; }

        private double diemTrungBinh;

        public double DiemTrungBinh
        {
            get
            {
                return diemTrungBinh;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemTrungBinh = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Diem trung binh phai tu 0 den 10!");
                }
            }
        }

        public string MaLop { get; set; }

        public SinhVien(
            string maSinhVien,
            string hoTen,
            DateTime ngaySinh,
            string maLop,
            double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 8)
            {
                return "Gioi";
            }
            else if (DiemTrungBinh >= 6.5)
            {
                return "Kha";
            }
            else if (DiemTrungBinh >= 5)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }
        }

        public override string LayThongTin()
        {
            return "Ma sinh vien: " + MaSinhVien
                + "\nHo ten: " + HoTen
                + "\nNgay sinh: " + NgaySinh.ToString("dd/MM/yyyy")
                + "\nMa lop: " + MaLop
                + "\nDiem trung binh: " + DiemTrungBinh
                + "\nXep loai: " + XepLoai();
        }
    }
}