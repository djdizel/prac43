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
            //Экземпляр класса и структуры
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            Console.WriteLine("До вызова методов");
            //Вывод значений полей
            myClass.change = "не изменено";
            myStruct.change = "не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.WriteLine("После вызова методов");
            //Инициализация полей
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
        }
        /// <summary>
        /// Метод, принимающий объект класса и принимает поле change
        /// </summary>
        /// <param name="myClass"></param>
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        /// <summary>
        /// Метод, принимающий объект структуры и принимает поле change
        /// </summary>
        /// <param name="myStruct"></param>
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
