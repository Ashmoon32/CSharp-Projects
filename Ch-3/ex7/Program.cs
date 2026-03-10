using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 2;
        int sum = 0;
        while (i <= 20)
        {
            sum += i;
            i += 2;
        }
        Console.WriteLine("The sum of even numbers from 1 to 20: " + sum);
    }
}
