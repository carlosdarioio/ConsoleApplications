using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AnyoBisiesto
{
    class Program
    {
        public static void Calculando(int anyo) {
            if ((((anyo % 100) != 0) && ((anyo % 4) == 0)) || ((anyo % 400) == 0))
            {
                Console.WriteLine("El año es bisieto ");
            }
            else
            {
                Console.WriteLine("El año no es bisieto ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año ");
            int appletenhtml = int.Parse(Console.ReadLine());
            Calculando(appletenhtml);


            Console.ReadLine();

        }
    }
}
