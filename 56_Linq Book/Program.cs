using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Linq_Book
{

    class Book
    {
        public enum CategoryBook { Cooking = 1, Children, Web, NET};
        public string  Author { get; set; }
        public string  Title { get; set; }
        public CategoryBook  Category { get; set; }
        public uint Year { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Author,-20}{Title,-30}{Category.ToString(),-10}{Year,-6}{Price}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book{Title = "Web Development", Author = "Aki Iskandar ", Category = Book.CategoryBook.Web, Year = 2019, Price=39.99f },
                new Book{Title = "Bootstrap 4 ", Author = "Jacob Lett", Category = Book.CategoryBook.Web, Year = 2018, Price=31.5f },
                new Book{Title = "Professional C# 7 ", Author = "Christian Nagel ", Category = Book.CategoryBook.NET, Year = 2018, Price=60.0f },
                new Book{Title = "Pro C# 7: With .NET", Author = "Andrew Troelsen", Category = Book.CategoryBook.NET, Year = 2017, Price=39.0f },
                new Book{Title = "C# 7.0 in a Nutshell", Author = "Jozeph Albahari", Category = Book.CategoryBook.NET, Year = 2017, Price=79.99f },
                new Book{Title = "harry Potter", Author = "Rowling", Category = Book.CategoryBook.Children, Year = 2017, Price=19.99f }

            };

            var res_1 = from book in books 
                        where book.Year <=2018
                        orderby book.Author descending
                        select book;
            //select book.Title
            Console.WriteLine($"Origin list :: \n{string.Join<Book>("\n", books)}");
            Console.WriteLine();
            Console.WriteLine(string.Join<Book>("\n",res_1));

            //var maxPrice = (from b in books select b).Max(x => x.Price);            
            var maxPrice = books.Max(x => x.Price);
            Console.WriteLine($"MAx price :: {maxPrice}");

            var res_2 = books.Where(b => b.Category == Book.CategoryBook.NET).OrderBy(b => b.Author);
            Console.WriteLine("\n Books of NET - category");
            Console.WriteLine(string.Join<Book>("\n",res_2));

            Console.WriteLine();
            var res_3 = from b in books group b by b.Category;
            foreach (var item in res_3)
            {
                Console.WriteLine($"_______{item.Key}_______ Count {item.Count()} ___ Max Price {item.Max(x=>x.Price)}");
                foreach (var book in item)
                {
                    Console.WriteLine(book);
                }
            }

            // Employee (name, age, salary)
            // Створити список працівників
            // 1) вибрати тільки працівників, їх іменах і зп
            // 2) вибрати працівників який мають вік більше 30 та впорядкувати за спаданням віку
            // 3) Знайти середній вік працівників
            // 4) додати до класу посаду(рядок або enum) Згрупувати працівників за посадами

        }
    }
}
