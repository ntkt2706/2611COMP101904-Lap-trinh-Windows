
using System;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        // Lớp lưu thông tin khóa học và học phí mỗi tháng
        private class KhoaHoc
        {
            public string Ten { get; set; }
            public decimal HocPhi { get; set; }

            public KhoaHoc(string ten, decimal hocPhi)
            {
                Ten = ten;
                HocPhi = hocPhi;
            }

            public override string ToString()
            {
                return Ten;
            }
        }

        // Khởi tạo Form
        public Form1()
        {
            InitializeComponent();

            // Giới hạn số ký tự
            txtHoTen.MaxLength = 50;
            txtSoDienThoai.MaxLength = 10;

            // Kiểm soát ký tự nhập vào
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;

            // Đăng ký các sự kiện
            Load += Form1_Load;

            cboKhoaHoc.SelectedIndexChanged +=
                cboKhoaHoc_SelectedIndexChanged;

            numSoThang.ValueChanged +=
                numSoThang_ValueChanged;

            btnDangKy.Click += btnDangKy_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThoat.Click += btnThoat_Click;
        }

        // =========================
        // 1. KHỞI TẠO DỮ LIỆU
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Danh sách khóa học
            cboKhoaHoc.Items.Clear();

            cboKhoaHoc.Items.Add(
                new KhoaHoc("C# WinForms cơ bản", 800000m));

            cboKhoaHoc.Items.Add(
                new KhoaHoc("SQL Server cơ bản", 700000m));

            cboKhoaHoc.Items.Add(
                new KhoaHoc("Web Frontend cơ bản", 750000m));

            cboKhoaHoc.Items.Add(
                new KhoaHoc("Lập trình Python cơ bản", 650000m));

            // Chọn khóa học đầu tiên
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            // Thiết lập hình thức học mặc định
            radOnline.Checked = true;

            // Số tháng đăng ký từ 1 đến 12
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            // Không cho chọn ngày sinh trong tương lai
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = DateTime.Today;

            // Hiển thị học phí ban đầu
            CapNhatTongTien();
        }

        // =========================
        // 2. KIỂM TRA KÝ TỰ HỌ TÊN
        // =========================
        private void txtHoTen_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép chữ cái, dấu cách và phím điều khiển
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================
        // 3. KIỂM TRA KÝ TỰ SỐ ĐIỆN THOẠI
        // =========================
        private void txtSoDienThoai_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép chữ số ASCII từ 0 đến 9
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================
        // 4. CẬP NHẬT TỔNG HỌC PHÍ
        // =========================
        private void CapNhatTongTien()
        {
            KhoaHoc khoaHoc =
                cboKhoaHoc.SelectedItem as KhoaHoc;

            if (khoaHoc == null)
            {
                lblTongTien.Text = "0 VNĐ";
                return;
            }

            decimal tongTien =
                khoaHoc.HocPhi * numSoThang.Value;

            lblTongTien.Text =
                tongTien.ToString("N0") + " VNĐ";
        }

        // Khi chọn khóa học khác
        private void cboKhoaHoc_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        // Khi thay đổi số tháng
        private void numSoThang_ValueChanged(
            object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        // =========================
        // 5. NÚT ĐĂNG KÝ
        // =========================
        private void btnDangKy_Click(
            object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            // Kiểm tra họ tên không được để trống
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ và tên học viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // Kiểm tra họ tên tối đa 50 ký tự
            if (hoTen.Length > 50)
            {
                MessageBox.Show(
                    "Họ tên không được vượt quá 50 ký tự!",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // Kiểm tra họ tên chỉ gồm chữ cái và dấu cách
            foreach (char c in hoTen)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show(
                        "Họ tên chỉ được chứa chữ cái và dấu cách!",
                        "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtHoTen.Focus();
                    return;
                }
            }

            // Kiểm tra số điện thoại không được để trống
            if (string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra tối đa 10 chữ số
            if (soDienThoai.Length > 10)
            {
                MessageBox.Show(
                    "Số điện thoại không được vượt quá 10 chữ số!",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra số điện thoại chỉ chứa chữ số 0-9
            foreach (char c in soDienThoai)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show(
                        "Số điện thoại chỉ được chứa chữ số từ 0 đến 9!",
                        "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSoDienThoai.Focus();
                    return;
                }
            }

            // Kiểm tra khóa học
            KhoaHoc khoaHoc =
                cboKhoaHoc.SelectedItem as KhoaHoc;

            if (khoaHoc == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn khóa học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboKhoaHoc.Focus();
                return;
            }

            // Lấy thông tin đăng ký
            string hinhThucHoc =
                radOnline.Checked ? "Online" : "Trực tiếp";

            string nhanEmail =
                chkNhanEmail.Checked ? "Có" : "Không";

            decimal tongTien =
                khoaHoc.HocPhi * numSoThang.Value;

            // Tạo phiếu đăng ký
            string phieuDangKy =
                "PHIẾU ĐĂNG KÝ KHÓA HỌC\n" +
                "================================\n\n" +
                "Họ và tên: " + hoTen + "\n" +
                "Số điện thoại: " + soDienThoai + "\n" +
                "Ngày sinh: " +
                    dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\n" +
                "Khóa học: " + khoaHoc.Ten + "\n" +
                "Hình thức học: " + hinhThucHoc + "\n" +
                "Số tháng đăng ký: " + numSoThang.Value + "\n" +
                "Học phí mỗi tháng: " +
                    khoaHoc.HocPhi.ToString("N0") + " VNĐ\n" +
                "Tổng học phí: " +
                    tongTien.ToString("N0") + " VNĐ\n" +
                "Nhận email thông báo: " + nhanEmail;

            // Hiển thị phiếu đăng ký
            MessageBox.Show(
                phieuDangKy,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // 6. NÚT LÀM MỚI
        // =========================
        private void btnLamMoi_Click(
            object sender, EventArgs e)
        {
            // Xóa thông tin học viên
            txtHoTen.Clear();
            txtSoDienThoai.Clear();

            // Đặt lại ngày sinh
            dtpNgaySinh.Value = DateTime.Today;

            // Bỏ chọn nhận email
            chkNhanEmail.Checked = false;

            // Chọn khóa học đầu tiên
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            // Đặt lại hình thức học
            radOnline.Checked = true;

            // Đặt lại số tháng
            numSoThang.Value = 1;

            // Cập nhật tổng học phí
            CapNhatTongTien();

            // Đưa con trỏ về ô họ tên
            txtHoTen.Focus();
        }

        // =========================
        // 7. NÚT THOÁT
        // =========================
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}