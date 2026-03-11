using System;
class Greeting
{
    static void Main(String[] args)
    {
        Console.WriteLine("Godendag!");
        Console.Write("GodenMorgen!");
        DateTime today = DateTime.Now;
        Console.WriteLine(today);
        double sqrt = Math.Sqrt(144);
        Console.WriteLine(sqrt);
        Console.WriteLine("Enter Your Age:");
        int age = Int32.Parse(Console.ReadLine());
        int NewAge = age + 11;
        Console.Write("after eleven year you will be ");
        Console.WriteLine(NewAge);
    
    }

}
