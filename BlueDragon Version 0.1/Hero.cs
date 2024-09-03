using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Health { get; set;  }
        public int Speed { get; }
        public string Sword { get; set; }
        public Hero (int health, int speed, string name = "Dragon Worrior")
        {
            Name = name;
            Health = health;
            Speed = speed;
        }
    }
}