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

        Student s1 = new Student();
        s1.Name = "Ashmoon";
        s1.Age = 21;

        Console.WriteLine("Name: " + s1.Name);
        Console.WriteLine("Age: " + s1.Age);
    }
}