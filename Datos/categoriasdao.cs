using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class categoriasdao
    {
        public List<Categorias> GetAll()
        {
            List<Categorias> lista = new List<Categorias>();
            if (Conexion.Conectar())
            {
                try
                {
                    String select = "select categoryid, categoryname, description from categories;";
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
                        Categorias categoria = new Categorias(Convert.ToInt32(fila["categoryid"]),
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

        public int Insert(Categorias categoria, bool update)
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
    }
}
