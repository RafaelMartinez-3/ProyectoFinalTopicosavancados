namespace ProyectoFinalTap
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTitulos = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.lblJefeDirecto = new MetroFramework.Controls.MetroLabel();
            this.lblCodigoPostal = new MetroFramework.Controls.MetroLabel();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.cmbJefeDirecto = new MetroFramework.Controls.MetroComboBox();
            this.txtCodigoPostal = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cmbTitulos
            // 
            this.cmbTitulos.FormattingEnabled = true;
            this.cmbTitulos.ItemHeight = 23;
            this.cmbTitulos.Location = new System.Drawing.Point(120, 239);
            this.cmbTitulos.Name = "cmbTitulos";
            this.cmbTitulos.Size = new System.Drawing.Size(312, 29);
            this.cmbTitulos.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 42);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(160, 425);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 42);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblJefeDirecto
            // 
            this.lblJefeDirecto.AutoSize = true;
            this.lblJefeDirecto.Location = new System.Drawing.Point(33, 357);
            this.lblJefeDirecto.Name = "lblJefeDirecto";
            this.lblJefeDirecto.Size = new System.Drawing.Size(80, 19);
            this.lblJefeDirecto.TabIndex = 33;
            this.lblJefeDirecto.Text = "Jefe directo:";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(18, 301);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(99, 19);
            this.lblCodigoPostal.TabIndex = 32;
            this.lblCodigoPostal.Text = " Código postal:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(73, 239);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 19);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(46, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 19);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbJefeDirecto
            // 
            this.cmbJefeDirecto.FormattingEnabled = true;
            this.cmbJefeDirecto.ItemHeight = 23;
            this.cmbJefeDirecto.Location = new System.Drawing.Point(120, 357);
            this.cmbJefeDirecto.Name = "cmbJefeDirecto";
            this.cmbJefeDirecto.Size = new System.Drawing.Size(312, 29);
            this.cmbJefeDirecto.TabIndex = 28;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(120, 301);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(312, 23);
            this.txtCodigoPostal.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 183);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(312, 23);
            this.txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 23);
            this.txtNombre.TabIndex = 25;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 508);
            this.Controls.Add(this.cmbTitulos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblJefeDirecto);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbJefeDirecto);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmEmpleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbTitulos;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroLabel lblJefeDirecto;
        private MetroFramework.Controls.MetroLabel lblCodigoPostal;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroComboBox cmbJefeDirecto;
        private MetroFramework.Controls.MetroTextBox txtCodigoPostal;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
    }
}