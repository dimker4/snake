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
            HorizontalLine topLine = new HorizontalLine(0, 60, 0, '+');
            HorizontalLine botLine = new HorizontalLine(0, 60, 20, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 20, '+');
            VerticalLine RightLine = new VerticalLine(60, 0, 20, '+');

            topLine.Draw();
            botLine.Draw();
            leftLine.Drow();
            RightLine.Drow();

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Console.ReadLine();
        }
    }
}
