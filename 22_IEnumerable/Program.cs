using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item apple = new Item { Name = "Apple", Price = 20};
            Item grapes = new Item { Name = "Grapes", Price = 30};
            Item orange = new Item { Name = "Orange", Price = 42};
            Item banana = new Item { Name = "Banana", Price = 54};

            ShopBucket shop = new ShopBucket();
            shop.AddItem(apple);
            shop.AddItem(grapes);
            shop.AddItem(orange);
            shop.AddItem(banana);

            Console.WriteLine(shop);

            foreach (var item in shop)
            {
                Console.WriteLine("--------");
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");

            foreach (var item in shop.GetReverse())
            {
                Console.WriteLine("--------");
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            foreach (var item in shop.GetCheaperItem(35))
            {
                Console.WriteLine("--------");
                Console.WriteLine(item);
            }
        }
    }
}
