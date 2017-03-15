using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Student adam = new Student("Adam Parker", 27, 3.5);
            Student john = new Student("John Shepard", 91, 4.0);

            Console.WriteLine(adam.ToString());
            Console.WriteLine(adam.GetGradeLevel());

            adam.AddGrade(3, 4);

            Console.WriteLine(adam.ToString());
            Console.WriteLine(adam.GetGradeLevel());

            Console.WriteLine(john.ToString());
            Console.WriteLine(john.GetGradeLevel());

            Console.WriteLine(adam.Equals(adam));
            Console.WriteLine(adam.Equals(john));

            Console.ReadLine();
        }
    }
}