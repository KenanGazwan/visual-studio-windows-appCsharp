using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Charts
{
    internal class PieChart : ChartStrategy
    {
        
        private static Color[] piesColors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple };

        public void drawChart(Panel panel, Graphics graphics, List<string> titles, List<int> values)
        {
            // Clear the graphics surface
            graphics.Clear(Color.White);

            if (titles.Count != values.Count)
            {
                throw new Exception("titles.Length != values.Length");
            }

            // Prepare the Pie Chart Colors
            List<Color> colors = new List<Color>();
            for (int i = 0; i < titles.Count; i++)
            {
                colors.Add(piesColors[i % piesColors.Length]);
            }

            Font labelFont = new Font("Calibri", 9, FontStyle.Bold);

            int total = values.Sum();
            int pieDiameter = Math.Min(panel.Width, panel.Height) - 20; // Determine the diameter of the Pie Chart
            Rectangle bounds = new Rectangle((panel.Width - pieDiameter) / 2, (panel.Height - pieDiameter) / 2, pieDiameter, pieDiameter);

            float startAngle = 0;

            for (int i = 0; i < values.Count; i++)
            {
                float sweepAngle = 360f * values[i] / total;

                using (SolidBrush brush = new SolidBrush(colors[i % colors.Count]))
                {
                    graphics.FillPie(brush, bounds, startAngle, sweepAngle);
                }

                // Calculate label position
                float midAngle = startAngle + sweepAngle / 2;
                float radius = bounds.Width / 2 * 1.2f; // Adjust the radius for label placement

                // Calculate label coordinates
                float labelX = bounds.X + bounds.Width / 2 + radius * (float)Math.Cos(midAngle * Math.PI / 180);
                float labelY = bounds.Y + bounds.Height / 2 + radius * (float)Math.Sin(midAngle * Math.PI / 180);

                // Draw label
                string label = "(" + values[i] + " MB" + ") " + titles[i];
                SizeF labelSize = graphics.MeasureString(label, labelFont);
                RectangleF labelRect = new RectangleF(labelX - labelSize.Width / 2, labelY - labelSize.Height / 2, labelSize.Width, labelSize.Height);
                graphics.DrawString(label, labelFont, Brushes.Black, labelRect, new StringFormat() { Alignment = StringAlignment.Center });

                startAngle += sweepAngle;
            }
        }

    }
}
