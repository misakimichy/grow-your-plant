using System;

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

        public Plant (string name, int height, int waterLevel, bool isAlive)
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            Happiness = 0;
            IsAlive = true;
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
            Happiness -= 2;
            WaterLevel += 3;
        }

        public void WeedGrow()
        {
            Happiness -= 2;
        }

        public void Rabbit()
        {
            IsAlive = false;
        }
    }
}