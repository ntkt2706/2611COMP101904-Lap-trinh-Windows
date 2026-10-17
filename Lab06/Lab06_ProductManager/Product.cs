using System;
using System.ComponentModel;

namespace Lab06_ProductManager
{
    public class Product
    {
        [DisplayName("Mã SP")]
        public string MaSP { get; set; }

        [DisplayName("Tên SP")]
        public string TenSP { get; set; }

        [DisplayName("Loại SP")]
        public string LoaiSP { get; set; }

        [DisplayName("Đơn giá")]
        public decimal DonGia { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Ngày nhập")]
        public DateTime NgayNhap { get; set; }

        [DisplayName("Còn KD")]
        public bool ConKinhDoanh { get; set; }

        // Ẩn cột đường dẫn ảnh trên DataGridView
        [Browsable(false)]
        public string DuongDanAnh { get; set; }
    }
}