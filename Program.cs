using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Book
    {
        public string avtor;
        public string nazvanie;
        public int stranits;
        public bool collection;
        public Book()
        {
            avtor = "Null";
            nazvanie = "Null";
            stranits = 0;
            collection = false;
        }
        public Book(string avtor, string nazvanie, int stranits, bool collection)
        {
            this.avtor = avtor;
            this.nazvanie = nazvanie;
            this.stranits = stranits;
            this.collection = collection;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book();
            Book bk_1 = new Book("Анджей Сапковский", "Wither", 318, false);
            Console.WriteLine("Автор: " + bk_1.avtor);
            Console.WriteLine("Название: " + bk_1.nazvanie);
            Console.WriteLine("Страницы: " + bk_1.stranits);
            Console.WriteLine("Коллекционное издание: " + bk_1.collection);
            Console.ReadKey();
        }
    }
}
