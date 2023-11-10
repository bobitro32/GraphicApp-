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
       
        private int radius;
        
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        
        public override double CalculateArea()
        {
            return Math.PI*radius;
        }

        public override double CalculatePerimeter()
        {
            return 2*Math.PI * radius;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color.Blue))
            {
                graphics.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
    }

    
}
