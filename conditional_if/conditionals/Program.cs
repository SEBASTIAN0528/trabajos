using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("the value is: " + a);
            if (a < 10)
            {
                Console.WriteLine("value is less than 10");
            } else
            {
                Console.WriteLine("value is greater than 10");
            }

            Console.ReadKey();
        }
    }
}
