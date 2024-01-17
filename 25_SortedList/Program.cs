using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList color = new SortedList()
            {
                {9,"red"},
                {7,"blue"},
                {3,"green"},
                {4,"pink"},
                //{4.5,"pink"}, // exception
            };

            Print(color, "\nPrint Sorted List :: ");

            color[1] = "black";
            color[3] = "brown";
            Print(color, "\nPrint Sorted List :: ");

            int index = 7;
            /*if (!color.ContainsKey(index))
            {
                color.Add(2, "gold");
            }
            else
            {
                Console.WriteLine("Bad key");
            }*/

            try
            {
                color.Add(index, "gold");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message} {index}");
            }

            Print(color, "\nPrint Sorted List :: ");

            color.Remove(index);
            Print(color, "\nPrint Sorted List :: ");
            color.RemoveAt(0);
            Print(color, "\nPrint Sorted List :: ");
            var res = color.GetValueList();
            foreach (var item in res)
            {
                Console.WriteLine($"{item}");
            }

            string value = (string)color.GetByIndex(0);
            Console.WriteLine($"{value}");

            Console.WriteLine($"\n\n{new string('=',40)}\n\n");
            SortedList<string, string> HEX = new SortedList<string, string>()
            {
                ["Red"] = "#FF0000",
                ["black"] = "#000000",
                ["white"] = "#FFFFFF",
                ["gray"] = "#CCCCCC"
            };
            Print(HEX, "Print SortedLIst Generics");
        }

        static void Print(IDictionary dictionary, string text = "")
        {
            Console.WriteLine(text);
            foreach (DictionaryEntry item in dictionary)
            {
                Console.WriteLine($"[{item.Key}] = {item.Value}");
            }
        }
    }


}
