using System.Drawing;

namespace GraphicApp
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private Point endPoint;
        private Control targetControl;
        private List<Shape> shapes;
        private Shape currentShape;
        private bool isRectangleButtonChecked = false;
        private bool isCircleButtonChecked = false;


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
            rectangleBtn.Click += (sender, e) => { isRectangleButtonChecked = true; isCircleButtonChecked = false; };
            circleBtn.Click += (sender, e) => { isRectangleButtonChecked = false; isCircleButtonChecked = true; };

        }
        
        private void HandleMouseDown(object sender, MouseEventArgs e )
        {
            startPoint = e.Location;


            

            if (isRectangleButtonChecked)
            {
                currentShape = new Rectangle { X = startPoint.X, Y = startPoint.Y };
            }
            else if (isCircleButtonChecked)
            {
                currentShape = new Circle { X = startPoint.X, Y = startPoint.Y };
            }
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if ((isRectangleButtonChecked || isCircleButtonChecked) && e.Button == MouseButtons.Left)
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

                // Redraw the form
                this.Invalidate();
            }
        }





        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            // Example: add a rectangle

            endPoint = e.Location;
            if (currentShape != null)
            {
                if (isRectangleButtonChecked)
                {
                    shapes.Add(new Rectangle
                    {
                        X = currentShape.X,
                        Y = currentShape.Y,
                        Width = endPoint.X - startPoint.X,
                        Height = endPoint.Y - startPoint.Y
                    });
                }
                else if (isCircleButtonChecked)
                {
                    shapes.Add(new Circle
                    {
                        X = currentShape.X,
                        Y = currentShape.Y,
                        Radius = (int)Math.Max(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y))
                    });
                }
            }

                currentShape = null;

                // Redraw the form
                this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw all shapes
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            currentShape?.Draw(e.Graphics);
        }



    }
}