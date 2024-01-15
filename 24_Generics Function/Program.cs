using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Generics_Function
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other)
        {
            if(other == null) return 1;
            return Age.CompareTo(other.Age);
        }
        public virtual void Busy()
        {
            Console.WriteLine($"Name :: {Name,-10} Age :: {Age}");
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Age :: {Age}";
        }
    }
    class Employee : Person
    {
        public override void Busy()
        {
            Console.WriteLine("Busy Employee"); 
            base.Busy();
        }
    }
    internal class Program
    {

        static void Swap<T>(ref T a,ref T b)
        {
            var tmp = a;
            a = b; 
            b = tmp;
        }
        static T Max<T>(T one, T two)where T: IComparable<Person>
        {
            return one.CompareTo(two as Person) > 0 ? one : two;
        }
        
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            double dd = 2.5;
            Console.WriteLine($"a = {a,-5} b = {b,-5}");
            Swap(ref a,ref b);
            Console.WriteLine($"a = {a,-5} b = {b,-5}");

            double one = 2.5, two = 5.2;
            Console.WriteLine($"one = {one,-5} two = {two,-5}");
            Swap(ref one, ref two);
            Console.WriteLine($"one = {one,-5} two = {two,-5}");

            Person person_1 = new Person { Name = "Vadik", Age = 22 };
            Person person_2 = new Person { Name = "Sasha", Age = 25 };

            Console.WriteLine($"Max :: {Max<Person>(person_1,person_2)}");
        }
    }
}
