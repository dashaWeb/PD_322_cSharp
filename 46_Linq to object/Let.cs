using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    internal class TestLet
    {
        public static void Way1()
        {
            string[] text = {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "Nunc mollis risus sed arcu malesuada, in lacinia nisi commodo.",
                "Phasellus finibus est non aliquet lacinia.",
                "Donec iaculis nisi id purus suscipit lobortis.",
                "In eleifend ante quis viverra laoreet.",
            };
            var query = from t in text
                        let words = t.Split(' ',',','.')
                        from w in words
                        where w.Count() > 5
                        select w;
            Console.WriteLine("Words in which more than 5 characters");
            foreach (var word in query)
            {
                Console.WriteLine("\t"+word);
            }
            Console.WriteLine();

            /*var q = text.SelectMany(w => w.ToArray());
            foreach (var word in q)
            { Console.Write(word + " "); }*/

            var q = text.SelectMany(w => w.Split(' ',',','.')).Where(i => i.Length > 5);
            Console.WriteLine("Words in which more than 5 characters");
            foreach (var word in q)
            {
                Console.WriteLine("\t" + word);
            }
            Console.WriteLine();
        }
    }
}
