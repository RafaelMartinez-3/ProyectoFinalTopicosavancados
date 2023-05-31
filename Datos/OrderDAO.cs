using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class OrderDAO
    {
        /// <summary>
        /// Tomamos las ordenes que hayamos efectuado en el dia
        /// </summary>
        /// <returns>Una lista de tipo order que tiene las ordenes efectuadas en ese dia</returns>
        public List<Order> GetTodayOrders()
        {
            List<Order> lista = new List<Order>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia select
                    String select = @"SELECT o.OrderId, CONCAT(e.FirstName, ' ', e.LastName) AS Empleado, c.CompanyName, o.OrderDate, SUM(od.UnitPrice * od.Quantity) AS Total
                                    FROM orders o
                                    JOIN employees e ON o.EmployeeId = e.EmployeeId
                                    JOIN customers c ON o.CustomerId = c.CustomerId
                                    JOIN `order details` od ON o.OrderId = od.OrderId
                                    WHERE DATE(o.OrderDate) = DATE(NOW())
                                    GROUP BY o.OrderId, Empleado, c.CompanyName, o.OrderDate;";
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
                        Order orden = new Order() {
                            OrderId = Convert.ToInt32(fila["OrderId"]),
                            Empleado = fila["Empleado"].ToString(),
                            Cliente = fila["CompanyName"].ToString(),
                            Fecha = fila["OrderDate"].ToString(),
                            Total = Convert.ToDecimal(fila["Total"])
                        };
                        lista.Add(orden);
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
        /// Insertamos valores en orders
        /// </summary>
        /// <param name="CustomerID">Id del cliente</param>
        /// <param name="EmployeeID">Id del empleado</param>
        /// <returns>0 si sucede un error, si no, el numero de filas afectadas</returns>
        public int InsertOrder(String CustomerID, int EmployeeID)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = @"INSERT INTO orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, ShipPostalCode) 
                                    VALUES (@CustomerID, @EmployeeID, NOW(), NOW(), NOW(), 1, @ShipPostalCode)";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@CustomerID", CustomerID);
                    sentencia.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    sentencia.Parameters.AddWithValue("@ShipPostalCode", "");
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (Exception e)
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
        /// Metodo para insertar valores en order details
        /// </summary>
        /// <param name="ProductID">id del producto</param>
        /// <param name="UnitPrice">El precio de las unidades</param>
        /// <param name="Quantity">Cantidad de unidades del producto</param>
        /// <returns>0 si sucede un error, si no, el numero de filas afectadas</returns>
        public int InsertOrderDetails(int ProductID, double UnitPrice, int Quantity)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = @"INSERT INTO `order details` (OrderID, ProductID, UnitPrice, Quantity, Discount) 
                                    VALUES ((select orderid from orders order by orderid desc limit 1),@ProductID, @UnitPrice, @Quantity, 0)";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@ProductID", ProductID);
                    sentencia.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    sentencia.Parameters.AddWithValue("@Quantity", Quantity);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (Exception e)
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
        /// Borramos el campo que queramos de order y orderdetails
        /// </summary>
        /// <param name="OrderId">Id de la orden</param>
        /// <returns>0 si sucede un error, si no, el numero de filas afectadas</returns>
        public int DeleteOrder(int OrderId)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = @"Delete from `order details` where orderid=@OrderId; Delete from orders where orderid=@OrderId";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@OrderId", OrderId);
                    //Ejercutar el comando 
                    int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());
                    return filasAfectadas;
                }
                catch (Exception e)
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
