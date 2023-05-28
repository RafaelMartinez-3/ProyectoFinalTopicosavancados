namespace ProyectoFinalTap
{
    partial class Menu
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
            this.mbtnCProducts = new MetroFramework.Controls.MetroButton();
            this.mbtnCCategories = new MetroFramework.Controls.MetroButton();
            this.mbtnAProducts = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mbtnCProducts
            // 
            this.mbtnCProducts.Location = new System.Drawing.Point(223, 82);
            this.mbtnCProducts.Name = "mbtnCProducts";
            this.mbtnCProducts.Size = new System.Drawing.Size(75, 23);
            this.mbtnCProducts.TabIndex = 0;
            this.mbtnCProducts.Text = "Ir";
            this.mbtnCProducts.Click += new System.EventHandler(this.mbtnCProducts_Click);
            // 
            // mbtnCCategories
            // 
            this.mbtnCCategories.Location = new System.Drawing.Point(223, 152);
            this.mbtnCCategories.Name = "mbtnCCategories";
            this.mbtnCCategories.Size = new System.Drawing.Size(75, 23);
            this.mbtnCCategories.TabIndex = 1;
            this.mbtnCCategories.Text = "Ir";
            // 
            // mbtnAProducts
            // 
            this.mbtnAProducts.Location = new System.Drawing.Point(223, 206);
            this.mbtnAProducts.Name = "mbtnAProducts";
            this.mbtnAProducts.Size = new System.Drawing.Size(75, 23);
            this.mbtnAProducts.TabIndex = 2;
            this.mbtnAProducts.Text = "Ir";
            this.mbtnAProducts.Click += new System.EventHandler(this.mbtnAProducts_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Catalogo de Productos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Catalogo de Categorias";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Adquirir Productos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 277);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnAProducts);
            this.Controls.Add(this.mbtnCCategories);
            this.Controls.Add(this.mbtnCProducts);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnCProducts;
        private MetroFramework.Controls.MetroButton mbtnCCategories;
        private MetroFramework.Controls.MetroButton mbtnAProducts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}