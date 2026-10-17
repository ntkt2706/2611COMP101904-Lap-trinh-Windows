using System;
using System.Windows.Forms;

namespace ShopManagerMini
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin loginForm = new FrmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Truyền user đã đăng nhập vào FrmMain
                Application.Run(new FrmMain(loginForm.LoggedInUser));
            }
        }
    }
}