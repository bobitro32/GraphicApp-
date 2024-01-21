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
            colorDialog1 = new ColorDialog();
            panel2 = new Panel();
            redo = new Button();
            undo = new Button();
            paste = new Button();
            clear = new Button();
            copy = new Button();
            filled = new CheckBox();
            thickness = new Label();
            colorDialog2 = new ColorDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            hScrollBar1.Location = new Point(3, 18);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 3;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(heart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rectangleBtn);
            panel1.Controls.Add(circleBtn);
            panel1.Controls.Add(triangle);
            panel1.ForeColor = Color.MediumVioletRed;
            panel1.Location = new Point(601, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 103);
            panel1.TabIndex = 4;
            // 
            // heart
            // 
            heart.BackColor = Color.Blue;
            heart.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            heart.ForeColor = Color.Fuchsia;
            heart.Location = new Point(100, 67);
            heart.Name = "heart";
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(redo);
            panel2.Controls.Add(undo);
            panel2.Controls.Add(paste);
            panel2.Controls.Add(clear);
            panel2.Controls.Add(copy);
            panel2.Controls.Add(filled);
            panel2.Controls.Add(thickness);
            panel2.Controls.Add(hScrollBar1);
            panel2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            panel2.ForeColor = Color.Fuchsia;
            panel2.Location = new Point(293, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 103);
            panel2.TabIndex = 5;
            // 
            // redo
            // 
            redo.BackColor = Color.MediumBlue;
            redo.Location = new Point(143, 61);
            redo.Name = "redo";
            redo.Size = new Size(75, 23);
            redo.TabIndex = 9;
            redo.Text = "Redo";
            redo.UseVisualStyleBackColor = false;
            // 
            // undo
            // 
            undo.BackColor = Color.MediumBlue;
            undo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            undo.Location = new Point(224, 32);
            undo.Name = "undo";
            undo.Size = new Size(75, 23);
            undo.TabIndex = 8;
            undo.Text = "Undo";
            undo.UseVisualStyleBackColor = false;
            // 
            // paste
            // 
            paste.BackColor = Color.MediumBlue;
            paste.ForeColor = Color.Fuchsia;
            paste.Location = new Point(143, 32);
            paste.Name = "paste";
            paste.Size = new Size(75, 23);
            paste.TabIndex = 7;
            paste.Text = "Paste";
            paste.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.Blue;
            clear.Location = new Point(224, 3);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // copy
            // 
            copy.BackColor = Color.Blue;
            copy.Location = new Point(143, 3);
            copy.Name = "copy";
            copy.Size = new Size(75, 23);
            copy.TabIndex = 5;
            copy.Text = "Copy";
            copy.UseVisualStyleBackColor = false;
            copy.Click += copyObject;
            // 
            // filled
            // 
            filled.AutoSize = true;
            filled.BackColor = Color.MediumBlue;
            filled.CheckAlign = ContentAlignment.MiddleRight;
            filled.ForeColor = Color.Fuchsia;
            filled.Location = new Point(0, 43);
            filled.Name = "filled";
            filled.Size = new Size(70, 21);
            filled.TabIndex = 4;
            filled.Text = "Filled";
            filled.UseVisualStyleBackColor = false;
            // 
            // thickness
            // 
            thickness.AutoSize = true;
            thickness.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            thickness.Location = new Point(0, 0);
            thickness.Name = "thickness";
            thickness.Size = new Size(89, 18);
            thickness.TabIndex = 0;
            thickness.Text = "Thickness";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(813, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ColorDialog colorDialog1;
        private Panel panel2;
        private Label thickness;
        private ColorDialog colorDialog2;
        private CheckBox filled;
        private Button copy;
        private Button clear;
        private Button paste;
        private Button undo;
        private Button redo;
    }

}