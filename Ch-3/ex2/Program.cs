using System;

class Program
{
    static void Main(string[] args)
    {
        int largest;
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                largest = num1;
            } else
            {
                largest = num3;
            }
        } else
        {
            if (num2 > num3)
            {
                largest = num2;
            } else
            {
                largest = num3;
            }
        }

        Console.WriteLine("Largest number is: " + largest);
    }
    

}