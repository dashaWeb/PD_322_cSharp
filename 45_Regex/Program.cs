using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _45_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Спец символи
                \d = визначає символ цифри
                \D = визначає символ крім цифри цифри
                \w = визначая будь-який символ цифри, букви, знака підкреслення
                \W = визначая будь-який символ крім цифри, букви, знака підкреслення
                \s = визначає будь-який не друкований символ і пробіл
                \S = визначає будь-який символ, крім символа табуляції, нового рядка, каретки
                .  = визначає будь-який символ крім символа нового рядка
                \. = визначає символ крапка 
             */
            { /////////////////////// Example 1
                /*string pattern = @"\d";
                var regex = new Regex(pattern);
                while (true)
                {
                    string symbol = Console.ReadKey().KeyChar.ToString();
                    if (symbol == " ")
                    {
                        break;
                    }
                    Console.WriteLine($"  is digit :: {regex.IsMatch(symbol)}");
                }*/
            }

            { /////////////////////// Example 2
                /*string pattern = @"\D";
                var regex = new Regex(pattern);
                var array = new[] { "test", "123", "test123test", "123test", "test123", "123test123" };

                foreach (var line in array)
                {
                    Console.WriteLine(regex.IsMatch(line)
                        ? $"String '{line}' matched '{pattern}'"
                        : $"String '{line}' NOT matched '{pattern}'");
                }

                pattern = @"[A-Z][a-z]*$";
                regex = new Regex(pattern);

                Console.WriteLine("\n\n");
                while (true)
                {
                    Console.WriteLine("Enter line");
                    string input = Console.ReadLine();
                    if (input == "exit")
                        break;

                    Console.WriteLine(input != null && regex.IsMatch(input)
                         ? $"String '{input}' matched '{pattern}'"
                         : $"String '{input}' NOT matched '{pattern}'");
                    Console.WriteLine(new string('=',50));
                }*/
                { /////////////////////// Example 3
                    string pattern;

                    //pattern = @"\d+";  // "123","test123test", "123test", "test123", "123test123"
                    //pattern = @"^\d+"; // "123", "123test", "123test123"
                    //pattern = @"\d+$"; // "123","test123", "123test123" 
                    //pattern = @"^\d+$"; // "123"
                    pattern = @"^\d+\D+\d+$"; // "123test123"
                    var regex = new Regex(pattern);
                    var array = new[] { "test", "123", "test123test", "123test", "test123", "123test123" };

                    foreach (var line in array)
                    {
                        Console.WriteLine(regex.IsMatch(line)
                        ? $"String '{line}' matched '{pattern}'"
                        : $"String '{line}' NOT matched '{pattern}'");
                    }
                    Console.WriteLine("\n\n");

                    string value = "4 - 5 AND 5 y 789";
                    Match match= Regex.Match(value, @"\d+");

                    /*if(match.Success)
                    {
                        Console.WriteLine($" Value :: {match.Value,-15} Index :: {match.Index,-15} Length :: {match.Length}" );
                    }
                    match = match.NextMatch();
                    if (match.Success)
                    {
                        Console.WriteLine($" Value :: {match.Value,-15} Index :: {match.Index,-15} Length :: {match.Length}");
                    }*/
                    while (match.Success) {
                        Console.WriteLine($" Value :: {match.Value,-15} Index :: {match.Index,-15} Length :: {match.Length}, Name :: {match.Name,-15}");
                        match = match.NextMatch();
                    }

                    Console.WriteLine("\n\n");

                    Match m = Regex.Match("123 Axx-1xxy \n Axyx-2-xyxy", @"A.*y");
                    while (m.Success)
                    {
                        Console.WriteLine($"Value  :: {m.Value}");
                        Console.WriteLine($"Index  :: {m.Index}");
                        Console.WriteLine($"Length :: {m.Length}");
                        m = m.NextMatch();
                    }


                    value = "saidsaid said she she see spear super spread";
                    MatchCollection matches = Regex.Matches(value, @"s\w+d");
                    Console.WriteLine(value);
                    foreach (Match item in matches)
                    {
                        Console.WriteLine($"Index :: {item.Index}, Value :: {item.Value}, Length :: {item.Length}");
                    }

                    string input = "Dont replace Dot N.t replaced Net NET dOt";
                    string output = Regex.Replace(input, @"N.t|Net", "NET");
                    Console.WriteLine(input);
                    Console.WriteLine(output);

                    // +38(067) - 45 - 54 - 124
                    string text = "blabla ttdgh gjgj 456987521 test 214587963 as 124785965";
                    //var res = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})", "+38(0$1)-$2-$3-$4");
                    var res = Regex.Replace(text, @"\d{9}", num => String.Format("{0:+38(0##)-##-##-###}",Convert.ToInt64(num.Value)));
                    Console.WriteLine(text);
                    Console.WriteLine(res);

                    pattern = @"dot";
                    var regs = new Regex(pattern,RegexOptions.IgnoreCase);
                    Console.WriteLine(regs.IsMatch(input));

                    var gg = regs.Matches(input);
                    foreach (Match item in gg)
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }
        }
    }
}
