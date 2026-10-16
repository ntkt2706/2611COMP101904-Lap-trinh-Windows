using System;

namespace Lab03_QuanLySinhVienOOP
{
    public class SinhVien : Nguoi
    {
        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }

        private double _diemTrungBinh;
        public double DiemTrungBinh
        {
            get { return _diemTrungBinh; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Điểm trung bình phải nằm trong khoảng từ 0 đến 10.");
                _diemTrungBinh = value;
            }
        }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string maLop, double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (_diemTrungBinh >= 8.0) return "Giỏi";
            if (_diemTrungBinh >= 6.5) return "Khá";
            if (_diemTrungBinh >= 5.0) return "Trung bình";
            return "Yếu";
        }

        public override string LayThongTin()
        {
            return $"Mã SV: {MaSinhVien,-10} | {base.LayThongTin()} | Lớp: {MaLop,-10} | Điểm: {DiemTrungBinh,4:0.0} | Loại: {XepLoai()}";
        }
    }
}