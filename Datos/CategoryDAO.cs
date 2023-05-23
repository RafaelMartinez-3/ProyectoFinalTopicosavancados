using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelos;

namespace Datos
{
    public class CategoryDAO
    {
        public List<Category> GetAll()
        {
            List<Category> lista = new List<Category>();
            if (Conexion.Conectar())
            {
                try
                {
                    String select = "select * from categories;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    da.Fill(dt);
                    // Objeto Category auxiliar para asignar null como 
                    //lista.Add(new Category());
                    foreach (DataRow fila in dt.Rows)
                    {
                        Category categoria = new Category(Convert.ToInt32(fila["categoryid"]),
                            fila["categoryname"].ToString(), fila["description"].ToString());
                        lista.Add(categoria);
                    }
                    return lista;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return null;
            }

        }

        public static  int Insert(Category categoria, bool update)
        {
            if (Conexion.Conectar())
            {
                try
                {
                    MySqlCommand sentencia = new MySqlCommand();
                    if (update)
                    {
                        String select = @"Update categories set CategoryName = @name,
                        Description = @description where CategoryId = @id;";

                        sentencia.CommandText = select;
                        sentencia.Parameters.AddWithValue("@name", categoria.CategoryName);
                        sentencia.Parameters.AddWithValue("@description", categoria.CategoryDescription);
                        sentencia.Parameters.AddWithValue("@id", categoria.CategoryID);
                    }
                    else
                    {
                        String select = @"insert into categories (categoryname,description) 
                            values (@name,@description);
                            select last_insert_id();";

                        sentencia.CommandText = select;
                        sentencia.Parameters.AddWithValue("@description", categoria.CategoryDescription);
                        sentencia.Parameters.AddWithValue("@name", categoria.CategoryName);

                    }

                    sentencia.Connection = Conexion.conexion;
                    object ob = sentencia.ExecuteScalar();

                    return Convert.ToInt32(ob);
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return 0;
            }
        }
        public static int Update(Category categoria)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = @"UPDATE categories SET 
                                        CategoryName=@categoryname, 
                                        Description=@description
                                    where CategoryID = @categoryid;";

                    MySqlCommand sentencia = new MySqlCommand(select, Conexion.conexion);
                    //sentencia.CommandText = select;
                    sentencia.Parameters.AddWithValue("@categoryid", categoria.CategoryID);
                    sentencia.Parameters.AddWithValue("@categoryname", categoria.CategoryName);
                    sentencia.Parameters.AddWithValue("@description", categoria.CategoryDescription);
                    
                    //Ejercutar el comando 
                    //Cuando nos interesa obtener un valor adicional en el comando (como en el ejemplo de arriba que obtiene el último id generado por autoincrement podemos usar ExecuteScalar
                    int claveNuevoProducto = Convert.ToInt32(sentencia.ExecuteScalar());

                    //O de lo contrario podríamos usar ExecuteNonQuery que simplemente ejecuta la sentencia y nos permite recuperar (solo si nos interesa) el número de filas afectadas (si es un insert nos regresa cuantas filas agregó, en un update cuantas filas editó y en un delete igual cuantas filas eliminó, por ejemplo:
                    //int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());


                    return claveNuevoProducto;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                //Devolvemos un cero indicando que no se insertó nada
                return 0;
            }
        }
    }
}
