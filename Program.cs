﻿using System;
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
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменено";
            myStruct.change = "не изменено";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
