namespace ProyectoFinalTap
{
    partial class FrmProducto
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
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.cbxDescontinuado = new MetroFramework.Controls.MetroCheckBox();
            this.cmbCompania = new MetroFramework.Controls.MetroComboBox();
            this.cmbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblCompania = new MetroFramework.Controls.MetroLabel();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioUnitario = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(37, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 29);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 29);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxDescontinuado
            // 
            this.cbxDescontinuado.AutoSize = true;
            this.cbxDescontinuado.Location = new System.Drawing.Point(128, 303);
            this.cbxDescontinuado.Name = "cbxDescontinuado";
            this.cbxDescontinuado.Size = new System.Drawing.Size(103, 15);
            this.cbxDescontinuado.TabIndex = 15;
            this.cbxDescontinuado.Text = "Descontinuado";
            this.cbxDescontinuado.UseVisualStyleBackColor = true;
            // 
            // cmbCompania
            // 
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.ItemHeight = 23;
            this.cmbCompania.Location = new System.Drawing.Point(128, 119);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(210, 29);
            this.cmbCompania.TabIndex = 16;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 23;
            this.cmbCategoria.Location = new System.Drawing.Point(128, 163);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(209, 29);
            this.cmbCategoria.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 213);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(210, 23);
            this.txtPrecio.TabIndex = 19;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(127, 260);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(210, 23);
            this.txtStock.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(48, 119);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(73, 19);
            this.lblCompania.TabIndex = 22;
            this.lblCompania.Text = "Compañia:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(1, 163);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(121, 19);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Nombre categoria:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(23, 213);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(97, 19);
            this.lblPrecioUnitario.TabIndex = 24;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(5, 260);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(117, 19);
            this.lblStock.TabIndex = 25;
            this.lblStock.Text = "Unidades en stock:";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 410);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCompania);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.cbxDescontinuado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroCheckBox cbxDescontinuado;
        private MetroFramework.Controls.MetroComboBox cmbCompania;
        private MetroFramework.Controls.MetroComboBox cmbCategoria;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblCompania;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroLabel lblPrecioUnitario;
        private MetroFramework.Controls.MetroLabel lblStock;
    }
}