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
    public partial class FrmCategoria : MetroForm
    {
        private int catId = 0;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Establecemos con valores predeterminamos a los controles
        /// </summary>
        /// <param name="categoryId">Id de la categoria</param>
        /// <param name="nombreCat">Nombre de la categoria</param>
        /// <param name="descripcionCat">Descripcion de la categoria</param>
        public void establecerValores(int categoryId, String nombreCat, String descripcionCat)
        {
            catId = categoryId;
            txtNombre.Text = nombreCat;
            txtDescripcion.Text = descripcionCat;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si damos en aceptar, insertaremos/modificaremos los campos segun corresponda
            CategoryDAO c = new CategoryDAO();
            Category cat;
            int contFilasModificadas = 0;
            if (catId == 0)
            {
                cat = new Category(0, txtNombre.Text, txtDescripcion.Text);
                contFilasModificadas = c.Insert(cat);
            }
            else
            {
                cat = new Category(catId, txtNombre.Text, txtDescripcion.Text);
                contFilasModificadas = c.Update(cat);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
