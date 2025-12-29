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
            int playerManaCostRunOneTime = 3;
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
                              
                               for(int i = 0; i < 100; i++)
                                {
                                    
                                    if (i % 2 == 0)
                                    {
                                        // We will make simple game logic, player turn is even number and monster is odd.
                                        Console.WriteLine(" 1. Attack {0} 2. Magic Attack {0} 3. Ultimate", Environment.NewLine);
                                        Console.Write("Enter your choice (default is 1): ");
                                        // If turn is even number, player turns to attack

                                        PlayerChoice = Console.ReadLine();
                                        switch (PlayerChoice)
                                        {
                                            case "1":
                                                Console.WriteLine($"You attack the {monsterName} with physical attack!");
                                                monsterHealth -= playerPhysicalAttackDamage;
                                                playerMana -= playerManaCostPerPhysicalAttack;
                                                break;


                                            case "2":
                                                Console.WriteLine($"You attack the {monsterName} with magic attack!");
                                                monsterHealth -= playerMagicDamage;
                                                playerMana -= playerManaCostPerMagicAttack;
                                                break;

                                            case "3":
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

                                        if (monsterHealth <= 0)
                                        {
                                            Console.WriteLine($"{monsterName} is died. You win.");
                                            isMonsterAlive = false;
                                        }
                                        else if (playerHealth <= 0)
                                        {
                                            Console.WriteLine($"You have been killed by {monsterName}. Game Over!");
                                            isPlayerAlive = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player Health : {0} {3} Player Mana : {1} {3} Monster Health : {2}", playerHealth, playerMana, monsterHealth, Environment.NewLine);
                                        }

                                    }
                                    else if (i % 2 == 1) // If turn is odd , monster turns to attack
                                    {

                                        Console.WriteLine($"{monsterName} turns to attack. Monster is attacking you! What would you do?");
                                        Console.WriteLine("You can only defend the half of the damage from magic attack and can run only from normal physical attack!");
                                        Console.WriteLine($" 1. Defend {Environment.NewLine} 2. Run{Environment.NewLine}");
                                        Console.Write("Enter your action: ");
                                        PlayerChoice = Console.ReadLine();
                                        switch (PlayerChoice)
                                        {
                                            case "1":
                                                if (playerMana < 5)
                                                {
                                                    Console.WriteLine("Not enough Mana to perform this action!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You defend the monster attack! No normal monster physical attack is effected.");
                                                    playerMana -= playerManaCostPerDefend;
                                                }
                                                break;

                                            case "2":
                                                if (playerMana < 3)
                                                {
                                                    Console.WriteLine("Not enough Mana to perform this action!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You run from the monster attack! No normal monster physical attack is effected.");
                                                    playerMana -= playerManaCostRunOneTime;
                                                }
                                                break;

                                            default:
                                                if (playerMana < 5)
                                                {
                                                    Console.WriteLine("Not enough Mana to perform this action!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You defend the monster attack! No normal monster physical attack is effected.");
                                                    playerMana -= playerManaCostPerDefend;
                                                }
                                                break;
                                        }

                                        if (monsterHealth <= 0)
                                        {
                                            Console.WriteLine($"{monsterName} is died. You win.");
                                            isMonsterAlive = false;
                                        }
                                        else if (playerHealth <= 0)
                                        {
                                            Console.WriteLine($"You have been killed by {monsterName}. Game Over!");
                                            isPlayerAlive = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player Health : {0} {3} Player Mana : {1} {3} Monster Health : {2}", playerHealth, playerMana, monsterHealth, Environment.NewLine);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Unexpected Error Occurred!");
                                    }

                                    if (monsterHealth <= 0 || isMonsterAlive == false || playerHealth <= 0 || isPlayerAlive == false)
                                    {
                                        i = 100;
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