using System;

namespace MultilevelInheritance
{
    class Person
    {
        public string Name;
        public void ShowName()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    class Student : Person
    {
        public string StudentId;

        public void ShowStudentId()
        {
            Console.WriteLine("Student Id: " + StudentId);
        }
    }

    class Graduate : Student
    {
        public string Degree;

        public void ShowDegree()
        {
            Console.WriteLine("Degree: " + Degree);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graduate g1 = new Graduate();

            g1.Name = "Ashmoon";
            g1.StudentId = "3GIT-1";
            g1.Degree = "A.G.T.I Information Technology";

            g1.ShowName();
            g1.ShowStudentId();
            g1.ShowDegree();
        }
    }
}