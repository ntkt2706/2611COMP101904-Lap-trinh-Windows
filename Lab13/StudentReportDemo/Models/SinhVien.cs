namespace StudentReportDemo.Models
{
    public class SinhVien
    {
        public string MaSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string MaLop { get; set; } = "";
        public string TenLop { get; set; } = "";
        public double Diem { get; set; }

        // Chỉ đọc: tự tính từ Diem, không cần lưu riêng
        public string KetQua => Diem >= 5 ? "Đạt" : "Không đạt";
    }
}