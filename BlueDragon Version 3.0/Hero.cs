using BlueDragon.Equipment;
using BlueDragon.Item;
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
        public Healing HealingSlot1 { get; set; } = new Healing("Leer", "Leer", 0);
        public Healing HealingSlot2 { get; set; } = new Healing("Leer", "Leer", 0);
        public Healing HealingSlot3 { get; set; } = new Healing("Leer", "Leer", 0);
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
        public void useHealingItem()
        {
            Console.WriteLine("Welches Heilungitem möchtest du verwenden?");
            Console.WriteLine("1) " + HealingSlot1.Name + "\r\n2) " + HealingSlot2.Name + "\r\n3) " + HealingSlot3.Name);
            ConsoleKeyInfo key = Console.ReadKey();
            char useSlot = key.KeyChar;
            while(true)
            {
                if (useSlot == '1')
                {
                    Health += HealingSlot1.Healingpower;
                    HealingSlot1 = null;
                }
                else if (useSlot == '2')
                {
                    Health += HealingSlot2.Healingpower;
                    HealingSlot2 = null;
                }
                else if (useSlot == '3')
                {
                    Health += HealingSlot3.Healingpower;
                    HealingSlot3 = null;
                }
                else
                {
                    Console.WriteLine("Du setzt doch kein Item ein!");
                }
            }

        }
    }
}