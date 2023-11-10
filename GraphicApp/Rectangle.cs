using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicApp
{
    internal class Rectangle : Shape
    {
        
        private int width;
        private int height;

        

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2*Width + Height*2;
        }
        public  Rectangle Empty()
        {
             return new Rectangle(0,0,0,0);
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color.Blue))
            {
                graphics.DrawRectangle(pen, X , Y,Width,Height);
            }
        }
    }
}
