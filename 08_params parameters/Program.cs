using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_params_parameters
{
    internal class Program
    {
        enum Color :ushort
        {
            RED = 33, BLUE = 11, GREEN = 12 
        }
        static int Sum(int one, int two)
        {
            return one + two;
        }
        static int Sum(params int[] arr)
        {
            return arr.Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5,4,6,7,8));
            Console.WriteLine((int)Color.BLUE);
            Console.WriteLine(String.Join("\n", Enum.GetNames(typeof(Color))));
            var colors = (Color[])Enum.GetValues(typeof(Color));
            foreach (var item in colors)
            {
                Console.WriteLine((int)item);
            }
        }
    }
}
