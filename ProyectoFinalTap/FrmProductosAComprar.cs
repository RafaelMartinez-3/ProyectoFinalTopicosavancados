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
    public partial class FrmProductosAComprar : MetroForm
    {
        List<ProductToBuy> products = new List<ProductToBuy>();
        public FrmProductosAComprar(List<ProductToBuy> p)
        {
            products = p;
            InitializeComponent();
            dgvProductosAComprar.DataSource = p;
            dgvProductosAComprar.AllowUserToAddRows = false;
            dgvProductosAComprar.AllowUserToDeleteRows = false;
            dgvProductosAComprar.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductosAComprar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductosAComprar.Columns["ProductId"].Visible = false;
            dgvProductosAComprar.Columns["ProductName"].HeaderText = "Producto";
            dgvProductosAComprar.Columns["BuySuggestion"].HeaderText = "Sugerencia";
        }

        public void actualizarDGV()
        {
            dgvProductosAComprar.DataSource = null;
            dgvProductosAComprar.DataSource = FrmMenu.lista;
            dgvProductosAComprar.AllowUserToAddRows = false;
            dgvProductosAComprar.AllowUserToDeleteRows = false;
            dgvProductosAComprar.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductosAComprar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductosAComprar.Columns["ProductId"].Visible = false;
            dgvProductosAComprar.Columns["ProductName"].HeaderText = "Producto";
            dgvProductosAComprar.Columns["BuySuggestion"].HeaderText = "Sugerencia";
            this.Refresh();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvProductosAComprar.DataSource = new List<ProductToBuy>();
            FrmMenu.lista = new List<ProductToBuy>();
            ProductDAO p = new ProductDAO();
            int filasModificadas = p.ResetUnitsOnOrder(products);
            if (filasModificadas == 0)
            {
                MessageBox.Show("Error al realizar la operación.");
            }
            else
            {
                MessageBox.Show("Operación realizada exitosamente.");
            }
        }
    }
}
