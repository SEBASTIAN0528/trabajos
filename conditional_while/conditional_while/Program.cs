using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 10;

            while (i < j)
            {
     
                Console.WriteLine(i);
                i = i+1;
            }

            Console.ReadKey();
        }
    }
}
