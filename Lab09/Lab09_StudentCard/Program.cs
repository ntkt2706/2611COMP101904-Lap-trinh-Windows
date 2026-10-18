using System;
using System.Windows.Forms;

namespace Lab09_StudentCard
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Gọi đúng tên Form thẻ sinh viên
            Application.Run(new FrmStudentCard());
        }
    }
}