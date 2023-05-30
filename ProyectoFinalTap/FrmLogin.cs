using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace ProyectoFinalTap
{
    /// <summary>
    /// Noemi Guzman Aguilera: Implemento el login, para eso agrego la clase Employee y EmployeeDAO
    /// </summary>
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        int contador = 1;
        private void mbtnIniciar_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Employee emp = employeeDAO.login(txtUsuario.Text, txtContrasenia.Text);
           
            if (emp != null)
            {
                
                MessageBox.Show("Bienvenido usuario " + emp.FullName);
                this.Hide();
                FrmMenu frm = new FrmMenu(emp);
                frm.ShowDialog();
                txtContrasenia.Text = " ";
                txtUsuario.Text = " ";
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                contador++;
                if (contador >= 3)
                {
                    DialogResult r = MessageBox.Show("Cambiar la conexión", "CONEXION FAIL", MessageBoxButtons.YesNoCancel);

                    if (r == DialogResult.Yes)
                    {
                        FrmConexion cambiar = new FrmConexion();
                        cambiar.ShowDialog();

                        Conexion conex = new Conexion();
                        conex.nuevaSesion(FrmConexion.servidor, FrmConexion.usuario, FrmConexion.contrasenia);

                    }
;
                }

            }

        }

        public void mCboTitleUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
