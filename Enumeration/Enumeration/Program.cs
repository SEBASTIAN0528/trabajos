using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        enum months { January, February, March, April, May, June, July, August, Septemberp, Octobe, November, December };
        
        static void Main(string[] args)
        {
            Console.Write("the month of the indenpendence of colombia is : " + months.July);

            Console.ReadKey();
        }
    }
}
