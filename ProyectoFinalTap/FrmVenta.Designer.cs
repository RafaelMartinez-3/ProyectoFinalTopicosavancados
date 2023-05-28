namespace ProyectoFinalTap
{
    partial class FrmVenta
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
			this.cbxCliente = new MetroFramework.Controls.MetroComboBox();
			this.lblCliente = new MetroFramework.Controls.MetroLabel();
			this.lblProducto = new MetroFramework.Controls.MetroLabel();
			this.cbxProducto = new MetroFramework.Controls.MetroComboBox();
			this.lblUnidades = new MetroFramework.Controls.MetroLabel();
			this.txtUnidades = new MetroFramework.Controls.MetroTextBox();
			this.lblTituloTotal = new MetroFramework.Controls.MetroLabel();
			this.lblTotal = new MetroFramework.Controls.MetroLabel();
			this.btnAgregar = new MetroFramework.Controls.MetroButton();
			this.btnQuitar = new MetroFramework.Controls.MetroButton();
			this.btnFinalizar = new MetroFramework.Controls.MetroButton();
			this.btnCancelar = new MetroFramework.Controls.MetroButton();
			this.dgvVenta = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxCliente
			// 
			this.cbxCliente.FormattingEnabled = true;
			this.cbxCliente.ItemHeight = 23;
			this.cbxCliente.Location = new System.Drawing.Point(78, 89);
			this.cbxCliente.Name = "cbxCliente";
			this.cbxCliente.Size = new System.Drawing.Size(275, 29);
			this.cbxCliente.TabIndex = 0;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(23, 89);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(49, 19);
			this.lblCliente.TabIndex = 1;
			this.lblCliente.Text = "Cliente";
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Location = new System.Drawing.Point(9, 138);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(63, 19);
			this.lblProducto.TabIndex = 4;
			this.lblProducto.Text = "Producto";
			// 
			// cbxProducto
			// 
			this.cbxProducto.FormattingEnabled = true;
			this.cbxProducto.ItemHeight = 23;
			this.cbxProducto.Location = new System.Drawing.Point(78, 138);
			this.cbxProducto.Name = "cbxProducto";
			this.cbxProducto.Size = new System.Drawing.Size(328, 29);
			this.cbxProducto.TabIndex = 5;
			// 
			// lblUnidades
			// 
			this.lblUnidades.AutoSize = true;
			this.lblUnidades.Location = new System.Drawing.Point(9, 193);
			this.lblUnidades.Name = "lblUnidades";
			this.lblUnidades.Size = new System.Drawing.Size(63, 19);
			this.lblUnidades.TabIndex = 6;
			this.lblUnidades.Text = "Unidades";
			// 
			// txtUnidades
			// 
			this.txtUnidades.Location = new System.Drawing.Point(78, 193);
			this.txtUnidades.Name = "txtUnidades";
			this.txtUnidades.Size = new System.Drawing.Size(75, 23);
			this.txtUnidades.TabIndex = 7;
			// 
			// lblTituloTotal
			// 
			this.lblTituloTotal.AutoSize = true;
			this.lblTituloTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblTituloTotal.Location = new System.Drawing.Point(495, 53);
			this.lblTituloTotal.Name = "lblTituloTotal";
			this.lblTituloTotal.Size = new System.Drawing.Size(50, 19);
			this.lblTituloTotal.TabIndex = 8;
			this.lblTituloTotal.Text = "TOTAL";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblTotal.Location = new System.Drawing.Point(495, 72);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(37, 19);
			this.lblTotal.TabIndex = 9;
			this.lblTotal.Text = "0.00";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(485, 144);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Location = new System.Drawing.Point(637, 231);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(75, 23);
			this.btnQuitar.TabIndex = 11;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Location = new System.Drawing.Point(180, 436);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
			this.btnFinalizar.TabIndex = 13;
			this.btnFinalizar.Text = "Finalizar";
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(379, 436);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// dgvVenta
			// 
			this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVenta.Location = new System.Drawing.Point(41, 242);
			this.dgvVenta.Name = "dgvVenta";
			this.dgvVenta.Size = new System.Drawing.Size(559, 150);
			this.dgvVenta.TabIndex = 15;
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 488);
			this.Controls.Add(this.dgvVenta);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblTituloTotal);
			this.Controls.Add(this.txtUnidades);
			this.Controls.Add(this.lblUnidades);
			this.Controls.Add(this.cbxProducto);
			this.Controls.Add(this.lblProducto);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.cbxCliente);
			this.Name = "FrmVenta";
			this.Text = "Venta";
			((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxCliente;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroComboBox cbxProducto;
        private MetroFramework.Controls.MetroLabel lblUnidades;
        private MetroFramework.Controls.MetroTextBox txtUnidades;
        private MetroFramework.Controls.MetroLabel lblTituloTotal;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnQuitar;
        private MetroFramework.Controls.MetroButton btnFinalizar;
        private MetroFramework.Controls.MetroButton btnCancelar;
		private System.Windows.Forms.DataGridView dgvVenta;
	}
}