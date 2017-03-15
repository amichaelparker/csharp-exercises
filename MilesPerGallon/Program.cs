using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("How many miles have you driven?");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons of fuel did your vehicle consume?");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles / gallons;
            Console.WriteLine("Your MPG is: {0}", mpg);
            Console.ReadLine();            
        }
    }
}
