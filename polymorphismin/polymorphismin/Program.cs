using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismin
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ptutor = new Class1();
            ptutor.set(1, "sebastian");
            Console.WriteLine(ptutor.get());
            ptutor.set("ibague");
            Console.WriteLine(ptutor.get());

            Console.ReadKey();
        }
    }
}
