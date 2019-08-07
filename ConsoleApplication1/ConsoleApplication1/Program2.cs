using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program2
    {
        public static int points=0;
        public static int AddPoints(int pointsToAdd = 1)
        {
            points += pointsToAdd;
            return points;
        }

        public static void Main3(string[] args)
        {          

        Console.WriteLine("alola2");      

        int point = 4;
        int newP = AddPoints(pointsToAdd:point);


        Console.ReadLine();

        }
              
    }
}
