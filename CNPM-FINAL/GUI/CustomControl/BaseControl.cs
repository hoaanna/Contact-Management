using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.CustomControl
{
    internal class BaseControl
    {
        public int BorderSize { get; set; } = 1;
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.Black;
        public Color BackgroundColor { get; set; } = Color.White;

        public BaseControl() { }

        public GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        public void DrawBorder(Control control, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = control.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = BorderSize > 0 ? BorderSize : 1;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - smoothSize))
            using (Pen penSurface = new Pen(control.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                control.Region = new Region(pathSurface);
                e.Graphics.DrawPath(penSurface, pathSurface);

                if (BorderSize > 0)
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
    }
}
