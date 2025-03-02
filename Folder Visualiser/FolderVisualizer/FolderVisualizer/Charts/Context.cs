using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderVisualizer.Charts
{
    internal class Context
    {
        private ChartStrategy strategy;

        public void setStrategy(ChartStrategy strategy)
        {
            this.strategy = strategy; 
        }

        public void drawChart(Panel panel, Graphics graphics, List<string> titles, List<int> values)
        {
            strategy.drawChart(panel, graphics, titles, values);
        }
    }
}
