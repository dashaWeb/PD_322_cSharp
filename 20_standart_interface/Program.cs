using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_standart_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ann = new Student("Ann",7,8,9,10,11,12);
            ann.Age = 12;
            Student vasil;


            //vasil = (Student)ann.Clone();
            vasil = ann.Clone() as Student;

            vasil.Name = "Vasil";
            vasil[0] = 1;
            vasil.Age = 15;
            Console.WriteLine($"Student (Ann){ann.Age}   Name ---> :: {ann}");
            Console.WriteLine($"Student (Vasil){vasil.Age} Name ---> :: {vasil}");
            
        }
    }
}
