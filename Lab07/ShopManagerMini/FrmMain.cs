using System;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagerMini
{
    public partial class FrmMain : Form
    {
        private User? _currentUser; // Thêm dấu ? để cho phép Nullable

        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // Chỉ định rõ ràng System.Windows.Forms.Timer để tránh lỗi phân vân
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, e) => {
                if (lblTime != null) lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            };
            timer.Start();

            this.FormClosing += FrmMain_FormClosing;
        }

        public FrmMain(User user) : this()
        {
            _currentUser = user;
            if (_currentUser != null && lblUserInfo != null)
            {
                lblUserInfo.Text = $"Người dùng: {_currentUser.FullName} | Vai trò: {_currentUser.Role}";
            }
        }

        private void OpenChildForm(Type formType)
        {
            Form? existingForm = this.MdiChildren.FirstOrDefault(f => f.GetType() == formType);
            if (existingForm != null)
            {
                existingForm.Activate();
            }
            else
            {
                if (Activator.CreateInstance(formType) is Form newForm)
                {
                    newForm.MdiParent = this;
                    newForm.Show();
                }
            }
        }

        private void mnuProduct_Click(object sender, EventArgs e) => OpenChildForm(typeof(FrmProduct));
        private void mnuCustomer_Click(object sender, EventArgs e) => OpenChildForm(typeof(FrmCustomer));
        private void mnuAbout_Click(object sender, EventArgs e) => OpenChildForm(typeof(FrmAbout));

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK && login.LoggedInUser != null)
            {
                _currentUser = login.LoggedInUser;
                if (lblUserInfo != null)
                {
                    lblUserInfo.Text = $"Người dùng: {_currentUser.FullName} | Vai trò: {_currentUser.Role}";
                }
                foreach (Form child in this.MdiChildren) child.Close();
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e) => Application.Exit();

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }
    }
}