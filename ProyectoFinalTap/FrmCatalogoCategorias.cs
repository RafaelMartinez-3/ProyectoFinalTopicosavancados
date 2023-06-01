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
using MetroFramework.Forms;

namespace ProyectoFinalTap
{
    public partial class FrmCatalogoCategorias : MetroForm
    {
        public static List<Category> categories;
        public FrmCatalogoCategorias()
        {
            //Llenamos el datagridview con datos de las categorias
            categories = new CategoryDAO().GetAll();
            InitializeComponent();
            dgvCategorias.DataSource = categories;
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Columns["CategoryName"].HeaderText = "Categoría";
            dgvCategorias.Columns["CategoryDescription"].HeaderText = "Descripción";
            dgvCategorias.Columns["CategoryID"].HeaderText= "Identificador";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario para agregar una categoria y despues actualizamos el datagridview
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
            categories = new CategoryDAO().GetAll();
            dgvCategorias.DataSource = categories;
            this.Refresh();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Mandamos los datos al formulario de categoria y despues actualizamos el datagridview
            FrmCategoria frm = new FrmCategoria();
            DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];
            int valorCelda1 = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string valorCelda2 = filaSeleccionada.Cells[1].Value.ToString();
            string valorCelda3 = filaSeleccionada.Cells[2].Value.ToString();
            frm.establecerValores(valorCelda1, valorCelda2, valorCelda3);
            frm.ShowDialog();
            categories = new CategoryDAO().GetAll();
            dgvCategorias.DataSource = categories;
            this.Refresh();
            this.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos el campo seleccionado del datagridview
            DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];
            int CategoryId= int.Parse(filaSeleccionada.Cells[0].Value.ToString());
            string CategoryName = filaSeleccionada.Cells[1].Value.ToString();
            string message = "¿Está seguro que desea eliminar la categoria " + CategoryName + " ?";
            string caption = "Eliminacion de categoria";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int c = new CategoryDAO().Delete(CategoryId);
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
                    MessageBox.Show("Eliminado exitosamente.");
                    categories = new CategoryDAO().GetAll();
                    dgvCategorias.DataSource = categories;
                    this.Refresh();
                }
            }
        }
    }
}
