using System;

namespace GrowPlant.Models
{
    class Plant
    {
        public string Name { get; set; }
        public int Height { get; set;}
        public int WaterLevel { get; set; }
        public bool IsAlive { get; set; }

        public Plant (string name, int height, int waterLevel, bool isAlive)
        {
            Name = name;
            Height = height;
            WaterLevel = waterLevel;
            IsAlive = isAlive;
        }
    }
}