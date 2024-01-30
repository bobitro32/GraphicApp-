using GraphicApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Rectangle = GraphicApp.Classes.Rectangle;

namespace GraphicApp
{
    [Serializable]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Heart))]
    [XmlRoot("ArrayOfShape")]
    public abstract class Shape
    {

        private Color color;

        [XmlElement("IsFilled")]
        public bool IsFilled { get; set; }
        [XmlElement("Thickness")]
        public float Thickness { get; set; }

        [XmlIgnore]
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }


        public abstract double CalculateArea();
        public abstract Shape CopyFigure(Point newMousePosition);
        public abstract double CalculatePerimeter();
        public abstract void Draw(Graphics graphics, Point currentMousePosition);
    }
}
