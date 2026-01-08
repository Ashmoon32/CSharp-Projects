using System;
class Program
{
    static void Main(string[] args)
    {
        var num = 8;
        for (var i = -num; i <= num; i++)
        {
            var k = i;
            if (k < 0)
            {
                k = k * -1;
            }
            for (var j = 0; j <= num; ++j)
            {
                if (j < k)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}