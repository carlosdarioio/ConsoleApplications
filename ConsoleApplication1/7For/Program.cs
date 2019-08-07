using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7For
{
    class Program
    {
        public static void Multiplicacion(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
            } 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Especificar Numero ");
            int N = int.Parse(Console.ReadLine());
            Multiplicacion(N);
            Console.ReadLine();
        }
    }
}
