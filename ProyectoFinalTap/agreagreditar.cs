using Datos;
using Google.Protobuf.WellKnownTypes;
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
using System.Xml.Linq;

namespace ProyectoFinalTap
{
    public partial class agreagreditar : Form
    {
        public  Category categories;

        public agreagreditar( Category ca)
        {
            InitializeComponent();
            this.categories = ca;
            LoadControls();
        }
        private void LoadControls()
        {
            cbocategories.DataSource = CatalogoCategorias.categories;
            cbocategories.DisplayMember = "CategoryName";
            cbocategories.SelectedIndex = categories.CategoryID;
            txtid.Text=categories.CategoryID+ " ";
          
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtdesc.Text.Equals("") || cbocategories.SelectedIndex < 1)
            {
                MessageBox.Show("Por favor ingrese el nombre del producto");
                return;
            }
            if (cbocategories.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor indique la categoría del producto");
                return;
            }
            
            Category categories = new Category();
            categories.CategoryDescription = txtdesc.Text;
            categories.CategoryID = ((Category)cbocategories.SelectedItem).CategoryID;
            
            if (categories.CategoryID == 0) CategoryDAO.Insert(categories,false);
            else CategoryDAO.Update(categories);
            this.Dispose();
        }
    }

    
}

