using BlueDragon.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Character
{
    internal class Enemie : Character
    {
        public Enemie(string name, int health, int speed, Weapon weapon)
        {
            Name = name;
            Health = health;
            Speed = speed;
            Weapon = weapon;
        }
        public void attack(Hero opponent, Weapon weapon)
        {
            opponent.Health -= weapon.Damage;
            weapon.Durability -= 1;
        }
    }
}
