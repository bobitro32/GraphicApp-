﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GraphicApp.Classes
{
    [Serializable]
    
    public class Heart : Shape
    {
        private float x;
        private float y;
        private float width;
        private float height;

        [XmlElement("Width")]
        public float Width
        {
            get { return width; }
            set
            {
                width = value;
                // Update other points accordingly
            }
        }
        [XmlElement("Height")]

        public float Height
        {
            get { return height; }
            set
            {
                height = value;
                // Update other points accordingly
            }
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
        public Heart(int x, int y, float width, float height, bool isFilled, Color color, float thickness = 1.0f)
        {

            Width = width;
            Height = height;
        }
        public Heart() { }

        public override double CalculateArea()
        {
            return 0;
        }

        public override double CalculatePerimeter()
        {
            return 0;
        }
        private GraphicsPath CreateHeartPath(float X, float Y, float width, float height)
        {
            float beX = X + width / 2;  // bottom endpoint X
            float beY = Y + height;     // bottom endpoint Y

            float c1DX = width * 0.968f;  // delta X of control point 1
            float c1DY = height * 0.672f;  // delta Y of control point 1
            float c2DX = width * 0.281f;  // delta X of control point 2
            float c2DY = height * 1.295f;  // delta Y of control point 2
            float teDY = height * 0.850f;  // delta Y of top endpoint

            GraphicsPath heartPath = new GraphicsPath();
            heartPath.StartFigure();
            heartPath.AddBezier(beX, beY, beX - c1DX, beY - c1DY, beX - c2DX, beY - c2DY, beX, beY - teDY);
            heartPath.AddBezier(beX, beY - teDY, beX + c2DX, beY - c2DY, beX + c1DX, beY - c1DY, beX, beY);
            heartPath.CloseFigure();

            return heartPath;
        }

        public override void Draw(Graphics graphics, Point currentMousePosition)
        {
            if (graphics == null) return;

            GraphicsPath path = CreateHeartPath(X, Y, Math.Max(Width, 100), Math.Max(Height, 100));

            using (Pen pen = new Pen(Color, Thickness))
            {
                if (IsFilled)
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
                else
                {
                    graphics.DrawPath(pen, path);
                }
            }
        }

        public override Shape CopyFigure(Point newMousePosition)
        {
            Heart heart = new Heart();

            heart.X = X; 
            heart.Y = Y; 
            heart.Width = Width;
            heart.Height = Height;
            heart.Thickness = Thickness;
            heart.IsFilled = IsFilled;
            heart.Color = Color;
            return heart;
        }
    }


}


