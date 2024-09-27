using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Equipment
{
    internal class Weapon : Equipment
    {
        public Weapon(string name, int damage, int durability, string element)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Element = element;
        }
    }
}
