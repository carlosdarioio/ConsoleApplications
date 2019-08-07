using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ClaseConexionSQL
{
    class Program
    {
        public static string conexion()
        {
            //Especificando datos de conexion    Nombre del servidor/PC                  nombre de la tabla 
            return "data source=WINDOWS-1HTKO0B\\MSSQLSERVER4;initial catalog=alola;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Estableciendo conexion c# a sql 2010");
            //Creando variable de conexion
            SqlConnection conn = new SqlConnection();
            //Asignando conexion
            conn.ConnectionString = conexion();
            //Aperturando conexion
            conn.Open();
            //Creando comando sql
            SqlCommand command = new SqlCommand("SELECT * FROM prueba", conn);
            // Creando un lector sql para leer los datos del comando.
            using (SqlDataReader lector = command.ExecuteReader())
            {
                // mientras lector tenga texto
                while (lector.Read())
                {
                    // escribira los siguientes datos
                    Console.WriteLine(String.Format("osea {0} | {1} ",lector[0], lector[1]));
                }
            }


            //Cerrando conexion
            conn.Close();
            conn.Dispose();
            Console.ReadLine();
        }
    }
}
