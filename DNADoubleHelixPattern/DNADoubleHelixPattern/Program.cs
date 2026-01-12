using System;

class CenteredPi
{
    static void Main()
    {
        // Dimensions of the symbol
        int height = 15;
        int width = 25;

        // Get terminal width to calculate the starting left position for centering
        int centerOffset = (Console.WindowWidth / 2) - (width / 2);

        for (int i = 0; i < height; i++)
        {
            // Print the empty spaces to push the symbol to the center
            Console.Write(new string(' ', Math.Max(0, centerOffset)));

            for (int j = 0; j < width; j++)
            {
                // 1. The Top Bar (with a slight curve/serif on the far left)
                bool isTopBar = (i == 0 && j > 0) || (i == 1 && j > 1 && j < width - 1);

                // 2. The Left Leg (Straight)
                bool isLeftLeg = (j == 6 || j == 7) && i > 0;

                // 3. The Right Leg (Curves at the very bottom)
                bool isRightLeg = (j == 17 || j == 18) && i > 0 && i < height - 2;

                // 4. The Bottom Curve (The "Foot" of Pi)
                bool isFoot = (i == height - 2 && j > 17 && j < 21) ||
                              (i == height - 1 && j > 19 && j < 23);

                // 5. The Left Serif (The little dip on the top left)
                bool isSerif = (i == 1 && j == 0) || (i == 2 && j == 0);

                if (isTopBar || isLeftLeg || isRightLeg || isFoot || isSerif)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n" + new string(' ', centerOffset + 5) + "π = 3.14159");
        Console.ReadKey();
    }
}