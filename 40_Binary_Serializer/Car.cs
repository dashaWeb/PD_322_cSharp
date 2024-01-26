using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Binary_Serializer
{
    [Serializable]
    class Engine
    {
        public double Power { get; set; }
        public Engine(double power)
        {
            Power = power;
        }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }
    [Serializable] // атрибут позначає можливість сереалізувати об'єкт типу Car
    internal class Car
    {
        //[NonSerialized]
        private int id;
        private string brand;
        public string Brand { get=>brand; set=>brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)
        {
            Brand = brand;
            this.id = id;
            Engine = new Engine(power);
        }
        public override string ToString()
        {
            return $"Id {id}. \t Car brand :: {Brand}. \t {Engine}.";
        }
    }
}
