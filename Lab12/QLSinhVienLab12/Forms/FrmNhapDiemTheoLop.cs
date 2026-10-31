using System.Data;
using QLSinhVienLab12.DAL;

namespace QLSinhVienLab12.Forms
{
    public partial class FrmNhapDiemTheoLop : Form
    {
        private readonly KetQuaDAL ketQuaDAL = new KetQuaDAL();
        private readonly BindingSource ketQuaSource = new BindingSource();

        public FrmNhapDiemTheoLop()
        {
            InitializeComponent();
        }

        private void FrmNhapDiemTheoLop_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBox();
                dgvKetQua.AutoGenerateColumns = true;
                dgvKetQua.DataSource = ketQuaSource;
                lblTrangThai.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được database: " + ex.Message);
            }
        }

        private void LoadComboBox()
        {
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = ketQuaDAL.GetLop();

            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MaMon";
            cboMonHoc.DataSource = ketQuaDAL.GetMonHoc();
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";

            if (maLop.Length == 0 || maMon.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp và môn học.");
                return;
            }

            DataTable table = ketQuaDAL.GetKetQuaByLopMon(maLop, maMon);
            ketQuaSource.DataSource = table;

            dgvKetQua.Columns["MaSV"].ReadOnly = true;
            dgvKetQua.Columns["HoTen"].ReadOnly = true;
            lblTrangThai.Text = $"Đã tải {table.Rows.Count} sinh viên";
        }

        private void btnLuuTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                ketQuaSource.EndEdit();

                if (ketQuaSource.DataSource is not DataTable table || table.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu để lưu. Hãy tải danh sách trước.");
                    return;
                }

                ValidateData(table);

                string maMon = cboMonHoc.SelectedValue?.ToString() ?? "";
                int count = ketQuaDAL.SaveAll(maMon, table);

                lblTrangThai.Text = $"Đã lưu {count} dòng";
                MessageBox.Show($"Đã lưu thành công {count} dòng.");
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lưu thất bại, đã rollback";
                MessageBox.Show("Không thể lưu dữ liệu: " + ex.Message);
            }
        }

        private void ValidateData(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string maSV = row["MaSV"].ToString() ?? "";
                string diemText = row["Diem"].ToString() ?? "";

                if (!double.TryParse(diemText, out double diem))
                    throw new Exception($"Điểm của sinh viên {maSV} không hợp lệ.");

                if (diem < 0 || diem > 10)
                    throw new Exception($"Điểm của sinh viên {maSV} phải từ 0 đến 10.");
            }
        }

        private void dgvKetQua_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Điểm phải là số từ 0 đến 10.");
            e.ThrowException = false;
        }
    }
}