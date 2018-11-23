using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


            Point p1 = new Point(1, 4, 'D');
            Snake snake = new Snake(p1, 8, Direction.RIGHT);
            var i = 0;

            while (true)
            {
                if (i > 8) i = 0;   
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow) snake.direction = Direction.LEFT;
                    if (key.Key == ConsoleKey.RightArrow) snake.direction = Direction.RIGHT;
                    if (key.Key == ConsoleKey.UpArrow) snake.direction = Direction.DOWN;
                    if (key.Key == ConsoleKey.DownArrow) snake.direction = Direction.UP;
                }
                Thread.Sleep(200);
                snake.Move(i);
                i++;
            }
            //snake.Drow();

            Console.ReadLine();
        }
    }
}
