using System;
using System.Runtime.Remoting.Services;

namespace NameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your name is : {0} {1}",firstName,lastName);

            Console.ReadKey();
        }
    }
}
