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
            int playerMana = 100;
            int playerPhysicalAttackDamage = 10;
            int playerMagicDamage = 20;
            int playerUltimateDamage = 40;
            int playerManaCostPerPhysicalAttack = 5;
            int playerManaCostPerMagicAttack = 10;
            int playerManaCostPerUlitmateAttack = 30;
            int playerManaCostPerDefend = 5;
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
            int bossSpeicalSpell = bossMonsterHealth += 100;
            bool isBossMonsterAlive = true;

            // For Player Choice
            string initialChoice;
            string PlayerChoice;

            // Others
            int turn = 0;


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

                        // Force user only to enter alphabetic characters
                        if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))
                        {
                            isValid = true;
                            Console.WriteLine($"Welcome Legend {playerName}, your journey has begun! ");
                            Console.WriteLine("========================================================");

                            // Start the actual game play here

                            // Dragon Monster Section - Start 

                            Console.WriteLine("Ohh {0}! You see the monster called {1}. What would you do?",playerName, monsterName);

                            while(isPlayerAlive && isMonsterAlive)
                            {
                                // We will make simple game logic, player turn is even number and monster is odd.
                                Console.WriteLine(" 1. Attack {0} 2. Defend {0} 3. Magic Attack {0} 4. Ultimate",Environment.NewLine);
                                Console.WriteLine("Enter your choice (default is 1): ");
                                if(turn % 2 == 0)
                                {
                                    
                                    PlayerChoice = Console.ReadLine();
                                    switch (PlayerChoice)
                                    {
                                        case "1":
                                            Console.WriteLine($"You attack the {monsterName} with physical attack!");
                                            monsterHealth -= playerPhysicalAttackDamage;
                                            playerMana -= playerManaCostPerPhysicalAttack;
                                            break;

                                        case "2":
                                            Console.WriteLine($"You defend from the {monsterName}'s attack! No monster damage is effected.");
                                            playerMana -= playerManaCostPerDefend;
                                            break;

                                        case "3":
                                            Console.WriteLine($"You attack the {monsterName} with magic attack!");
                                            monsterHealth -= playerMagicDamage;
                                            playerMana -= playerManaCostPerMagicAttack;
                                            break;

                                        case "4":
                                            Console.WriteLine($"You attack the {monsterName} with your ultimate attack!!");
                                            monsterHealth -= playerUltimateDamage;
                                            playerMana -= playerManaCostPerUlitmateAttack;
                                            break;

                                        default:
                                            Console.WriteLine($"You attack the {monsterName} with physical attack!");
                                            monsterHealth -= playerPhysicalAttackDamage;
                                            playerMana -= playerManaCostPerPhysicalAttack;
                                            break;
                                    }
                                    
                                    if(monsterHealth <= 0)
                                    {
                                        Console.WriteLine($"{monsterName} is died. You win.");
                                        isMonsterAlive = false;
                                    } else if(playerHealth <= 0)
                                    {
                                        Console.WriteLine($"You have been killed by {monsterName}. Game Over!");
                                        isPlayerAlive = false;
                                    } else
                                    {
                                        Console.WriteLine(" Player Health : {0} {3} Player Mana : {1} {3} Monster Health : {2}", playerHealth, playerMana, monsterHealth, Environment.NewLine);
                                    }
                                }
                            }
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