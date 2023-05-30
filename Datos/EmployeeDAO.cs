using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;

namespace Datos
{
    public class EmployeeDAO
    {
        public Employee Login(String usuario, String password)
        {
            Employee emp = null;
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (SELECT)
                    String select = @"SELECT EmployeeId, FirstName, LastName, Title
                        FROM Employees
                        WHERE UserName=@usuario AND Password=@password";
                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@usuario", usuario);
                    sentencia.Parameters.AddWithValue("@password", password);
                    sentencia.Connection = Conexion.conexion;

                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);

                    //Llenar el datatable
                    da.Fill(dt);
                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {
                        DataRow fila = dt.Rows[0];
                        emp = new Employee()
                        {
                            EmployeeId = Convert.ToInt32(fila["EmployeeId"]),
                            FirstName = fila["FirstName"].ToString(),
                            LastName = fila["LastName"].ToString(),
                            Title = fila["Title"].ToString()
                        };

                    }

                    return emp;
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

        public List<Employee> GetAll()
        {
            List<Employee> lista = new List<Employee>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    String select = @"SELECT e.EmployeeId, e.FirstName, e.LastName, e.Title, e.PostalCode, CASE WHEN e.ReportsTo IS NULL THEN 0 ELSE e.ReportsTo END AS ReportsTo,
                                    CASE WHEN e.ReportsTo IS NULL THEN '' 
                                    ELSE concat(m.FirstName,' ',m.LastName) END AS ReportsToName
                                    FROM Employees e
                                    LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID;";
                    DataTable dt = new DataTable();
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sentencia;
                    da.Fill(dt);
                    foreach (DataRow fila in dt.Rows)
                    {
                        Employee empleado = new Employee()
                        {
                            EmployeeId = Convert.ToInt32(fila["EmployeeId"]),
                            FirstName = fila["FirstName"].ToString(),
                            LastName = fila["LastName"].ToString(),
                            Title = fila["Title"].ToString(),
                            PostalCode = fila["PostalCode"].ToString(),
                            ReportsTo = Convert.ToInt32(fila["ReportsTo"]),
                            ReportsToName = fila["ReportsToName"].ToString()
                        };
                        lista.Add(empleado);
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

        public int Insert(Employee emp)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT y UPDATE)
                    String select = @"INSERT INTO Employees (FirstName, LastName, Title, PostalCode, ReportsTo, Notes) 
                                    VALUES (@FirstName, @LastName, @Title, @PostalCode, @ReportsTo, @Notes);
                                    UPDATE EMPLOYEES SET UserName=concat(LEFT(firstname,1),lastname), Password=EmployeeId*111;"
                    ;

                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    sentencia.Parameters.AddWithValue("@LastName", emp.LastName);
                    sentencia.Parameters.AddWithValue("@Title", emp.Title);
                    sentencia.Parameters.AddWithValue("@PostalCode", emp.PostalCode);
                    if (emp.ReportsTo.Equals(0))
                    {
                        sentencia.Parameters.AddWithValue("@ReportsTo", null);
                    }
                    else
                    {
                        sentencia.Parameters.AddWithValue("@ReportsTo", emp.ReportsTo);
                    }
                    sentencia.Parameters.AddWithValue("@Notes", "");

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

        public int Update(Employee emp)
        {
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (UPDATE)
                    String select = @"UPDATE EMPLOYEES SET FirstName = @FirstName, LastName = @LastName, Title = @Title, 
                                    PostalCode = @PostalCode, ReportsTo = @ReportsTo
                                    WHERE EmployeeID = @EmployeeID;
                                    UPDATE EMPLOYEES SET UserName=concat(LEFT(firstname,1),lastname), Password=EmployeeId*111;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    sentencia.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    sentencia.Parameters.AddWithValue("@LastName", emp.LastName);
                    sentencia.Parameters.AddWithValue("@Title", emp.Title);
                    sentencia.Parameters.AddWithValue("@PostalCode", emp.PostalCode);
                    if (emp.ReportsTo.Equals(0))
                    {
                        sentencia.Parameters.AddWithValue("@ReportsTo", null);
                    }
                    else
                    {
                        sentencia.Parameters.AddWithValue("@ReportsTo", emp.ReportsTo);
                    }
                    sentencia.Parameters.AddWithValue("@EmployeeID", emp.EmployeeId);
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
                    String select = "Delete from employees where EmployeeId=@EmployeeId;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    sentencia.Parameters.AddWithValue("@EmployeeId", id);
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

        public List<String> GetTitles()
        {
            List<String> lista = new List<String>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    String select = @"SELECT Title FROM employees GROUP BY Title;";
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;
                    MySqlDataReader reader = sentencia.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(reader["Title"].ToString());
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
