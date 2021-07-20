using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Lines
    {
        int x1, y1, x2, y2;
        public Lines()
        {
            Console.WriteLine("Enter the coordinate X1");
            this.x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate Y1");
            this.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate X2");
            this.x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate Y2");
            this.y2 = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateLineLength()
        {
            return (int) Math.Sqrt(Convert.ToDouble(((this.x2 - this.x1) ^ 2) + ((this.y2 - this.y1) ^ 2)));
        }
    }
}
