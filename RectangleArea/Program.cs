using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;

            Console.WriteLine("Input the length of the rectangle:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the width of the rectangle:");
            width = double.Parse(Console.ReadLine());

            area = length * width;
            Console.WriteLine("The area of the rectangle is {0}.", area);
            Console.ReadLine();

        }
    }
}
