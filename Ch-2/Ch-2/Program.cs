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

        long l = 1234567891011121314L;
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


        DateTime now = DateTime.Now;
        Console.WriteLine("Current Year: " + now.Year);
        Console.WriteLine("Current Month: " + now.Month);
        Console.WriteLine("Current Day: " + now.Day);
        Console.WriteLine("Current Hour:Minute:Second :: " + now.Hour + ":" + now.Minute + ":" + now.Second);

        DateTime Now = DateTime.Now;
        Console.WriteLine(Now);

        DateTime Today = DateTime.Today;
        Console.WriteLine(Today);

        DateTime Future = Today.AddDays(7);
        Console.WriteLine("On that day, you will have presentation :" + Future.ToString("dd/MM/yyyy"));
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
        Console.WriteLine(now.ToString("dd:MM:yyyy"));

        int Num1 = 2;
        int NumMinus = -2;
        float Num2 = 3.2f;
        float Num3 = 3.6f;
        long Num4 = 555555L;
        double Num5 = 3.3333333D;
        Console.WriteLine(Math.Sqrt(Num5));
        Console.WriteLine(Math.Abs(NumMinus));
        Console.WriteLine(Math.Max(Num1, Num4));
        Console.WriteLine(Math.Min(NumMinus, Num5));
        Console.WriteLine(Math.Round(Num2));
        Console.WriteLine(Math.Round(Num3));
        Console.WriteLine(Math.Floor(Num2));
        Console.WriteLine(Math.Ceiling(Num2));

        




    }
}