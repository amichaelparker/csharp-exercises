using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student adam = new Student("Adam", 1364481);
            //adam.Name = "Adam Parker";
            //adam.Id = 1364481;
            adam.Credits = 60;
            adam.GPA = 4.0;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", adam.Name, adam.Id, adam.GPA, adam.Credits);
            Console.ReadLine();
        }
    }

    public class Student
    {
        public Student(string name, int studentId)
        {
            this.name = name;
            this.studentId = studentId;
        }

        private string name;
        private int studentId;
        private int numberOfCredits;
        private double gpa;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Id
        {
            get { return studentId; }
            private set { studentId = value; }
        }

        public int Credits
        {
            get { return numberOfCredits; }
            set { numberOfCredits = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }
}