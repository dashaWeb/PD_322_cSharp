using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Overload_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction one = new Fraction(1, 2);
            Fraction two = new Fraction(1, 3);
            Console.WriteLine($"{one}, {two}");

            Fraction sum = one + two;
            Console.WriteLine($"{one} + {two} = {sum}");
            sum += one;
            Console.WriteLine($"{sum}");

            Fraction three = new Fraction(1, 2);
            Console.WriteLine($"\n {one} == {three} ? {one == three}"); // true
            Console.WriteLine($" {one} == {two} ? {one == two}"); // false

            Console.WriteLine($"++{one} = {++one}");
            Console.WriteLine($"{one}++ = {one++}");
            Console.WriteLine($"{one}");

            Console.WriteLine();
            one.Num = 0;
            if(one)
            {
                Console.WriteLine($"{one} = true");
            }
            else
            {
                Console.WriteLine($"{one} = false");
            }
            Console.WriteLine();
            Console.WriteLine($"Num :: {one[0]}");
            Console.WriteLine($"Denom :: {one[1]}");
            one[0] = -33;
            Console.WriteLine(one);
            try { 
                for(int i = 0; i < 3; i++) {
                    Console.WriteLine($"one[{i}] : {one[i]}");
                }
            }
            catch(Exception e) { Console.WriteLine(e.Message); }

            double b;
            int c = 5;
            b = c; // int to double (неявне перетворення)
            Console.WriteLine(b);
            c = (int)b; // double to int (явне перетворення)

            // int value = sum; // так можна якщо перевантажили як implicit
            Console.WriteLine($"{sum} cast to int : {(int)sum}");
            Console.WriteLine($"{sum} cast to double : {(double)sum}");

            double dVal = sum;
            Console.WriteLine($"{sum} cast to double implicitly(dVAlue) : {dVal}");
            Point test = sum;
            Console.WriteLine($"({test.X},{test.Y})");
            
        }
    }
}
