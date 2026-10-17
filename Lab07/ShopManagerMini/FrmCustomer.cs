using System.ComponentModel;
using System.Windows.Forms;

namespace ShopManagerMini
{
    public partial class FrmCustomer : Form
    {
        private BindingList<Customer> _customers;

        public FrmCustomer()
        {
            InitializeComponent();
            _customers = new BindingList<Customer>
            {
                new Customer { MaKH = "KH01", HoTen = "Nguyễn Văn A", SoDienThoai = "0901234567", LoaiKH = "Thân thiết" }
            };
            dgvCustomers.DataSource = _customers;

            btnAddKH.Click += (s, e) => {
                if (!string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    _customers.Add(new Customer
                    {
                        MaKH = txtMaKH.Text.Trim(),
                        HoTen = txtHoTen.Text.Trim(),
                        SoDienThoai = txtSDT.Text.Trim(),
                        LoaiKH = "Thường"
                    });
                }
            };
        }
    }
}