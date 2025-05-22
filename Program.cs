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
            Notebook notebook = new Notebook();
            Console.WriteLine("Введите модель ноутбука");
            notebook.model = Console.ReadLine();
            Console.WriteLine("Введите марку ноутбука");
            notebook.brand = Console.ReadLine();
            Console.WriteLine("Введите цену ноутбука");
            notebook.price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(notebook.ToString());
        }
    }
}
