using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pLine;

        public VerticalLine(int x, int yTop, int yBottom, char c)
        {
            pLine = new List<Point>();

            for (var y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, c);
                pLine.Add(p);
            }

        }

        public void Drow()
        {
            foreach (var i in pLine)
            {
                i.Draw();
            }
        }
    }
}
