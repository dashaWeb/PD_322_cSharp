using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Linq_to_object
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name : {Name}, Age : {Age}";
        }
    }
    class TestAgregation
    {
        public static void Way()
        {
            // Sum, Min, Max, Average -------------
            int[] number = { 1, 2, 3, 4, 10, 34, 58, 56, 77, 102 };
            List<User> list = new List<User>()
            {
            new User(){ Name = "Pasha",Age = 23},
            new User(){ Name = "Sasha",Age = 43},
            new User(){ Name = "Oleg",Age = 35},
            };

            int sumNum = number.Sum();
            int sumUser = list.Sum(user => user.Age);
            Console.WriteLine($"Test array numbers :: {string.Join("\t",number)}");
            Console.WriteLine("Sum numbers :: " + sumNum);
            Console.WriteLine($"Test array Users ::\n {string.Join<User>("\n\t",list)}");
            Console.WriteLine("Sum users age :: " + sumUser);
            Console.WriteLine("Min users age :: " + list.Min(i => i.Age));
            Console.WriteLine("Max users age :: " + list.Max(i => i.Age));
            Console.WriteLine("Avg users age :: " + list.Average(i => i.Age));



        }
    }
}
