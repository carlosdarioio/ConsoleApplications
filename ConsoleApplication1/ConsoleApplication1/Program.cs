using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int points=0;
        public static int AddPoints(int pointsToAdd = 1)
        {
            points += pointsToAdd;
            return points;
        }

        public static void Main(string[] args)
        {          

        Console.WriteLine("alola");      

        int point = 4;
        int newP = AddPoints(pointsToAdd:point);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=WINDOWS-1HTKO0B\\MSSQLSERVER4;initial catalog=alola;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework";
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM prueba", conn);
            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    Console.WriteLine(String.Format("{0} | {1} ",
                    // call the objects from their index
                    reader[0], reader[1]));
                }
            }



            conn.Close();
            conn.Dispose();
            Console.ReadLine();

        }

      
    }
}
