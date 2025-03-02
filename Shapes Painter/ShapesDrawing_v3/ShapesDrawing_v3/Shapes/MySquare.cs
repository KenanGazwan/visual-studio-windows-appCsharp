using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing_v3.Shapes
{
    internal class MySquare : Shape
    {
        private int x, y, side;
        private Rectangle rectangle;

        public MySquare() { }

        public MySquare(int x, int y, int side, int number) :base(number) 
        {
            base.number = number;
            this.x = x;
            this.y = y;
            this.side = side;
            base.name = "Square";

        }

        public override void draw(Graphics graphics)
        {
            rectangle = new Rectangle(x, y, side, side);

            graphics.DrawRectangle(GetPenDraw(), rectangle);
        }

        public override bool highlight(Graphics graphics, Point location)
        {
            if (!highlighted && rectangle.Contains(location))
            {
                highlight(graphics);
            }
            else if (highlighted && rectangle.Contains(location))
            {
                removeHighlight(graphics);
            }
            else if (highlighted && !rectangle.Contains(location))
            {
                removeHighlight(graphics);
            }

            return highlighted;
        }

        public override void highlight(Graphics graphics)
        {
            graphics.DrawRectangle(GetPenHighlight(), rectangle);
            highlighted = !highlighted;
        }

        public override void removeHighlight(Graphics graphics)
        {
            draw(graphics);
            highlighted = !highlighted;
        }


        public override string info()
        {
            return this.ToString() + " (x= " + x + ", y= " + y + ", Side= " + side + ")";
        }


    }
}
