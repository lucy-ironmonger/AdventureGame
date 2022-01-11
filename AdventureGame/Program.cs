/*
 * Adventure Game, by Lucy Ironmonger - 2022
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace AdventureGame
{
    internal class Program
    {

        public static class Game
            {
                // character name 
                public static string CharacterName = "Max Power";

                // print out game title and overview
                public static void startGame()
                {
                    Console.WriteLine("Adventure Game!");
                    Console.WriteLine("Welcome, thanks for dropping by.");
                    nameCharacter();
                }

                // ask player for a name, and save it
                public static void nameCharacter()
                {
                    Console.WriteLine("Enter a name for your character.");
                    CharacterName = Console.ReadLine();
                    Console.WriteLine($"Alright! Your character is called {CharacterName}...");
                }
            }

        class Item
        {

        }

        static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight-20;
            Console.Title = "Adventure Game: Welcome";
            Game.startGame();
            Game.nameCharacter();
            
        }
    }
}
