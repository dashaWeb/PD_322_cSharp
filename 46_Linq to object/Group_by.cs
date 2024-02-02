using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"Product :: {Name} --> {Category}";
        }
    }

    class TestGroupBy
    {
        public static void Way1()
        {
            int[] arr = { 9, 34, 65, 12, 94, 42, 365 };
            var query = from x in arr
                        where x > 10
                        group x by x % 10;
            Console.WriteLine("Forming groups of criteria::");
            foreach ( IGrouping<int,int> group in query )
            {
                Console.WriteLine($"Key :: {group.Key}");
                Console.WriteLine("\t Value :: ");
                foreach (int item in group)
                {
                    Console.Write($"\t {item}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var res = arr.Where( x => x > 10 ).GroupBy(x => x%10).OrderBy(g => g.Key);
            foreach (IGrouping<int, int> group in res)
            {
                Console.WriteLine($"Key :: {group.Key}");
                Console.WriteLine("\t Value :: ");
                foreach (int item in group)
                {
                    Console.Write($"\t {item}");
                }
                Console.WriteLine();
            }
        }

        public static void Way2()
        {
            Product[] arr = {
                new Product(){ Name = "Apple", Category = "Food"},
                new Product(){ Name = "Phone", Category = "Tech"},
                new Product(){ Name = "banana", Category = "Food"},
                new Product(){ Name = "Laptop", Category = "Tech"},
                new Product(){ Name = "Plum", Category = "Food"},
            };

            Console.WriteLine(string.Join<Product>("\n",arr));
            var res = arr.GroupBy(product => product.Category);
            Console.WriteLine("Result group by");
            foreach (IGrouping<string,Product> group in res)
            {
                Console.WriteLine($"{group.Key}");
                Console.WriteLine("\t Value :: ");
                foreach (var item in group)
                {
                    Console.Write($"\t {item.Name}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            var res2 = arr.Where(item => char.IsUpper(item.Name[0]) && item.Category == "Food").Select(item => item.Name);
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
