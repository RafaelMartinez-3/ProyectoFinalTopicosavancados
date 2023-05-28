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

        public int UpdateUnitsInStock(int id, int stock)
        {
			//Conectarme
			if (Conexion.Conectar())
			{
				try
				{
					//Crear la sentencia a ejecutar (UPDATE)
					String select = @"UPDATE products SET UnitsInStock = @UnitsInStock WHERE ProductID = @ProductID";
					MySqlCommand sentencia = new MySqlCommand();
					sentencia.CommandText = select;
					sentencia.Connection = Conexion.conexion;
					sentencia.Parameters.AddWithValue("@ProductID", id);
					sentencia.Parameters.AddWithValue("@UnitsInStock", stock); 
					
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
                    //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
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
    }

}
