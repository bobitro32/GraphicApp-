using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GraphicApp.Classes
{
    [Serializable]
    public class Rectangle : Shape
    {
        private float x;
        private float y;

        private int width;
        private int height;


        [XmlElement("Width")]
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        [XmlElement("Height")]
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        [XmlElement("X")]
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        [XmlElement("Y")]
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        
        [XmlElement("Color")]
        public string ColorHtml
        {
            get { return ColorTranslator.ToHtml(Color); }
            set { Color = ColorTranslator.FromHtml(value); }
        }

        public Rectangle(int x, int y, int width, int height, bool isFilled, Color color, float thickness = 1.0f)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
            int a = 10;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Width + Height * 2;
        }
        public Rectangle Empty()
        {
            return new Rectangle(0, 0, 0, 0, false, Color, 0);
        }

        public override void Draw(Graphics graphics, Point currentMousePosition)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                if (IsFilled) {

                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillRectangle(brush,X,Y,Width,Height);
                    }
                }
                graphics.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override Shape CopyFigure(Point newMousePosition)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = X;
            rectangle.Y = Y;
            rectangle.Width = Width;
            rectangle.Height = Height;
            rectangle.Thickness = Thickness;
            rectangle.IsFilled = IsFilled;
            rectangle.Color = Color;
            return rectangle;
        }
    }
}
