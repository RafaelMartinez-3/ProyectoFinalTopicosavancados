namespace ProyectoFinalTap
{
    partial class FrmMenu
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
            this.btnCProducts = new MetroFramework.Controls.MetroButton();
            this.btnCCategories = new MetroFramework.Controls.MetroButton();
            this.lblCatalogoProductos = new MetroFramework.Controls.MetroLabel();
            this.lblCatalogoCategorias = new MetroFramework.Controls.MetroLabel();
            this.lblCEmpleados = new MetroFramework.Controls.MetroLabel();
            this.btnCEmpleados = new MetroFramework.Controls.MetroButton();
            this.lblVentas = new MetroFramework.Controls.MetroLabel();
            this.btnVentasIr = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCProducts
            // 
            this.btnCProducts.Location = new System.Drawing.Point(223, 82);
            this.btnCProducts.Name = "btnCProducts";
            this.btnCProducts.Size = new System.Drawing.Size(91, 25);
            this.btnCProducts.TabIndex = 0;
            this.btnCProducts.Text = "Ir";
            this.btnCProducts.Click += new System.EventHandler(this.mbtnCProducts_Click);
            // 
            // btnCCategories
            // 
            this.btnCCategories.Location = new System.Drawing.Point(223, 136);
            this.btnCCategories.Name = "btnCCategories";
            this.btnCCategories.Size = new System.Drawing.Size(91, 25);
            this.btnCCategories.TabIndex = 1;
            this.btnCCategories.Text = "Ir";
            this.btnCCategories.Click += new System.EventHandler(this.mbtnCCategories_Click);
            // 
            // lblCatalogoProductos
            // 
            this.lblCatalogoProductos.AutoSize = true;
            this.lblCatalogoProductos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCatalogoProductos.Location = new System.Drawing.Point(23, 82);
            this.lblCatalogoProductos.Name = "lblCatalogoProductos";
            this.lblCatalogoProductos.Size = new System.Drawing.Size(185, 25);
            this.lblCatalogoProductos.TabIndex = 3;
            this.lblCatalogoProductos.Text = "Catálogo de Productos";
            // 
            // lblCatalogoCategorias
            // 
            this.lblCatalogoCategorias.AutoSize = true;
            this.lblCatalogoCategorias.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCatalogoCategorias.Location = new System.Drawing.Point(23, 136);
            this.lblCatalogoCategorias.Name = "lblCatalogoCategorias";
            this.lblCatalogoCategorias.Size = new System.Drawing.Size(189, 25);
            this.lblCatalogoCategorias.TabIndex = 4;
            this.lblCatalogoCategorias.Text = "Catálogo de Categorias";
            // 
            // lblCEmpleados
            // 
            this.lblCEmpleados.AutoSize = true;
            this.lblCEmpleados.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCEmpleados.Location = new System.Drawing.Point(24, 184);
            this.lblCEmpleados.Name = "lblCEmpleados";
            this.lblCEmpleados.Size = new System.Drawing.Size(192, 25);
            this.lblCEmpleados.TabIndex = 5;
            this.lblCEmpleados.Text = "Catálogo de Empleados";
            // 
            // btnCEmpleados
            // 
            this.btnCEmpleados.Location = new System.Drawing.Point(223, 185);
            this.btnCEmpleados.Name = "btnCEmpleados";
            this.btnCEmpleados.Size = new System.Drawing.Size(91, 23);
            this.btnCEmpleados.TabIndex = 6;
            this.btnCEmpleados.Text = "Ir";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVentas.Location = new System.Drawing.Point(24, 236);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(63, 25);
            this.lblVentas.TabIndex = 7;
            this.lblVentas.Text = "Ventas";
            // 
            // btnVentasIr
            // 
            this.btnVentasIr.Location = new System.Drawing.Point(223, 236);
            this.btnVentasIr.Name = "btnVentasIr";
            this.btnVentasIr.Size = new System.Drawing.Size(75, 23);
            this.btnVentasIr.TabIndex = 8;
            this.btnVentasIr.Text = "Ir";
            this.btnVentasIr.Click += new System.EventHandler(this.btnVentasIr_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 348);
            this.Controls.Add(this.btnVentasIr);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.btnCEmpleados);
            this.Controls.Add(this.lblCEmpleados);
            this.Controls.Add(this.lblCatalogoCategorias);
            this.Controls.Add(this.lblCatalogoProductos);
            this.Controls.Add(this.btnCCategories);
            this.Controls.Add(this.btnCProducts);
            this.Name = "FrmMenu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCProducts;
        private MetroFramework.Controls.MetroButton btnCCategories;
        private MetroFramework.Controls.MetroLabel lblCatalogoProductos;
        private MetroFramework.Controls.MetroLabel lblCatalogoCategorias;
        private MetroFramework.Controls.MetroLabel lblCEmpleados;
        private MetroFramework.Controls.MetroButton btnCEmpleados;
        private MetroFramework.Controls.MetroLabel lblVentas;
        private MetroFramework.Controls.MetroButton btnVentasIr;
    }
}