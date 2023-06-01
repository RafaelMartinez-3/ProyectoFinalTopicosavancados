namespace ProyectoFinalTap
{
    partial class FrmSugerenciaProductos
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
            this.btnNo = new MetroFramework.Controls.MetroButton();
            this.btnSi = new MetroFramework.Controls.MetroButton();
            this.dgvSugerencias = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(191, 507);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(105, 43);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(70, 507);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(105, 43);
            this.btnSi.TabIndex = 6;
            this.btnSi.Text = "Si";
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // dgvSugerencias
            // 
            this.dgvSugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugerencias.Location = new System.Drawing.Point(23, 186);
            this.dgvSugerencias.Name = "dgvSugerencias";
            this.dgvSugerencias.Size = new System.Drawing.Size(321, 293);
            this.dgvSugerencias.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(321, 75);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Los siguientes productos tienen un nivel\r\nbajo de inventario, ¿desea añadirlos a " +
    "la \r\nlista de productos a comprar?";
            // 
            // FrmSugerenciaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 570);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.dgvSugerencias);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "FrmSugerenciaProductos";
            this.Text = "Escazes de productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNo;
        private MetroFramework.Controls.MetroButton btnSi;
        private System.Windows.Forms.DataGridView dgvSugerencias;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
    }
}