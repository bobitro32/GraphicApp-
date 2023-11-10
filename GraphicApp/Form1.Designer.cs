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
            SuspendLayout();
            // 
            // button1
            // 
            rectangleBtn.Location = new Point(113, 13);
            rectangleBtn.Name = "rectangleBtn";
            rectangleBtn.Size = new Size(75, 23);
            rectangleBtn.TabIndex = 0;
            rectangleBtn.Text = "Rectangle";
            rectangleBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            circleBtn.Location = new Point(218, 20);
            circleBtn.Name = "circleBtn";
            circleBtn.Size = new Size(75, 23);
            circleBtn.TabIndex = 1;
            circleBtn.Text = "Circle";
            circleBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(circleBtn);
            Controls.Add(rectangleBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion


        private Button rectangleBtn;
        private Button circleBtn;
    }

}