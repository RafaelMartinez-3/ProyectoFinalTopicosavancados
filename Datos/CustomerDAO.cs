using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos
{
	/*
	 * Pedro Antonio Ayala Ramos
	 * Creacion de metodos para obtener datos de los clientes
	 */
	public class CustomerDAO
	{
		public List<Customer> getCustomers()
		{
			if (Conexion.Conectar())
			{
				try
				{
					List<Customer> lista = new List<Customer>();
					String select = "select CustomerID, CompanyName from customers;";
					DataTable dt = new DataTable();
					MySqlCommand sentencia = new MySqlCommand();
					sentencia.CommandText = select;
					sentencia.Connection = Conexion.conexion;
					MySqlDataAdapter da = new MySqlDataAdapter();
					da.SelectCommand = sentencia;
					da.Fill(dt);
					foreach (DataRow fila in dt.Rows)
					{
						Customer cliente = new Customer(fila["CustomerID"].ToString(), 
							fila["CompanyName"].ToString());
						lista.Add(cliente);
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
