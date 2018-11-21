using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public Point() { }
        public Point(int _x, int _y, char _c)
        {
            x = _x;
            y = _y;
            c = _c;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + offset;
            if (direction == Direction.LEFT) x = x - offset;
            if (direction == Direction.UP) y = y + offset;
            if (direction == Direction.DOWN) y = y - offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public void Clear()
        {
            c = ' ';
            this.Draw();
        }
    }
}
