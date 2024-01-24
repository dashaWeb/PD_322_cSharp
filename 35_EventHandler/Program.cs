using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company softServe = new Company { Name = "SoftServe" };
            Company honeyComb = new Company { Name = "HoneyComb" };



            Interviwer ann = new Interviwer { Name = "Ann" };
            Interviwer ivan = new Interviwer { Name = "Ivan" };

            // subscribe
            softServe.NewPosition += ann.DoSomething;
            softServe.NewPosition += ivan.DoSomething;

            honeyComb.NewPosition += ann.DoSomething;
            honeyComb.NewPosition += ivan.DoSomething;
            // honeyComb.NewPosition = ivan.DoSomething; error if event


            softServe.AddPosition("Intern C++");
            Console.WriteLine();
            honeyComb.AddPosition("Junior .NET");
            Console.WriteLine();

            honeyComb.NewPosition -= ann.DoSomething;
            //honeyComb.NewPosition = null; //error if event
            honeyComb.AddPosition("Middle Frontend");
            Console.WriteLine();

            
        }
    }
}
