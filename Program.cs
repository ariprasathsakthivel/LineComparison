
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine, secondLine;
            firstLine = LineLength();
            secondLine = LineLength();
            if (firstLine == secondLine)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (firstLine > secondLine)
            {
                Console.WriteLine("First line is greater than second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than first line");
            }
            Console.WriteLine("Length of first line {0}", firstLine);
            Console.WriteLine("Length of second line {0}", secondLine);
        }

        private static int LineLength()
        {
            int x1, y1, x2, y2, lengthOfLine;
            Console.WriteLine("Enter the coordinate X1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate Y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate X2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate Y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            lengthOfLine = (int)Math.Sqrt(Convert.ToDouble((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            return lengthOfLine;
        }
    }
}
