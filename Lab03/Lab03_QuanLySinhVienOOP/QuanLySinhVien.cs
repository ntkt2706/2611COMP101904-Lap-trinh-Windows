using System.Collections.Generic;
using System.Linq;

namespace Lab03_QuanLySinhVienOOP
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSach;

        public QuanLySinhVien()
        {
            danhSach = new List<SinhVien>();
        }

        // Them sinh vien
        public bool Them(SinhVien sinhVien)
        {
            SinhVien? sinhVienTonTai = danhSach
                .FirstOrDefault(sv =>
                    sv.MaSinhVien == sinhVien.MaSinhVien);

            if (sinhVienTonTai != null)
            {
                return false;
            }

            danhSach.Add(sinhVien);
            return true;
        }

        // Lay danh sach
        public List<SinhVien> LayDanhSach()
        {
            return danhSach;
        }

        // Tim theo ma
        public SinhVien? TimTheoMa(string maSinhVien)
        {
            return danhSach.FirstOrDefault(
                sv => sv.MaSinhVien == maSinhVien);
        }

        // Tim theo ten
        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return danhSach
                .Where(sv => sv.HoTen
                    .ToLower()
                    .Contains(tuKhoa.ToLower()))
                .ToList();
        }

        // Sua diem
        public bool SuaDiem(
            string maSinhVien,
            double diemMoi)
        {
            SinhVien? sinhVien = TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                return false;
            }

            sinhVien.DiemTrungBinh = diemMoi;
            return true;
        }

        // Xoa sinh vien
        public bool Xoa(string maSinhVien)
        {
            SinhVien? sinhVien = TimTheoMa(maSinhVien);

            if (sinhVien == null)
            {
                return false;
            }

            danhSach.Remove(sinhVien);
            return true;
        }

        // Sap xep diem giam dan
        public List<SinhVien> SapXepTheoDiem()
        {
            return danhSach
                .OrderByDescending(sv => sv.DiemTrungBinh)
                .ToList();
        }

        // Loc sinh vien dat
        public List<SinhVien> LocSinhVienDat()
        {
            return danhSach
                .Where(sv => sv.DiemTrungBinh >= 5)
                .ToList();
        }
    }
}