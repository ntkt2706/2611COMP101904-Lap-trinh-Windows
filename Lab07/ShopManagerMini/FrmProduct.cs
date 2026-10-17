using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagerMini
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> _products;

        public FrmProduct()
        {
            InitializeComponent();
            _products = new BindingList<Product>
            {
                new Product { MaSP = "SP01", TenSP = "Chuột không dây", LoaiSP = "Điện tử", DonGia = 150000, SoLuong = 10 },
                new Product { MaSP = "SP02", TenSP = "Bàn phím cơ", LoaiSP = "Điện tử", DonGia = 800000, SoLuong = 5 }
            };
            dgvProducts.DataSource = _products;

            btnAdd.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Mã và Tên sản phẩm không được trống!");
                    return;
                }
                if (_products.Any(p => p.MaSP.Equals(txtMaSP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Mã sản phẩm bị trùng!");
                    return;
                }
                _products.Add(new Product
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiSP = cboLoai.Text,
                    DonGia = numGia.Value,
                    SoLuong = (int)numSL.Value
                });
            };

            btnDelete.Click += (s, e) => {
                if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product p)
                {
                    if (MessageBox.Show($"Xóa sản phẩm {p.TenSP}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _products.Remove(p);
                    }
                }
            };
        }
    }
}