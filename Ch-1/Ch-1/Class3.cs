using System;

namespace Ch_1
{
    public class Class3
    {
        public static void Run()
        {
            Console.Write("Enter Your Age: ");
            int age = Int32.Parse(Console.ReadLine());
            int newAge = age + 10;
            Console.WriteLine("Your age in 10 years : " + newAge);
        }
    }
}