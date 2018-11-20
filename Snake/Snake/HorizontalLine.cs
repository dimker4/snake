using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine (int xLeft, int xRight, int y, char c)
        {
            pLine = new List<Point>();

            for (var x = xLeft; x <= xRight; x++)
            {
                var p = new Point(x, y, c);
                pLine.Add(p);
            }
        }

    }
}
