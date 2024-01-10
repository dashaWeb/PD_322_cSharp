using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_inheritance_extention
{

    static class IntExctension
    {
        public static int CounterDigits(this int value)
        {
            return Math.Abs(value).ToString().Length;
        }
    }
    static class ArrayExctension
    {
        public static int SumPositive(this int[] arr)
        {
            return Array.FindAll(arr, x => x > 0).Sum();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal[] zoo = new Animal[]
            {
                new Cat("Cat"),
                new Dog("Dog")
            };
            foreach (var z in zoo)
            {
                // is, as
                if (z is Cat)
                {
                    Console.WriteLine($"Name :: {(z as Cat).Name,-10} Age :: {(z as Cat).Age,-10} Weight :: {z.Weight,-10}");

                }
                if (z is Dog)
                {
                    Console.WriteLine($"Name :: {(z as Dog).Name,-10} Age :: {(z as Dog).Age,-10} Weight :: {z.Weight,-10}");
                    (z as Dog).Voice();

                }
                Console.WriteLine("\n=============================\n");
            }*/
            int a = -12334;
            Console.WriteLine($"Count digits {a} = {a.CounterDigits()}");
            int[]arr = new int[] { 1,2,3,4,5};
            Console.WriteLine($"Sum element {arr.SumPositive()}");
        }
    }
}
