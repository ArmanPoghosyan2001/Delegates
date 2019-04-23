using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Delegates
{
    public delegate void MyDelegate(int argument);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate my = null;

            my = (int i) =>
            {
                 i--;
                 Console.WriteLine($"Begin {i}");

                 if (i > 0)
                 {
                     my(i);
                 }

                 Console.WriteLine($"End {i}");
            };

            my(3);

            Console.ReadKey();
        }
    }
}
