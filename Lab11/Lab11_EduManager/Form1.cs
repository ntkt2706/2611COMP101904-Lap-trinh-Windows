using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab11_EduManager
{
    public partial class Form1 : Form
    {
        // Sử dụng chuỗi kết nối cục bộ đã thiết lập ở Lab 10
        string connectionString = "Server=.;Database=EduManagerDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // F1: Tự động load dữ liệu khi mở Form
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm nạp dữ liệu lên DataGridView (Dùng chung cho Load khởi tạo và Tìm kiếm)
        private void LoadData(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaLop, TenLop, MaKhoa FROM LOP";
                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " WHERE MaLop LIKE @Keyword OR TenLop LIKE @Keyword";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLop.DataSource = dt;
                }
            }
        }

        // F2: Đổ dữ liệu từ DataGridView lên TextBox
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
                txtMaLop.Enabled = false; // Khóa mã lớp khi chọn để sửa/xóa
            }
        }

        // F3: Thêm lớp mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã lớp và Tên lớp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Kiểm tra trùng mã lớp
                string checkQuery = "SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thêm dữ liệu (Mặc định thêm vào Khoa CNTT để khớp cấu trúc Database Lab 10)
                string insertQuery = "INSERT INTO LOP (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, 'CNTT')";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            btnLamMoi_Click(sender, e);
            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // F4: Sửa tên lớp
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa và điền đầy đủ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE LOP SET TenLop = @TenLop WHERE MaLop = @MaLop";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            btnLamMoi_Click(sender, e);
            MessageBox.Show("Cập nhật lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // F5: Xóa lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM LOP WHERE MaLop = @MaLop";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    btnLamMoi_Click(sender, e);
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    // Mã lỗi 547 là lỗi vi phạm khóa ngoại (Foreign Key constraint)
                    if (ex.Number == 547)
                        MessageBox.Show("Không thể xóa lớp đang có sinh viên!", "Lỗi Ràng Buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // F6: Tìm kiếm lớp
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        // F7: Làm mới Form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();
            txtMaLop.Enabled = true;
            LoadData();
        }
    }
}