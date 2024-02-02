using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    internal class TestSets
    {
        public static void Way()
        {
            string[] A = { "Blue", "Grey", "Yellow", "Cyan", "Grey", "Yellow" };
            string[] B = { "Yellow", "Magenta", "White", "Blue" };

            Console.WriteLine($"A :: {string.Join("\t",A)}");
            Console.WriteLine($"B :: {string.Join("\t",B)}");

            Console.WriteLine();

            // Except 
            var res = A.Except( B );
            Console.WriteLine($"Except    :: {string.Join("\t",res)}");

            //Intersect
            res = A.Intersect( B );
            Console.WriteLine($"Intersect :: {string.Join("\t", res)}");

            //Union
            res = A.Union(B);
            Console.WriteLine($"Union     :: {string.Join("\t", res)}");

            //Concat
            res = A.Concat(B);
            Console.WriteLine($"Concat    :: {string.Join("\t", res)}");

            //Distinct
            res = A.Distinct();
            Console.WriteLine($"Concat    :: {string.Join("\t", res)}");
        }
    }
}
