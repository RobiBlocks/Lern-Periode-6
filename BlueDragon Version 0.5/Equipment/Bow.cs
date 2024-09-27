using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Equipment
{
    internal class Bow : Equipment
    {
        public Bow(string name, int damage, int durability, string element)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Element = element;
        }
    }
}
