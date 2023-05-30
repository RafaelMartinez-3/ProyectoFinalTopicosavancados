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
    public partial class FrmCatalogoEmpleados : MetroForm
    {
        private List<Employee> emp;
        public FrmCatalogoEmpleados()
        {
            InitializeComponent();
            emp = new EmployeeDAO().GetAll();
            dgvEmpleados.DataSource = emp;

            //Desactivar la adición, eliminación y edición de el gridview
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEmpleados.Columns["EmployeeId"].HeaderText = "Empleado";
            dgvEmpleados.Columns["FirstName"].HeaderText = "Nombre";
            dgvEmpleados.Columns["LastName"].HeaderText = "Apellido";
            dgvEmpleados.Columns["Title"].HeaderText = "Título";
            dgvEmpleados.Columns["PostalCode"].HeaderText = "Código postal";
            dgvEmpleados.Columns["ReportsToName"].HeaderText = "Jefe directo";

            dgvEmpleados.Columns["ReportsTo"].Visible = false;
            dgvEmpleados.Columns["FullName"].Visible = false;
        }
        public void actualizarDGV()
        {
            emp = new EmployeeDAO().GetAll();
            dgvEmpleados.DataSource = emp;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEmpleado agregar = new FrmEmpleado(emp);
            agregar.establecerValores(0, "", "", "", "", 0);
            agregar.ShowDialog();
            actualizarDGV();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int empladoId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string nombre = filaSeleccionada.Cells[1].Value.ToString();
            string apellido = filaSeleccionada.Cells[2].Value.ToString();
            string titulo = filaSeleccionada.Cells[3].Value.ToString();
            string codigoPostal = filaSeleccionada.Cells[4].Value.ToString();
            int jefeDirecto = int.Parse(filaSeleccionada.Cells[5].Value.ToString());
            List<Employee> empleados = new EmployeeDAO().GetAll();
            foreach (Employee item in empleados)
            {
                if (item.EmployeeId.Equals(empladoId))
                {
                    empleados.Remove(item);
                    break;
                }
            }
            FrmEmpleado editar = new FrmEmpleado(empleados);
            editar.establecerValores(empladoId, nombre, apellido, titulo, codigoPostal, jefeDirecto);
            editar.ShowDialog();
            actualizarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int employeeId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string employeeName = filaSeleccionada.Cells[7].Value.ToString();
            string message = "¿Está seguro que desea eliminar al empleado " + employeeName + " ?";
            string caption = "Eliminacion de empleado";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int c = new EmployeeDAO().Delete(employeeId);
                if (c == 1451)
                {
                    MessageBox.Show("No se puede eliminar por que tiene relación con otros elementos.");
                }
                else if (c == 0)
                {
                    MessageBox.Show("No se pudo realizar la operación.");
                }
                else
                {
                    actualizarDGV();
                    MessageBox.Show("Eliminado exitosamente.");
                }
            }
        }
    }
}
