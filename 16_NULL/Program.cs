using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NULL
{
    class Contact
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        void Print()
        {
            Console.WriteLine($"Phone :: {Phone,-20} Email :: {Email}");
        }
        public string getContact()
        {
            return Phone == null || Email == null ? throw new Exception("Error Contact") : $"Phone :: {Phone,20} Email :: {Email}";
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Contact Contact { get; set; }

        public override string ToString()
        {
            return $"Name :: {Name,-10}, LastName :: {LastName,-10}, {Contact?.getContact()}";
        }
    }
    internal class Program
    {
        static int[] CreateArr(int count)
        {
            int[] arr = new int[count];
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rnd.Next(1, 15);
            }
            return arr;
        }
        static void Main()
        {
            // value typer --> int, double, bool, Struct,
            // reference   --> class, string, array 

            /*int a;

            int[] mas;
            string text = null;
            Console.WriteLine($"Test text  :: {text}");*/


            // ??
            // ?
            //string name = null;
            /*if(name == null)
            {
                Console.WriteLine($"Person :: NoName");
            }
            else
            {
                Console.WriteLine($"Person :: {name}");
            }*/
            /*Console.WriteLine($"Person :: {name??"Noname"}");*/
            /*int[] arr = null;
            arr = CreateArr(10);*/
            /*if(arr == null)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Sum elements :: " + arr.Sum());
            }*/

            //Console.WriteLine("Sum elements :: " + (arr?.Sum() ?? 0));

            /*Person person = new Person { Name = "Ivan", LastName = "Bondar", Contact = new Contact { Phone = "5555", Email = "hfh@gmail.com"} };
            //Person person = null;
            Console.WriteLine(person?.ToString());
            string res = person?.Contact?.getContact() ?? "NoInfo";
            Console.WriteLine("Result :: " + res);*/


            /*Nullable<int> age = null;
            //int? age = null;
            DateTime? birthday = null;

            age = 12;
            if(age.HasValue) {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("Error age = null");
            }*/

        }
    }
}
