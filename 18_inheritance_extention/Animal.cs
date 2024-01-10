using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_inheritance_extention
{
    abstract class Animal
    {
        public string Name { get; set; }
        public virtual int Age { get=>10; }
        public abstract int Weight { get; }
        public Animal(string name)
        {
            Name = name;
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override int Weight => 15;
        public override int Age { get => 25; }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override int Weight => 21;
        public override int Age { get => 12; }
        public void Voice()
        {
            Console.WriteLine("Dog Voice");
        }
    }
}
