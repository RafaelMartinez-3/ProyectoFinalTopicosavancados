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
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnFinalizar = new MetroFramework.Controls.MetroButton();
            this.btnQuitar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblTituloTotal = new MetroFramework.Controls.MetroLabel();
            this.txtUnidades = new MetroFramework.Controls.MetroTextBox();
            this.lblUnidades = new MetroFramework.Controls.MetroLabel();
            this.cbxProducto = new MetroFramework.Controls.MetroComboBox();
            this.lblProducto = new MetroFramework.Controls.MetroLabel();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.cbxCliente = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(52, 273);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(559, 150);
            this.dgvVenta.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(356, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 43);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(206, 447);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(104, 43);
            this.btnFinalizar.TabIndex = 26;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(617, 273);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 51);
            this.btnQuitar.TabIndex = 25;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(506, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 51);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.Location = new System.Drawing.Point(506, 103);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 19);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "0.00";
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTituloTotal.Location = new System.Drawing.Point(506, 84);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(50, 19);
            this.lblTituloTotal.TabIndex = 22;
            this.lblTituloTotal.Text = "TOTAL";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(89, 224);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(85, 23);
            this.txtUnidades.TabIndex = 21;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(20, 224);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(63, 19);
            this.lblUnidades.TabIndex = 20;
            this.lblUnidades.Text = "Unidades";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.ItemHeight = 23;
            this.cbxProducto.Location = new System.Drawing.Point(89, 169);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(328, 29);
            this.cbxProducto.TabIndex = 19;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 169);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(63, 19);
            this.lblProducto.TabIndex = 18;
            this.lblProducto.Text = "Producto";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(34, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 19);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.ItemHeight = 23;
            this.cbxCliente.Location = new System.Drawing.Point(89, 120);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(328, 29);
            this.cbxCliente.TabIndex = 16;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
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
            this.Text = "AgreGarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnFinalizar;
        private MetroFramework.Controls.MetroButton btnQuitar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblTituloTotal;
        private MetroFramework.Controls.MetroTextBox txtUnidades;
        private MetroFramework.Controls.MetroLabel lblUnidades;
        private MetroFramework.Controls.MetroComboBox cbxProducto;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroComboBox cbxCliente;
    }
}