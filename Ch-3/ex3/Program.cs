using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your percentage: ");
        int percentage = Convert.ToInt32(Console.ReadLine());

        if (percentage >= 90)
        {
            Console.WriteLine("Excellent!");
        } else if (percentage >= 75)
        {
            Console.WriteLine("Good!");
        } else if (percentage >= 50)
        {
            Console.WriteLine("Average!");
        } else
        {
            Console.WriteLine("Poor!");
        }
    }
}
