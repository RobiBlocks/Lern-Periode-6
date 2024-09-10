using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Item
{
    internal class Healing
    {
        public string Name { get; set;  }
        public string Description { get; set; }
        public int Healingpower { get; set; }
        public Healing(string name, string description, int healingpower)
        {
            Name = name;
            Description = description;
            Healingpower = healingpower;
        }
    }
}
