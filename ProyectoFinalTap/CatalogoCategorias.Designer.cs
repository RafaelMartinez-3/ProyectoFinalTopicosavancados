namespace ProyectoFinalTap
{
    partial class CatalogoCategorias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvcategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcategories
            // 
            this.dgvcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategories.Location = new System.Drawing.Point(91, 63);
            this.dgvcategories.Name = "dgvcategories";
            this.dgvcategories.Size = new System.Drawing.Size(568, 228);
            this.dgvcategories.TabIndex = 0;
            // 
            // CatalogoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.dgvcategories);
            this.Name = "CatalogoCategorias";
            this.Text = "Catalogo de categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcategories;
    }
}

