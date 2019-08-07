using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8WhilePotencia
{
    class Program
    {
        public static int Potencia(int Base,int Expo)
        {
            int p = 1;
            while (Expo>0)
            {
                p = p * Base;
                Expo --;
            }
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Potencia ");
            Console.WriteLine("Especificar Base ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Especificar Exponente ");
            int Ex = int.Parse(Console.ReadLine());
            Console.WriteLine("La potencia de {0} elevado al {1} es {2}",Base,Ex, Potencia(Base, Ex));
            Console.ReadLine();
            
        }
    }
}
