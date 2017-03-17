using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        public string Name { get; set; }
        private static Random randomId = new Random();
        private List<int> usedId = new List<int>();
        private int studentId;
        public int StudentId { get { return studentId; } }
        public int Credits { get; set; }
        public double GPA { get; set; }

        public Student(string name,
            int numberOfCredits, 
            double gpa)
        {
            Name = name;
            Credits = numberOfCredits;
            GPA = gpa;
            do
            {
                studentId = randomId.Next(1000000, 1999999);
            } while (usedId.Contains(studentId));
            usedId.Add(studentId);
        }

        public Student(string name)
            : this(name, 0, 0) { }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: numberOfCredits, gpa
            double currentQualityScore = GPA * Credits;
            double updatedQualityScore = currentQualityScore + (courseCredits * grade);
            Credits += courseCredits;
            GPA = updatedQualityScore / Credits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on numberOfCredits
            if (Credits < 30)
            {
                return "Freshman\n";
            }
            if (Credits >= 30 && Credits < 60)
            {
                return "Sophomore\n";
            }
            if (Credits >= 60 && Credits < 90)
            {
                return "Junior\n";
            }
            return "Senior\n";
        }

        public override String ToString()
        {
            return Name + " ( Student ID: " + StudentId + ", Credits: " + Credits + ", GPA: " + GPA + ")";
        }

        public override bool Equals(Object o)
        {
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }
    }
}
