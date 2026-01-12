//using System;

//class CenteredPi
//{
//    static void Main()
//    {
//        // Dimensions of the symbol
//        int height = 15;
//        int width = 25;

//        // Get terminal width to calculate the starting left position for centering
//        int centerOffset = (Console.WindowWidth / 2) - (width / 2);

//        for (int i = 0; i < height; i++)
//        {
//            // Print the empty spaces to push the symbol to the center
//            Console.Write(new string(' ', Math.Max(0, centerOffset)));

//            for (int j = 0; j < width; j++)
//            {
//                // 1. The Top Bar (with a slight curve/serif on the far left)
//                bool isTopBar = (i == 0 && j > 0) || (i == 1 && j > 1 && j < width - 1);

//                // 2. The Left Leg (Straight)
//                bool isLeftLeg = (j == 6 || j == 7) && i > 0;

//                // 3. The Right Leg (Curves at the very bottom)
//                bool isRightLeg = (j == 17 || j == 18) && i > 0 && i < height - 2;

//                // 4. The Bottom Curve (The "Foot" of Pi)
//                bool isFoot = (i == height - 2 && j > 17 && j < 21) ||
//                              (i == height - 1 && j > 19 && j < 23);

//                // 5. The Left Serif (The little dip on the top left)
//                bool isSerif = (i == 1 && j == 0) || (i == 2 && j == 0);

//                if (isTopBar || isLeftLeg || isRightLeg || isFoot || isSerif)
//                {
//                    Console.Write("*");
//                }
//                else
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine("\n" + new string(' ', centerOffset + 5) + "π = 3.14159");
//        Console.ReadKey();
//    }
//}


using System;

class PiPattern
{
    static void Main()
    {
        int height = 12; // Overall height of the symbol
        int width = 20;  // Overall width of the top bar

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                // 1. The Top Bar (First two rows)
                if (i < 2)
                {
                    Console.Write("*");
                }
                // 2. The Left Leg (Straight down)
                else if (j == 4 || j == 5)
                {
                    Console.Write("*");
                }
                // 3. The Right Leg (Straight, then curves at the bottom)
                else if (i < height - 2 && (j == 14 || j == 15))
                {
                    Console.Write("*");
                }
                // 4. The Hook/Curve of the right leg
                else if (i >= height - 2 && j >= 15 && j <= 18)
                {
                    // This creates the little "flick" at the bottom right of Pi
                    if (i == height - 2 && j == 16) Console.Write("*");
                    else if (i == height - 1 && j > 15) Console.Write("*");
                    else Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}