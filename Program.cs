using System;
using System.Collections.Generic;
using GrowPlant.Models;

// Use Singleton to avoid static variables.
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
namespace GrowPlant
{
    class Program
    {
        public static void Main()
        {
            InitializeGame();
        }

        public static void InitializeGame()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("How do you want to take care of your plant?");
            Console.WriteLine("1: water | 2: feed | 3: give sunshine | 4. clean weeds");
            Console.WriteLine("I'm going to (1 - 4): ");
            HandleEvent();
        }

        public static void HandleEvent()
        {
            Plant plant = new Plant();
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    plant.Water();
                    break;
                case 2:
                    plant.Feed();
                    break;
                case 3:
                    plant.GiveSunshine();
                    break;
                case 4:
                    plant.CleanWeeds();
                    break;
                default:
                    Console.WriteLine("Please choose a number between 1 and 4.");
                    HandleEvent();
                    break;
            }
        }
    }
}