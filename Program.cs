
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            if (LineLength() == LineLength())
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");
            }
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
