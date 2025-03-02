using ShapesDrawing_v3.Shapes;
using System.Diagnostics;
using System.Drawing;
using System.IO.Packaging;
using System.Windows.Forms;

namespace ShapesDrawing_v3
{
    public partial class Form1 : Form
    {
        // Form1 Attributes
        private Graphics graphics;
        private int[] randomPara;
        private ShapeCollection shapeCol = new ShapeCollection();
        private Form2 infoModeForm;

        public Form1()
        {
            InitializeComponent();
            graphics = Area_B.CreateGraphics();
            infoModeForm = new Form2();

            // Add a MouseClick event handler to the Area_B panel
            Area_B.MouseClick += (sender, e) => OnPanelMouseClick(e);

            Area_C.MouseClick += Area_C_MouseClick;

        }

        private void Area_C_MouseClick(object sender, EventArgs e)
        {
            if (Area_C.SelectedItem != null)
            {
                foreach (var item in shapeCol.GetShapesList())
                {
                    item.removeHighlight(graphics);
                }

                string selectedText = Area_C.SelectedItem.ToString();
                shapeCol.GetShape(selectedText).highlight(graphics);

            }
        }

        private void OnPanelMouseClick(MouseEventArgs e)
        {
            Area_C.ClearSelected();

            foreach (var item in shapeCol.GetShapesList())
            {
                bool shouldSelect = false;

                shouldSelect = item.highlight(graphics, e.Location);

                if (shouldSelect)
                {
                    int index = Area_C.FindStringExact(item.ToString());
                    Area_C.SetSelected(index, true);
                }

            }
            this.Invalidate();
        }

        // UI tools methods
        private void DrawMode_Click(object sender, EventArgs e)
        {
            this.Show(); this.BringToFront();
        }
        private void InfoMode_Click(object sender, EventArgs e)
        {
            infoModeForm.Show(); infoModeForm.BringToFront();
            infoModeForm.setInfoList(shapeCol.GetInfoList());
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            updateRandomValues();

            shapeCol.Add(new MyRectangle(), randomPara);

            shapeCol.GetLast().draw(graphics);

            addToArea_C(shapeCol.GetLast());
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            updateRandomValues();

            shapeCol.Add(new MyCircle(), randomPara);

            shapeCol.GetLast().draw(graphics);

            addToArea_C(shapeCol.GetLast());
        }

        private void Square_Click(object sender, EventArgs e)
        {
            updateRandomValues();

            shapeCol.Add(new MySquare(), randomPara);

            shapeCol.GetLast().draw(graphics);

            addToArea_C(shapeCol.GetLast());
        }

        private void Line_Click(object sender, EventArgs e)
        {
            updateRandomValues();

            shapeCol.Add(new MyLine(), randomPara);

            shapeCol.GetLast().draw(graphics);

            addToArea_C(shapeCol.GetLast());
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            updateRandomValues();

            shapeCol.Add(new MyTriangle(), randomPara);

            shapeCol.GetLast().draw(graphics);

            addToArea_C(shapeCol.GetLast());
        }

        // My custom methods
        private void updateRandomValues()
        {
            Random rnd = new Random();
            int random_x, random_y, random_width, random_height;
            random_x = rnd.Next(0, 600);
            random_y = rnd.Next(0, 600);
            random_width = rnd.Next(0, 200);
            random_height = rnd.Next(0, 200);

            randomPara = new int[] { random_x, random_y, random_width, random_height };
        }

        private void addToArea_C(Shape shape)
        {
            Area_C.Items.Add(shape.ToString());
        }

    }
}
