using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Class_Char
{
    /*
     public - доступний рівень
     protected - захищений, доступ дозволено з поточного класу або його спадкоємця
     private - доступ дозволений лише в межах класу
     internal - доступ обмежено поточною збіркою
    protected internal - доступ обмежено поточною збіркою,доступ дозволено з поточного класу або його спадкоємця
    private protected - доступ дозволено в поточному класі та класах нащадках поточної збірки
     */
    internal class Character
    {
        private string name = "Unknown";
        private uint hp = 100; 
        public Character(string name,uint hp, uint damage) {
            //this.name = name;
            Name = name;
            this.hp = hp;
            Damage = damage;
        }
        public Character(string name = "Unknown")
            : this(name, 100, 0) { }
        public uint Damage { get; set; } // авто-властивість, компілятор створить поле типу uint та для нього get; set;
        public uint KPD
        {
            /*get
            {
                return Damage * hp;
            }*/
            get => Damage * hp;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // value - ключове слово для set = значення яке хочемо встановити
                //name = value;
                /*if(value.Length!= 0)
                {
                    name = value;
                }*/
                if (!String.IsNullOrWhiteSpace(value)) // якщо прийшло не пусте (null "" " " \t \n)
                {
                    name = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name :: {name, -10} HP :: {hp,-10} Damage :: {Damage}";
        }
        public void Print()
        {
            Console.WriteLine($"Character name : {name}");
            Console.WriteLine($"Character hp : {hp}");
            Console.WriteLine($"Character damage : {Damage}");
        }
    }
}
