using System;
using System.Collections.Generic;

namespace GrowPlant.Models
{
    public class Plant
    {
        // Getting idea from Tamagotchi
        public string Name { get; set; }
        public int Height { get; set;}
        public int WaterLevel { get; set; }
        public int Happiness { get; set; }
        public bool IsAlive { get; set; }
        public Random RandomNum { get; set; }
        public List<Action> Trouble { get; set; }

        public Plant ()
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            Happiness = 0;
            IsAlive = true;
            RandomNum = new Random();
            Trouble = new List<Action> () { NoSun, Windstorm, WeedsGrow, EatPlant };

        }

        public void Water()
        {
            Height += 1;
            WaterLevel += 2;
        }

        public void Feed()
        {
            Happiness += 1;
        }

        public void GiveSunshine()
        {
            Height += 2;
            WaterLevel -= 2;
            Happiness += 2;
        }

        public void CleanWeeds()
        {
            WaterLevel -= 1;
            Happiness += 2;
        }

        public void NoSun()
        {
            Console.WriteLine($"\nIt's been cloudy. {Name} seems sad.\n");
            Happiness -= 1;
            WaterLevel += 1;
        }

        public void Windstorm()
        {
            Console.WriteLine("\nA crazy rainstorm flooded the ground!\n");
            Happiness -= 2;
            WaterLevel += 3;
        }

        public void WeedsGrow()
        {
            Console.WriteLine($"\nWeeds are growing like crazy! You need to clean them up for {Name}.\n");
            Happiness -= 2;
        }

        public void EatPlant()
        {
            Console.WriteLine($"\nOops, it looks like a rabbit ate {Name}... Seriously?\n");
            IsAlive = false;
        }

        // Randomize NoSun, Windstorm, WeedsGrow, EatPlant events
        public void RandomizeEvent()
        {
            int randomNumber = RandomNum.Next(0, 4);
            Trouble[randomNumber]();
        }

        public void CheckAlive()
        {
            if (WaterLevel < 0 || Happiness < 0 || WaterLevel > 10)
            {
                IsAlive = false;
            }
        }
        public void Reset()
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            Happiness = 0;
            IsAlive = true;
        }
    }
}