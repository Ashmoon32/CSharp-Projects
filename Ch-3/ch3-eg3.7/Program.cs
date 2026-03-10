using System;

class Program
{
    static void Main(string[] args)
    {
        string isUserDone = "";
        do
        {
            Console.WriteLine("In do/while loop:");
            Console.Write("Are you done? [yes/no]: ");
            isUserDone = Console.ReadLine();
        } while (isUserDone.ToLower() != "yes");
    }
}