using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductDAO
    {
        public List<Product> obtenerTodas()
        {
            List<Product> lista = new List<Product>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = "select ProductID,ProductName,P.SupplierID,S.CompanyName,P.CategoryID,C.CategoryName,UnitPrice,UnitsInStock,Discontinued " +
                        "from products P,suppliers S,categories C " +
                        "where S.SupplierID = P.SupplierID and C.CategoryID = P.CategoryID;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText=select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        Product categoria = new Product(
                            Convert.ToInt32(fila["ProductID"]),
                            fila["ProductName"].ToString(),
                            Convert.ToInt32(fila["SupplierID"]),
                            fila["CompanyName"].ToString(),
                            Convert.ToInt32(fila["CategoryID"]),
                            fila["CategoryName"].ToString(),
                            Convert.ToDouble(fila["UnitPrice"]),
                            Convert.ToInt32(fila["UnitsInStock"]),
                            Convert.ToBoolean(fila["Discontinued"])
                            );
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

        public int agregar(Product prod)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = "INSERT INTO products (ProductName, SupplierID, CategoryID, UnitPrice, UnitsInStock, Discontinued) " +
                       "VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice, @UnitsInStock, @Discontinued)";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@ProductName", prod.ProductName);
                    sentencia.Parameters.AddWithValue("@SupplierID", prod.SupplierID); // ID del proveedor
                    sentencia.Parameters.AddWithValue("@CategoryID", prod.CategoryID); // ID de la categoría
                    sentencia.Parameters.AddWithValue("@UnitPrice", prod.UnitPrice);
                    sentencia.Parameters.AddWithValue("@UnitsInStock", prod.UnitsInStock);
                    sentencia.Parameters.AddWithValue("@Discontinued", prod.Discontinued);
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

        public int editar(Product prod)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "UPDATE products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, " +
                       "UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, Discontinued = @Discontinued " +
                       "WHERE ProductID = @ProductID";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@ProductName", prod.ProductName);
                    sentencia.Parameters.AddWithValue("@SupplierID", prod.SupplierID); // ID del proveedor
                    sentencia.Parameters.AddWithValue("@CategoryID", prod.CategoryID); // ID de la categoría
                    sentencia.Parameters.AddWithValue("@UnitPrice", prod.UnitPrice);
                    sentencia.Parameters.AddWithValue("@UnitsInStock", prod.UnitsInStock);
                    sentencia.Parameters.AddWithValue("@Discontinued", prod.Discontinued);
                    sentencia.Parameters.AddWithValue("@ProductID", prod.ProductID); // ID del producto a editar
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

        public int Eliminar(int id)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "Delete from products where ProductId=@ProductId;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@ProductId", id);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (MySqlException e)
                {
                    if (e.Number==1451)
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
                //Devolvemos un cero indicando que no se insertó nada
                return 0;
            }
        }
        public List<Product> reorder()
        {
            List<Product> lista = new List<Product>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = "select p.productName, s.CompanyName, (p.ReorderLevel-p.UnitsInStock) as Unidades From products p join suppliers s where p.SupplierID = s.SupplierID and p.UnitsInStock<= p.ReorderLevel and p.Discontinued=0 order by s.CompanyName;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText=select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        Product product = new Product(
                            fila["ProductName"].ToString(),
                            fila["CompanyName"].ToString(),
                            Convert.ToInt32(fila["Unidades"])
                            );
                        lista.Add(product);
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
        public List<Inventary> obtenerInventario()
        {
            List<Inventary> valores = new List<Inventary>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = "select ProductID,ProductName,ReorderLevel,UnitsInStock from products where Discontinued=0;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        Inventary product = new Inventary(
                            Convert.ToInt32(fila["ProductID"]),
                            fila["ProductName"].ToString(),
                            Convert.ToInt32(fila["ReorderLevel"]),
                            Convert.ToInt32(fila["UnitsInStock"])
                            );
                        valores.Add(product);
                    }

                    return valores;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            return valores;
        }

        public int actualizarInventario(int id, int enStock)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "Update products set UnitsInStock=@UnitsInStock where ProductID=@ProductID;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@ProductID", id);
                    sentencia.Parameters.AddWithValue("@UnitsInStock", enStock);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (MySqlException e)
                {
                    return 0;
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
