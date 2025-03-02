namespace ShapesDrawing_v3
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
            DrawMode = new Button();
            InfoMode = new Button();
            Square = new Button();
            Circle = new Button();
            Line = new Button();
            Rectangle = new Button();
            Triangle = new Button();
            button6 = new Button();
            Area_A = new Panel();
            button1 = new Button();
            button2 = new Button();
            Area_B = new Panel();
            ShapesListTitle = new TextBox();
            Area_C = new ListBox();
            Area_A.SuspendLayout();
            SuspendLayout();
            // 
            // DrawMode
            // 
            DrawMode.BackColor = SystemColors.GrayText;
            DrawMode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            DrawMode.ForeColor = SystemColors.ButtonHighlight;
            DrawMode.Location = new Point(13, 12);
            DrawMode.Name = "DrawMode";
            DrawMode.Size = new Size(138, 45);
            DrawMode.TabIndex = 0;
            DrawMode.Text = "DrawMode";
            DrawMode.UseVisualStyleBackColor = false;
            DrawMode.Click += DrawMode_Click;
            // 
            // InfoMode
            // 
            InfoMode.BackColor = SystemColors.GrayText;
            InfoMode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            InfoMode.ForeColor = SystemColors.ButtonHighlight;
            InfoMode.Location = new Point(158, 12);
            InfoMode.Name = "InfoMode";
            InfoMode.Size = new Size(132, 45);
            InfoMode.TabIndex = 1;
            InfoMode.Text = "InfoMode";
            InfoMode.UseVisualStyleBackColor = false;
            InfoMode.Click += InfoMode_Click;
            // 
            // Square
            // 
            Square.BackColor = SystemColors.ButtonShadow;
            Square.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Square.Location = new Point(11, 174);
            Square.Name = "Square";
            Square.Size = new Size(106, 55);
            Square.TabIndex = 2;
            Square.Text = "Square";
            Square.UseVisualStyleBackColor = false;
            Square.Click += Square_Click;
            // 
            // Circle
            // 
            Circle.BackColor = SystemColors.ButtonShadow;
            Circle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Circle.Location = new Point(11, 18);
            Circle.Name = "Circle";
            Circle.Size = new Size(106, 55);
            Circle.TabIndex = 3;
            Circle.Text = "Circle";
            Circle.UseVisualStyleBackColor = false;
            Circle.Click += Circle_Click;
            // 
            // Line
            // 
            Line.BackColor = SystemColors.ButtonShadow;
            Line.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Line.Location = new Point(123, 95);
            Line.Name = "Line";
            Line.Size = new Size(106, 55);
            Line.TabIndex = 4;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = false;
            Line.Click += Line_Click;
            // 
            // Rectangle
            // 
            Rectangle.BackColor = SystemColors.ButtonShadow;
            Rectangle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Rectangle.Location = new Point(11, 95);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(106, 55);
            Rectangle.TabIndex = 5;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = false;
            Rectangle.Click += Rectangle_Click;
            // 
            // Triangle
            // 
            Triangle.BackColor = SystemColors.ButtonShadow;
            Triangle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Triangle.Location = new Point(123, 18);
            Triangle.Name = "Triangle";
            Triangle.Size = new Size(106, 55);
            Triangle.TabIndex = 6;
            Triangle.Text = "Triangle";
            Triangle.UseVisualStyleBackColor = false;
            Triangle.Click += Triangle_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.Location = new Point(123, 174);
            button6.Name = "button6";
            button6.Size = new Size(106, 55);
            button6.TabIndex = 7;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = false;
            // 
            // Area_A
            // 
            Area_A.BackColor = SystemColors.ControlLightLight;
            Area_A.Controls.Add(button1);
            Area_A.Controls.Add(button2);
            Area_A.Controls.Add(Circle);
            Area_A.Controls.Add(Square);
            Area_A.Controls.Add(button6);
            Area_A.Controls.Add(Triangle);
            Area_A.Controls.Add(Line);
            Area_A.Controls.Add(Rectangle);
            Area_A.Location = new Point(25, 101);
            Area_A.Name = "Area_A";
            Area_A.Size = new Size(241, 598);
            Area_A.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(11, 258);
            button1.Name = "button1";
            button1.Size = new Size(106, 55);
            button1.TabIndex = 8;
            button1.Text = ".";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(123, 258);
            button2.Name = "button2";
            button2.Size = new Size(106, 55);
            button2.TabIndex = 9;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = false;
            // 
            // Area_B
            // 
            Area_B.BackColor = SystemColors.ButtonHighlight;
            Area_B.Location = new Point(288, 101);
            Area_B.Name = "Area_B";
            Area_B.Size = new Size(794, 598);
            Area_B.TabIndex = 9;
            // 
            // ShapesListTitle
            // 
            ShapesListTitle.BackColor = SystemColors.Control;
            ShapesListTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShapesListTitle.Location = new Point(1148, 51);
            ShapesListTitle.Name = "ShapesListTitle";
            ShapesListTitle.ReadOnly = true;
            ShapesListTitle.Size = new Size(111, 43);
            ShapesListTitle.TabIndex = 11;
            ShapesListTitle.Text = "Shapes";
            ShapesListTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // Area_C
            // 
            Area_C.FormattingEnabled = true;
            Area_C.ItemHeight = 23;
            Area_C.Location = new Point(1102, 100);
            Area_C.Name = "Area_C";
            Area_C.Size = new Size(203, 602);
            Area_C.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 737);
            Controls.Add(Area_C);
            Controls.Add(ShapesListTitle);
            Controls.Add(Area_B);
            Controls.Add(Area_A);
            Controls.Add(InfoMode);
            Controls.Add(DrawMode);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Name = "Form1";
            Text = "Draw App";
            Area_A.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DrawMode;
        private Button InfoMode;
        private Button Square;
        private Button Circle;
        private Button Line;
        private Button Rectangle;
        private Button Triangle;
        private Button button6;
        private Panel Area_A;
        private Button button1;
        private Button button2;
        private Panel Area_B;
        private TextBox ShapesListTitle;
        private ListBox Area_C;
    }
}
