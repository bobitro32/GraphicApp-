namespace GraphicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectangleBtn = new Button();
            circleBtn = new Button();
            triangle = new Button();
            SuspendLayout();
            // 
            // rectangleBtn
            // 
            rectangleBtn.BackColor = Color.IndianRed;
            rectangleBtn.Location = new Point(113, 13);
            rectangleBtn.Name = "rectangleBtn";
            rectangleBtn.Size = new Size(75, 23);
            rectangleBtn.TabIndex = 0;
            rectangleBtn.Text = "Rectangle";
            rectangleBtn.UseVisualStyleBackColor = false;
            // 
            // circleBtn
            // 
            circleBtn.BackColor = Color.IndianRed;
            circleBtn.Location = new Point(194, 13);
            circleBtn.Name = "circleBtn";
            circleBtn.Size = new Size(75, 23);
            circleBtn.TabIndex = 1;
            circleBtn.Text = "Circle";
            circleBtn.UseVisualStyleBackColor = false;
            // 
            // triangle
            // 
            triangle.BackColor = Color.IndianRed;
            triangle.Location = new Point(275, 13);
            triangle.Name = "triangle";
            triangle.Size = new Size(75, 26);
            triangle.TabIndex = 2;
            triangle.Text = "triangle";
            triangle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(triangle);
            Controls.Add(circleBtn);
            Controls.Add(rectangleBtn);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion


        private Button rectangleBtn;
        private Button circleBtn;
        private Button triangle;
    }

}