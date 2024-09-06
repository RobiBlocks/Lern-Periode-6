using BlueDragon.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero character = new Hero(100, 20);

            Sword fireSword = new Sword("Feuerschwert", 10, 20, "Feuer");
            Sword iceSword = new Sword("Eisschwert", 6, 40, "Eis");
            Sword electricSword = new Sword("Elektroschwert", 8, 30, "Elektro");

            Bow poisonBow = new Bow("Giftbogen", 3, 25, "Gift");

            Start(character, fireSword, iceSword, electricSword, poisonBow);

            Weapon slingshot = new Weapon("Steinschleuder", 5, 10, "Stein");

            Enemie goblin = new Enemie("Greg", 20, 30, slingshot);
            Enemie sushi = new Enemie("Reis", 10, 40, slingshot);
            Enemie dragon = new Enemie("Blue Dragon", 300, 10, slingshot);

            AuftauchenGegner(character, goblin, sushi);
            goblin.Health = 20;
            sushi.Health = 10;
            Console.WriteLine("Du gehst weiter");
            AuftauchenGegner(character, goblin, sushi);
            goblin.Health = 20;
            sushi.Health = 10;
            Console.WriteLine("Du gehst weiter");
            AuftauchenGegner(character, goblin, sushi);
            goblin.Health = 20;
            sushi.Health = 10;
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
        static void AuftauchenGegner(Hero player, Enemie opponent1, Enemie opponent2)
        {
            Enemie[] enemies = new Enemie[] { opponent1, opponent2 };

            Random die = new Random();
            int random = die.Next(0, 2);

            //Es kämpft nur der goblin

            Console.WriteLine("Wanderer, ein " + enemies[random].Name + " taucht auf!");
            while (player.Health > 0 && enemies[random].Health > 0)
            {
                if (player.Speed > enemies[random].Speed)
                {
                    Console.WriteLine("Womit willst du kämpfen?\r\n1) Schwert\r\n2) Bogen");
                    ConsoleKeyInfo KeyData = Console.ReadKey(true);
                    char weapon = KeyData.KeyChar;
                    switch (weapon)
                    {
                        case '1':
                            player.attackSword(enemies[random], player.Sword);
                            break;
                        case '2':
                            player.attackBow(enemies[random], player.Bow);
                            break;
                    }

                    if (enemies[random].Health <= 0)
                    {
                        Console.WriteLine("Du hast den Gegner besiegt!");
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
                        Console.WriteLine("Womit willst du kämpfen?\r\n1) Schwert\r\n2) Bogen");
                        ConsoleKeyInfo KeyData = Console.ReadKey(true);
                        char weapon = KeyData.KeyChar;
                        switch (weapon)
                        {
                            case '1':
                                player.attackSword(enemies[random], player.Sword);
                                break;
                            case '2':
                                player.attackBow(enemies[random], player.Bow);
                                break;
                        }
                    }

                    if (enemies[random].Health <= 0)
                    {
                        Console.WriteLine("Du hast den Gegner besiegt!");
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
            }
        }
    }
}