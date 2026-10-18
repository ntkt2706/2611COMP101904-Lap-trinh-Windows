using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab09_StudentCard
{
    public partial class FrmStudentCard : Form
    {
        private Color _cardColor = Color.LightCyan;

        public FrmStudentCard()
        {
            InitializeComponent();

            // Khóa kích thước Form, cấm phóng to để tránh lỗi khoảng trống
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Thiết lập giá trị mặc định
            cboGioiTinh.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
            cboKhoa.SelectedIndex = 0;

            // Bật DoubleBuffering cho Panel
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, pnlPreview, new object[] { true });

            // Gắn sự kiện Click
            btnChooseImg.Click += BtnChooseImg_Click;
            btnColor.Click += BtnColor_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnPreviewPrint.Click += BtnPreviewPrint_Click;
            btnPrint.Click += BtnPrint_Click;
            btnSavePNG.Click += BtnSavePNG_Click;
            btnExit.Click += (s, e) => Application.Exit();

            // Gắn sự kiện Vẽ
            pnlPreview.Paint += PnlPreview_Paint;
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Tự động vẽ lại khi nhập dữ liệu
            txtMaSV.TextChanged += (s, e) => pnlPreview.Invalidate();
            txtHoTen.TextChanged += (s, e) => pnlPreview.Invalidate();
            cboLop.SelectedIndexChanged += (s, e) => pnlPreview.Invalidate();
            cboKhoa.SelectedIndexChanged += (s, e) => pnlPreview.Invalidate();
            txtKhoaHoc.TextChanged += (s, e) => pnlPreview.Invalidate();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (picAvatar.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh đại diện!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnChooseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var bmp = new Bitmap(ofd.FileName))
                    {
                        picAvatar.Image = new Bitmap(bmp);
                    }
                    pnlPreview.Invalidate();
                }
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog { Color = _cardColor })
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _cardColor = cd.Color;
                    pnlPreview.Invalidate();
                }
            }
        }

        private void DrawCard(Graphics g, Rectangle bounds)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            // Nền & Khung
            using (SolidBrush bgBrush = new SolidBrush(_cardColor))
            {
                g.FillRectangle(bgBrush, bounds);
            }
            g.DrawRectangle(Pens.DarkBlue, bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1);

            // Tiêu đề
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontSubHeader = new Font("Arial", 10, FontStyle.Bold);
            StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center };

            g.DrawString("TRƯỜNG ĐẠI HỌC SƯ PHẠM TP.HCM", fontSubHeader, Brushes.DarkRed, new Rectangle(bounds.X, bounds.Y + 15, bounds.Width, 20), centerFormat);
            g.DrawString("THẺ SINH VIÊN", fontHeader, Brushes.DarkBlue, new Rectangle(bounds.X, bounds.Y + 35, bounds.Width, 30), centerFormat);

            // Ảnh
            if (picAvatar.Image != null)
            {
                Rectangle imgRect = new Rectangle(bounds.X + 25, bounds.Y + 80, 100, 130);
                g.DrawImage(picAvatar.Image, imgRect);
                g.DrawRectangle(Pens.Gray, imgRect);
            }

            // Thông tin sinh viên
            Font fontLabel = new Font("Arial", 9, FontStyle.Bold);
            Font fontValue = new Font("Arial", 9, FontStyle.Regular);
            int textX = bounds.X + 140;
            int startY = bounds.Y + 80;
            int spacing = 22;

            g.DrawString($"MSSV: {txtMaSV.Text}", fontLabel, Brushes.Black, textX, startY);
            g.DrawString($"Họ tên: {txtHoTen.Text.ToUpper()}", fontLabel, Brushes.DarkBlue, textX, startY + spacing);
            g.DrawString($"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}", fontValue, Brushes.Black, textX, startY + spacing * 2);
            g.DrawString($"Giới tính: {cboGioiTinh.Text}", fontValue, Brushes.Black, textX, startY + spacing * 3);
            g.DrawString($"Lớp: {cboLop.Text}", fontValue, Brushes.Black, textX, startY + spacing * 4);
            g.DrawString($"Khoa: {cboKhoa.Text}", fontValue, Brushes.Black, textX, startY + spacing * 5);

            // QR Code
            int qrSize = 55;
            Rectangle qrRect = new Rectangle(bounds.Right - qrSize - 20, bounds.Bottom - qrSize - 20, qrSize, qrSize);
            g.FillRectangle(Brushes.White, qrRect);
            g.DrawRectangle(Pens.Black, qrRect);
            g.FillRectangle(Brushes.Black, qrRect.X + 5, qrRect.Y + 5, 12, 12);
            g.FillRectangle(Brushes.Black, qrRect.X + 38, qrRect.Y + 5, 12, 12);
            g.FillRectangle(Brushes.Black, qrRect.X + 5, qrRect.Y + 38, 12, 12);
            g.FillRectangle(Brushes.Black, qrRect.X + 22, qrRect.Y + 22, 15, 15);
        }

        private void PnlPreview_Paint(object sender, PaintEventArgs e)
        {
            DrawCard(e.Graphics, new Rectangle(0, 0, pnlPreview.Width, pnlPreview.Height));
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle printRect = new Rectangle(100, 100, pnlPreview.Width, pnlPreview.Height);
            DrawCard(e.Graphics, printRect);
        }

        private void BtnPreviewPrint_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void BtnSavePNG_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PNG Image|*.png", FileName = $"{txtMaSV.Text}_Card.png" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(pnlPreview.Width, pnlPreview.Height))
                    {
                        pnlPreview.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPreview.Width, pnlPreview.Height));
                        bmp.Save(sfd.FileName, ImageFormat.Png);
                        MessageBox.Show("Lưu thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtKhoaHoc.Clear();
            picAvatar.Image = null;
            dtpNgaySinh.Value = DateTime.Now;
            _cardColor = Color.LightCyan;
            pnlPreview.Invalidate();
        }
    }
}