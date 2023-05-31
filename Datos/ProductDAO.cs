using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DJVC Ajuste para normalizar nombre de metodos
namespace Datos
{
    public class ProductDAO
    {
        //DJVC Cambio en metodo para el ReorderLevel
        /// <summary>
        /// Tomamos todos los valores de la tabla de productos
        /// </summary>
        /// <returns>Lista de tipo productos</returns>
        public List<Product> GetAll()
        {
            List<Product> lista = new List<Product>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = @"Select ProductID,ProductName,P.SupplierID,S.CompanyName,P.CategoryID,C.CategoryName,UnitPrice,UnitsInStock,ReorderLevel,Discontinued 
                                    from products P,suppliers S,categories C 
                                    where S.SupplierID = P.SupplierID and C.CategoryID = P.CategoryID
                                    order by ProductName;";
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
                        Product categoria = new Product(
                            Convert.ToInt32(fila["ProductID"]),
                            fila["ProductName"].ToString(),
                            Convert.ToInt32(fila["SupplierID"]),
                            fila["CompanyName"].ToString(),
                            Convert.ToInt32(fila["CategoryID"]),
                            fila["CategoryName"].ToString(),
                            Convert.ToDouble(fila["UnitPrice"]),
                            Convert.ToInt32(fila["UnitsInStock"]),
                            Convert.ToInt32(fila["ReorderLevel"]),
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

        /// <summary>
        /// Tomamos todos los productos, pero solo los que tengan stock
        /// </summary>
        /// <returns>Una lista de tipo productosñ</returns>
        public List<Product> GetAllWithStock()
        {
            List<Product> lista = new List<Product>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = @"Select ProductID,ProductName,P.SupplierID,S.CompanyName,P.CategoryID,C.CategoryName,UnitPrice,UnitsInStock,ReorderLevel,Discontinued 
                                    from products P,suppliers S,categories C 
                                    where S.SupplierID = P.SupplierID and C.CategoryID = P.CategoryID and P.UnitsInStock>0 and P.Discontinued=0
                                    order by ProductName;";
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
                        Product categoria = new Product(
                            Convert.ToInt32(fila["ProductID"]),
                            fila["ProductName"].ToString(),
                            Convert.ToInt32(fila["SupplierID"]),
                            fila["CompanyName"].ToString(),
                            Convert.ToInt32(fila["CategoryID"]),
                            fila["CategoryName"].ToString(),
                            Convert.ToDouble(fila["UnitPrice"]),
                            Convert.ToInt32(fila["UnitsInStock"]),
                            Convert.ToInt32(fila["ReorderLevel"]),
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

        //DJVC Cambio en metodo para el ReorderLevel
        public int Insert(Product prod)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = @"INSERT INTO products (ProductName, SupplierID, CategoryID, UnitPrice, UnitsInStock, ReorderLevel, Discontinued) 
                                    VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice, @UnitsInStock, @ReorderLevel, @Discontinued)";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@ProductName", prod.ProductName);
                    sentencia.Parameters.AddWithValue("@SupplierID", prod.SupplierID); // ID del proveedor
                    sentencia.Parameters.AddWithValue("@CategoryID", prod.CategoryID); // ID de la categoría
                    sentencia.Parameters.AddWithValue("@UnitPrice", prod.UnitPrice);
                    sentencia.Parameters.AddWithValue("@UnitsInStock", prod.UnitsInStock);
                    sentencia.Parameters.AddWithValue("@ReorderLevel", prod.ReorderLevel);
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


        //DJVC Cambio en el metodo para el ReorderLevel
        /// <summary>
        /// Actualizamos la tabla de productos con el producto que le mandamos
        /// </summary>
        /// <param name="prod">Una varible de tipo productos con los datos a actualizar</param>
        /// <returns>0 si no se puede conectar, si no, el numero de filas afectadas</returns>
        public int Update(Product prod)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = @"UPDATE products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, 
                                    UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued 
                                    WHERE ProductID = @ProductID";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@ProductName", prod.ProductName);
                    sentencia.Parameters.AddWithValue("@SupplierID", prod.SupplierID); // ID del proveedor
                    sentencia.Parameters.AddWithValue("@CategoryID", prod.CategoryID); // ID de la categoría
                    sentencia.Parameters.AddWithValue("@UnitPrice", prod.UnitPrice);
                    sentencia.Parameters.AddWithValue("@UnitsInStock", prod.UnitsInStock);
                    sentencia.Parameters.AddWithValue("@ReorderLevel", prod.ReorderLevel);
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

        /// <summary>
        /// Borramos por id un producto
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <returns>0 si no podemos hacer la conexion, si no, el numero de filas afectadas</returns>
        public int Delete(int id)
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
                //Devolvemos un cero indicando que no se insertó nada
                return 0;
            }
        }

        /// <summary>
        /// Tomamos los datos necesarios de productos para poder hacer el inventario
        /// </summary>
        /// <returns>Regresamos una lista de tipo inventario</returns>
        public List<Inventory> GetInventory()
        {
            List<Inventory> valores = new List<Inventory>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = "select ProductID,ProductName,ReorderLevel,UnitsInStock from products where Discontinued=0 order by ProductName;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    foreach (DataRow fila in dt.Rows)
                    {
                        Inventory product = new Inventory(
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

        /// <summary>
        /// Actualizamos los datos de la tabla products segun el inventario
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="enStock">La cantidad nueva de stock</param>
        /// <returns>Regresamos 0 si no se puede hacer la conexion, si no, el numero de filas afectadas</returns>
        public int UpdateInvetory(int id, int enStock)
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

        /// <summary>
        /// Actualizamos la tabla de productos segun los productos a comprar
        /// </summary>
        /// <param name="list">Lista de tipo ProductToBuy que contiene todos los productos que vamos
        /// a comprar</param>
        /// <returns>0 si sucede un error, si no, el numero de filas afectadas</returns>
        public int UpdateUnitsOnOrder(List<ProductToBuy> list)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "Update products set UnitsOnOrder=@UnitsOnOrder where ProductId=@ProductId;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    int filasAfectadas = 0;
                    foreach (ProductToBuy product in list)
                    {
                        sentencia.Parameters.Clear();
                        sentencia.Parameters.AddWithValue("@UnitsOnOrder", product.BuySuggestion);
                        sentencia.Parameters.AddWithValue("@ProductId", product.ProductId);
                        filasAfectadas += Convert.ToInt32(sentencia.ExecuteNonQuery());
                    }
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

        /// <summary>
        /// Reseteamos los productos que vamos a comprar
        /// </summary>
        /// <param name="list">Lista de tipo ProductToBuy que contiene los productos a comprar</param>
        /// <returns>0 si sucede un error, si no, el numero de filas afectadas</returns>
        public int ResetUnitsOnOrder(List<ProductToBuy> list)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = "Update products set UnitsOnOrder=0 where ProductId=@ProductId;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    int filasAfectadas = 0;
                    foreach (ProductToBuy product in list)
                    {
                        sentencia.Parameters.Clear();
                        sentencia.Parameters.AddWithValue("@ProductId", product.ProductId);
                        filasAfectadas += Convert.ToInt32(sentencia.ExecuteNonQuery());
                    }
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

        /// <summary>
        /// Tomamos los elementos que deberiamos de comprar
        /// </summary>
        /// <returns>Regresamos una lista de tipo ProductToBuy con los productos que deberiamos
        /// de comprar</returns>
        public List<ProductToBuy> GetElementsToBuy()
        {
            List<ProductToBuy> lista = new List<ProductToBuy>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = @"Select ProductId, ProductName, 
                                    Case when ReorderLevel=0 
                                        then 10
                                        else cast(ReorderLevel*1.5 as signed) 
                                    end as BuySuggestion 
                                    from products where (Discontinued=0 and UnitsOnOrder=0) and UnitsInStock<5;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    foreach (DataRow fila in dt.Rows)
                    {
                        ProductToBuy product = new ProductToBuy()
                        {
                            ProductId = Convert.ToInt32(fila["ProductId"].ToString()),
                            ProductName = fila["ProductName"].ToString(),
                            BuySuggestion = Convert.ToInt32(fila["BuySuggestion"].ToString())
                        };
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

        /// <summary>
        /// Actualizar los productos para mostrarlos y comprarlos despues
        /// </summary>
        /// <returns>Una lista de tipo ProductToBuy con los productos a comprar</returns>
        public List<ProductToBuy> GetRegisteredElementsToBuy()
        {
            List<ProductToBuy> lista = new List<ProductToBuy>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = @"Select ProductId, ProductName, 
                                    Case when ReorderLevel=0 
                                        then 10
                                        else cast(ReorderLevel*1.5 as signed) 
                                    end as BuySuggestion 
                                    from products where (Discontinued=0 and UnitsOnOrder = case when ReorderLevel=0 
                                        then 10
                                        else cast(ReorderLevel*1.5 as signed) 
                                        end) and UnitsInStock<5;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    //Llenar el datatable
                    da.Fill(dt);
                    foreach (DataRow fila in dt.Rows)
                    {
                        ProductToBuy product = new ProductToBuy()
                        {
                            ProductId = Convert.ToInt32(fila["ProductId"].ToString()),
                            ProductName = fila["ProductName"].ToString(),
                            BuySuggestion = Convert.ToInt32(fila["BuySuggestion"].ToString())
                        };
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
    }

}
