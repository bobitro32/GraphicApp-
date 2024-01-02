using System.Drawing;

namespace GraphicApp
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private Point endPoint;
        private Shape coppiedShape;
        private List<Shape> shapes;
        private Shape currentShape;
        private bool isRectangleButtonChecked = false;
        private bool isCircleButtonChecked = false;
        private bool isTriangleButtonChecked = false;
        private bool isHeartButtonPressed = false;
        private bool isCopyButtonPressed = false;

        private Point currentMousePosition;
        private bool isDrawingShape = false;
        private float shapeThickness = 1.0f;

        public Form1()
        {
            InitializeComponent();
            InitializeShapes();
            AttachMouseEvents();
        }

        private void InitializeShapes()
        {
            shapes = new List<Shape>();
            currentShape = null;
        }

        private void AttachMouseEvents()
        {
            this.MouseDown += HandleMouseDown;
            this.MouseMove += HandleMouseMove;
            this.MouseUp += HandleMouseUp;
            rectangleBtn.Click += (sender, e) => { isRectangleButtonChecked = true; isCircleButtonChecked = false; isTriangleButtonChecked = false; isHeartButtonPressed = false; };
            circleBtn.Click += (sender, e) => { isRectangleButtonChecked = false; isCircleButtonChecked = true; isTriangleButtonChecked = false; isHeartButtonPressed = false; };
            triangle.Click += (sender, e) => { isRectangleButtonChecked = false; ; isCircleButtonChecked = false; isTriangleButtonChecked = true; isHeartButtonPressed = false; };
            heart.Click += (sender, e) => { isRectangleButtonChecked = false; ; isCircleButtonChecked = false; isTriangleButtonChecked = false; isHeartButtonPressed = true; };

        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;


            currentMousePosition = e.Location;

            if (isRectangleButtonChecked)
            {
                currentShape = new Rectangle { X = startPoint.X, Y = startPoint.Y };
            }
            else if (isCircleButtonChecked)
            {
                currentShape = new Circle { X = startPoint.X, Y = startPoint.Y };
            }
            else if (isTriangleButtonChecked)
            {
                currentShape = new Triangle { X = startPoint.X, Y = startPoint.Y };
            }
            else if (isHeartButtonPressed)
            {
                currentShape = new Heart { X = startPoint.X, Y = startPoint.Y };
            }

        }
        private double CalculateDistance(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if ((isRectangleButtonChecked || isCircleButtonChecked || isTriangleButtonChecked || isHeartButtonPressed) && e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;

                if (isRectangleButtonChecked)
                {
                    currentShape = new Rectangle
                    {
                        X = Math.Min(startPoint.X, e.X),
                        Y = Math.Min(startPoint.Y, e.Y),
                        Width = Math.Abs(endPoint.X - startPoint.X),
                        Height = Math.Abs(endPoint.Y - startPoint.Y),
                        IsFilled = false,
                        Color = Color.DarkMagenta,
                        Thickness = shapeThickness
                    };
                }
                else if (isCircleButtonChecked)
                {
                    currentShape = new Circle
                    {
                        X = Math.Min(startPoint.X, e.X),
                        Y = Math.Min(startPoint.Y, e.Y),
                        Radius = (int)Math.Max(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y)),
                        IsFilled = false,
                        Color = Color.DarkOliveGreen,
                        Thickness = shapeThickness
                    };
                }
                else if (isTriangleButtonChecked)
                {
                    if (currentShape is Triangle)
                    {
                        // Set width and height directly
                        (currentShape as Triangle).X = Math.Min(startPoint.X, e.X);

                        (currentShape as Triangle).Width = Math.Abs(endPoint.X - startPoint.X);
                        (currentShape as Triangle).Height = (endPoint.Y - startPoint.Y);
                        (currentShape as Triangle).Color = Color.DarkRed;
                        (currentShape as Triangle).Thickness = shapeThickness;
                    }
                }
                else if (isHeartButtonPressed)
                {
                    currentShape = new Heart
                    {
                        X = Math.Min(startPoint.X, endPoint.X),
                        Y = Math.Min(startPoint.Y, endPoint.Y),
                        Width = Math.Abs(endPoint.X - startPoint.X),
                        Height = (endPoint.Y - startPoint.Y),
                        IsFilled = false,
                        Color = Color.Red,
                        Thickness = shapeThickness
                    };

                }


                currentMousePosition = e.Location;

                // Redraw the form
                this.Invalidate();
            }
        }


        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;

            if (currentShape != null)
            {
                shapes.Add(currentShape);
            }

            currentShape = null;
            currentMousePosition = e.Location;

            this.Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw all shapes
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics, currentMousePosition);
            }
            currentShape?.Draw(e.Graphics, currentMousePosition);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            float multiplier = 0.1f; // You can change this value
            shapeThickness = e.NewValue * multiplier;

            // Optionally, update the thickness property of the current shape being drawn
            if (currentShape != null)
            {
                currentShape.Thickness = shapeThickness;
                this.Invalidate();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            this.Invalidate();
        }
        private void copyObject(object sender, EventArgs e)
        {
            Shape lastShape = shapes.Last();
            coppiedShape = lastShape.CopyFigure();
        }
        private void pasteObject(object sender, EventArgs e)
        {
            pasteMi(coppiedShape);
            
            this.Invalidate();
        }
        private void pasteMi(Shape shape) {

            shape.X = currentMousePosition.X;
            shape.Y = currentMousePosition.Y;
            
            shapes.Add(shape);
            coppiedShape = null;
            this.Invalidate();
            
        }

    }

}