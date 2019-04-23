using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Delegates
{
    public delegate void MyDel();

    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main(string[] args)
        {
            MyDel myDel = null;

            MyDel myDel1 = new MyDel(Method1);
            MyDel myDel2 = new MyDel(Method2);
            MyDel myDel3 = new MyDel(Method3);

            myDel = myDel1 + myDel2 + myDel3;
            bool quit = true;
            while (quit)
            {
                Console.WriteLine("Write any number from 1 to 7 or exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            myDel1.Invoke();
                            break;
                        }
                    case "2":
                        {
                            myDel2.Invoke();
                            break;
                        }
                    case "3":
                        {

                            myDel3.Invoke();
                            break;
                        }
                    case "4":
                        {
                            MyDel myDel4 = myDel - myDel1;
                            myDel4.Invoke();
                            break;
                        }
                    case "5":
                        {
                            MyDel myDel4 = myDel - myDel2;
                            myDel4.Invoke();
                            break;
                        }
                    case "6":
                        {
                            MyDel myDel4 = myDel - myDel3;
                            myDel4.Invoke();
                            break;
                        }
                    case "7":
                        {
                            myDel.Invoke();
                            break;
                        }
                    case "exit":
                        {
                            quit = false;
                            break;
                        }
                }
            }
        }
    }
}
