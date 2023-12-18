using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Static_field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started ...");
            Console.WriteLine($"Last id : {Employee.LastId}");
            Employee emp1 = new Employee() { Name = "Denis", Birth = DateTime.Parse("30/10/1990"), Position = Position.Director };
            Console.WriteLine(emp1);
            Console.WriteLine($"Age : {emp1.Age}");

            Employee emp2 = new Employee()
            {
                Name = "Ivan",
                Birth = new DateTime(2000, 9, 16),
                Position = Position.Director
            };
            Console.WriteLine(emp2);
            Console.WriteLine($"Age : {emp2.Age}");

            Console.WriteLine($"Same position : {Employee.SamePosition(emp1,emp2)}");
            
        }
    }
}
