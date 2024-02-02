using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////// Select

            // res = from in source_name
            /* //        select result_value
             int[] arr = { 5, 34, 67, -12, 94, -42 };

             var query = from i in arr
                         select i * -1;
             Console.WriteLine(String.Join("\t",query));

             //var res = arr.Select(ConvertData);
             //var res = arr.Select(delegate (int item) { return item * -1; });           
             var res = arr.Select(item => item * -1);
             Console.WriteLine();
             Console.WriteLine(String.Join("\t",res));*/


            // Where : визначає фільтер вибірки
            /*int[] arr = { 5, 34, 67, 12, 94, 42 };
            var query = from i in arr
                        where i%2 == 0
                        select i;
            Console.WriteLine("Only the even elements");
            Console.WriteLine(String.Join("\t",query));

            // Method
            query = arr.Where(i => i%2 == 0).Select(i => i * -1);
            Console.WriteLine("Only the even elements");
            Console.WriteLine(String.Join("\t", query));

            string[] words = { "red", "green", "yellow", "purple", "gray", "blue" };
            *//*var res = from word in words
                      where word.Length == 4
                      select word;*//*

            var res = words.Where(word => word.Length == 4);
            int count = 0;
            foreach (var word in res)
            {
                Console.WriteLine($"{++count}. {word}");
            }*/


            // Order by
            int[] arr = { 5, 34, 67, 12, 94, 42 };
            var query = from i in arr
                        where i %2 ==0
                        orderby i // abc
                        select i;

            Console.WriteLine("Even elements ascending");
            foreach(var i in query)
            {
                Console.Write($"{i,-10}");
            }
            Console.WriteLine();


            var res = arr.Where(i => i %2 ==0).OrderByDescending(i => Math.Abs(i));
            Console.WriteLine("Even elements Descending");
            foreach (var i in res)
            {
                Console.Write($"{i,-10}");
            }
            Console.WriteLine();

            // Group by
            TestGroupBy.Way1();
            TestGroupBy.Way2();

            // Into
            TestInto.Way1();

            //Let
            TestLet.Way1();

            //Join
            TestJoin.Way1();

            // Agregation
            TestAgregation.Way();

            // Sets
            TestSets.Way();
        }
        /*static int ConvertData(int item)
        {
            return item * -1;
        }*/
    }
}
