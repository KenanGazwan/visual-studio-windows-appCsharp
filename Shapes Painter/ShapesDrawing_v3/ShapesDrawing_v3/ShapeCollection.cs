using ShapesDrawing_v3.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing_v3
{
    public class ShapeCollection
    {
        private List<Shapes.Shape> myShapes;
        private List<String> infoList;

        // This is not the reponsibility of the shape collection class
        private int rectangleCount, squareCount, lineCount, circleCount, triangleCount;

        public ShapeCollection() {
            myShapes = new List<Shape>();
            rectangleCount = 0; squareCount = 0; lineCount = 0; circleCount = 0; triangleCount = 0;
        }

        public void Add(Shapes.Shape shape, int[] shapeParam)
        {
            //This Method add the shape to the list,
            //and keeps track of the shapes number

            if(shape is MyRectangle)
            {
                rectangleCount++;
                shape = new MyRectangle(shapeParam[0], shapeParam[1], shapeParam[2], shapeParam[3], rectangleCount);
            } 
            else if (shape is MyCircle)
            {
                circleCount++;
                shape = new MyCircle(shapeParam[0], shapeParam[1], shapeParam[2], shapeParam[3], circleCount);
            }
            else if (shape is MySquare)
            {
                squareCount++;
                shape = new MySquare(shapeParam[0], shapeParam[1], shapeParam[2], squareCount);
            }
            else if (shape is MyLine)
            {
                lineCount++;
                shape = new MyLine(shapeParam[0], shapeParam[1], lineCount);
            }
            else if (shape is MyTriangle)
            {
                triangleCount++;
                shape = new MyTriangle(shapeParam[0], shapeParam[1], shapeParam[2], shapeParam[3], triangleCount);
            }
            else { throw new ArgumentOutOfRangeException(); }

            myShapes.Add(shape);
        }

        // returns the last item added to the shapelist.
        public Shape GetLast()
        {
            try
            {
                return myShapes.Last<Shape>();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }

        public Shape GetShape(String shapeName)
        {
            foreach (var item in myShapes)
            {
                if (shapeName.Equals(item.ToString()))
                {
                    return item;
                }
            }
            throw new InvalidDataException();
        }

        public List<String> GetInfoList()
        {
            infoList = new List<string>();

            foreach (var item in myShapes)
            {
                infoList.Add(item.info());
            }

            return infoList;
        }

        public List<Shapes.Shape> GetShapesList()
        {
            return myShapes;
        }

 
    }
}
