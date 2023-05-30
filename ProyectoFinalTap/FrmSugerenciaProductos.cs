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
    public partial class FrmSugerenciaProductos : MetroForm
    {
        List<ProductToBuy> products = new List<ProductToBuy>();
        public FrmSugerenciaProductos(List<ProductToBuy> l)
        {
            products = l;
            InitializeComponent();
            dgvSugerencias.DataSource = products;
            dgvSugerencias.AllowUserToAddRows = false;
            dgvSugerencias.AllowUserToDeleteRows = false;
            dgvSugerencias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSugerencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSugerencias.Columns["ProductName"].HeaderText = "Producto";
            dgvSugerencias.Columns["BuySuggestion"].HeaderText = "Sugerencia";
            dgvSugerencias.Columns["ProductId"].Visible = false;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if (!FrmMenu.lista.SequenceEqual(products))
            {
                FrmMenu.lista.AddRange(products);
                ProductDAO p = new ProductDAO();
                int filasModificadas = p.UpdateUnitsOnOrder(products);
                if (filasModificadas == 0)
                {
                    MessageBox.Show("Error al realizar la operación.");
                }
                else
                {
                    MessageBox.Show("Operación realizada exitosamente.");
                    if (System.Windows.Forms.Application.OpenForms.OfType<FrmProductosAComprar>().Any())
                    {
                        FrmProductosAComprar form = System.Windows.Forms.Application.OpenForms.OfType<FrmProductosAComprar>().FirstOrDefault();
                        if (form != null)
                        {
                            form.Invoke(new Action(() => form.actualizarDGV()));
                        }
                    }
                    this.Dispose();
                }
            }
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
