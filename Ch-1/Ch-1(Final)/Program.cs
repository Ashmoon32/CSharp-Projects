using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Good Day!");

        Console.Write("John ");
        Console.WriteLine("Smith");

        Console.WriteLine("1");
        Console.WriteLine("101");
        Console.WriteLine("1001");

        DateTime Today = DateTime.Now;
        Console.WriteLine(Today);

        Console.WriteLine(Today.ToString(
            "dd-MM-yyyy"));

        
        Console.WriteLine("Tomorrow: " + Today.AddDays(1).ToString("dddd, dd/MM/yyyy, HH:mm:ss"));
        Console.WriteLine("Today: " + Today.ToString("dddd, dd/MM/yyyy, HH:mm:ss"));
        Console.WriteLine("Yesterday: " + Today.AddDays(-1).ToString("dddd, dd/MM/yyyy, HH:mm:ss"));


    }
}