using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4IfEnClases
{
    class Program
    {
        //cREANDO Clase Nacion
        public static string Nacion(string n)
        {
            string valor = " Txt ";
            //Comprobando le valor especificado
            if (n == "USA")
            {
                valor = "Estado Unidense ";
            }
            else if (n == "LA")
            {
                valor = "Latino Americano";
            }
            else
            {
                valor = "Ninguno";
            }
            
            return valor;
        }

        static void Main(string[] args)
        {
            //Especificando el valor
            Console.WriteLine("Eres de USA O LA");
            string N = Console.ReadLine();

            if(Nacion(N)!="Ninguno")
            {
                Console.WriteLine("Eres {0}",Nacion(N));
            }
            else
            {
                Console.WriteLine("Error escribio: {0}",N);
            }
            
            Console.ReadLine();

        }
    }
}
