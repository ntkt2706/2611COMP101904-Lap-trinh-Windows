using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_QuanLySinhVienOOP
{
    public class QuanLySinhVien
    {
        private List<SinhVien> _danhSach = new List<SinhVien>();

        public void Them(SinhVien sv)
        {
            if (_danhSach.Any(x => x.MaSinhVien.Equals(sv.MaSinhVien, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Mã sinh viên đã tồn tại trong hệ thống.");
            }
            _danhSach.Add(sv);
        }

        public List<SinhVien> LayDanhSach()
        {
            return _danhSach;
        }

        public SinhVien TimTheoMa(string maSV)
        {
            return _danhSach.FirstOrDefault(x => x.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return _danhSach.Where(x => x.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public bool SuaDiem(string maSV, double diemMoi)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                sv.DiemTrungBinh = diemMoi;
                return true;
            }
            return false;
        }

        public bool Xoa(string maSV)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                _danhSach.Remove(sv);
                return true;
            }
            return false;
        }

        public List<SinhVien> SapXepTheoDiem()
        {
            return _danhSach.OrderByDescending(x => x.DiemTrungBinh).ToList();
        }

        public List<SinhVien> LocSinhVienDat()
        {
            return _danhSach.Where(x => x.DiemTrungBinh >= 5.0).ToList();
        }
    }
}