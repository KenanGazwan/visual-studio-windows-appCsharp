using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ShapesDrawing_v3.Shapes
{    
    internal class MyRectangle : Shape
    {
        private int x, y, width, height;
        private Rectangle rectangle;
        public MyRectangle() { }

        public MyRectangle(int x, int y, int width, int height, int number) : base(number)
        {
            base.number = number;
            base.name = "Rectangle";

            this.x = x;
            this.y = y;
            this.width = width; 
            this.height = height;
        }


        public override void draw(Graphics graphics)
        {
            rectangle = new Rectangle(x, y, width, height);
            
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
            else if(highlighted && !rectangle.Contains(location))
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
            return this.ToString() + " (x= " + x + ", y= " + y + ", Width= " + width + ", Height= " + height + ")";
        }


    }
}
