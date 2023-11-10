using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicApp
{
    abstract class Shape
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract void Draw(Graphics graphics);
    }
}
