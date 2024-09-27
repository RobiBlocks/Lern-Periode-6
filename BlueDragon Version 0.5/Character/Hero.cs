using BlueDragon.Equipment;
using BlueDragon.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon.Character
{
    internal class Hero : Character
    {
        public Healing HealingSlot1 { get; set; }
        public Healing HealingSlot2 { get; set; }
        public Healing HealingSlot3 { get; set; }
        public Hero(int health, int speed, string name = "Dragon Warrior")
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
            Console.WriteLine("Welches Heilungitem möchtest du verwenden?\r\n");

            if (HealingSlot1 != null || HealingSlot2 != null || HealingSlot3 != null)
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
                            Health += HealingSlot1.Power;
                            HealingSlot1 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!");
                            break;
                        }
                    }
                    else if (useSlot == '2')
                    {
                        if (HealingSlot2 != null)
                        {
                            Health += HealingSlot2.Power;
                            HealingSlot2 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!\r\n");
                            break;
                        }
                    }
                    else if (useSlot == '3')
                    {
                        if (HealingSlot3 != null)
                        {
                            Health += HealingSlot3.Power;
                            HealingSlot3 = null;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du besitzt kein Item auf diesem Slot!\r\n");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Du hast keine Items, die du einsetzen kannst!\r\n");
            }
        }
    }
}