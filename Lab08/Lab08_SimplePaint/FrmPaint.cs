using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab08_SimplePaint
{
    public partial class FrmPaint : Form
    {
        private List<DrawItem> _items = new List<DrawItem>();
        private DrawItem _currentItem;
        private bool _isDrawing = false;
        private Color _currentColor = Color.Black;

        public FrmPaint()
        {
            InitializeComponent();

            // Thiết lập mặc định
            cboMode.SelectedIndex = 0;
            this.KeyPreview = true; // Để bắt phím tắt Ctrl+Z

            // Bật DoubleBuffering cho canvas để vẽ không bị giật/nháy hình
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, canvas, new object[] { true });

            // Gắn sự kiện cho Canvas
            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseUp += Canvas_MouseUp;
            canvas.Paint += Canvas_Paint;

            // Gắn sự kiện cho các Tool
            btnColor.Click += BtnColor_Click;
            btnUndo.Click += BtnUndo_Click;
            btnClear.Click += BtnClear_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                float width = (float)nudWidth.Value;
                string mode = cboMode.Text;

                if (mode == "Pen")
                {
                    var penItem = new DrawPen { Color = _currentColor, Width = width };
                    penItem.Points.Add(e.Location);
                    _currentItem = penItem;
                }
                else if (mode == "Line")
                {
                    _currentItem = new DrawLine { Color = _currentColor, Width = width, Start = e.Location, End = e.Location };
                }
                else if (mode == "Rectangle")
                {
                    _currentItem = new DrawRectangle { Color = _currentColor, Width = width, Start = e.Location, End = e.Location };
                }
                else if (mode == "Ellipse")
                {
                    _currentItem = new DrawEllipse { Color = _currentColor, Width = width, Start = e.Location, End = e.Location };
                }

                _items.Add(_currentItem);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Cập nhật tọa độ chuột
            lblStatus.Text = $"Tọa độ: X={e.X}, Y={e.Y}";

            if (_isDrawing && _currentItem != null)
            {
                if (_currentItem is DrawPen penItem)
                {
                    penItem.Points.Add(e.Location);
                }
                else if (_currentItem is DrawLine lineItem)
                {
                    lineItem.End = e.Location;
                }
                else if (_currentItem is DrawRectangle rectItem)
                {
                    rectItem.End = e.Location;
                }
                else if (_currentItem is DrawEllipse ellipseItem)
                {
                    ellipseItem.End = e.Location;
                }

                // Yêu cầu vẽ lại ngay lập tức
                canvas.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = false;
                _currentItem = null;
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Bật chế độ khử răng cưa cho nét vẽ mượt mà
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ lại toàn bộ danh sách các đối tượng
            foreach (var item in _items)
            {
                item.Draw(e.Graphics);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = _currentColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _currentColor = cd.Color;
                    pnlColorPreview.BackColor = _currentColor; // Cập nhật màu hiển thị
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (_items.Count > 0)
            {
                _items.RemoveAt(_items.Count - 1);
                canvas.Invalidate(); // Vẽ lại sau khi xóa
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _items.Clear();
            canvas.Invalidate();
        }

        // CHỨC NĂNG NÂNG CAO: Lưu ảnh ra file PNG
        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PNG Image|*.png", FileName = "MyPaint.png" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(canvas.Width, canvas.Height))
                    {
                        canvas.DrawToBitmap(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height));
                        bmp.Save(sfd.FileName, ImageFormat.Png);
                    }
                    MessageBox.Show("Đã lưu tác phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // CHỨC NĂNG NÂNG CAO: Bắt phím tắt Ctrl + Z để Undo
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                BtnUndo_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}