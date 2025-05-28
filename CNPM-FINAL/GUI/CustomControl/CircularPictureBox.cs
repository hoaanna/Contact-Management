using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

    namespace CNPM_FINAL.GUI.CustomControl
    {
    public class CircularPictureBox : PictureBox
    {
        private int borderSize = 2;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Custom")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public CircularPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Transparent;
        }

        private GraphicsPath GetCirclePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2F;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = BorderSize > 0 ? BorderSize : 1;

            float radius = borderRadius > 0 ? borderRadius : Math.Min(this.Width, this.Height) / 2f;

            using (GraphicsPath pathSurface = GetCirclePath(rectSurface, radius))
            using (GraphicsPath pathBorder = GetCirclePath(rectBorder, radius - borderSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                this.Region = new Region(pathSurface);


                if (borderSize > 0)
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
    }
}
