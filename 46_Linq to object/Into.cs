using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    internal class TestInto
    {
        public static void Way1()
        {
            int[] arr = { 5, 34, 67, 12, 94, 42 };
            /*var query = from i in arr
                        group i by i % 10 into gr
                        where gr.Count() > 1
                        select gr;*/
            /*var query = from gr in(from i in arr group i by i%10)
                        where gr.Count() > 1
                        select gr;*/

            var query = arr.GroupBy(i => i % 10).Where(g => g.Count() > 1);
            Console.WriteLine("Groups with the number of elements is greater than 1 :: ");
            foreach (var i in query)
            {
                Console.WriteLine($"{i.Key} \n\t Value :: ");
                foreach (var j in i)
                {
                    Console.Write($"\t{j}");
                }
                Console.WriteLine();
            }
        }
    }
}
