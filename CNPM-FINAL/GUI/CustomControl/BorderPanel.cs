using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.CustomControl
{
    public class BorderPanel : Panel
    {
        private readonly BaseControl baseHelper = new BaseControl();

        [Category("Custom")]
        public int BorderSize
        {
            get => baseHelper.BorderSize;
            set { baseHelper.BorderSize = value; this.Invalidate(); }
        }

        [Category("Custom")]
        public int BorderRadius
        {
            get => baseHelper.BorderRadius;
            set { baseHelper.BorderRadius = value; this.Invalidate(); }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get => baseHelper.BorderColor;
            set { baseHelper.BorderColor = value; this.Invalidate(); }
        }

        [Category("Custom")]
        public Color BackgroundColor
        {
            get => baseHelper.BackgroundColor;
            set { baseHelper.BackgroundColor = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            baseHelper.DrawBorder(this, e);
        }
    }
}
