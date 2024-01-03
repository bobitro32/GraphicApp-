using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicApp
{
    internal class Circle : Shape
    {
       
        private double radius;
        
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(bool isFilled, Color color, float thickness = 1.0f)
        {
           
            
        }
        public Circle(int x,int y,double radius, bool isFilled, Color color, float thickness = 1.0f)
        {
           
            Radius = radius;

        }
        public Circle() { }
        public override double CalculateArea()
        {
            return Math.PI*radius;
        }

        public override double CalculatePerimeter()
        {
            return 2*Math.PI * radius;
        }

        public override void Draw(Graphics graphics, Point currentMousePosition)
        {
            using (Pen pen = new Pen(Color,Thickness))
            {
                graphics.DrawEllipse(pen, X, Y ,  (int)Radius,(int)Radius);
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
