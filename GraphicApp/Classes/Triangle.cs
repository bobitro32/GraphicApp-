using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace GraphicApp.Classes
{
    [Serializable]
    public class Triangle : Shape
    {
        private PointF leftBottom;
        private PointF rightBottom;
        private PointF top;
        private float width;
        private float height;
        [XmlElement]
        public PointF LeftBottom { get => LeftBottom; set => LeftBottom = value; }
        [XmlElement]
        public PointF RightBottom { get => RightBottom; set => RightBottom = value; }
        [XmlElement]
        public PointF Top { get => Top; set => Top = value; }
        [XmlElement("Width")]

        public float Width
        {
            get => width;
            set
            {
                width = value;
                rightBottom.X = leftBottom.X + value;
                top.X = leftBottom.X + value / 2;
            }
        }
        [XmlElement("Height")]

        public float Height
        {
            get => height;
            set
            {
                height = value;
                top.Y = leftBottom.Y - Height;
            }
        }
        
        public float Y
        {
            get { return leftBottom.Y; }
            set
            {
                leftBottom.Y = value;
                rightBottom.Y = value;
                top.Y = value - Height;
            }
        }
        
        public float X
        {
            get { return leftBottom.X; }
            set
            {
                leftBottom.X = value;
                rightBottom.X = value + Width;
                top.X = value + Width / 2;
            }
        }


        public Triangle(float x, float y, float width, float height,
                       bool isFilled, Color color, float thickness = 1.0f)
        {
            leftBottom = new PointF(x, y + height);
            rightBottom = new PointF(x + width, y + height);
            top = new PointF(x + width / 2, y);
            Width = width;
            Height = height;


        }
        public Triangle()
        {

        }
        private float CalculateDistance(PointF point1, PointF point2)
        {
            return MathF.Sqrt(MathF.Pow(point2.X - point1.X, 2) + MathF.Pow(point2.Y - point1.Y, 2));
        }

        public override double CalculateArea()
        {
            return 0;
        }

        public override double CalculatePerimeter()
        {
            return 0;
        }
        public override void Draw(Graphics graphics, Point currentMousePosition)
        {

            if (graphics == null) return;
            Point[] trianglePoints = new Point[]
            {
                new Point((int)leftBottom.X, (int)leftBottom.Y),
                new Point((int)rightBottom.X, (int)rightBottom.Y),
                new Point((int)top.X, (int)top.Y)
            };
            using (Pen pen = new Pen(Color, Thickness))
            {
                if (IsFilled)
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillPolygon(brush, trianglePoints);
                    }
                }
                else
                {
                    graphics.DrawPolygon(pen, trianglePoints);

                }
            }

        }

        public override Shape CopyFigure(Point newMousePosition)
        {
            Triangle triangle = new Triangle();
            triangle.X = newMousePosition.X; // Set the X position to the new mouse click X
            triangle.Y = newMousePosition.Y;
            triangle.Width = Width;
            triangle.Height = Height;
            triangle.IsFilled = IsFilled;
            triangle.Color = Color;
            triangle.Thickness = Thickness;
            return triangle;
        }
    }

}
