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
using Datos;
using Modelos;

namespace ProyectoFinalTap
{
    public partial class FrmVenta : MetroFramework.Forms.MetroForm
    {
		static Employee empleadoGeneral;
		double totalPantalla;
         public List<Sales> ventitas = new List<Sales>();
		List<Product> productos	= new List<Product>();
		List<Customer> clientes = new List<Customer>();
        FrmInicioVentas ventas = new FrmInicioVentas(empleadoGeneral);
        public FrmVenta(Employee empleado)
        {
            InitializeComponent();
            
            //Inicializar componentes
            empleadoGeneral = empleado;
			clientes = new CustomerDAO().getCustomers();
            cbxCliente.DataSource = clientes;
			cbxCliente.DisplayMember = "CompanyName";
			cbxCliente.ValueMember = "CustomerID";
			cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
			productos = new ProductDAO().GetAll();
			cbxProducto.DataSource = productos;
            cbxProducto.DisplayMember = "ProductName";
            cbxProducto.ValueMember = "ProductID";
            cbxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvVenta.DataSource = ventitas;
			dgvVenta.AllowUserToAddRows = false;
			dgvVenta.AllowUserToDeleteRows = false;
			dgvVenta.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvVenta.Columns["ProductID"].Visible = false;
			dgvVenta.Columns["UnitsInStock"].Visible = false;
			dgvVenta.Columns["ProductName"].HeaderText = "Producto";
			dgvVenta.Columns["UnitPrice"].HeaderText = "Precio";
			dgvVenta.Columns["Quantity"].HeaderText = "Unidades";
			dgvVenta.Columns["Subtotal"].HeaderText = "Subtotal";
			this.Text = "Venta - " + empleado.FirstName;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			//Agregar la validacion de que no ingrese 0 o negativos en la cantidad, asi como agregar
			//Los datos que pide la maestra a la tabla cuando se agregue un producto
			Regex validarNumeros = new Regex("^[1-9][0-9]*$");
			if(validarNumeros.Match(txtUnidades.Text).Success)
			{
				int lugar = cbxProducto.SelectedIndex;
				if (productos[lugar].UnitsInStock-Convert.ToInt32(txtUnidades.Text)>0)
				{
					//Agregamos los datos a la lista de ventitas para mostrarlo despues en la tabla 
					bool existeUnaIgual = false;
					dgvVenta.DataSource = null;
					for(int i=0; i<ventitas.Count; i++)
					{
						if (ventitas[i].ProductID.Equals(cbxProducto.SelectedValue))
						{
							ventitas[i].Quantity += Convert.ToInt32(txtUnidades.Text);
							productos[lugar].UnitsInStock -= Convert.ToInt32(txtUnidades.Text);
							ventitas[i].UnitsInStock -= Convert.ToInt32(txtUnidades.Text);
							totalPantalla -= ventitas[i].Subtotal;
							ventitas[i].Subtotal = ventitas[i].Quantity * ventitas[i].UnitPrice;
							totalPantalla += ventitas[i].Subtotal;
							existeUnaIgual = true;
							break;
						}
					}
					//Si no existe la venta, la agregamos
					if(!existeUnaIgual)
					{
						Sales nuevaVenta = new Sales();
						nuevaVenta.ProductID = Convert.ToInt32(cbxProducto.SelectedValue);
						nuevaVenta.ProductName = productos[lugar].ProductName;
						nuevaVenta.UnitPrice = productos[lugar].UnitPrice;
						nuevaVenta.Quantity = Convert.ToInt32(txtUnidades.Text);
						productos[lugar].UnitsInStock -= nuevaVenta.Quantity;
						nuevaVenta.UnitsInStock = productos[lugar].UnitsInStock;
						nuevaVenta.Subtotal = nuevaVenta.Quantity * nuevaVenta.UnitPrice;
						totalPantalla += nuevaVenta.Subtotal;
						ventitas.Add(nuevaVenta);
					}
					//Reiniciar el data grid view
					lblTotal.Text = totalPantalla+"";
					dgvVenta.DataSource = ventitas;
					dgvVenta.AllowUserToAddRows = false;
					dgvVenta.AllowUserToDeleteRows = false;
					dgvVenta.EditMode = DataGridViewEditMode.EditProgrammatically;
					dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					dgvVenta.Columns["ProductID"].Visible = false;
					dgvVenta.Columns["UnitsInStock"].Visible = false;
					dgvVenta.Columns["ProductName"].HeaderText = "Producto";
					dgvVenta.Columns["UnitPrice"].HeaderText = "Precio";
					dgvVenta.Columns["Quantity"].HeaderText = "Unidades";
					dgvVenta.Columns["Subtotal"].HeaderText = "Subtotal";

				}
				else
				{
					MessageBox.Show("No hay cantidades suficientes para este producto.", "Error",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Debe ingresar números validos en la cantidad.", "Error",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
            //Eliminamos el campo que estemos seleccionando en el gridview
            DataGridViewRow filaSeleccionada = dgvVenta.SelectedRows[0];
			
			for(int i=0; i<ventitas.Count; i++)
			{
                if (ventitas[i].ProductName==filaSeleccionada.Cells[0].Value.ToString())
				{
					lblTotal.Text = (totalPantalla - ventitas[i].Subtotal) + "";
					ventitas.RemoveAt(i);
					break;
				}
			}
            //Actualizamos la tabla
            dgvVenta.DataSource = null;
            dgvVenta.DataSource = ventitas;
			dgvVenta.AllowUserToAddRows = true;
			dgvVenta.AllowUserToDeleteRows = true;
			dgvVenta.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvVenta.Columns["ProductID"].Visible = false;
			dgvVenta.Columns["UnitsInStock"].Visible = false;
			dgvVenta.Columns["ProductName"].HeaderText = "Producto";
			dgvVenta.Columns["UnitPrice"].HeaderText = "Precio";
			dgvVenta.Columns["Quantity"].HeaderText = "Unidades";
			dgvVenta.Columns["Subtotal"].HeaderText = "Subtotal";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			ventitas = null;
			this.Close();
		}

		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			//Generamos las consultas pertinentes para agregar los datos a las tablas correspondientes
			bool todoExitoso = true;
			OrderDAO ordenes = new OrderDAO();
			ProductDAO productos = new ProductDAO();
			if(ordenes.insertOrder(cbxCliente.SelectedValue.ToString(), empleadoGeneral.EmployeeId)>0)
			{
				for (int i = 0; i < ventitas.Count; i++)
				{
					if(productos.UpdateInvetory(ventitas[i].ProductID, ventitas[i].UnitsInStock)>0)
					{
						if (ordenes.insertOrderDetails(ventitas[i].ProductID, ventitas[i].UnitPrice, ventitas[i].Quantity)>0)
						{
							continue;
						}
						else
						{
							MessageBox.Show("Ha ocurrido un error al querer hacer la venta, intentelo de nuevo mas " +
								"tarde.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
							todoExitoso = false;
							break;
						}
					}
					else
					{
						MessageBox.Show("Ha ocurrido un error al querer hacer la venta, intentelo de nuevo mas " +
							"tarde.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						todoExitoso = false;
						break;
					}
				}
			}
			else
			{
				MessageBox.Show("Ha ocurrido un error al querer hacer la venta, intentelo de nuevo mas " +
					"tarde.", "Error",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				todoExitoso = false;
			}
			if(todoExitoso)
			{
				MessageBox.Show("Venta generada exitosamente.", "Información",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
				
			}
		}
	}
}
