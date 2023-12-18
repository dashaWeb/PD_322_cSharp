using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Static_field
{
    enum Position { None, Manager, Developer, Economist, Director}
    internal class Employee
    {
        private static int lastId;
        public readonly int ID = ++lastId;// readonly поле тількт для читання, встановлюється 1 раз (у конструкторі або тут)
        public string Name { get; set; } = "Noname";
        public DateTime Birth { get; set; }
        public Position Position { get; set; } = Position.None;
        //public static int LastId => lastId; // only get
        public static int LastId { get => lastId; }// only get
        public static bool SamePosition(Employee e1, Employee e2)
        {
            return e1.Position == e2.Position;
        }
        static Employee() // без параметрів спрацює до використання класу (створення обєкта, виклик статичного метода чи властивості)
        {
            Console.WriteLine("\t\t Static ctor demo");
            lastId = new Random().Next(1,10) * 1000;
        }
        public override string ToString()
        {
            return $"ID : {ID,-5} Birth : {Birth.ToShortDateString(), -15} Position : {Position}";
        }
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
    }
}
