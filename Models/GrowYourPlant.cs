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
        public int RandomNum;

        public Plant ()
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            Happiness = 0;
            IsAlive = true;
            RandomNum = 0;
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

        // Randomize Windstorm, WeedGrow, Rabiit events
        public void RandomizeEvent()
        {
            Random randomNum = new Random();
            RandomNum = randomNum.Next(0, 4);
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
            RandomNum = 0;
        }
    }
}