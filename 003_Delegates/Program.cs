﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Delegates
{
    class MyClass
    {
        public string Method(string name)
        {
            return "Hello" + name;
        }
    }

    public delegate string MyDelegate(string name);

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method);

            string greeting = myDelegate.Invoke("Jeffrey Richter");

            Console.WriteLine(greeting);

            greeting = myDelegate("Arman");

            Console.WriteLine(greeting);


            Console.ReadKey();

        }
    }
}
