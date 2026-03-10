using System;

namespace ClassObjectExample
{
    class Student
    {
        public int studentId;
        public string studentName;

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.studentId = 1;
            s1.studentName = "Ashmoon";

            s1.DisplayDetails();

            Console.ReadKey();
        }
    }
}