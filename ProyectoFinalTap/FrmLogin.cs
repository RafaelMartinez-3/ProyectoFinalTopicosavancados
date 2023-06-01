using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using MetroFramework.Forms;
using Modelos;
using MySql.Data.MySqlClient;

namespace ProyectoFinalTap
{
    /// <summary>
    /// Noemi Guzman Aguilera: Implemento el login, para eso agrego la clase Employee y EmployeeDAO
    /// </summary>
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void mbtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Intentamos iniciar sesion con los datos que nos mandan
                EmployeeDAO employeeDAO = new EmployeeDAO();
                Employee emp = employeeDAO.Login(txtUsuario.Text, txtContrasenia.Text);
                if (emp != null)
                {

                    MessageBox.Show("Bienvenido usuario " + emp.FullName);
                    this.Hide();
                    FrmMenu frm = new FrmMenu(emp);
                    frm.ShowDialog();
                    txtContrasenia.Text = "";
                    txtUsuario.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");

                }
            }
            //Si sucede una excepcion al querer conectar, mostramos la ventana de conexion para
            //actualizar la conexion a la base de datos
            catch (MySqlException ex)
            {
                this.Hide();
                FrmConexion conexion = new FrmConexion();
                conexion.ShowDialog();
                this.Show();
            }
        }
    }
}
