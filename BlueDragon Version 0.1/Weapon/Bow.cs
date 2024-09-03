using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Weapon
{
    internal class Bow
    {
        public string Name { get; }
        public int Damage { get; }
        public int Durability { get; set; }
        public string Element { get; }

        public Bow(string name, int damage, int durability, string element)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Element = element;
        }
    }
}
