using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           sebasclass ptutor = new sebasclass();
            ptutor.rename(".Net by sebastian :v");
            Console.WriteLine(ptutor.get());
            Console.ReadKey();
        }
    }
}

