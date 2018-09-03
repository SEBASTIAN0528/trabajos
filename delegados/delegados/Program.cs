using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace delegados
{
    public delegate void operacion(int a, int b);

    class Program
    {

         static void Main(string[] args)
        {
           

            operacion mul = new operacion(Mult);
            mul += Divi;

            int N1;
            int N2;
            int op;

            Console.WriteLine("Hola!!!");
            Console.WriteLine("Escribe el primer numero");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el segundo numero");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el numero de la operacion \n 1.suma y resta \n 2.multiplicacion y division");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op){
                case 1:
                    mas(N1, N2);
                    break;

                case 2:
                    mul(N1, N2);
                    break;
            }
        }

        public static void Suma(int a, int b)
        {
            Console.WriteLine("Ejecutando Suma");
            int re = a + b;
            Console.WriteLine("El resultado de la suma es: " + re);
            Console.ReadKey();

        }

        public static void Resta(int a, int b)
        {
            Console.WriteLine("Ejecutando Resta");
            int re = a - b;
            Console.WriteLine("El resultado de la resta es: " + re);
            Console.ReadKey();
        }

        public static void Mult(int a, int b)
        {
            Console.WriteLine("Ejecutando multiplicacion");
            int re = a * b;
            Console.WriteLine("El resultado de la multiplicacion es: " + re);
            Console.ReadKey();
        }

        public static void Divi(int a, int b)
        {
            Console.WriteLine("Ejecutando division");
            int re = a / b;
            Console.WriteLine("El resultado de la divicion es: " + re);
            Console.ReadKey();
        }
    }
}
