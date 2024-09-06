using BlueDragon.Equipment;
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
        public Sword Sword { get; set; }
        public Bow Bow { get; set; }
        public Hero (int health, int speed, string name = "Dragon Worrior")
        {
            Name = name;
            Health = health;
            Speed = speed;
        }
        public void attackSword(Enemie opponent, Sword sword)
        {
            opponent.Health -= sword.Damage;
            sword.Durability -= 1;
        }
        public void attackBow(Enemie opponent, Bow bow)
        {
            opponent.Health -= bow.Damage;
            bow.Durability -= 1;
        }
    }
}