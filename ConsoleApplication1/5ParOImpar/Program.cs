using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ParOImpar
{
    class Program
    {
        public static void ParOImpar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero introducido es par");
            }
            else
            {
                Console.WriteLine("El numero introducido es impar");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Especificar Numero1 ");
            int N = int.Parse(Console.ReadLine());
            ParOImpar(N);

            Console.WriteLine("Especificar Numero2 ");
            N = int.Parse(Console.ReadLine());
            ParOImpar(N);

            Console.ReadLine();

        }
    }
}
