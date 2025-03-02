using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing_v3.Shapes
{
    internal class MyLine : Shape
    {
        private int point_1, point_2;
        private Point p1, p2;
        private Point[] points;

        public MyLine() { }

        public MyLine(int point_1, int point_2, int number) : base(number) 
        { 
            base.number = number;
            this.point_1 = point_1;
            this.point_2 = point_2;
            base.name = "Line";
        }

        public override void draw(Graphics graphics)
        {
            p1 = new Point(point_1, point_2);
            p2 = new Point(2* point_1, 2*point_2);
            points = new Point[] { p1, p2 };
            graphics.DrawLine(GetPenDraw(), p1, p2);
        }

        public override bool highlight(Graphics graphics, Point location)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(p1, p2);



            if (!highlighted && path.IsOutlineVisible(location, GetPenDraw()))
            {
                highlight(graphics);
            }
            else if (highlighted && path.IsOutlineVisible(location, GetPenDraw()))
            {
                removeHighlight(graphics);
            }
            else if (highlighted && !path.IsOutlineVisible(location, GetPenDraw()))
            {
                removeHighlight(graphics);
            }

            return highlighted;
        }

        public override void highlight(Graphics graphics)
        {
            graphics.DrawLine(GetPenHighlight(), p1, p2);
            highlighted = !highlighted;
        }

        public override void removeHighlight(Graphics graphics)
        {
            draw(graphics);
            highlighted = !highlighted;
        }

        public override string info()
        {
            return this.ToString() + " (point 1 =(" + point_1 + ", " + point_2 + "), (point 2 =("+point_1*2 +", "+point_2*2 +")" +")";
        }
    }
}
