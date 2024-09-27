using BlueDragon.Character;
using BlueDragon.Equipment;
using BlueDragon.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Held
            Hero character = new Hero(100, 20);

            //Held Waffen
            Sword fireSword = new Sword("Feuerschwert", 10, 20, "Feuer");
            Sword iceSword = new Sword("Eisschwert", 6, 40, "Eis");
            Sword electricSword = new Sword("Elektroschwert", 8, 30, "Elektro");

            Bow poisonBow = new Bow("Giftbogen", 3, 25, "Gift");

            //Heilungsitems
            Healing healingPotion1 = new Healing("Heilungstrank I", "Wenn du diesen Trank einsetzt, regenerierst du 20 Lebenspunkte.", 20);
            Healing healingPotion2 = new Healing("Heilungstrank II", "Wenn du diesen Trank einsetzt, regenerierst du 40 Lebenspunkte.", 40);

            Start(character, fireSword, iceSword, electricSword, poisonBow);

            //Gegner Waffen
            Weapon slingshot = new Weapon("Steinschleuder", 5, 10, "Stein");
            Weapon waterCannon = new Weapon("Wasserkanone", 10, 12, "Wasser");
            Weapon punch = new Weapon("Faustschlag", 15, 8, "Mensch");

            //Gegner World 1
            Enemie goblin = new Enemie("Greg", 20, 30, slingshot);
            Enemie sushi = new Enemie("Reis", 10, 40, slingshot);
            Enemie dragon = new Enemie("Blue Dragon", 300, 10, slingshot);

            //Gegner World 2
            Enemie crab = new Enemie("Clap", 25, 15, waterCannon);
            Enemie shark = new Enemie("Sharki", 30, 30, waterCannon);

            //Gegner World 3
            Enemie monkey = new Enemie("Louie", 30, 25, punch);
            Enemie snake = new Enemie("Phytor", 20, 24, waterCannon);

            //Story World 1
            for (int i = 0; i < 10; i++)
            {
                AuftauchenGegner(character, goblin, sushi, healingPotion1);
                if (character.Health <= 0)
                {
                    break;
                }
                goblin.Health = 20;
                sushi.Health = 10;
                Console.WriteLine("Du gehst weiter");
            }

            char richtung = '0';
            if (character.Health > 0)
            {
                Console.WriteLine("Du bist mit der 1. Welt fertig");
                Console.WriteLine("Du kommt an eine Abzweigung. Es gibt ein Schild:\r\n1) Wald\r\n2) Meer");
                ConsoleKeyInfo key = Console.ReadKey(true);
                richtung = key.KeyChar;
            }

            //Story World 2
            if (richtung == '1')
            {
                for (int i = 0; i < 10; i++)
                {
                    AuftauchenGegner(character, crab, shark, healingPotion1);
                    crab.Health = 25;
                    shark.Health = 30;
                    Console.WriteLine("Du gehst weiter");
                }
                Console.WriteLine("Du hast das Abenteuer erfolgreich beendet!");
            }

            //Story World 3
            else if (richtung == '2')
            {
                AuftauchenGegner(character, monkey, snake, healingPotion1 );
                monkey.Health = 30;
                snake.Health = 20;
                Console.WriteLine("Du gehst weiter");
            }
            Console.WriteLine("Du hast das Abenteuer erfolgreich beendet!");
        }

        static void Start(Hero player, Sword sword1, Sword sword2, Sword sword3, Bow bow)
        {
            Console.Write("Wer bist du? ");
            player.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hallo " + player.Name);
            Console.WriteLine("(Drücke Enter)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welches Schwert möchtest du haben?");
            Console.WriteLine("Es gibt folgende drei Schwerter:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) Feuerschwert");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2) Eisschwert");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3) Elektroschwert\r\n");

            ConsoleKeyInfo KeyData = Console.ReadKey(true);
            char choice = KeyData.KeyChar;

            switch (choice)
            {
                case '1':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du erhälst das Feuerschwert!");
                    player.Sword = sword1;
                    break;
                case '2':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du erhälst das  Eisschwert!");
                    player.Sword = sword2;
                    break;
                case '3':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du erhälst das Elektroschwert!");
                    player.Sword = sword3;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Zusätzlich erhälst du den Giftbogen");
            Console.ForegroundColor = ConsoleColor.White;
            player.Bow = bow;

            Console.WriteLine("(Drücke Enter)");
            Console.ReadLine();
            Console.Clear();
        }
        static void AuftauchenGegner(Hero player, Enemie opponent1, Enemie opponent2, Healing itemHealing)
        {
            Enemie[] enemies = new Enemie[] { opponent1, opponent2 };

            Random die = new Random();
            int random = die.Next(0, 2);

            Console.WriteLine($"{player.Name}, ein {enemies[random].Name} taucht auf!");
            while (player.Health > 0 && enemies[random].Health > 0)
            {
                if (player.Speed > enemies[random].Speed)
                {
                    Console.WriteLine("Möchtest angreifen oder ein Item einsetzen?\r\n1) Angreifen\r\n2) Item einsetzen");
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    char itemOrFight = key.KeyChar;

                    if(itemOrFight == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("Du setzt als erstes dein Item ein!");
                        player.useHealingItem();
                    }
                    else
                    {
                        Console.WriteLine("\r\nWomit willst du kämpfen?\r\n1) Schwert\r\n2) Bogen\r\n");
                        ConsoleKeyInfo KeyData = Console.ReadKey(true);
                        char weapon = KeyData.KeyChar;
                        Console.Clear();
                        switch (weapon)
                        {
                            case '1':
                                Console.WriteLine("Du greifst als erstes an!\r\n");
                                player.attackSword(enemies[random], player.Sword);
                                break;
                            case '2':
                                Console.WriteLine("Du greifst als erstes an!\r\n");
                                player.attackBow(enemies[random], player.Bow);
                                break;
                        }
                    }

                    if (enemies[random].Health <= 0)
                    {
                        Console.WriteLine("Du hast den Gegner besiegt!\r\n");
                        AuftauchenHeilungsItem(player, itemHealing);

                        Console.WriteLine("Leben Charakter:     " + player.Health);
                        Console.WriteLine("Leben Gegner:        " + enemies[random].Health + "\r\n");
                        Console.WriteLine("(Drücke Enter)");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        enemies[random].attack(player, enemies[random].Weapon);
                        Console.WriteLine($"Der {enemies[random].Name} greift als zweites an!\r\n");
                    }

                    if (player.Health <= 0)
                    {
                        Console.WriteLine("GAME OVER!");
                        Console.WriteLine("Leben Charakter:     " + player.Health);
                        Console.WriteLine("Leben Gegner:        " + enemies[random].Health + "\r\n");
                        Console.WriteLine("(Drücke Enter)");
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    enemies[random].attack(player, enemies[random].Weapon);
                    Console.WriteLine($"Der {enemies[random].Name} greift als erstes an!\r\n");

                    if (player.Health <= 0)
                    {
                        Console.WriteLine("GAME OVER!");
                        Console.WriteLine("Leben Charakter:     " + player.Health);
                        Console.WriteLine("Leben Gegner:        " + enemies[random].Health + "\r\n");
                        Console.WriteLine("(Drücke Enter)");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Möchtest angreifen oder ein Item einsetzen?\r\n1) Angreifen\r\n2) Item einsetzen");
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        char itemOrFight = key.KeyChar;

                        if (itemOrFight == '2')
                        {
                            Console.Clear();
                            player.useHealingItem();
                        }
                        else
                        {
                            Console.WriteLine("\r\nWomit willst du kämpfen?\r\n1) Schwert\r\n2) Bogen\r\n");
                            ConsoleKeyInfo KeyData = Console.ReadKey(true);
                            char weapon = KeyData.KeyChar;
                            switch (weapon)
                            {
                                case '1':
                                    Console.WriteLine("Du greifst als zweites an!\r\n");
                                    player.attackSword(enemies[random], player.Sword);
                                    break;
                                case '2':
                                    Console.WriteLine("Du greifst als zweites an!\r\n");
                                    player.attackBow(enemies[random], player.Bow);
                                    break;
                            }
                        }
                    }

                    if (enemies[random].Health <= 0)
                    {
                        Console.WriteLine("Du hast den Gegner besiegt!\r\n");
                        AuftauchenHeilungsItem(player, itemHealing);

                        Console.WriteLine("Leben Charakter:     " + player.Health);
                        Console.WriteLine("Leben Gegner:        " + enemies[random].Health + "\r\n");
                        Console.WriteLine("(Drücke Enter)");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
                Console.WriteLine("Leben Charakter:     " + player.Health);
                Console.WriteLine("Haltbarkeit Schwert:  " + player.Sword.Durability);
                Console.WriteLine("Leben Gegner:        " + enemies[random].Health + "\r\n");
                Console.WriteLine("(Drücke Enter)");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void AuftauchenHeilungsItem(Hero player, Healing itemHealing)
        {
            Random die = new Random();
            int itemProbability = die.Next(0, 4);
            if (itemProbability == 0)
            {
                Console.WriteLine($"Du erhälst einen {itemHealing.Name} !");

                if (player.HealingSlot1 == null)
                {
                    player.HealingSlot1 = itemHealing;
                    Console.WriteLine("Das gefundene Item wird in Slot 1 gespeichert!\r\n");
                }
                else if (player.HealingSlot2 == null)
                {
                    player.HealingSlot2 = itemHealing;
                    Console.WriteLine("Das gefundene Item wird in Slot 2 gespeichert!\r\n");
                }
                else if (player.HealingSlot3 == null)
                {
                    player.HealingSlot3 = itemHealing;
                    Console.WriteLine("Das gefundene Item wird in Slot 3 gespeichert!\r\n");
                }
                else
                {
                    Console.WriteLine("Du hast keinen Platz in deiner Tasche.");
                    Console.WriteLine("Möchtest du ein anderes Item wegwerfen?\r\n1) ja\r\n2) nein");
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    char destroyItem = key.KeyChar;

                    if (destroyItem == '1')
                    {
                        Console.WriteLine("Welches Item möchtest du wegwerfen?");
                        Console.WriteLine("1) " + player.HealingSlot1.Name + "\r\n2) " + player.HealingSlot2.Name + "\r\n3) " + player.HealingSlot3.Name);
                        key = Console.ReadKey(true);
                        char destroyItemSlot = key.KeyChar;

                        if (destroyItemSlot == '1')
                        {
                            player.HealingSlot1 = itemHealing;
                            Console.WriteLine("Das gefundene Item wird in Slot 1 gespeichert!\r\n");
                        }
                        else if (destroyItemSlot == '2')
                        {
                            player.HealingSlot2 = itemHealing;
                            Console.WriteLine("Das gefundene Item wird in Slot 2 gespeichert!\r\n");
                        }
                        else if (destroyItem == '3')
                        {
                            player.HealingSlot3 = itemHealing;
                            Console.WriteLine("Das gefundene Item wird in Slot 3 gespeichert!\r\n");
                        }
                        else
                        {
                            Console.WriteLine("Du wirfst das gefundene Item weg!");
                        }
                    }
                }
            }
        }
    }
}
