using System.Drawing;

namespace GraphicApp
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private Point endPoint;
        private List<Shape> shapes;
        private Shape currentShape;
        private bool isRectangleButtonChecked = false;
        private bool isCircleButtonChecked = false;
        private bool isTriangleButtonChecked = false;
        private Point currentMousePosition;
        private bool isDrawingShape = false;

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
            rectangleBtn.Click += (sender, e) => { isRectangleButtonChecked = true; isCircleButtonChecked = false; isTriangleButtonChecked = false; };
            circleBtn.Click += (sender, e) => { isRectangleButtonChecked = false; isCircleButtonChecked = true; isTriangleButtonChecked = false; };
            triangle.Click += (sender, e) => { isRectangleButtonChecked = false; ; isCircleButtonChecked = false; isTriangleButtonChecked = true; };

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

        }
        private double CalculateDistance(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if ((isRectangleButtonChecked || isCircleButtonChecked || isTriangleButtonChecked) && e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;

                if (isRectangleButtonChecked)
                {
                    currentShape = new Rectangle
                    {
                        X = startPoint.X,
                        Y = startPoint.Y,
                        Width = endPoint.X - startPoint.X,
                        Height = endPoint.Y - startPoint.Y
                    };
                }
                else if (isCircleButtonChecked)
                {
                    currentShape = new Circle
                    {
                        X = startPoint.X,
                        Y = startPoint.Y,
                        Radius = (int)Math.Max(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y))
                    };
                }
                else if (isTriangleButtonChecked)
                {
                    if (currentShape is Triangle)
                    {
                        // Set width and height directly
                        (currentShape as Triangle).Width = Math.Abs(endPoint.X - startPoint.X);
                        (currentShape as Triangle).Height = Math.Abs(endPoint.Y - startPoint.Y);
                    }
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




            // Redraw the form
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


    }

}