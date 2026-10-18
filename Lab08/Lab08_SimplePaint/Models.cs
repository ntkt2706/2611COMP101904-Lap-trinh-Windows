using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab08_SimplePaint
{
    // Lớp trừu tượng cha
    public abstract class DrawItem
    {
        public Color Color { get; set; }
        public float Width { get; set; }
        public abstract void Draw(Graphics g);
    }

    // Lớp vẽ tự do (Pen)
    public class DrawPen : DrawItem
    {
        public List<Point> Points { get; set; } = new List<Point>();
        public override void Draw(Graphics g)
        {
            if (Points.Count > 1)
            {
                // Sử dụng 'using' để tự động giải phóng Pen sau khi vẽ xong
                using (Pen p = new Pen(Color, Width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
                {
                    g.DrawLines(p, Points.ToArray());
                }
            }
        }
    }

    // Lớp vẽ đường thẳng (Line)
    public class DrawLine : DrawItem
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public override void Draw(Graphics g)
        {
            using (Pen p = new Pen(Color, Width) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawLine(p, Start, End);
            }
        }
    }

    // Lớp vẽ hình chữ nhật (Rectangle)
    public class DrawRectangle : DrawItem
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public override void Draw(Graphics g)
        {
            using (Pen p = new Pen(Color, Width))
            {
                // Dùng Math.Min và Math.Abs để xử lý trường hợp kéo chuột ngược (từ phải sang trái, dưới lên trên)
                int x = Math.Min(Start.X, End.X);
                int y = Math.Min(Start.Y, End.Y);
                int width = Math.Abs(Start.X - End.X);
                int height = Math.Abs(Start.Y - End.Y);
                g.DrawRectangle(p, x, y, width, height);
            }
        }
    }

    // Lớp vẽ hình Elip (Ellipse)
    public class DrawEllipse : DrawItem
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public override void Draw(Graphics g)
        {
            using (Pen p = new Pen(Color, Width))
            {
                int x = Math.Min(Start.X, End.X);
                int y = Math.Min(Start.Y, End.Y);
                int width = Math.Abs(Start.X - End.X);
                int height = Math.Abs(Start.Y - End.Y);
                g.DrawEllipse(p, x, y, width, height);
            }
        }
    }
}