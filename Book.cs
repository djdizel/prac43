using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43
{
    public struct Book
    {
        public string name;
        public string author;
        public int year;
        public int pages;

        public Book(string name, string author, int year, int pages)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        public override string ToString()
        {
            return $"Название: {name}, Автор: {author}, Год издания: {year}, Колво страниц: {pages}";
        }
    }
}
