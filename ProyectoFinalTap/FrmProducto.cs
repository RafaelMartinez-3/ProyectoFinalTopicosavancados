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
    /*
     Creado por: Ayala Ramos Pedro Antonio
    Esta ventana hace referencia a metodos que tenemos en las clases que previamente creamos y 
    la funcionalidad principal es agregar/editar un producto de preferencia y asi tener una mejor 
    administracion de los datos que queremos.
     */
    //DJVC Cambios para agregar ReorderLevel
    public partial class FrmProducto : MetroForm
    {
        //Valores iniciales para poder agregar/editar productos
        private int proId;
        private List<Category> categorias = new CategoryDAO().GetAll();
        private List<Supplier> companias = new SupplierDAO().GetMinimum();
        public FrmProducto()
        {
            //Actualizamos los combobox de la ventana
            InitializeComponent();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "CategoryName";
            cmbCategoria.ValueMember = "CategoryId";
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompania.DataSource = companias;
            cmbCompania.DisplayMember = "CompanyName";
            cmbCompania.ValueMember = "SupplierId";
            cmbCompania.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Metodo para establecer valores si es que existen, si no, se quedan por default los controles.
        /// </summary>
        /// <param name="pId">Id del producto</param>
        /// <param name="pName">Nombre del producto</param>
        /// <param name="sId">Id del proveedor</param>
        /// <param name="cId">Id del cliente</param>
        /// <param name="uPrice">Precio por unidad</param>
        /// <param name="uStock">Unidades en stock</param>
        /// <param name="reorder">Nivel de reorder</param>
        /// <param name="discont">Productos descontinuados</param>
        public void establecerValores(int pId,string pName,int sId,int cId,
            double uPrice,int uStock, int reorder, bool discont)
        {
            proId = pId;
            if(pId != 0)
            {
                txtNombre.Text = pName;
                cmbCategoria.SelectedValue = cId;
                cmbCompania.SelectedValue = sId;
                txtPrecio.Text = uPrice + "";
                txtStock.Text = uStock + "";
                txtReorden.Text = reorder + "";
                cbxDescontinuado.Checked = discont;
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //Actualizamos/Insertamos los datos que nos pusieron en la ventana
            ProductDAO p = new ProductDAO();
            Product prdt;
            int contFilasModificadas = 0;
            int unidadesStock = 0;
            int reorder = 0;
            double precioUnidad = 0.0;
            if (!double.TryParse(txtPrecio.Text, out precioUnidad))
            {
                MessageBox.Show("Precio unitario no valido. Debe ser un número.");
            }
            else if (!int.TryParse(txtStock.Text, out unidadesStock))
            {
                MessageBox.Show("Unidades en stock no valido. Debe ser un número.");
            }
            else if (!int.TryParse(txtReorden.Text, out reorder))
            {
                MessageBox.Show("Nivel de reorden no valido. Debe ser un número.");
            }
            else
            {
                if (proId == 0)
                {
                    //Insertamos el nuevo dato
                    prdt = new Product(0, txtNombre.Text, int.Parse(cmbCompania.SelectedValue.ToString()), cmbCategoria.SelectedText,
                            int.Parse(cmbCategoria.SelectedValue.ToString()), cmbCategoria.SelectedText, precioUnidad, unidadesStock, reorder, cbxDescontinuado.Checked);
                    contFilasModificadas = p.Insert(prdt);
                }
                else
                {
                    //Actualizamos a nuevos datos
                    prdt = new Product(proId, txtNombre.Text, int.Parse(cmbCompania.SelectedValue.ToString()), cmbCategoria.SelectedText,
                        int.Parse(cmbCategoria.SelectedValue.ToString()), cmbCategoria.SelectedText, precioUnidad, unidadesStock, reorder, cbxDescontinuado.Checked);
                    contFilasModificadas = p.Update(prdt);
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
