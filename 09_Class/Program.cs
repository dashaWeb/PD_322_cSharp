using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_Class_Char;
namespace _09_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("Elf",100,5);
            Console.WriteLine(character);
            character.Print();

            character.Name = "   ";
            Console.WriteLine(character);
            character.Name = "Kind Elf";
            Console.WriteLine(character);

            //character.KPD = 22; no set
            Console.WriteLine($"KPD : {character.KPD}");
            Console.WriteLine();
            Character c2 = new Character(hp:150, damage:2, name:"Mage");
            c2.Print();
            Console.WriteLine();

            Character c3 = new Character{ Damage = 10, Name = "Warrior" };
            c3.Print();
        }
    }
}
