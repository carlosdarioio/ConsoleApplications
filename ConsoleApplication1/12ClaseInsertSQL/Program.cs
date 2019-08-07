using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ClaseInsertSQL
{
    class Program
    {
        public static string conexion()
        {
            //Especificando datos de conexion    Nombre del servidor/PC                  nombre de la tabla 
            return "data source=WINDOWS-1HTKO0B\\MSSQLSERVER4;initial catalog=alola;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework";
        }

        public static void VisualizarDatos()
        {
            Console.WriteLine("Mostrando datos de la tabla: ");
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
                    Console.WriteLine(String.Format("{0} | {1} ", lector[0], lector[1]));
                }
            }
            //Cerrando conexion
            conn.Close();
            conn.Dispose();
        }
        public static void Insertar(string name)
        {

            //Creando variable de conexion
            SqlConnection conn = new SqlConnection();
            //Asignando conexion
            conn.ConnectionString = conexion();
            //Aperturando conexion
            conn.Open();
            //Creando comando sql que inserta los datos de la tabla prueba
            SqlCommand command = new SqlCommand(String.Format("insert into prueba(prueba) values('{0}')",name), conn);
            // Creando un comprobante de la ejecucion sql para visualizar cuantos datos del comando fueron actualizados.
            int comprobante = command.ExecuteNonQuery();

            //Cerrando conexion
            conn.Close();
            conn.Dispose();
            //Si el comprobante es mayor que 0 es porque actualizo datos
            if (comprobante > 0)
            {

                Console.WriteLine("Ingresando datos ");
                VisualizarDatos();
            }
            else //de lo contrario
            {
                Console.WriteLine("Error ");
            }

        }
        static void Main(string[] args)
        {
            //Visualizando datos antes de efectuar la clase Insertar
            VisualizarDatos();            
            string nombre = "";
            //Comprobando que el datos especificado sea correcto
            try
            {
                Console.WriteLine("Especificar Nombre a Ingresar ");
                nombre = Console.ReadLine();
                //Si se especifico un numero se ejecutara la funcion borrar con el id establecido
                Insertar(nombre);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error especificar datos correctos " + e.ToString());
            }

            Console.ReadLine();
        }
    }
}
