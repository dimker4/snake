using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine (int xLeft, int xRight, int y, char c)
        {
            pList = new List<Point>();

            for (var x = xLeft; x <= xRight; x++)
            {
                var p = new Point(x, y, c);
                pList.Add(p);
            }
        }

        public void Draw ()
        {
            foreach (var i in pList)
            {
                i.Draw();
            }
        }
    }
}
