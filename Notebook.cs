using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43
{
    public struct Notebook
    {
        public string model;
        public string brand;
        public double price;

        public Notebook(string model, string brand, double price)
        {
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Модель: {model}, Производитель: {brand}, Цена: {price}";
        }
    }
}
