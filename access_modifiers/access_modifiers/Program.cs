using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            access_modifiers pTutor = new access_modifiers();
            Console.WriteLine(pTutor.get());
            Console.ReadKey();
        }
    }
}
