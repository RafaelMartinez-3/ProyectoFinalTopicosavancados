using Datos;
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
    public partial class FrmInicioVentas : MetroFramework.Forms.MetroForm
    {
        Employee empleadoGeneral;
        List<Sales> ventas;
        public FrmInicioVentas(Employee empleado)
        {
            InitializeComponent();
            empleadoGeneral = empleado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
		{
            FrmVenta nuevaVenta = new FrmVenta(empleadoGeneral);
            nuevaVenta.ShowDialog();
            ventas = nuevaVenta.ventitas;
            llenartabla(nuevaVenta.ventitas);
            

		}
        public void llenartabla(List<Sales> ventas)
        {
            if(ventas!= null)
            {
                Conexion con = new Conexion();

                dgvVentasInicio.DataSource = ventas;
                dgvVentasInicio.AllowUserToAddRows = true;
                dgvVentasInicio.AllowUserToDeleteRows = true;
                dgvVentasInicio.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvVentasInicio.Columns["ProductID"].HeaderText = "Identificador";
                dgvVentasInicio.Columns["ProductName"].HeaderText = "Nombre";
                dgvVentasInicio.Columns["UnitPrice"].HeaderText = "Precio Unitario";
                dgvVentasInicio.Columns["Quantity"].HeaderText = "Cantidad";
                dgvVentasInicio.Columns["UnitsInStock"].HeaderText = "Unidades en stock";
                dgvVentasInicio.Columns["Subtotal"].HeaderText = "Subtotal";
            }
            
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos el campo que estemos seleccionando en el gridview
           
            
            for (int i = 0; i < ventas.Count; i++)
            {
                DataGridViewRow filaSeleccionada = dgvVentasInicio.SelectedRows[0];
                if (ventas[i].ProductName == filaSeleccionada.Cells[1].Value.ToString())
                {
                    ventas.RemoveAt(i);
                    break;
                }
            }
            //Actualizamos la tabla
            dgvVentasInicio.DataSource = null;
            Conexion con = new Conexion();

            dgvVentasInicio.DataSource = ventas;
            dgvVentasInicio.AllowUserToAddRows = true;
            dgvVentasInicio.AllowUserToDeleteRows = true;
            dgvVentasInicio.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentasInicio.Columns["ProductID"].HeaderText = "Identificador";
            dgvVentasInicio.Columns["ProductName"].HeaderText = "Nombre";
            dgvVentasInicio.Columns["UnitPrice"].HeaderText = "Precio Unitario";
            dgvVentasInicio.Columns["Quantity"].HeaderText = "Cantidad";
            dgvVentasInicio.Columns["UnitsInStock"].HeaderText = "Unidades en stock";
            dgvVentasInicio.Columns["Subtotal"].HeaderText = "Subtotal";
        }
    }
}
