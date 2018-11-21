using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pLine = new List<Point>();
            for (var i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLine.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pLine.First();
            pLine.Remove(tail);
            Point head = GetNextPoint();
            pLine.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint ()
        {
            Point head = pLine.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, this.direction);
            return nextPoint;
        }
    }
}
