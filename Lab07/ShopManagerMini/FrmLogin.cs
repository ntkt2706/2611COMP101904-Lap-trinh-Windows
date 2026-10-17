using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagerMini
{
    public partial class FrmLogin : Form
    {
        public User LoggedInUser { get; private set; }
        private List<User> _users;

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Dữ liệu mẫu
            _users = new List<User>
            {
                new User { Username = "admin", Password = "123", FullName = "Quản trị viên", Role = "Admin" },
                new User { Username = "user", Password = "123", FullName = "Nhân viên bán hàng", Role = "User" }
            };

            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += (s, e) => Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                LoggedInUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}