using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GraphicApp.Classes
{
    [Serializable]
    public class Circle : Shape
    {
        private float x;
        private float y;
        
        private double radius;
        [XmlElement("Radius")]
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
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

        public Circle(bool isFilled, Color color, float thickness = 1.0f)
        {

        }
        public Circle(int x, int y, double radius, bool isFilled, Color color, float thickness = 1.0f)
        {
            X = x;
            Y = y;
            Radius = radius;

        }
        public Circle() {
           
        }
        public override double CalculateArea()
        {
            return Math.PI * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Draw(Graphics graphics, Point currentMousePosition)
        {
            using (Pen pen = new Pen(Color, Thickness))
            {
                if (IsFilled)
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillEllipse(brush, x, y, (int)Radius, (int)Radius);
                    }

                }
                else {
                    graphics.DrawEllipse(pen, x, y, (int)Radius, (int)Radius);

                }
            }
        }

        public override Shape CopyFigure(Point newMousePosition)
        {
            Circle circle = new Circle();
            circle.Radius = Radius;
            circle.IsFilled = IsFilled;
            circle.X = X;
            circle.Y = Y;
            circle.Color = Color;
            circle.Thickness = Thickness;
            return circle;

        }
    }


}
