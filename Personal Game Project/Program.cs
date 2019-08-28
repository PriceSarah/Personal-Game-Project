using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string race = "";

            Console.WriteLine("Hello There and welcome to the character Creator.");
            Console.WriteLine("To Start things off, please tell me, what is your characters name?");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ah yes " + name + ". Alright " + name + " Now I would like for you to pick a race for your character. Choose wisley as you may not change it later.");
            Console.WriteLine("");

            while (race != "1" && race != "2" && race != "3" && race != "4" && race != "5" && race != "6" && race != "7" && race != "8" && race != "9")
            {
                //race selection
                Console.WriteLine("1: Human");
                Console.WriteLine("2: Elf");
                Console.WriteLine("3: Dwarf");
                Console.WriteLine("4: Halfling");
                Console.WriteLine("5: Half-Elf");
                Console.WriteLine("6: Half-Orc");
                Console.WriteLine("7: Tiefling");
                Console.WriteLine("8: Gnome");
                Console.WriteLine("9: Dragonborn");
                race = Console.ReadLine();
            }
            Character player;
            if (race == "1")
                {
                player = new Human(name);
                }

            Console.WriteLine("So you are " + name + " the " + race);

            Console.ReadKey();
        }
    }
}
