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
                    //DJVC Cambio para no mostrar un producto inexistente
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

        public int Insert(Category cat)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = "INSERT INTO Categories (CategoryName, Description) VALUES (@NombreCat, @DescripcionCat)";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@NombreCat", cat.CategoryName);
                    sentencia.Parameters.AddWithValue("@DescripcionCat", cat.CategoryDescription);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
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

        public int Update(Category cat)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "UPDATE Categories SET CategoryName = @NombreCat, Description = @DescripcionCat WHERE CategoryID = @IdCat";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@NombreCat", cat.CategoryName);
                    sentencia.Parameters.AddWithValue("@DescripcionCat", cat.CategoryDescription);
                    sentencia.Parameters.AddWithValue("@IdCat", cat.CategoryID);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
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

        public int Delete(int id)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (Delete)
                    String delete = "Delete from Categories where CategoryId=@CategoryId;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = delete;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@CategoryId", id);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1451)
                    {
                        return 1451;
                    }
                    else
                    {
                        return 0;
                    }
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                //Devolvemos un cero indicando que no se eliminó nada
                return 0;
            }
        }
    }
}
