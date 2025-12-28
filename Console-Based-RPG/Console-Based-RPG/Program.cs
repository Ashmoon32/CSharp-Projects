using System;
using System.Text.RegularExpressions;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Player
            string playerName;
            int playerHealth = 100;
            int playerEnergy = 100;
            bool isPlayerAlive = true;

            // For Normal Monster
            string monsterName = "Dragon";
            int monsterHealth = 50;
            bool isMonsterAlive = true;
            int monsterAttackDamage = 5;

            // For Elite Monster
            string eliteMonsterName = "Chaos Warlord";
            int eliteMonsterHealth = 200;
            int eliteMonsterAttackDamage = 20;
            int eliteMonsterUltimateDamage = 50;
            bool isEliteMonsterAlive = true;

            // For Final Monster Boss
            string bossMonsterName = "King of Immortality";
            int bossMonsterHealth = 500;
            int bossMonsterNormalPhysicalAttackDamage = 100;
            int bossMonsterMagicAttackDamage = 150;
            int bossMonsterUltimateAttackDamage = 300;
            bool isBossMonsterAlive = true;

            // For Player Choice
            string initialChoice;
            string PlayerChoice;


            // Game introduction and Player Input           
            try
            {
                Console.WriteLine("Welcome To the Adventure Legend!");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Start the Game {0}2. Exit", Environment.NewLine);
                Console.Write("Enter your choice: ");
                initialChoice = Console.ReadLine();
                int intInitialChoice = int.Parse(initialChoice);
                if (intInitialChoice == 1)
                {
                    bool isValid = false;
                    do
                    {
                        

                        Console.Write("Please enter your character name: ");
                        playerName = Console.ReadLine();

                        if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))
                        {
                            isValid = true;
                            Console.WriteLine($"Welcome Legend {playerName}, your journey has begun! ");

                        } else
                        {
                            Console.WriteLine("Invalid Character Name! Please use only letters(a to z, A to Z).");
                        }
                    } while (!(isValid));

                }
                else if (intInitialChoice == 2)
                {
                    Console.WriteLine("Bye.. See ya later!");
                } else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Invalid Choice.");
            } finally
            {
                Console.WriteLine("Program End.");
            }

            

        }





    }
}