using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SimbolosEnClases
{
    class Program
    {
        //Defindiendo la clase numero1
        public static int numero1()
        {
            int valor = 2018;
            return valor;
        }
        //Defindiendo la clase numero2
        public static int numero2()
        {
            int valor = 18;
            return valor;
        }
        //Defindiendo la clase del texto
        public static string texto()
        {
            string valor = " Txt ";
            return valor;
        }
        
        static void Main(string[] args)
        {
            //Mostrando valores
            Console.WriteLine(numero1() - numero2());
            Console.WriteLine(texto() + texto());
            Console.WriteLine(100*20/4);

            Console.ReadLine();
        }
    }
}
