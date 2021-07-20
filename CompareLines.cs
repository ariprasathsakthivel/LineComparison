using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class CompareLines
    {
        public int firstLine, secondLine;
        public CompareLines()
        {
            Lines line1 = new Lines();
            this.firstLine = line1.CalculateLineLength();
            Lines line2 = new Lines();
            this.secondLine = line2.CalculateLineLength();
        }
        public void Comparing()
        {
            if (this.firstLine.CompareTo(this.secondLine) == 0) 
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (this.firstLine.CompareTo(this.secondLine) > 0) 
            {
                Console.WriteLine("First line is greater than second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than first line");
            }
            Console.WriteLine("Length of first line {0}", this.firstLine);
            Console.WriteLine("Length of second line {0}", this.secondLine);
        }
    }
}