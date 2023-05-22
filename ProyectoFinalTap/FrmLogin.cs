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
            Employee emp = employeeDAO.login(txtUsuario.Text, txtContrasenia.Text);
            if (emp != null)
            {
                MessageBox.Show("Bienvenido usuario " + emp.FullName);
                FrmMenu frml = new FrmMenu();
                if (txtUsuario.Text == "AFuller")
                {
                    //frml.ocultarEmpleados(true);
                    this.Hide();
                    frml.ShowDialog();
                    txtContrasenia.Text = "";
                    txtUsuario.Text = "";
                    this.Show();
                }
                else
                {
                    //frml.ocultarEmpleados(false);
                    this.Hide();
                    frml.ShowDialog();
                    txtContrasenia.Text = "";
                    txtUsuario.Text = "";
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
    }
}
