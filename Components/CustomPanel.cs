using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BankSystem.Components
{
    public class CustomPanel : Panel
    {
        private int borderSize = 8;
        private int borderRadius = 24;
        private Color borderColor = CustomColors.Orange;
        private Color backgroundColor = CustomColors.LightBlue;

        //Properties:

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        //Constructor:
        public CustomPanel()
        {
            DoubleBuffered = true; // REduce the flickering of Graphics with double buffering

        }

        //Methods to create the rounded corner rectangle panel:
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {

            GraphicsPath path2 = new GraphicsPath();
            float curveSize = radius * 2F;

            path2.StartFigure();
            path2.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path2.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path2.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path2.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path2.CloseFigure();
            return path2;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderSize > 2) // Rounded Button
            {

                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, borderSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface:
                    Region = new Region(pathSurface);
                    //Draw the surface border for HD results:
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    // Button Border:
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // That is for normal button:

            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface:
                Region = new Region(rectSurface);
                //Button Border:
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }

                }

            }

        }
    }
}
