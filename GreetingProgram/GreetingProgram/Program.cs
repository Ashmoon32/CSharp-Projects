using System;

namespace GreetingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;

            if(currentTime.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            } else
            {
                Console.WriteLine("Good Day");
            }
        }
    }
}
