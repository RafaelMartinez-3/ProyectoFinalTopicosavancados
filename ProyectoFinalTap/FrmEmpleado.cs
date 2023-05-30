using Datos;
using MetroFramework.Forms;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTap
{
    public partial class FrmEmpleado : MetroForm
    {
        private int empleadoId;
        //public List<Employee> empleados = new EmployeeDAO().GetAll();
        private List<String> titulos = new EmployeeDAO().GetTitles();
        public FrmEmpleado(List<Employee> emp)
        {
            InitializeComponent();
            emp.Add(new Employee());
            actualizarCombo(emp);
        }

        public void actualizarCombo(List<Employee> emp)
        {
            cmbJefeDirecto.DataSource = null;
            cmbJefeDirecto.DataSource = emp;
            cmbJefeDirecto.DisplayMember = "FullName";
            cmbJefeDirecto.ValueMember = "EmployeeId";
            cmbJefeDirecto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTitulos.DataSource = titulos;
            cmbTitulos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void establecerValores(int empId, string nombre, string apellido, string titulo, string cPostal, int jDirecto)
        {
            empleadoId = empId;
            if (empId != 0)
            {
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                cmbTitulos.SelectedItem = titulo;
                txtCodigoPostal.Text = cPostal;
                cmbJefeDirecto.SelectedValue = jDirecto;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            EmployeeDAO em = new EmployeeDAO();
            Employee empl = new Employee();
            if (txtNombre.Text.Length > 10 || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Nombre es un campo obligatorio que acepta hasta 10 caracteres.");
            }
            else if (txtApellido.Text.Length > 20 || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Apellido es un campo obligatorio que acepta hasta 20 caracteres.");
            }
            else if (txtCodigoPostal.Text.Length > 10)
            {
                MessageBox.Show("Solo se pueden introducir hasta 10 caracteres en Codigo postal.");
            }
            else
            {
                empl.EmployeeId = empleadoId;
                empl.FirstName = txtNombre.Text;
                empl.LastName = txtApellido.Text;
                empl.Title = cmbTitulos.SelectedItem.ToString();
                empl.PostalCode = txtCodigoPostal.Text;
                empl.ReportsTo = Convert.ToInt32(cmbJefeDirecto.SelectedValue);
                int contFilasModificadas;
                if (empleadoId == 0)
                {
                    contFilasModificadas = em.Insert(empl);
                }
                else
                {
                    contFilasModificadas = em.Update(empl);
                }
                if (contFilasModificadas == 0)
                {
                    MessageBox.Show("Error al realizar la operación.");
                }
                else
                {
                    MessageBox.Show("Operación realizada exitosamente.");
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
