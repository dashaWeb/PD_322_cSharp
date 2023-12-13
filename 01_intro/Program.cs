using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_intro
{
    internal class Program
    {
        static void ReadChar()
        {
            int res = Console.Read();
            Console.WriteLine(res);

        }
        static void ReadText()
        {
            string text = Console.ReadLine();
            Console.WriteLine(text);
        }
        static void convertString()
        {

            // way 1
            /*Console.Write("Enter number :: ");
            string text = Console.ReadLine();
            double res = Convert.ToDouble(text);
            res = res + 10;
            Console.WriteLine("Result :: " + res);*/
            // way 2
            /*Console.Write("Enter number :: ");
            string text = Console.ReadLine();
            int res = int.Parse(text);
            res = res + 10;
            Console.WriteLine("Result :: " + res);*/
            //way 3
            /*Console.Write("Enter number :: ");
            string text = Console.ReadLine();
            int res;
            if (int.TryParse(text, out res))
            {
                res = res + 10;
                Console.WriteLine("Result :: " + res);
            }
            else
            {
                Console.WriteLine("Error value");
            }*/
        }
        static void Main(string[] args)
        {

            //TestConsole();
            //ReadChar();
            //ReadText();
            //convertString();
            /*
            if(){}
            else if(){}
            else{}
             */
            /*int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                case 3:
                    Console.WriteLine("Monday");
                    //goto case 2;
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }*/
            /*int i = 1;
            for (; ; )
            {
                i++;
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("End :: " + i);*/
            /*int i = 0;
            while (i < 10)
            {
                i++;
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/
            /*int res;
            do
            {
                Console.Write(" 2 + 2 = ");
                res = int.Parse(Console.ReadLine());
            } while (res != 4);*/
            // +,-,*,/,%
            // ==,>,<,>=,<=,!=
            // +=, -=, *=, /=, %=;
            // a++, --b;
            // +,-,!
            /*int a = 5;
            Console.WriteLine(a > 2 ? "True..." : "False");*/

            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                switch (key.Key) {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                }
                key = Console.ReadKey();
            }


        }
        static void TestConsole()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine("Hello World");
            Console.ResetColor();
            int number = 22;
            double number_f = 2.5;
            char s = 'A';

            Console.WriteLine("Number int :: " + number + "\n\n\t\a\v");
            Console.WriteLine("number ::{0}  s :: {1}, test_number {0} ", number, s);
            Console.WriteLine($" Number :: {number,20} \n number double :: {number_f,15} \n char :: {s,-20}, test");
        }
    }
}
