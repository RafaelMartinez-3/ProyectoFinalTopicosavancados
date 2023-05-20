using Datos;
using Model;
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
    public partial class Form1 : Form
    {
        public static List<Categorias> categories;
        public Form1()
        {
            Conexion con = new Conexion();

            categories = new categoriasdao().GetAll();
            InitializeComponent();
            dgvcategories.DataSource = categories;
            dgvcategories.AllowUserToAddRows = false;
            dgvcategories.AllowUserToDeleteRows = false;
            dgvcategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcategories.Columns["CategoryName"].HeaderText = "Categoría";
            //dgvcategories.Columns["description"].HeaderText = "Descripcion";
            dgvcategories.Columns["CategoryID"].HeaderText= "Identificador";

        }
    }
}
