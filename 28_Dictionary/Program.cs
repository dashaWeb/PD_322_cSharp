using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _28_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> names = new Dictionary<int, string>()
            {
                [6000] = "Ann",
                [6000] = "Petro",
                [3000] = "Ivan",
                [4000] = "Sasha",
                [1000] = "Max",
            };

            foreach(var name in names) {
                Console.WriteLine($"{name.Key, -10} {name.Value}");
            }

            names[7000] = "Alex";

            Console.WriteLine("\n\n");
            foreach (var name in names)
            {
                Console.WriteLine($"{name.Key,-10} {name.Value}");
            }

            if(!names.ContainsKey(2000)) {
                names.Add(2000, "Masha");
            }
            Console.WriteLine("\n\n");
            names.Remove(6000);
            names.Remove (10000);
            foreach (var name in names)
            {
                Console.WriteLine($"{name.Key,-10} {name.Value}");
            }

            SortedDictionary<int,string> tmp = new SortedDictionary<int,string>(names);
            Console.WriteLine("\n\n");
            foreach (var name in tmp)
            {
                Console.WriteLine($"{name.Key,-10} {name.Value}");
            }


            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            string text = "Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек." +
                " А це весела птиця-синиця. Яка часто краде пшеницю. Яка в темній комірці зберігається У будинку, Який побудував Джек.";
            string[] splitted = text.Split(new char[] { ' ', ',', '-', '.', '\n' },StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in splitted.Select(word => word.ToLower()))
            {
                dict[item] = dict.ContainsKey(item) ? dict[item] + 1 : 1;
            }

            int count = 0;
            Console.WriteLine($"\tWord:\t\tCount: ");
            foreach (var item in dict)
            {
                Console.WriteLine($"{++count}.\t{item.Key,-18}{item.Value} ");
            }
            Console.WriteLine();
        }
    }
}
