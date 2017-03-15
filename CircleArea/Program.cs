using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            const double pi = 3.14;

            do
            {
                Console.Write("Please enter a positive number for the radius: ");
                radius = double.Parse(Console.ReadLine());
            } while (radius < 0 || !double.TryParse(Convert.ToString(radius), out radius));

            area = pi * (radius * radius);

            Console.WriteLine("The area of a circle of radius {0} is: {1}", radius, area);
            Console.ReadLine();
        }
    }
}
