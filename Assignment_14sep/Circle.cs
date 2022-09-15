using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14sep
{
    public class Circle
    {
        double radius;
        double pi = 3.14;
        double area;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void CalculateArea()
        {
             area = pi * radius * radius;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);

        }
        
    }
}
