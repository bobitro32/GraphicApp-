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
            hScrollBar1 = new HScrollBar();
            panel1 = new Panel();
            heart = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rectangleBtn
            // 
            rectangleBtn.BackColor = Color.Blue;
            rectangleBtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rectangleBtn.ForeColor = Color.Fuchsia;
            rectangleBtn.Location = new Point(3, 33);
            rectangleBtn.Name = "rectangleBtn";
            rectangleBtn.Size = new Size(91, 33);
            rectangleBtn.TabIndex = 0;
            rectangleBtn.Text = "Rectangle";
            rectangleBtn.UseVisualStyleBackColor = false;
            // 
            // circleBtn
            // 
            circleBtn.BackColor = Color.Blue;
            circleBtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            circleBtn.ForeColor = Color.Fuchsia;
            circleBtn.Location = new Point(3, 67);
            circleBtn.Name = "circleBtn";
            circleBtn.Size = new Size(91, 33);
            circleBtn.TabIndex = 1;
            circleBtn.Text = "Circle";
            circleBtn.UseVisualStyleBackColor = false;
            // 
            // triangle
            // 
            triangle.BackColor = Color.Blue;
            triangle.BackgroundImageLayout = ImageLayout.None;
            triangle.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            triangle.ForeColor = Color.Fuchsia;
            triangle.Location = new Point(100, 33);
            triangle.Name = "triangle";
            triangle.Size = new Size(87, 33);
            triangle.TabIndex = 2;
            triangle.Text = "Triangle";
            triangle.UseVisualStyleBackColor = false;
            // 
            // hScrollBar1
            // 
            hScrollBar1.AllowDrop = true;
            hScrollBar1.Location = new Point(711, 142);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 3;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(heart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rectangleBtn);
            panel1.Controls.Add(circleBtn);
            panel1.Controls.Add(triangle);
            panel1.ForeColor = Color.MediumVioletRed;
            panel1.Location = new Point(588, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 103);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            heart.BackColor = Color.Blue;
            heart.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            heart.ForeColor = Color.Fuchsia;
            heart.Location = new Point(100, 67);
            heart.Name = "button1";
            heart.Size = new Size(87, 33);
            heart.TabIndex = 4;
            heart.Text = "Heart";
            heart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(63, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Shapes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(hScrollBar1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Button rectangleBtn;
        private Button circleBtn;
        private Button triangle;
        private HScrollBar hScrollBar1;
        private Panel panel1;
        private Label label1;
        private Button heart;
    }

}