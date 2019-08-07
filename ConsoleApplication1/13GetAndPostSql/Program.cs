using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Web;

namespace _13GetAndPostSql
{

    class Program
    {
        private static string conexion
        {
            //Especificando datos de conexion    Nombre del servidor/PC                  nombre de la tabla 
            get
            {
                return "data source=WINDOWS-1HTKO0B\\MSSQLSERVER4;initial catalog=alola;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework";
            }

         }
        public static DataTable xGetFromSQL(string xSql)
        {
            try
            {
                DataTable xDT = new DataTable();
                using (SqlDataAdapter xDA = new SqlDataAdapter(xSql, conexion))
                {
                    xDA.SelectCommand.CommandTimeout = 600000;
                    xDA.Fill(xDT);
                }

                return xDT;
            }
            catch { throw; }
        }

        public static void xPOSTToSQL(string xSQL)
        {
            using (SqlCommand xCommand = new SqlCommand(xSQL, new SqlConnection(conexion)))
            {
                xCommand.Connection.Open();
                xCommand.ExecuteNonQuery();
                xCommand.Connection.Close();
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ejecutando xGetFromSQL c# ");
            Console.WriteLine(String.Format("{0}", xGetFromSQL("  select prueba from prueba where id =5").Rows[0][0].ToString()));

            Console.WriteLine("Ejecutando xPOSTToSQL c# ");
            Console.WriteLine(String.Format("{0}", xGetFromSQL("  update prueba set prueba ='Fin' where id =5")));

            Console.WriteLine("Ejecutando xGetFromSQL c# ");
            Console.WriteLine(String.Format("{0}", xGetFromSQL("  select prueba from prueba order by id").Rows[0][0].ToString()));


            Console.ReadLine();
        }
    }
}
