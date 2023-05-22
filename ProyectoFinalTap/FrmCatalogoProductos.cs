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

namespace ProyectoFinalTap
{
    /*
     Creado por: Diego Jesus Vasquez Calderon
        Creacion del formulario Catalogo de productos
        Mostrar los productos en un DataGridView
        Cambio de nombre a las columnas
        Creacion metodo para actalizar el dgv 
        Creacion de los botones AInventario, Agregar, Editar y Eliminar con sus respectivas funciones
     */
    public partial class FrmCatalogoProductos : MetroForm
    {
        private List<Product> productos;
        public FrmCatalogoProductos()
        {
            InitializeComponent();
            productos = new ProductDAO().GetAll();
            dgvProductos.DataSource = productos;

            //Desactivar la adición, eliminación y edición de el gridview
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvProductos.Columns["ProductId"].HeaderText = "Identificador";
            dgvProductos.Columns["ProductName"].HeaderText = "Producto";
            dgvProductos.Columns["CompanyName"].HeaderText = "Compañia";
            dgvProductos.Columns["CategoryName"].HeaderText = "Categoría";
            dgvProductos.Columns["UnitPrice"].HeaderText = "Precio unitario";
            dgvProductos.Columns["UnitsInStock"].HeaderText = "Inventario";
            dgvProductos.Columns["ReorderLevel"].HeaderText = "Reorden";
            dgvProductos.Columns["Discontinued"].HeaderText = "Descontinuado";

            dgvProductos.Columns["SupplierId"].Visible = false;
            dgvProductos.Columns["CategoryId"].Visible = false;
            dgvProductos.Columns["Unidades"].Visible = false;
        }

        public void actualizarDGV()
        {
            productos = new ProductDAO().GetAll();
            dgvProductos.DataSource = productos;
        }

        private void btnAInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario= new FrmInventario();
            inventario.ShowDialog();
            actualizarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto agregar = new FrmProducto();
            agregar.establecerValores(0, "", 0, 0, 0, 0, 0, false);
            agregar.ShowDialog();
            actualizarDGV();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            FrmProducto editar = new FrmProducto();
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];

            int productId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string productName = filaSeleccionada.Cells[1].Value.ToString();
            int supplierId = int.Parse(filaSeleccionada.Cells[2].Value.ToString());
            int categoryId = int.Parse(filaSeleccionada.Cells[4].Value.ToString());
            double unitPrice = Convert.ToDouble(filaSeleccionada.Cells[6].Value.ToString());
            int unitStock = int.Parse(filaSeleccionada.Cells[7].Value.ToString());
            int reorderlevel = int.Parse(filaSeleccionada.Cells[8].Value.ToString());
            bool discontinued = Convert.ToBoolean(filaSeleccionada.Cells[9].Value.ToString());

            editar.establecerValores(productId, productName, supplierId,
                categoryId, unitPrice, unitStock, reorderlevel, discontinued);
            editar.ShowDialog();
            actualizarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            int productId = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string productName = filaSeleccionada.Cells[1].Value.ToString();
            string message = "¿Está seguro que desea eliminar el producto " + productName + " ?";
            string caption = "Eliminacion de producto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int c = new ProductDAO().Delete(productId);
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

