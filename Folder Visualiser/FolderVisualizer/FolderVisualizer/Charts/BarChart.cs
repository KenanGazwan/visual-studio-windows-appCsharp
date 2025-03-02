using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Charts
{
    internal class BarChart : ChartStrategy
    {

        protected static Rectangle[] Bars;
        public void drawChart(Panel panel, Graphics graphics, List<string> titles, List<int> values)
        {
            // Clear the graphics surface
            graphics.Clear(Color.White);

            if (titles.Count != values.Count)
            {
                throw new Exception("titles.Length != values.Length");
            }

            int numberOfBars = titles.Count;
            int barHeight = (int)(1.0 / 12.0 * panel.Height);
            int paddingValue = (int)(1.0 / 30.0 * panel.Height);
            int maxBarLength = panel.Width - 4 * paddingValue;

            Color barColor = Color.DarkCyan;
            Font labelFont = new Font("Calibri", 12, FontStyle.Bold);
            Pen pen = new Pen(barColor, 1);

            // Calculate the total height of the content
            int totalHeight = paddingValue + numberOfBars * (barHeight + 10);

            // Set the AutoScrollMinSize property of the panel to ensure scrollability
            panel.AutoScrollMinSize = new Size(panel.ClientSize.Width, totalHeight);

            // Initialize y coordinate for drawing
            int y = paddingValue - panel.VerticalScroll.Value;

            for (int i = 0; i < numberOfBars; i++)
            {
                string label = "(" + values[i] + " MB" + ") " + titles[i];

                int barWidth = (values[i] + 1) * 10;
                if (barWidth > maxBarLength)
                {
                    barWidth = maxBarLength;
                }

                Rectangle textLabel = new Rectangle(paddingValue, y, maxBarLength, barHeight);
                Rectangle bar = new Rectangle(paddingValue, y, barWidth, barHeight);

                graphics.FillRectangle(new SolidBrush(barColor), bar);
                graphics.DrawRectangle(pen, bar);
                graphics.DrawString(label, labelFont, Brushes.Black, textLabel,
                    new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

                // Update y coordinate for next bar
                y += barHeight + 10;
            }
        }

    }
}
