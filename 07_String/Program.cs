using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _07_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.String text = "test line";
            /*string line = "lorem ipsun dolor"*/;
            StringBuilder line = new StringBuilder();
            Console.WriteLine($"Size :: {line.Length,10}, Capacity {line.Capacity}");
            line.Append("lorem ipsun dolor IPSUN IPSUN IPSUN");
            Console.WriteLine($"Size :: {line.Length,10}, Capacity {line.Capacity}");
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = Char.ToUpper(line[i]);
            }
            Console.WriteLine(line);
            var word = line.Remove(0, 5);
            Console.WriteLine(word);
            Console.WriteLine(line);
            line.Replace("IPSUN", "test");
            Console.WriteLine(line);

            char[] arrCh = text.ToCharArray();

            //string str = new string(arrCh);
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec neque mattis, efficitur leo at, congue risus. Ut justo ex, posuere in porttitor nec, dapibus quis nisl";
            string wordd = "Lorem";
            Console.WriteLine(str);
            Console.WriteLine($"Contains :: {wordd} :: {str.Contains(wordd)}");
            Console.WriteLine($"IndexOf :: {wordd} :: {str.IndexOf(wordd)}"); // -1 not found
            Console.WriteLine($"StartsWith :: {wordd} :: {str.StartsWith(wordd)}");
            Console.WriteLine($"EndsWith :: {"l"} :: {str.EndsWith("l")}");

            string letters = "is";
            int index = 0;
            while (true)
            {
                index = str.IndexOfAny(letters.ToCharArray(),index);
                if (index != -1)
                {
                    Console.WriteLine($"Index of first from '{letters}' :: {index}. \t Letter :: {str[index]}");
                    index++;
                }
                else
                {
                    Console.WriteLine("Not found");
                    break;
                }
            }
            string one = "Apple", two = "Apricot";
            Console.WriteLine($"{one} == {two} : {one == two}");
            Console.WriteLine($"{one} .CompareTo {two} : {one.CompareTo(two)}");

            two = "apple";
            Console.WriteLine($"{one} .CompareTo {two} : {one.CompareTo(two)}");
            Console.WriteLine($"{one} .String.CompareOrdinal {two} : {String.CompareOrdinal(one,two)}");
            Console.WriteLine($"{one} .String.Compare {two} : {String.Compare(one, two,true)}");
            string html = "Hyper text markup language";
            Console.WriteLine("Origin line :: " + html);
            Console.WriteLine($"html.Remove :: {html.Remove(5)}");
            Console.WriteLine($"html.Remove :: {html.Remove(5,2)}");
            Console.WriteLine($"html.Remove :: {html.Replace('a','*')}");
            Console.WriteLine($"html.Remove :: {html.Insert(5,"new text")}");
            Console.WriteLine($"html.Remove :: {html.Substring(5,5)}");
            string phone = "(+380)96-452-12-59";
            string[] numberPhone = phone.Split("-()+".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            /*foreach (var item in numberPhone)
            {
                Console.WriteLine(item);
            }*/
            Console.WriteLine(String.Join("\t",numberPhone));

        }
    }
}
