using BlueDragon.Weapon;
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
            Sword plantSword = new Sword("Pflanzenschwert", 40, 5, "Pflanze");

            Start(character, fireSword, iceSword, electricSword, plantSword);

            Enemie goblin = new Enemie("Greg", 10, 30);
            Enemie sushi = new Enemie("Reis", 5, 40);
            Enemie dragon = new Enemie("Blue Dragon", 300, 10);

            Enemie[] enemies = new Enemie[] { goblin, sushi };

            Random die = new Random();
            int random = die.Next(0, 1);

            //Es kämpft nur der goblin

            Console.WriteLine("Wanderer, ein Gegner taucht auf:");
            enemies[random].attack(character, fireSword);
            Console.WriteLine(fireSword.Durability);
            Console.WriteLine(character.Health);
        }

        static void Start(Hero player, Sword sword1, Sword sword2, Sword sword3, Sword sword4)
        {
            Console.Write("Wer bist du? ");
            player.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hallo " + player.Name);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welches Schwert möchtest du haben?");
            Console.WriteLine("Es gibt folgende drei Schwerter:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) Feuerschwert");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2) Eisschwert");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3) Elektroschwert");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4) Pflanzenschwert");

            ConsoleKeyInfo KeyData = Console.ReadKey(true);
            char choice = KeyData.KeyChar;

            switch (choice)
            {
                case '1':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du erhälst das Feuerschwert!");
                    break;
                case '2':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du erhälst das  Eisschwert!");
                    break;
                case '3':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du erhälst das Elektroschwert!");
                    break;
                case '4':
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du erhälst das Pflanzenschwert!");
                    break;
            }

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}