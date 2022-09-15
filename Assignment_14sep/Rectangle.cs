using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14sep
{
    public class Rectangle
    {
        double length;
        double breadth;
        double perimeter;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public void CalculatePerimeter()
        {
            perimeter = 2 * (length + breadth);
        }

        public void Print()
        {
            Console.WriteLine("Perimeter -> " + perimeter);
        }

    }
}
