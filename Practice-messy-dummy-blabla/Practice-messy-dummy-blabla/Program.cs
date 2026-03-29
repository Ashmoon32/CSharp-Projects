using System;
using System.IO;
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

        //int? age = null;
        //bool? isGraduated = null;

        //age = 21;

        //Console.WriteLine("Age: " + (age.HasValue ? age.ToString() : "No value"));
        //Console.WriteLine("Graduated: " + (isGraduated.HasValue ? isGraduated.ToString() : "No value"));

        //bool a = true, b = false;
        //Console.WriteLine(" a AND b : " + (a && b));
        //Console.WriteLine(" a OR b : " + (a || b));
        //Console.WriteLine(" NOT a : " + !a);

        //Console.Write("Enter radius: ");
        //double radius = double.Parse(Console.ReadLine());

        //double Area = Math.PI * radius * radius;
        //double Perimeter = 2 * (Math.PI * radius);

        //Console.WriteLine("Area: " + Area);
        //Console.WriteLine("Perimeter: " + Perimeter);

        // int count = 0;
        //int sum = 0;

        //while (count < 5)
        //{
        //    Console.Write("Enter integer " + (count + 1) + ": ");
        //    string input = Console.ReadLine();

        //    if (int.TryParse(input, out int number))
        //    {
        //        sum += number;
        //        count++;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid number! Please enter a valid integer.");
        //    }
        //}

        //Console.WriteLine("Sum = " + sum);

        //int sum = 0;
        //Console.Write("Enter the integer number n: ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Enter the number :" + (i + 1) + ": ");
        //    int num = int.Parse(Console.ReadLine());
        //    sum += num;
        //}
        //Console.WriteLine("Sum = " + sum);

        string path = "E:\\sample.txt";

        StreamWriter write = new StreamWriter(path, true);
        write.WriteLine("Welcome to C# file handling!");
        write.WriteLine("This file is created using StreamWriter.");
        write.WriteLine("I love you so much KSP");
        write.Close();

        Console.WriteLine("File created and data written successfully!");

        Console.WriteLine(new String('-', 40));

        StreamReader read = new StreamReader(path);
        string content = read.ReadToEnd();
        read.Close();

        Console.WriteLine("Content of the file:");
        Console.WriteLine(content);
    }
}