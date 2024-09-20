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
        public Healing HealingSlot1 { get; set; }
        public Healing HealingSlot2 { get; set; }
        public Healing HealingSlot3 { get; set; }
        public Hero (int health, int speed, string name = "Dragon Warrior")
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

            if(HealingSlot1 != null || HealingSlot2 != null || HealingSlot3 != null)
            {
                Console.WriteLine($"1) {(HealingSlot1 != null ? HealingSlot1.Name : "---")}  ");
                Console.WriteLine($"2) {(HealingSlot2 != null ? HealingSlot2.Name : "---")}  ");
                Console.WriteLine($"3) {(HealingSlot3 != null ? HealingSlot3.Name : "---")}  ");
                ConsoleKeyInfo key = Console.ReadKey(true);
                char useSlot = key.KeyChar;
                while (true)
                {
                    if (useSlot == '1')
                    {
                        if (HealingSlot1 != null)
                        {
                            Health += HealingSlot1.Healingpower;
                            HealingSlot1 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!");
                            break;
                        }
                    }
                    else if(useSlot == '2')
                    {
                        if (HealingSlot2 != null)
                        {
                            Health += HealingSlot2.Healingpower;
                            HealingSlot2 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!");
                            break;
                        }
                    }
                    else if (useSlot == '3')
                    {
                        if (HealingSlot3 != null)
                        {
                            Health += HealingSlot3.Healingpower;
                            HealingSlot3 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Du hast keine Items, die du einsetzen kannst!");
            }
        }
    }
}