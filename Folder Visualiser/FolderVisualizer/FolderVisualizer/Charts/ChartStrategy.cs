using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FolderVisualizer.Charts
{
    internal interface ChartStrategy
    {
        public abstract void drawChart(Panel panel, Graphics graphics, List<string> titles, List<int> values);
    }
}
