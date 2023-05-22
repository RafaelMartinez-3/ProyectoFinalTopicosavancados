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
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 250);
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
    }
}