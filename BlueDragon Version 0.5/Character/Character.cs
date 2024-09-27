using BlueDragon.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Character
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public Weapon Weapon { get; set; }
        public Sword Sword { get; set; }
        public Bow Bow { get; set; }
    }
}
