using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
            duck.Move();

            Console.WriteLine($"Speed :: {((IFly)duck).Speed}");

            Console.WriteLine(" Duck Fly");
            IFly fl = duck;
            fl.Fly();
            //var n = fl.Speed;
            Console.WriteLine(" Duck Fly");
            IMove mv = duck;
            mv.Move();

            Console.WriteLine("\n\n");
            SteamerDuck steamerDuck = new SteamerDuck();
            steamerDuck.Fly();
            steamerDuck.Swim();
            steamerDuck.Move();


            Console.WriteLine();
            Duck[] ducks = { duck, steamerDuck };
            foreach (var item in ducks)
            {
                item.Fly();
                Console.WriteLine($"Speed :: {item.Speed}");
            }

        }
    }
}
