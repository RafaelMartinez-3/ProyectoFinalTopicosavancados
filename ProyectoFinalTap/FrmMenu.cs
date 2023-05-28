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
using Modelos;
using Org.BouncyCastle.Asn1.Crmf;

namespace ProyectoFinalTap
{
    /// <summary>
    /// Noemi Guzman Aguilera, Dependiendo al usuario autentificado se le mostraran solo las funciones 
    /// correspondientes.
    /// </summary>
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        Employee empleadoGlobal;
        public FrmMenu()
        {
            InitializeComponent();
            
        }
        public FrmMenu(Employee empl)
        {
            InitializeComponent();
            empleadoGlobal = empl;
            lblCatalogoCategorias.Visible = false;
            btnCCategories.Visible = false;
            lblCatalogoProductos.Visible = false;
            btnCProducts.Visible = false;
            lblCEmpleados.Visible = false;
            btnCEmpleados.Visible = false;
            lblVentas.Visible = false;
            btnVentasIr.Visible = false;
            if (empl.Title.Equals("Sales Representative"))
            {
                SaleRepresentative();
            }
            else if (empl.Title.Equals("Inside Sales Coordinator"))
            {
                InsideSalesCoordinador();
            }
            else if (empl.Title.Equals("Vice President, Sales"))
            {
                VicePresidentSales();
            }
            else
            {

            }
        }

        public  void SaleRepresentative()
        {
            lblVentas.Visible = true;
            btnVentasIr.Visible = true;
            

        }
        public  void InsideSalesCoordinador()
        {
            lblCatalogoCategorias.Visible = true;
            btnCCategories.Visible = true;
            lblCatalogoProductos.Visible = true;
            btnCProducts.Visible = true;
            lblVentas.Visible = true;
            btnVentasIr.Visible = true;

        }
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
        }

        private  void mbtnCProducts_Click(object sender, EventArgs e)
        {
            FrmCatalogoProductos frm = new FrmCatalogoProductos();
            frm.ShowDialog();
            
        }

        private void mbtnCCategories_Click(object sender, EventArgs e)
        {
            FrmCatalogoCategorias frm3 = new FrmCatalogoCategorias();
            frm3.ShowDialog();
        }

        private void btnVentasIr_Click(object sender, EventArgs e)
        {
            FrmInicioVentas frmV = new FrmInicioVentas(empleadoGlobal);
            frmV.ShowDialog();
        }
    }
}
