using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Equipment
{
    internal class Equipment
    {
        protected string Name { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }
        protected string Element { get; set; }
    }
}
