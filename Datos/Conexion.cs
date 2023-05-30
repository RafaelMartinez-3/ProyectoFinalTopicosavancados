using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        private static string server = "localhost", user = "root", password = "root";
        public static bool Conectar(String servidor, string usuario, string pass)
        {

            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open) return true;

                MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
                build.Server = server;
                build.UserID = user;
                build.Password = password;
                build.Database = "northwind";
                conexion = new MySqlConnection(build.ConnectionString);
                conexion.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                /* 1049 Unknown database 
                 * 1045 Access denied for user (usuario y contraseña)
                 * 1042 Unable to connect to any of the specified MySQL hosts. (sevicio apagado o nombre
                 * de server no valido)
                 * 
                 * */
                Console.Write(ex.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return false;

            }
        }
        public void nuevaSesion(string host, string userr, string pass)
        {
            server = host;
            user = userr;
            password = pass;

        }
        public static bool Conectar()
        {

            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open) return true;

                conexion = new MySqlConnection();
                conexion.ConnectionString = "server=localhost;uid=root;pwd=root;database=northwind";
                conexion.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                /* 1049 Unknown database 
                 * 1045 Access denied for user (usuario y contraseña)
                 * 1042 Unable to connect to any of the specified MySQL hosts. (sevicio apagado o nombre
                 * de server no valido)
                 * 
                 * */
                Console.Write(ex.StackTrace);
                return false;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return false;

            }
        }

        public static void Desconectar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
