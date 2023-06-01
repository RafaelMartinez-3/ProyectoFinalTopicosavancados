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
    /// <summary>
    /// Noemi Guzman Aguilera
    /// </summary>
    public partial class FrmMenu : MetroForm
    {
        //Lista para mostrar los productos a comprar
        public static List<ProductToBuy> lista = new List<ProductToBuy>();
        Employee empleadoGlobal;
        public FrmMenu()
        {
            InitializeComponent();
        }
        public FrmMenu(Employee empl)
        {
            InitializeComponent();
            //Inicializamos los controles para que no se muestren
            empleadoGlobal = empl;
            lblCatalogoCategorias.Visible = false;
            btnCCategories.Visible = false;
            lblCatalogoProductos.Visible = false;
            btnCProducts.Visible = false;
            lblCEmpleados.Visible = false;
            btnCEmpleados.Visible = false;
            lblVentas.Visible = false;
            btnVentasIr.Visible = false;
            lblProductosAComprar.Visible = false;
            btnProductosComprarIr.Visible = false;
            //Y las mostramos segun el rango del empleado que este ingresando
            if (empl.Title.Equals("Sales Representative"))
            {
                SaleRepresentative();
            }
            else if (empl.Title.Equals("Inside Sales Coordinator") || empl.Title.Equals("Sales Manager"))
            {
                InsideSalesCoordinador();
            }
            else if (empl.Title.Equals("Vice President, Sales"))
            {
                VicePresidentSales();
            }
        }

        /// <summary>
        /// Mostramos los controles para sales representative
        /// </summary>
        public void SaleRepresentative()
        {
            lblVentas.Visible = true;
            btnVentasIr.Visible = true;
        }
        /// <summary>
        /// Mostramos los controles para el inside sales coordinador
        /// </summary>
        public void InsideSalesCoordinador()
        {
            lblCatalogoCategorias.Visible = true;
            btnCCategories.Visible = true;
            lblCatalogoProductos.Visible = true;
            btnCProducts.Visible = true;
            lblVentas.Visible = true;
            btnVentasIr.Visible = true;
            lblProductosAComprar.Visible = true;
            btnProductosComprarIr.Visible = true;
            //Iniciamos la task para mostrar cada cierto tiempo los productos que deberiamos comprar
            Task.Factory.StartNew(() =>
            {
                List<ProductToBuy> list1;
                Task.Delay(6000).Wait();
                while (true)
                {
                    //Si no esta abierto el menu, no abrimos ese form
                    if (!System.Windows.Forms.Application.OpenForms.OfType<FrmMenu>().Any())
                    {
                        break;
                    }
                    //Si esta abierto, entonces tomamos los productos a comprar y lo mostramos
                    list1 = new ProductDAO().GetElementsToBuy();
                    if (list1.Count != 0)
                    {
                        FrmSugerenciaProductos sugerencias = new FrmSugerenciaProductos(list1);
                        sugerencias.ShowDialog();
                    }
                    Task.Delay(6000).Wait();
                }
            });
        }
        /// <summary>
        /// Metodo para mostrar los controles al vice president sales
        /// </summary>
        public void VicePresidentSales()
        {
            lblCatalogoCategorias.Visible = true;
            btnCCategories.Visible = true;
            lblCatalogoProductos.Visible = true;
            btnCProducts.Visible = true;
            lblCEmpleados.Visible = true;
            btnCEmpleados.Visible = true;
            lblVentas.Visible = true;
            btnVentasIr.Visible = true;
            lblProductosAComprar.Visible = true;
            btnProductosComprarIr.Visible = true;
        }


        private void mbtnCProducts_Click(object sender, EventArgs e)
        {
            FrmCatalogoProductos frm = new FrmCatalogoProductos();
            frm.ShowDialog();
            
        }

        private void mbtnCCategories_Click(object sender, EventArgs e)
        {
            //Abrir el catalogo de categorias
            FrmCatalogoCategorias frm2 = new FrmCatalogoCategorias();
            frm2.ShowDialog();
        }

        private void btnCEmpleados_Click(object sender, EventArgs e)
        {
            //Abrir el catalogo de empleados
            FrmCatalogoEmpleados frm3 = new FrmCatalogoEmpleados();
            frm3.ShowDialog();
        }

        private void btnVentasIr_Click(object sender, EventArgs e)
        {
            //Abrir las ventas
            FrmInicioVentas frm4 = new FrmInicioVentas(empleadoGlobal);
            frm4.ShowDialog();
        }

        private void btnProductosComprarIr_Click(object sender, EventArgs e)
        {
            //Abrir los productos a comprar
            FrmProductosAComprar frm5 = new FrmProductosAComprar();
            frm5.ShowDialog();
        }
    }
}
