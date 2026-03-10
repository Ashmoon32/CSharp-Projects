using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Square of numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            int square = i * i;
            Console.WriteLine("Number: " + i + ",Square: " + square);
        }
    }
}
