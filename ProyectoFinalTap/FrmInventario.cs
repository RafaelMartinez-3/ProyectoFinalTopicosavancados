using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Forms;

namespace ProyectoFinalTap
{
    /*
     Creado por: Ayala Ramos Pedro Antonio
    Hacemos referencia a metodos ya antes creados en nuestras clases para poder administrar el
    inventario que pasa por nuestra aplicacion, asi como poder ir agregando mas si es que asi lo 
    deseamos y validando que no nos vayan a ingresar valores negativos o cero.
     */
    public partial class FrmInventario : MetroForm
    {
        private List<Inventory> inventario;
        public FrmInventario()
        {
            InitializeComponent();
            //Llenar el combobox con los productos a querer comprar
            inventario = new ProductDAO().GetInventory();
            cbxProductos.DataSource = inventario;
            cbxProductos.DisplayMember = "ProductName";
            cbxProductos.ValueMember = "ReorderLevel";
            cbxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Hacemos una expresion regular para solo aceptar numeros
            Regex validarNumeros = new Regex("^[1-9][0-9]*$");
            if (validarNumeros.Match(txtCantidad.Text).Success)
            {
                //Tomamos el seleccionado y verificamos si todo esta en orden (con el reoder level y las unidades)
                int lugar = cbxProductos.SelectedIndex;
                if ((inventario[lugar].ReorderLevel * 5) >=
                    (inventario[lugar].UnitsInStock + Convert.ToInt32(txtCantidad.Text)))
                {
                    //Actualizamos los campos en la base de datos
                    if (new ProductDAO().UpdateInvetory(inventario[lugar].ProductID,
                        inventario[lugar].UnitsInStock + Convert.ToInt32(txtCantidad.Text)) > 0)
                    {
                        MessageBox.Show("Inventario actualizado exitosamente.", "Informacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Tomamos nuevamente el inventario con los datos actualizados
                        inventario = new ProductDAO().GetInventory();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo efectuar la actualizacion, intentelo mas tarde. ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada rebasa el limite de inventario permitida para ese producto.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar números validos en la cantidad.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
