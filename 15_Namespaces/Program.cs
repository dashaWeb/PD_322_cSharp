using System;
/*using NS1;
using NS;*/
using n = NS;
using static System.Console;
using static System.Math;

/*
 namespase CSharpNamespace
{
    class Foo{}
}
  namespase CSharpNamespace1
{
    class Foo{}
}
 */

namespace A
{
    class incrementer
    {
        private int _count;
        public incrementer(int count)
        {
            _count = count;
        }
        public int MultyIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                _count++;
            }
            return _count;
        }
    }
}
namespace B
{
    class incrementer
    {
        private int _var;
        public incrementer(int count)
        {
            _var = count;
        }
        public int MultyIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                _var += 10;
            }
            return _var;
        }
    }
}
namespace _15_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A.incrementer one = new A.incrementer(5);
            B.incrementer two = new B.incrementer(10);
            WriteLine(one.MultyIncrement());
            WriteLine(two.MultyIncrement());
            n.Class obj = new n.Class();
            obj.print();

            WriteLine($"Square root 81 = {Sqrt(81)}");
            WriteLine($"2 raised to the 5 {Pow(2,5)}");
        }
    }
}

