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
            //Guardamos lo que nos ingresen en los controles directamente en el almacenamiento de la 
            //aplicacion
            Datos.Properties.Settings.Default.Servidor = txtServidor.Text;
            Datos.Properties.Settings.Default.Usuario = txtUsuario.Text;
            Datos.Properties.Settings.Default.Contrasenia = txtContrasenia.Text;
            Datos.Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
