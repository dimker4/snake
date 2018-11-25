using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public int widthSizeMap;
        public int heightSizeMap;
        public char c;

        public Food (int _w, int _h, char _c)
        {
            this.widthSizeMap = _w;
            this.heightSizeMap = _h;
            this.c = _c;
        }

        public Point CreateFood ()
        {
            Point p = new Point();
            Random rnd = new Random();
            p.x = rnd.Next(this.widthSizeMap);
            p.y = rnd.Next(this.heightSizeMap);
            p.c = this.c;
            return p;
        }
    }
}
