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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(5, 7, '@');
            p2.Draw();

            HorizontalLine topLine = new HorizontalLine(0, 80, 0, '-');
            HorizontalLine botLine = new HorizontalLine(0, 80, 20, '-');

            topLine.Draw();
            botLine.Draw();

            Console.ReadLine();
        }
    }
}
