using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Std_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => { Console.WriteLine("Test Action"); };
            action += Hello;

            action();

            Action<int, string> act = (number, name) => { Console.WriteLine($"{number} :: {name}"); };
            act(5, "Alex");


            Predicate<int> odd = (number) => number % 2 != 0;
            Console.WriteLine($"Test number odd :: {odd(5)}");
            Console.WriteLine($"Test number odd :: {odd(6)}");

            Func<int, int, double> avg = (a, b) => (a + b) / 2.0;
            Console.WriteLine($"Average :: {avg(4, 5)}");

            Comparison<string> del = (s1,s2) => s1.Length.CompareTo(s2.Length);
            string word1 = "Program";
            string word2 = "Python";
            Console.WriteLine($"Compare ({word1},{word2}): {del(word1,word2)}");
            Console.WriteLine($"Compare ({word2},{word1}): {del(word2,word1)}");
        }
        static void Hello() { Console.WriteLine("Hello"); }
    }
}
