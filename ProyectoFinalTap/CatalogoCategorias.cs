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
    public partial class CatalogoCategorias : MetroForm
    {
        public static List<Category> categories;
        private agreagreditar agregarEditar;

        public CatalogoCategorias()
        {
            Conexion con = new Conexion();

            categories = new CategoryDAO().GetAll();
            InitializeComponent();
            dgvcategories.DataSource = categories;
            dgvcategories.AllowUserToAddRows = false;
            dgvcategories.AllowUserToDeleteRows = false;
            dgvcategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcategories.Columns["CategoryName"].HeaderText = "Categoría";
            //dgvcategories.Columns["description"].HeaderText = "Descripcion";
            dgvcategories.Columns["CategoryID"].HeaderText= "Identificador";

        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            agregarEditar = new agreagreditar(new Category());
            agregarEditar.FormClosed += new FormClosedEventHandler(AgregarEditarFormClosed);
            agregarEditar.ShowDialog();
        }
        private void AgregarEditarFormClosed(object sender, FormClosedEventArgs e)
        {
            Conexion con = new Conexion();

            categories = new CategoryDAO().GetAll();
            InitializeComponent();
            dgvcategories.DataSource = categories;
            dgvcategories.AllowUserToAddRows = false;
            dgvcategories.AllowUserToDeleteRows = false;
            dgvcategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcategories.Columns["CategoryName"].HeaderText = "Categoría";
            //dgvcategories.Columns["description"].HeaderText = "Descripcion";
            dgvcategories.Columns["CategoryID"].HeaderText = "Identificador";

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvcategories.SelectedRows.Count > 0)
            {
                int index = dgvcategories.CurrentRow.Index;
                Category cat= categories[index];
                agregarEditar = new agreagreditar(cat);
                agregarEditar.FormClosed += new FormClosedEventHandler(AgregarEditarFormClosed);
                agregarEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro que desea editar.");
            }
        }
    }
}
