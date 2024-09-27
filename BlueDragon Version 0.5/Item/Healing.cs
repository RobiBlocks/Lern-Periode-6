using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Item
{
    internal class Healing : Item
    {
        public Healing(string name, string description, int healingpower)
        {
            Name = name;
            Description = description;
            Power = healingpower;
        }
    }
}
