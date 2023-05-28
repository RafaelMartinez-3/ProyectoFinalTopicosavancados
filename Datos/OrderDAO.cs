﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;
using Modelos;

namespace Datos
{
	internal class OrderDAO
	{
		public int insertOrder(int CustomerID, int EmployeeID)
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
		public int insertOrderDetails(int ProductID, double UnitPrice, int Quantity)
		{
			//Conectarme
			if (Conexion.Conectar())
			{
				try
				{
					//Crear la sentencia a ejecutar (INSERT)
					String select = @"INSERT INTO `order details` (ProductID, UnitPrice, Quantity, Discount) 
                                    VALUES (@ProductID, @UnitPirce, @Quantity, 0)";
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
