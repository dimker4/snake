using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;

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

        internal void Move(int i)
        {
            Point tail = pLine.First();
            pLine.Remove(tail);
            Point head = GetNextPoint();

            //List<char> s = new List<char>();
            //s.Add('D');
            //s.Add('i');
            //s.Add('m');
            //s.Add('a');
            //s.Add('Z');
            //s.Add('o');
            //s.Add('R');
            //s.Add('i');
            //s.Add('n');
            //head.c = s[i];

            pLine.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint () // Вернет следующую точку при перемещении
        {
            Point head = pLine.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, this.direction);
            return nextPoint;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (food.x == head.x & food.y == head.y)
            {
                food.c = head.c;
                pLine.Add(food);
                return true;
            }
            return false;
        }
    }
}
