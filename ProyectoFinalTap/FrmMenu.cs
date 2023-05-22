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
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //DJVC Metodo para cuando se ocupe revisar si se loguea el usuario de mayor rango
        //public void ocultarEmpleados(bool ocultar)
        //{
        //    if (ocultar)
        //    {
        //        lblCatalogoEmpleados.Visible = false;
        //        btnCEmpleados.Visible = false;
        //        btnCEmpleados.Enabled = false;
        //    }
        //    else
        //    {
        //        lblCatalogoEmpleados.Visible = true;
        //        btnCEmpleados.Visible = true;
        //        btnCEmpleados.Enabled = true;
        //    }
        //}

        private void mbtnCProducts_Click(object sender, EventArgs e)
        {
            FrmCatalogoProductos frm = new FrmCatalogoProductos();
            frm.ShowDialog();
            
        }

        private void mbtnCCategories_Click(object sender, EventArgs e)
        {
            FrmCatalogoCategorias frm3 = new FrmCatalogoCategorias();
            frm3.ShowDialog();
        }
    }
}
