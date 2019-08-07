using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ClaseDeVariables
{
    class Program
    {
        //Defindiendo la clase del numero entero
        public static int numero()
        {
            int valor = 2018;
            return valor;
        }
        //Defindiendo la clase del texto
        public static string texto()
        {
            string valor = " Txt ";
            return valor;
        }
        //Defindiendo la clase de la variable boleana
        public static bool booleano()
        {
            bool valor = true;
            return valor;
        }
        static void Main(string[] args)
        {
            //Mostrando valores
            Console.WriteLine(numero());
            Console.WriteLine(texto());
            Console.WriteLine(booleano());
            Console.ReadLine();
        }
    }
}
