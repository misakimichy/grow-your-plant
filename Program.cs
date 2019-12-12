using System;
using GrowPlant.Models;

// Use Singleton to avoid static variables.
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
namespace GrowPlant
{
    class Program
    {
        private static Plant plant = new Plant();
        private static string userInput = "";
        public static void Main()
        {
            Console.WriteLine("Let's grow your plant!");
            Console.WriteLine("Make your plant taller and make it happier! \nOnce the water level hits more than 10 or less than 0, you plant is going to die.");
            Console.WriteLine("\nLet's name your plant: ");
            userInput = Console.ReadLine();
            plant.Name = userInput;
            RenderOption();
        }

        public static void RenderOption()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"How do you want to take care of {plant.Name}? \n1: water | 2: feed | 3: give sunshine | 4. clean weeds");
            Console.WriteLine("\nI'm going to... (option: 1 - 4).\n");
            HandleEvent();
        }

        public static void HandleEvent()
        {
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    plant.Water();
                    break;
                case "2":
                    plant.Feed();
                    break;
                case "3":
                    plant.GiveSunshine();
                    break;
                case "4":
                    plant.CleanWeeds();
                    break;
                default:
                    Console.WriteLine("Please choose a number between 1 and 4.");
                    HandleEvent();
                    break;
            }
            plant.RandomizeEvent();
            CheckStatus();
        }

        public static void CheckStatus()
        {
            plant.CheckAlive();
            if(plant.IsAlive)
            {
                UpdateState();
                RenderOption();
            }
            else
            {
                Console.WriteLine("GAME OVER!!");
                Console.WriteLine($"Sorry, {plant.Name} died...");
                Console.WriteLine("Play again? (Y/N)");
                string userInput = Console.ReadLine().ToUpper();
                if(userInput == "Y")
                {
                    plant.Reset();
                    Main();
                }
                else
                {
                    Console.WriteLine("See you again!");
                }
            }
        }
        public static void UpdateState()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"{plant.Name}'s current status: \nHeight: {plant.Height} \nWater level: {plant.WaterLevel} \nHappiness level: {plant.Happiness}.\n");
        }
    }
}