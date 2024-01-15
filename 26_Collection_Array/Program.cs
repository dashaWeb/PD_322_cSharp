using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Collection_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int a = 123; // stack
            object obj = a;

            Console.WriteLine($"{obj} -- > {obj.GetType().Name}");

            if(obj is int )
            {

                int b = (int)obj;
            }*/

            /*List<int> list = new List<int>();
            Console.WriteLine($"Count :: {list.Count}, \t Capacity :: {list.Capacity}");

            List<int> list_2 = new List<int>(10);
            Console.WriteLine($"Count :: {list_2.Count}, \t Capacity :: {list_2.Capacity}");

            List<int> list_3 = new List<int>(new int[] { 1,2,3});
            Console.WriteLine($"Count :: {list_3.Count}, \t Capacity :: {list_3.Capacity}");


            list.Add(12);
            list.Add(13);
            list.AddRange(new int[] { 1,2,3,4});
            PrintList(list, "List");

            list.Remove(12);
            PrintList(list, "List Remove");
            list.Remove(22);
            PrintList(list, "List Remove");

            list.RemoveRange(0, 2);
            PrintList(list, "List RemoveRange");

            list.RemoveAt(0);
            PrintList(list, "List RemoveAt");

            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                list.Add(rnd.Next(-10, 10));
            }
            Console.WriteLine();
            PrintList(list, "List Fill");
            list.RemoveAll(x => x < 0);
            PrintList(list, "List Fill");

            //list.Clear();
            Console.WriteLine($"Count :: {list.Count}, \t Capacity :: {list.Capacity}");

            //list.Reverse();
            list.Reverse(0,5);
            PrintList(list, "List Fill");

            *//*Console.WriteLine($"IndexOf {list.IndexOf(5)}");
            Console.WriteLine($"IndexOf {list.IndexOf(5,4)}");
            Console.WriteLine($"IndexOf {list.IndexOf(5,4,6)}");*//*

            list.Insert(5, 333);
            PrintList(list, "List Fill");
            list.InsertRange(2, new int[] { 0, 0, 0, 0 });
            PrintList(list, "List Fill");
            list.Sort();
            PrintList(list, "List Fill");
            Console.WriteLine(String.Join<int>(", ",list));*/

            ArrayList listt= new ArrayList() {1,5,true,"121" };

            PrintList(listt);
            listt.Add(1.5);
            PrintList(listt);
            foreach (var item in listt)
            {
                if(item is double)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void PrintList<T>(IEnumerable<T> list, string prompt = "")
        {
            Console.Write($"Print {prompt} :: ");
            foreach (var item in list)
            {
                Console.Write($"{item, 7}");
            }
            Console.WriteLine();
        }
        static void PrintList(IEnumerable list, string prompt = "")
        {
            Console.Write($"Print {prompt} :: ");
            foreach (var item in list)
            {
                Console.Write($"{item,7}");
            }
            Console.WriteLine();
        }
    }
}
