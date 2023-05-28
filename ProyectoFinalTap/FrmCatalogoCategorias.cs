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
            Conexion con = new Conexion();

            categories = new CategoryDAO().GetAll();
            InitializeComponent();
            dgvcategories.DataSource = categories;
            dgvcategories.AllowUserToAddRows = false;
            dgvcategories.AllowUserToDeleteRows = false;
            dgvcategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcategories.Columns["CategoryName"].HeaderText = "Categoría";
            dgvcategories.Columns["CategoryDescription"].HeaderText = "Descripción";
            dgvcategories.Columns["CategoryID"].HeaderText= "Identificador";
        }
    }
}
