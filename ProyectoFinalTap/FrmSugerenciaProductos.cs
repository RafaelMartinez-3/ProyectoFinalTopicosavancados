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
        //Lista para guardar los datos de los productos por comprar
        List<ProductToBuy> products = new List<ProductToBuy>();
        public FrmSugerenciaProductos(List<ProductToBuy> l)
        {
            //Llenamos el gridview con los datos de la lista
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
            //Comparamos si son la misma, si no lo son, la añadimos
            if (!FrmMenu.lista.SequenceEqual(products))
            {
                //Actualizamos con UnitsOnOrder
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
                    //Tomamos la primera ventana abierta de tipo productos a comprar
                    if (System.Windows.Forms.Application.OpenForms.OfType<FrmProductosAComprar>().Any())
                    {
                        //Tomamos dicha ventana con los datos e actualizamos
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
