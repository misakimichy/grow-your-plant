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
        private Random _randomNum;
        private List<Action> _trouble;

        public Plant ()
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            Happiness = 0;
            IsAlive = true;
            _randomNum = new Random();
            _trouble = new List<Action> () { Windstorm, WeedsGrow, Rabbit };

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

        public void Windstorm()
        {
            Console.WriteLine("\nA crazy rainstorm flooded the ground!\n");
            Happiness -= 2;
            WaterLevel += 3;
        }

        public void WeedsGrow()
        {
            Console.WriteLine($"\nWeeds are growing like crazy! You need to clean up for {Name}.\n");
            Happiness -= 2;
        }

        public void Rabbit()
        {
            Console.WriteLine($"\nOops, it looks like a rabbit ate {Name}... Seriously?\n");
            IsAlive = false;
        }

        // Randomize Windstorm, WeedsGrow, Rabiit events
        public void RandomizeEvent()
        {
            int randomNumber = _randomNum.Next(0, 3);
            _trouble[randomNumber]();
        }

        public void CheckAlive()
        {
            if(WaterLevel < 0 || WaterLevel > 10 || Happiness < 0)
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