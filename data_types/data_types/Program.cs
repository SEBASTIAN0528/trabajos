using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 28;
            double num2 = 28.5;
            Boolean status = true;
            string hello = "Hello, data types: ";
            string nombre = "Sebas";

            Console.Write(hello + "int = " + num+ ", double = "+ num2+
                ", boolean = "+ status+" and string = "+nombre);

            Console.ReadKey();
        }
    }
}
