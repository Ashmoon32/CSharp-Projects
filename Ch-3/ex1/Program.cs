using System;

class Program
{
    static void Main(string[] args)
    {
       try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

        } catch (Exception ex) {
            Console.WriteLine("Error : " + ex.Message);
        } finally
        {
            Console.WriteLine("Program Finished.");
        }
    }
}