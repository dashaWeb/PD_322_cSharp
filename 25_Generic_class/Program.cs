using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Generic_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack);

            stack.Pop();
            Console.WriteLine(stack);
            Console.WriteLine(stack.Peek());
            Console.WriteLine($"Count :: {stack.Count,-10} Capacity :: {stack.Capacity}");
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine($"Count :: {stack.Count,-10} Capacity :: {stack.Capacity}");
        }
    }
}
