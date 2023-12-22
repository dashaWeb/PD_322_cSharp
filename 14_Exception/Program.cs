using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception
{
    internal class Program
    {
        /*// exapmle 1
        static int DivisionNumbers(int n1, int n2) {

            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException de)
            {
                throw new Exception("Filter check Exception");
            }
            return result;
        }*/
        // exapmle 2
        /*static int DivisionNumbers(int n1, int n2)
        {

            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            return result;
        }*/

        class MyClass
        {
            public void BadMethod()
            {
                Exception exception = new Exception("My Exception message");
                exception.HelpLink = "https://stackoverflow.com";
                exception.Data.Add("Exception", "Test exception");
                exception.Data.Add("Time invoke", DateTime.Now);
                exception.Data.Add("User name", "Dasha");
                throw exception;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                MyClass instance = new MyClass();
                instance.BadMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Member name       {ex.TargetSite}");
                Console.WriteLine($"Member class      {ex.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type       {ex.TargetSite.MemberType}");
                Console.WriteLine($"Method name       {ex.TargetSite.Name}");
                Console.WriteLine($"Message           {ex.Message}");
                Console.WriteLine($"Source            {ex.Source}");
                Console.WriteLine($"HelpLink          {ex.HelpLink}");
                Console.WriteLine($"Stack             {ex.StackTrace}");
                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key}, {item.Value}");
                }
            }


            /*// exapmle 1
            Console.WriteLine("Enter ywo numbers");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                result = DivisionNumbers(number1, number2);
                Console.WriteLine($"Result division numbers :: {result}");
            }
            catch(Exception e) when(e.InnerException != null)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*// exapmle 1
            Console.WriteLine("Enter two numbers");
            int number1, number2, result = 0;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                result = DivisionNumbers(number1, number2);
                Console.WriteLine($"Result division numbers :: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            // exapmle 1
            /*int[] a = new int[5];
            int n = 0;
            try // зовнішній блок
            {
                for (int i = -3; i  <=3; i++)
                {
                    try // внутрішній блок
                    {
                        a[n] = 100 / i;
                        Console.WriteLine(a[n]);
                        n++;
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Inside catch");
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("outside catch");
                Console.WriteLine(ex.Message);
            }*/


            /*Console.WriteLine("Next example");
            Console.ReadKey();
            Product product = new Product();
            try
            {
                product.Name = "bread";
                Console.WriteLine(product.Name);
                product.DateIn = new DateTime(2024, 12, 20);
            }
            catch (BadProductException ex)
            {
                Console.WriteLine($"Message error : {ex.Message}");
                Console.WriteLine($"Bad value(date) : {ex.ErrorDate}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message : {ex.Message}");
                if (ex.Data.Contains("Value"))
                {
                    Console.WriteLine($"Value     : {ex.Data["Value"]}");
                    Console.WriteLine($"TimeStamp : {ex.Data["TimeStamp"]}");
                }
                Console.WriteLine($"TargetSite : {ex.TargetSite}");
                foreach (var key in ex.Data.Keys)
                {
                    Console.WriteLine($"{key} ----- {ex.Data[key]}");
                }
            }
            product.InputName();
            Console.WriteLine(product.Name);*/
            /*int a, b;
            try
            {
                Console.Write("Enter first number : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
           *//* catch (DivideByZeroException ex)
            {

                Console.WriteLine($"Division by zero {ex.Message}");
            }*//*
            catch (ArgumentNullException ex)
            {

                Console.WriteLine($"ArgumentNullException {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception {ex.Message}");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Continue ... ");
            Console.ReadKey();*/
        }
    }
}
