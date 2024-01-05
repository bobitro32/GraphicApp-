namespace GraphicApp
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private Point endPoint;
        private Shape copiedShape;
        private List<Shape> shapes;
        private Shape currentShape;
        private bool isRectangleButtonChecked = false;
        private bool isCircleButtonChecked = false;
        private bool isTriangleButtonChecked = false;
        private bool isHeartButtonPressed = false;
        private bool isPasteButtonPressed = false;
        private bool isCopyButtonPressed = false;

        private Stack<List<Shape>> undoStack;
        private Stack<List<Shape>> redoStack;
        private Point currentMousePosition;
        
        
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
            undoStack = new Stack<List<Shape>>();
            redoStack = new Stack<List<Shape>>();
            currentShape = null;
        }

        private void AttachMouseEvents()
        {
            this.MouseDown += HandleMouseDown;
            this.MouseMove += HandleMouseMove;
            this.MouseUp += HandleMouseUp;
            rectangleBtn.Click += (sender, e) => { isRectangleButtonChecked = true; isCircleButtonChecked = false; isTriangleButtonChecked = false; isHeartButtonPressed = false; isPasteButtonPressed = false; };
            circleBtn.Click += (sender, e) => { isRectangleButtonChecked = false; isCircleButtonChecked = true; isTriangleButtonChecked = false; isHeartButtonPressed = false; isPasteButtonPressed = false;  };
            triangle.Click += (sender, e) => { isRectangleButtonChecked = false; ; isCircleButtonChecked = false; isTriangleButtonChecked = true; isHeartButtonPressed = false; isPasteButtonPressed = false; };
            heart.Click += (sender, e) => { isRectangleButtonChecked = false; ; isCircleButtonChecked = false; isTriangleButtonChecked = false; isHeartButtonPressed = true; isPasteButtonPressed = false;  };
            paste.Click += (sender, e) => { isRectangleButtonChecked = false; isCircleButtonChecked = false; isTriangleButtonChecked = false; isHeartButtonPressed = false; isPasteButtonPressed = true;  };
            undo.Click += (sender, e) => Undo();
            redo.Click += (sender, e) =>  Redo();

        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;


            currentMousePosition = e.Location;
            if (isCopyButtonPressed)
            {
                pasteObject(currentMousePosition);
            }

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
            else if (isPasteButtonPressed)
            {
                if (copiedShape != null)
                {
                    copiedShape.X = currentMousePosition.X;
                    copiedShape.Y = currentMousePosition.Y;
                    shapes.Add(copiedShape); // Add the copied shape to the list
                    copiedShape = null; // Reset copiedShape after pasting
                }
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
            undoStack.Push(shapes);
            redoStack.Push(shapes);



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
            copiedShape = lastShape.CopyFigure(currentMousePosition);
            //copiedShape.Thickness = lastShape.Thickness;
            isCopyButtonPressed = true;
        }
        private void pasteObject(Point pasteLocation)
        {
            if (copiedShape != null)
            {
                copiedShape.X = pasteLocation.X;
                copiedShape.Y = pasteLocation.Y;
                
                shapes.Add(copiedShape);

                undoStack.Push(new List<Shape>(shapes));
                redoStack.Clear();
                redoStack.Push(new List<Shape>(shapes));

                copiedShape = null; // Reset copiedShape after pasting
                isCopyButtonPressed = false; // Reset the flag
                this.Invalidate();
            }
        }
        private void Undo() {

            if (undoStack.Count > 1)
            {
                undoStack.Pop(); // Pop the current state
                List<Shape> previousState = undoStack.Peek(); // Peek the previous state
                redoStack.Push(new List<Shape>(shapes)); // Push the current state onto redo stack

                // Remove one shape at a time from the shapes list
                if (shapes.Count >= previousState.Count)
                {
                    Shape removedShape = shapes.Last();
                    shapes.Remove(removedShape);
                    redoStack.Push(new List<Shape>(shapes)); // Push the updated state onto redo stack
                }

            }
            else {
                redoStack.Push(shapes);
                shapes.Clear();
            }
            this.Refresh();

        }
        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                List<Shape> nextState = redoStack.Pop(); // Pop the next state
                
                shapes.AddRange(nextState);
                undoStack.Push(new List<Shape>(shapes)); // Push a copy of the shapes list onto undo stack
                
            }
            this.Invalidate();

        }
    }

}