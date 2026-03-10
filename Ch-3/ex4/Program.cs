using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the total purchase amount(KS): ");
        double amount = double.Parse(Console.ReadLine());
        double discount;

        if(amount >= 5000)
        {
            discount = amount * 0.20;
        } else if (amount >= 3000 && amount < 5000)
        {
            discount = amount * 0.10;
        } else
        {
            discount = 0;
        }

        double finalAmount = amount - discount;
        Console.WriteLine("Discount: " + discount + "KS");
        Console.WriteLine("Final amount to pay: " + finalAmount + "KS");
    }
}
