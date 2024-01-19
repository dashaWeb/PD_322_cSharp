using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_delegate_param
{

    internal class Program
    {
        delegate bool DelArr<T>(T data);
        static int CountArray<T>(T[] arr, DelArr<T> fun)
        {
            int count = 0;
            foreach (T item in arr)
            {
                if (fun(item)) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { -10, 22, 54, -95, 25, -12, 23 };
            string[] colors = { "Red", "yellow", "brown", "Violet", "purple", "pink", "black" };
            Console.WriteLine($"Count Negative :: {CountArray(arr, el => el < 0)}");
            Console.WriteLine($"Count colors :: {CountArray(colors, el => el.Contains('e'))}");
            Console.WriteLine($"Count colors :: {CountArray(colors, el => Char.IsUpper(el[0]))}");

        }
    }
}
