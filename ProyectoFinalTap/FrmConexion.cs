using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Properties;

namespace ProyectoFinalTap
{
    public partial class FrmConexion : MetroForm
    {
        public FrmConexion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Datos.Properties.Settings.Default.Servidor);
     
            Datos.Properties.Settings.Default.Servidor = txtServidor.Text;
            Datos.Properties.Settings.Default.Usuario = txtUsuario.Text;
            Datos.Properties.Settings.Default.Contrasenia = txtContrasenia.Text;
            Datos.Properties.Settings.Default.Save();

            MessageBox.Show(Datos.Properties.Settings.Default.Servidor);
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
