using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;
using Modelos;

namespace Datos
{
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
					// Objeto Category auxiliar para asignar null como 
					//DJVC Cambio para no mostrar un producto inexistente
					foreach (DataRow fila in dt.Rows)
					{
						Customer cliente = new Customer(Convert.ToInt32(fila["CustomerID"]), 
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
