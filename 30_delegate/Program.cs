using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_delegate
{
    delegate void DelegateMsg(string message);
    static class Messages
    {
        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public static void Bye(string name)
        {
            Console.WriteLine($"Bye {name}");
        }
        public static void HowAreYou(string name)
        {
            Console.WriteLine($"HowAreYou {name}");
        }
        public static void HowAreYou(string name, string surname)
        {
            Console.WriteLine($"HowAreYou {name}, {surname}");
        }
        public static void DrawLine(int number, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string('*', number));
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.HowAreYou("Alex"); // явний виклик
            Messages.DrawLine(50, ConsoleColor.Green);

            DelegateMsg del = new DelegateMsg(Messages.Hello);
            Console.WriteLine($"____ Delegate reference {del.Method}");
            Console.WriteLine($"____ Delegate target {del.Target}");

            Messages.DrawLine(50, ConsoleColor.Red);

            del.Invoke("Max");
            del("Pasha");

            Messages.DrawLine(50, ConsoleColor.Blue);
            DelegateMsg delgroup = Messages.Bye;
            delgroup += Messages.Hello;
            delgroup += Messages.HowAreYou;
            delgroup += Messages.HowAreYou;

            delgroup("Masha");

            Messages.DrawLine(50, ConsoleColor.Cyan);
            delgroup -= Messages.HowAreYou;
            delgroup("Dmytro");

        }
    }
}
