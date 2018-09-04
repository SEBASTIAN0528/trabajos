using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ptutor = new Class1();
            ptutor.set(1, ".Net");
            Console.WriteLine(ptutor.get());
            Console.ReadKey();
        }
    }
}
