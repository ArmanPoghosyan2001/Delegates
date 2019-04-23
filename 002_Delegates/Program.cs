using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Delegates
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Message with delegate");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            MyDelegate myDelegate = new MyDelegate(my.Method);

            myDelegate.Invoke();

            myDelegate();

            Console.ReadKey();
        }
    }
}
