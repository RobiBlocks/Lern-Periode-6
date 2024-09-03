using BlueDragon.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon
{
    internal class Enemie
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Speed { get; }
        public Enemie(string name, int health, int speed)
        {
            Name = name;
            Health = health;
            Speed = speed;
        }
        
        public void attack(Hero opponent, Sword weapon)
        {
            opponent.Health -= weapon.Damage;
            weapon.Durability -= 1;
        }
    }
}
