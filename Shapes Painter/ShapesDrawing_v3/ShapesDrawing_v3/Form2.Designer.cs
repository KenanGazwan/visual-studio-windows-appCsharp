namespace ShapesDrawing_v3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DrawMode = new Button();
            InfoMode = new Button();
            ListInfoShapes = new ListView();
            ListInfoTitle = new TextBox();
            Refresh = new Button();
            SuspendLayout();
            // 
            // DrawMode
            // 
            DrawMode.BackColor = SystemColors.GrayText;
            DrawMode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            DrawMode.ForeColor = SystemColors.ButtonHighlight;
            DrawMode.Location = new Point(12, 12);
            DrawMode.Name = "DrawMode";
            DrawMode.Size = new Size(138, 45);
            DrawMode.TabIndex = 3;
            DrawMode.Text = "DrawMode";
            DrawMode.UseVisualStyleBackColor = false;
            DrawMode.Click += DrawMode_Click;
            // 
            // InfoMode
            // 
            InfoMode.BackColor = SystemColors.GrayText;
            InfoMode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            InfoMode.ForeColor = SystemColors.ButtonHighlight;
            InfoMode.Location = new Point(156, 12);
            InfoMode.Name = "InfoMode";
            InfoMode.Size = new Size(138, 45);
            InfoMode.TabIndex = 4;
            InfoMode.Text = "InfoMode";
            InfoMode.UseVisualStyleBackColor = false;
            InfoMode.Click += InfoMode_Click;
            // 
            // ListInfoShapes
            // 
            ListInfoShapes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListInfoShapes.Location = new Point(12, 172);
            ListInfoShapes.Name = "ListInfoShapes";
            ListInfoShapes.Size = new Size(1293, 553);
            ListInfoShapes.TabIndex = 5;
            ListInfoShapes.UseCompatibleStateImageBehavior = false;
            ListInfoShapes.View = View.List;
            // 
            // ListInfoTitle
            // 
            ListInfoTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListInfoTitle.Location = new Point(12, 123);
            ListInfoTitle.Name = "ListInfoTitle";
            ListInfoTitle.ReadOnly = true;
            ListInfoTitle.Size = new Size(179, 43);
            ListInfoTitle.TabIndex = 6;
            ListInfoTitle.Text = "Shapes";
            ListInfoTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // Refresh
            // 
            Refresh.BackColor = SystemColors.GrayText;
            Refresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Refresh.ForeColor = SystemColors.ButtonHighlight;
            Refresh.Location = new Point(1167, 12);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(138, 45);
            Refresh.TabIndex = 7;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 737);
            Controls.Add(Refresh);
            Controls.Add(ListInfoTitle);
            Controls.Add(ListInfoShapes);
            Controls.Add(InfoMode);
            Controls.Add(DrawMode);
            Name = "Form2";
            Text = "DrawApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DrawMode;
        private Button InfoMode;
        private ListView ListInfoShapes;
        private TextBox ListInfoTitle;
        private Button Refresh;
    }
}