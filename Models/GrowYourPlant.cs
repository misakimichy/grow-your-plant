using System;

namespace GrowPlant.Models
{
    public class Plant
    {
        public string Name { get; set; }
        public int Height { get; set;}
        public int WaterLevel { get; set; }
        public int AttentionLevel { get; set; }
        public bool IsAlive { get; set; }

        public Plant (string name, int height, int waterLevel, bool isAlive)
        {
            Name = "";
            Height = 0;
            WaterLevel = 3;
            AttentionLevel = 0;
            IsAlive = true;
        }

        public void Water()
        {
            Height += 1;
            WaterLevel += 2;
        }

        public void Feed()
        {
            AttentionLevel += 1;
        }

        public void GiveSunshine()
        {
            Height += 1;
            WaterLevel -= 1;
            AttentionLevel += 2;
        }
    }
}