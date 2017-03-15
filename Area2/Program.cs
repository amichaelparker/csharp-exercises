using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string radius;
            double radiusValue;
            double area;
            const double pi = 3.14;
            bool isParsed;
            int num;

            do
            {
                Console.Write("Please enter a positive number for the radius: ");
                radius = Console.ReadLine();
                
                // isParsed bool created for while check based on Tom's suggestion
                isParsed = double.TryParse(radius, out radiusValue); //if no value for radiusValue, TryParse automatically assigns 0 to radiusValue
            } while (radiusValue < 0 || !isParsed);

            area = pi * (radiusValue * radiusValue);

            Console.WriteLine("The area of a circle of radius {0} is: {1}", radius, area);
            Console.ReadLine();
        }
    }
}
