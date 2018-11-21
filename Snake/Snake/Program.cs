using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIMA BOBROVICH");
            HorizontalLine topLine = new HorizontalLine(0, 60, 1, '+');
            HorizontalLine botLine = new HorizontalLine(0, 60, 20, '+');
            VerticalLine leftLine = new VerticalLine(0, 1, 20, '+');
            VerticalLine RightLine = new VerticalLine(60, 1, 20, '+');

            topLine.Drow();
            botLine.Drow();
            leftLine.Drow();
            RightLine.Drow();

            Point p1 = new Point(1, 4, '*');

            Snake snake = new Snake(p1, 4, Direction.RIGHT);

            for (var i = 5; i <= 15; i ++)
            {
                snake.Drow();
                snake.Move();
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}
