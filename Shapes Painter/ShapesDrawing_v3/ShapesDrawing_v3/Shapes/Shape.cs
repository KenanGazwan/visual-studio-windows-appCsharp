using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing_v3.Shapes
{
    public abstract class Shape
    {
        protected int number;
        protected String name;
        protected bool highlighted;

        protected Shape() { }
        protected Shape(int number) 
        {
            this.number = number;
            this.highlighted = false;
        }

        public abstract void draw(Graphics graphics);

        // This method is to highlight the shape accoding to clicking the shape,
        // So, we need the location of mouse click
        public abstract bool highlight(Graphics graphics, Point location);

        public abstract void highlight(Graphics graphics);

        public abstract void removeHighlight(Graphics graphics);

        public abstract String info();

        public override String ToString()
        {
            return name + " " + number;
        }

        public Pen GetPenDraw() 
        { 
            return new Pen(Color.Green, 5); ;
        }

        public Pen GetPenHighlight()
        {
            return new Pen(Color.Blue, 3); ;
        }


    }
}
