using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.ComponentModel;

namespace BankSystem.Components
{
    public class CustomButton : Button
    {
        //Fields:

        private int borderSize = 0;
        private int borderRadius = 24;
        private Color borderColor = Color.Black;


        [Category("Custom Properties")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("Custom Properties")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }
        [Category("Custom Properties")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }



        //Constructor:
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.White;
            ForeColor = Color.Blue;
            Size = new Size(240, 60);
            TextAlign = ContentAlignment.MiddleCenter;
            Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        //Methods:

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {

            Invalidate();
        }

    }
}
