using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab06_ProductManager
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> _productList;
        private string _currentImagePath = "";

        public FrmProduct()
        {
            InitializeComponent();

            // Khởi tạo danh sách và gán cho DataGridView
            _productList = new BindingList<Product>();
            dgvProducts.DataSource = _productList;

            // Đăng ký các sự kiện
            this.Load += FrmProduct_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnSearch.Click += BtnSearch_Click;
            btnSelectImage.Click += BtnSelectImage_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;

            contextMenuDgv.Items[0].Click += BtnEdit_Click;
            contextMenuDgv.Items[1].Click += BtnDelete_Click;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            _productList.Add(new Product { MaSP = "SP01", TenSP = "Laptop Dell", LoaiSP = "Điện tử", DonGia = 15000000, SoLuong = 10, NgayNhap = DateTime.Now.AddDays(-5), ConKinhDoanh = true });
            _productList.Add(new Product { MaSP = "SP02", TenSP = "Bàn phím cơ", LoaiSP = "Điện tử", DonGia = 800000, SoLuong = 20, NgayNhap = DateTime.Now.AddDays(-2), ConKinhDoanh = true });
            _productList.Add(new Product { MaSP = "SP03", TenSP = "Bàn làm việc", LoaiSP = "Văn phòng", DonGia = 1200000, SoLuong = 5, NgayNhap = DateTime.Now, ConKinhDoanh = false });

            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
            UpdateStatus("Đã tải dữ liệu mẫu thành công.");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (_productList.Any(p => p.MaSP.Equals(txtMaSP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errProvider.SetError(txtMaSP, "Mã sản phẩm đã tồn tại!");
                return;
            }

            var newProduct = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = _currentImagePath
            };

            _productList.Add(newProduct);
            ClearInput();
            UpdateStatus($"Đã thêm sản phẩm: {newProduct.TenSP}");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInput()) return;

            // Sử dụng as Product để an toàn chuyển đổi kiểu
            var product = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (product != null)
            {
                product.TenSP = txtTenSP.Text.Trim();
                product.LoaiSP = cboLoaiSP.Text;
                product.DonGia = numDonGia.Value;
                product.SoLuong = (int)numSoLuong.Value;
                product.NgayNhap = dtpNgayNhap.Value;
                product.ConKinhDoanh = chkConKinhDoanh.Checked;

                if (!string.IsNullOrEmpty(_currentImagePath))
                    product.DuongDanAnh = _currentImagePath;

                dgvProducts.Refresh();
                UpdateStatus($"Đã cập nhật sản phẩm: {product.TenSP}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (product == null) return; // Bảo vệ chống null

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm mã {product.MaSP}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                _productList.Remove(product);
                ClearInput();
                UpdateStatus($"Đã xóa sản phẩm mã: {product.MaSP}");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvProducts.DataSource = _productList;
                UpdateStatus("Đã hiển thị toàn bộ danh sách.");
                return;
            }

            var filteredList = new BindingList<Product>(_productList.Where(p =>
                p.MaSP.ToLower().Contains(keyword) ||
                p.TenSP.ToLower().Contains(keyword)).ToList());

            dgvProducts.DataSource = filteredList;
            UpdateStatus($"Tìm thấy {filteredList.Count} kết quả.");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgvProducts.DataSource = _productList;
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu.");
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentImagePath = ofd.FileName;
                    picProduct.Image = Image.FromFile(_currentImagePath);
                }
            }
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra dòng có tồn tại không
            if (dgvProducts.CurrentRow == null) return;

            // 2. Ép kiểu dòng hiện tại về dạng Product
            var currentProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

            // 3. ĐÂY LÀ DÒNG QUAN TRỌNG NHẤT: Nếu không có dữ liệu thì THOÁT NGAY, không chạy xuống dưới
            if (currentProduct == null) return;

            // 4. Khi đã chắc chắn có dữ liệu rồi mới gán
            txtMaSP.Text = currentProduct.MaSP;
            txtTenSP.Text = currentProduct.TenSP;
            cboLoaiSP.Text = currentProduct.LoaiSP;
            numDonGia.Value = currentProduct.DonGia;
            numSoLuong.Value = currentProduct.SoLuong;
            dtpNgayNhap.Value = currentProduct.NgayNhap;
            chkConKinhDoanh.Checked = currentProduct.ConKinhDoanh;

            // 5. Load hình ảnh an toàn
            string imgPath = currentProduct.DuongDanAnh;
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                picProduct.Image = Image.FromFile(imgPath);
            }
            else
            {
                picProduct.Image = null;
            }

            _currentImagePath = imgPath;
            errProvider.Clear();
        }

        private bool ValidateInput()
        {
            errProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errProvider.SetError(txtMaSP, "Mã sản phẩm không được để trống!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errProvider.SetError(txtTenSP, "Tên sản phẩm không được để trống!");
                isValid = false;
            }
            if (numDonGia.Value <= 0)
            {
                errProvider.SetError(numDonGia, "Đơn giá phải lớn hơn 0!");
                isValid = false;
            }
            if (dtpNgayNhap.Value.Date > DateTime.Now.Date)
            {
                errProvider.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại!");
                isValid = false;
            }

            return isValid;
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Now;
            chkConKinhDoanh.Checked = true;
            picProduct.Image = null;
            _currentImagePath = "";
            txtMaSP.Focus();
            errProvider.Clear();
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            lblCount.Text = $"Tổng SP: {_productList.Count}";
        }
    }
}