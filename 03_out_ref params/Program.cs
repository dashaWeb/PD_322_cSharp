using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_out_ref_params
{
    internal class Program
    {
        static void BadSwap(int left, int right) // параметр передається за значенням (приходить копія значень)
        {
            var tmp = left;
            left = right; 
            right = tmp;
        }
        // ref, out - передача за посиланням
        // ref - переданий фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
        // out - переданий фактичний параметр може бути НЕ ПРОІНІЦІАЛІЗОВАНИЙ, тобто параметр для збереження результату
        static void Swap(ref int left, ref int right) // параметр передається за посиланням
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
        static void Inc(ref int value)
        {
            ++value;
        }
        static void Change(out int first, int value)
        {
            first = value * 2;
        }
        static void Main(string[] args)
        {
            int one = 10;
            int two = 15;
            Console.WriteLine($"Before swap :: \tone({one}), \ttwo({two})");
            //BadSwap(one, two);
            Swap(ref one, ref two);
            Console.WriteLine($"After swap  :: \tone({one}), \ttwo({two})");
            int value = 5;
            Console.WriteLine($"Start value :: {value}");
            Inc(ref value);
            Console.WriteLine($"End value :: {value}");
            int res;
            Change(out res, value);
            Console.WriteLine(res);
        }
    }
}
