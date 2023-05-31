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
    public partial class FrmInicioVentas : MetroForm
    {
        Employee empleadoGeneral;
        public List<Order> ordenes;
        public static List<Sales> ventas = new List<Sales>();
        public FrmInicioVentas(Employee empleado)
        {
            ordenes = new OrderDAO().GetTodayOrders();
            InitializeComponent();
            empleadoGeneral = empleado;
            dgvVentasInicio.DataSource = ordenes;
            dgvVentasInicio.AllowUserToAddRows = true;
            dgvVentasInicio.AllowUserToDeleteRows = true;
            dgvVentasInicio.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentasInicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvVentasInicio.Columns["OrderId"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmVenta nuevaVenta = new FrmVenta(empleadoGeneral);
            nuevaVenta.ShowDialog();
            actualizarDGV();
        }

        public void actualizarDGV()
        {
            ordenes = new OrderDAO().GetTodayOrders();
            dgvVentasInicio.DataSource = ordenes;
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ordenes.Count!=0)
            {
                DataGridViewRow filaSeleccionada = dgvVentasInicio.SelectedRows[0];
                int OrderId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                string message = "¿Está seguro que desea eliminar esta orden?";
                string caption = "Eliminacion de orden";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int c = new OrderDAO().DeleteOrder(OrderId);
                    if (c == 0)
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
            else
            {
                MessageBox.Show("No se pudo realizar la operación. No se han hecho ventas.N");
            }
        }
    }
}
