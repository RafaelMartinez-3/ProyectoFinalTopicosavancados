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
using Modelos;

namespace ProyectoFinalTap
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void mbtnIniciar_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Employee emp = employeeDAO.login(mtxtUsuario.Text, mtxtContrasenia.Text);

            if (emp != null)
            {
                Menu frml = new Menu();
                frml.ShowDialog();
                
                //MessageBox.Show("Bienvenido usuario " + emp.FullName);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
    }
}
