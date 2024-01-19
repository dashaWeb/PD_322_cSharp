using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_delegat_calc
{

    delegate double DelCalc(double a, double b);
    class Calculate
    {
        public static double Add(double a, double b) => a + b;
        public static double Sub(double a, double b) => a - b;
        public double Mult(double a, double b) => lastRes = a * b;
        private double lastRes = 1;
        public override string ToString()
        {
            return $"Mult lastres = {lastRes}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DelCalc calc = new DelCalc(Calculate.Sub) + Calculate.Add;
            Console.WriteLine($"__ Method {calc.Method}");
            Console.WriteLine($"__ Res = {calc(5,2)}");

            foreach (var item in calc.GetInvocationList())
            {
                Console.WriteLine($"Method :: {item.Method.Name} = {item.DynamicInvoke(2,5)}");
            }

            Calculate calculate = new Calculate();
            DelCalc del = calculate.Mult;
            Console.WriteLine($"Method {del.Method}");
            Console.WriteLine($"Target object {del.Target}");
            del(5, 2);
            Console.WriteLine(calculate);
        }
    }
}
