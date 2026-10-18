using Lab08_SimplePaint;
using System;
using System.Windows.Forms;

namespace Lab08_SimplePaint
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPaint());
        }
    }
}