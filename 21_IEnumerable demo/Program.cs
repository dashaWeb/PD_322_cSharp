using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_IEnumerable_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable 
            // Enumerablae - те, що перелічуємо
            // Enumerator - той, хто переміщається (С++ ітератор)

            int[] arr = { 10, 22,33,-25,333 };
            var enArr = arr.GetEnumerator();
            while (enArr.MoveNext())
            {
                Console.Write($"{enArr.Current,7}");
            }
            Console.WriteLine();

            string str = "Hello from IEnumerable";
            var enStr = str.GetEnumerator();
            while (enStr.MoveNext())
            {
                Console.Write($"{enStr.Current,2} * ");
            }
            Console.WriteLine();

            StringBuilder sb = new StringBuilder("");
            enStr.Reset();
            while (enStr.MoveNext())
            {
                sb.Append(enStr.Current);
                sb.Append("___");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(str);
            Console.WriteLine(sb);
        }
    }
}
