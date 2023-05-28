namespace ProyectoFinalTap
{
    partial class FrmInicioVentas
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
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.txtEliminar = new MetroFramework.Controls.MetroButton();
            this.dgvVentasInicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(188, 85);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(75, 23);
            this.txtEliminar.TabIndex = 1;
            this.txtEliminar.Text = "Eliminar";
            // 
            // dgvVentasInicio
            // 
            this.dgvVentasInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasInicio.Location = new System.Drawing.Point(40, 132);
            this.dgvVentasInicio.Name = "dgvVentasInicio";
            this.dgvVentasInicio.Size = new System.Drawing.Size(672, 295);
            this.dgvVentasInicio.TabIndex = 2;
            // 
            // FrmInicioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.dgvVentasInicio);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmInicioVentas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton txtEliminar;
        private System.Windows.Forms.DataGridView dgvVentasInicio;
    }
}