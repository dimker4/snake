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

            topLine.Draw();
            botLine.Draw();
            leftLine.Draw();
            RightLine.Draw();


            Point p1 = new Point(1, 4, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            Food f = new Food(60, 20, '@');
            Point food = f.CreateFood();
            food.Draw();

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
                if (snake.Eat(food))
                {
                    food = f.CreateFood();
                    food.Draw();
                }
                i++;
            }
        }
    }
}
