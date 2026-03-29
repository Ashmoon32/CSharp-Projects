using System;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {

        //Student s1 = new Student();
        //s1.Name = "Ashmoon";
        //s1.Age = 21;

        //Console.WriteLine("Name: " + s1.Name);
        //Console.WriteLine("Age: " + s1.Age);

        //string StudentName = "Ashmoon";
        //int[] Marks = { 90, 99, 98 };

        //Console.WriteLine("Student Name: " + StudentName);
        //Console.WriteLine("Marks: " + string.Join(",", Marks));

        //string bookTitle = "Programming in C#";
        //string[] authors = { "Mya Soe", "Soe Moe" };

        //Console.WriteLine("Book Title: " + bookTitle);
        //Console.WriteLine("Authors: " + string.Join(",", authors));

        //Student[] students = new Student[2];

        //students[0] = new Student();
        //students[0].Name = "Ash";
        //students[0].Age = 20;

        //students[1] = new Student();
        //students[1].Name = "Moon";
        //students[1].Age = 21;

        //foreach( Student s in students)
        //{
        //    Console.WriteLine("Name : " + s.Name + ", Age : " + s.Age);
        //}

        int? age = null;
        bool? isGraduated = null;

        age = 21;

        Console.WriteLine("Age: " + (age.HasValue ? age.ToString() : "No value"));
        Console.WriteLine("Graduated: " + (isGraduated.HasValue ? isGraduated.ToString() : "No value"));
    }
}