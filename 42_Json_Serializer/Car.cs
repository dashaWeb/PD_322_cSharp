using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _42_Json_Serializer
{
    // json serializer - буде серіалізувати публічні та властивості
    class Engine
    {
        public double Power { get; set; }
        public Engine(double power)
        {
            Power = power;
        }
        public Engine()
            : this(1.0)
        { }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }

    class Car
    {
        public int id;
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)
        {
            Brand = brand;
            this.id = id;
            Engine = new Engine(power);
        }
        public Car()
            : this(0, "Nobrand", 1.0)
        { }
        public override string ToString()
        {
            return $"Id {id}. \t Car brand :: {Brand}. \t {Engine}.";
        }
    }
}
