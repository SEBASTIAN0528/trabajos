using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;

            switch (a)
            {
                case 1: Console.WriteLine("value is 1");
                    break;
                case 2:
                    Console.WriteLine("value is 2");
                    break;
                default: Console.WriteLine("value is different");
                    break;
            }
            Console.ReadKey();
        }
    }
}
