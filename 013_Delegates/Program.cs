using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Delegates
{
    class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Something");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = MyClass.Method;
            myDelegate();

            Console.ReadKey();
        }
    }
}
