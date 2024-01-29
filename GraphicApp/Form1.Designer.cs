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
            label2 = new Label();
            redo = new Button();
            undo = new Button();
            paste = new Button();
            clear = new Button();
            copy = new Button();
            filled = new CheckBox();
            thickness = new Label();
            colorDialog2 = new ColorDialog();
            selectFile = new Button();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            save = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // rectangleBtn
            // 
            rectangleBtn.BackColor = Color.Black;
            rectangleBtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rectangleBtn.ForeColor = Color.DimGray;
            rectangleBtn.Location = new Point(3, 33);
            rectangleBtn.Name = "rectangleBtn";
            rectangleBtn.Size = new Size(91, 33);
            rectangleBtn.TabIndex = 0;
            rectangleBtn.Text = "Rectangle";
            rectangleBtn.UseVisualStyleBackColor = false;
            // 
            // circleBtn
            // 
            circleBtn.BackColor = Color.Black;
            circleBtn.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            circleBtn.ForeColor = Color.DimGray;
            circleBtn.Location = new Point(3, 67);
            circleBtn.Name = "circleBtn";
            circleBtn.Size = new Size(91, 33);
            circleBtn.TabIndex = 1;
            circleBtn.Text = "Circle";
            circleBtn.UseVisualStyleBackColor = false;
            // 
            // triangle
            // 
            triangle.BackColor = Color.Black;
            triangle.BackgroundImageLayout = ImageLayout.None;
            triangle.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            triangle.ForeColor = Color.DimGray;
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
            hScrollBar1.LargeChange = 5;
            hScrollBar1.Location = new Point(123, 67);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(89, 14);
            hScrollBar1.TabIndex = 3;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(heart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rectangleBtn);
            panel1.Controls.Add(circleBtn);
            panel1.Controls.Add(triangle);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(730, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 103);
            panel1.TabIndex = 4;
            // 
            // heart
            // 
            heart.BackColor = Color.Black;
            heart.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            heart.ForeColor = Color.DimGray;
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
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(48, 7);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 3;
            label1.Text = "Shapes";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(redo);
            panel2.Controls.Add(undo);
            panel2.Controls.Add(paste);
            panel2.Controls.Add(clear);
            panel2.Controls.Add(copy);
            panel2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            panel2.ForeColor = Color.Fuchsia;
            panel2.Location = new Point(454, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 103);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(57, 7);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 10;
            label2.Text = "FUNCTIONS";
            // 
            // redo
            // 
            redo.BackColor = Color.Black;
            redo.ForeColor = Color.DimGray;
            redo.Location = new Point(186, 72);
            redo.Name = "redo";
            redo.Size = new Size(81, 23);
            redo.TabIndex = 9;
            redo.Text = "Redo";
            redo.UseVisualStyleBackColor = false;
            // 
            // undo
            // 
            undo.BackColor = Color.Black;
            undo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            undo.ForeColor = Color.DimGray;
            undo.Location = new Point(186, 38);
            undo.Name = "undo";
            undo.Size = new Size(81, 23);
            undo.TabIndex = 8;
            undo.Text = "Undo";
            undo.UseVisualStyleBackColor = false;
            // 
            // paste
            // 
            paste.BackColor = Color.Black;
            paste.ForeColor = Color.DimGray;
            paste.Location = new Point(3, 70);
            paste.Name = "paste";
            paste.Size = new Size(101, 23);
            paste.TabIndex = 7;
            paste.Text = "Paste";
            paste.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.Black;
            clear.ForeColor = Color.DimGray;
            clear.Location = new Point(110, 57);
            clear.Name = "clear";
            clear.Size = new Size(70, 27);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // copy
            // 
            copy.BackColor = Color.Black;
            copy.ForeColor = Color.DimGray;
            copy.Location = new Point(3, 45);
            copy.Name = "copy";
            copy.Size = new Size(101, 23);
            copy.TabIndex = 5;
            copy.Text = "Copy";
            copy.UseVisualStyleBackColor = false;
            copy.Click += copyObject;
            // 
            // filled
            // 
            filled.AutoSize = true;
            filled.BackColor = Color.Black;
            filled.CheckAlign = ContentAlignment.MiddleRight;
            filled.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            filled.ForeColor = Color.DimGray;
            filled.Location = new Point(3, 39);
            filled.Name = "filled";
            filled.Size = new Size(76, 22);
            filled.TabIndex = 4;
            filled.Text = "Filled";
            filled.UseVisualStyleBackColor = false;
            // 
            // thickness
            // 
            thickness.AutoSize = true;
            thickness.BackColor = Color.DimGray;
            thickness.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            thickness.ForeColor = Color.Black;
            thickness.Location = new Point(123, 42);
            thickness.Name = "thickness";
            thickness.Size = new Size(89, 18);
            thickness.TabIndex = 0;
            thickness.Text = "Thickness";
            // 
            // selectFile
            // 
            selectFile.AutoSize = true;
            selectFile.BackColor = Color.Black;
            selectFile.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectFile.ForeColor = Color.DimGray;
            selectFile.Location = new Point(6, 65);
            selectFile.Name = "selectFile";
            selectFile.Size = new Size(103, 28);
            selectFile.TabIndex = 11;
            selectFile.Text = "Select File\r\n";
            selectFile.TextAlign = ContentAlignment.TopLeft;
            selectFile.UseVisualStyleBackColor = false;
            selectFile.Click += selectFile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(filled);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(hScrollBar1);
            panel3.Controls.Add(thickness);
            panel3.Location = new Point(227, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 103);
            panel3.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(56, 7);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 0;
            label3.Text = "DESIGN";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(save);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(selectFile);
            panel4.Location = new Point(5, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 103);
            panel4.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(30, 11);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 12;
            label4.Text = "SAVE/RELOAD";
            // 
            // save
            // 
            save.BackColor = Color.Black;
            save.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            save.ForeColor = Color.DimGray;
            save.Location = new Point(113, 37);
            save.Name = "save";
            save.Size = new Size(96, 24);
            save.TabIndex = 14;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(942, 451);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private OpenFileDialog openFileDialog1;
        private Button selectFile;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private TextBox textBox1;
        private Button save;
    }

}