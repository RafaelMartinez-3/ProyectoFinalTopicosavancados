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
    public partial class FrmInicioVentas : MetroFramework.Forms.MetroForm
    {
        Employee empleadoGeneral;
        public FrmInicioVentas(Employee empleado)
        {
            InitializeComponent();
            empleadoGeneral = empleado;
        }

		private void btnAgregar_Click(object sender, EventArgs e)
		{
            FrmVenta nuevaVenta = new FrmVenta(empleadoGeneral);
            nuevaVenta.ShowDialog();
		}
	}
}
