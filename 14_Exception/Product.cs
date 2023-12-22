using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception
{
    internal class Product
    {
        string name;
        int price;
        DateTime dateIn;
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name must be not null or writespace");
                }
                if (!value.All(c => Char.IsLetter(c)))
                {
                    Exception ex = new Exception("Bad name : must has all letters");
                    ex.Data.Add("Value", value); // ex.Data - колекція даних(пар : кд.ч та значення);
                    ex.Data.Add("TimeStamp", DateTime.Now);
                    throw ex;
                }
                name = value;
            }
        }
        public DateTime DateIn
        {
            get => dateIn;
            set => dateIn = value <= DateTime.Now ? value : throw new BadProductException("Error date of product", value);
        }
        public void InputName()
        {
            while (true)
            {
                Console.WriteLine("Input product name : ");
                string input = Console.ReadLine();
                try
                {
                    Name = input;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
            }

        }
    }
}
