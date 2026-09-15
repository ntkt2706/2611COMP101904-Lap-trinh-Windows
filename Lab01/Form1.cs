using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Danh sách khoa
            // Danh sách các khoa
            cboKhoa.Items.Add("Khoa Ngữ Văn");
            cboKhoa.Items.Add("Khoa Toán - Tin học");
            cboKhoa.Items.Add("Khoa Công nghệ thông tin");
            cboKhoa.Items.Add("Khoa Vật lý");
            cboKhoa.Items.Add("Khoa Hóa học");
            cboKhoa.Items.Add("Khoa Sinh học");
            cboKhoa.Items.Add("Khoa Lịch sử");
            cboKhoa.Items.Add("Khoa Địa lý");
            cboKhoa.Items.Add("Khoa tiếng Anh");
            cboKhoa.Items.Add("Khoa tiếng Pháp");
            cboKhoa.Items.Add("Khoa tiếng Nga");
            cboKhoa.Items.Add("Khoa tiếng Trung");
            cboKhoa.Items.Add("Khoa tiếng Nhật");
            cboKhoa.Items.Add("Khoa tiếng Hàn quốc");
            cboKhoa.Items.Add("Khoa Giáo dục chính trị");
            cboKhoa.Items.Add("Khoa Tâm lý học");
            cboKhoa.Items.Add("Khoa Khoa học Giáo dục");
            cboKhoa.Items.Add("Khoa Giáo dục Tiểu học");
            cboKhoa.Items.Add("Khoa Giáo dục Mầm non");
            cboKhoa.Items.Add("Khoa Giáo dục Quốc phòng");
            cboKhoa.Items.Add("Khoa Giáo dục đặc biệt");
            cboKhoa.Items.Add("Khoa Giáo dục Thể chất");

            cboKhoa.SelectedIndex = -1;

            // Sự kiện
            btnHienThi.Click += btnHienThi_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            // Năm sinh
            if (string.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập năm sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNamSinh.Focus();
                return;
            }

            if (!int.TryParse(txtNamSinh.Text.Trim(), out int namSinh))
            {
                MessageBox.Show(
                    "Năm sinh phải là số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNamSinh.Focus();
                txtNamSinh.SelectAll();
                return;
            }

            int namHienTai = DateTime.Now.Year;

            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show(
                    $"Năm sinh phải từ 1900 đến {namHienTai}!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNamSinh.Focus();
                txtNamSinh.SelectAll();
                return;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Email!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            string email = txtEmail.Text.Trim();

            if (!Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Email không đúng định dạng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            // Giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn giới tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Khoa
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn khoa/lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboKhoa.Focus();
                return;
            }

            // Tính tuổi
            int tuoi = namHienTai - namSinh;

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            string khoa = cboKhoa.SelectedItem.ToString();

            string ketQua =
                "THÔNG TIN SINH VIÊN\r\n" +
                "Họ tên: " + txtHoTen.Text.Trim() + "\r\n" +
                "Tuổi: " + tuoi + "\r\n" +
                "Email: " + email + "\r\n" +
                "Giới tính: " + gioiTinh + "\r\n" +
                "Khoa/Lớp: " + khoa;

            lblKetQua.Text = ketQua;

            MessageBox.Show(
                ketQua,
                "Thông tin sinh viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();

            radNam.Checked = false;
            radNu.Checked = false;

            cboKhoa.SelectedIndex = -1;

            lblKetQua.Text = "";

            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}