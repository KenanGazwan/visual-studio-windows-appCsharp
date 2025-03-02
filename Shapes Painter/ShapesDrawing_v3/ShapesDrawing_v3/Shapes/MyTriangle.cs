using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing_v3.Shapes
{
    internal class MyTriangle : Shape
    {

        private int x, y, width, height;
        private Point p1, p2, p3;
        private Point[] points;

        public MyTriangle() {  }
        public MyTriangle(int x, int y, int width, int height, int number) : base(number)
        {
            base.number = number;   
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            base.name = "Triangle";
        }

        public override void draw(Graphics graphics)
        {
            p1 = new Point(x, y); 
            p2 = new Point(x + width, y);
            p3 = new Point(x + width / 2, y - height); 

            points = new Point[] { p1, p2, p3 };

            graphics.DrawPolygon(GetPenDraw(), points);
        }

        public override bool highlight(Graphics graphics, Point location)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(points);

            if (!highlighted && path.IsVisible(location))
            {
                highlight(graphics);
            }
            else if (highlighted && path.IsVisible(location))
            {
                removeHighlight(graphics);
            }
            else if (highlighted && !path.IsVisible(location))
            {
                removeHighlight(graphics);
            }

            return highlighted;
        }

        public override void highlight(Graphics graphics)
        {
            graphics.DrawPolygon(GetPenHighlight(), points);
            highlighted = !highlighted;
        }

        public override void removeHighlight(Graphics graphics)
        {
            draw(graphics);
            highlighted = !highlighted;
        }


        public override string info() 
        {
            return this.ToString() + " (x= " + x + ", y= " + y + ", Width= " + width + ", Height= " + height + ")";
        }

    }
}
