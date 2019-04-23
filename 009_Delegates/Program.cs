using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); };

            myDelegate += () => { Console.WriteLine("Hello 2"); };

            myDelegate += () => Console.WriteLine("Hello 3");

            myDelegate();

            Console.ReadKey();
        }
    }
}