using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            books[0] = new Book("Война и мир", "Лев Толстой", 1869, 1225);
            books[1] = new Book("1984", "Джордж Оруэлл", 1949, 328);
            books[2] = new Book("Убить пересмешника", "Харпер Ли", 1960, 281);
            for(int i =0; i<books.Length; i++)
            {
                Console.WriteLine("1-3 - информация о книгах \n0 - Выход");
                int index = Convert.ToInt32(Console.ReadLine());
                if (index == 0)
                    break;
                else if (index < 1 || index > 3)
                    Console.WriteLine("Некорректный номер книги.");
                else
                    Console.WriteLine(books[index - 1].ToString());
            }
        }
    }
}
