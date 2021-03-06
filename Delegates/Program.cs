﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Message with delegate");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(MyClass.Method);

            del.Invoke();

            del();

            Console.ReadKey();
        }
    }
}
