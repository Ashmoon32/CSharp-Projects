using System;

class HourglassPattern
{
    static void Main()
    {
        int height = 15; // The total height of the hourglass
        Random random = new Random();

        for (int i = 0; i < height; i++)
        {
            // Calculate the indentation (spacing) for the hourglass shape
            int spaces = i < height / 2 ? i : height - i - 1;
            int width = height - 2 * spaces;

            // Print leading spaces
            for (int s = 0; s < spaces; s++) Console.Write(" ");

            // Print the sand logic
            for (int j = 0; j < width; j++)
            {
                if (i < height / 2)
                {
                    // TOP HALF: Randomly print '*' to look like falling/thinning sand
                    // 40% chance to print a grain
                    if (random.Next(0, 10) < 4) Console.Write("*");
                    else Console.Write(" ");
                }
                else
                {
                    // BOTTOM HALF: Print solid '*' to look like a pile of sand
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}