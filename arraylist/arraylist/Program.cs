using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nombre = new ArrayList();

            nombre.Add("sebastian");
            nombre.Add("ibague");
            nombre.Add(17);
            nombre.Add(false);

            Console.WriteLine(nombre[0]);
            Console.WriteLine(nombre[1]);
            Console.WriteLine(nombre[2]);
            Console.WriteLine(nombre[3]);

            Console.ReadKey();

        }
    }
}
