using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 45;
        Console.WriteLine(i);
        float f = 3.14f;
        Console.WriteLine(f);
        char c = 'A';
        Console.WriteLine(c);
        bool isTrue = true;
        Console.WriteLine(isTrue);


        Console.WriteLine();


        string stu_name = "Ashmoon";
        int stu_age = 21;
        char grade = 'S';
        Console.WriteLine("Name : " + stu_name);
        Console.WriteLine("Age : " + stu_age);
        Console.WriteLine("Grade : " + grade);

        Console.WriteLine();

        long l = 123345L;
        byte b = 123;
        Console.WriteLine("Long: " + l);
        Console.WriteLine("Byte: " + b);

        Console.WriteLine();

        int A = 10, B = 3;
        Console.WriteLine("Addition: " + (A + B));
        Console.WriteLine("Subtraction: " + (A - B));
        Console.WriteLine("Multiplication: " + (A * B));
        Console.WriteLine("Division: " + (A / B));
        Console.WriteLine("Remainder: " + (A % B));


    }
}