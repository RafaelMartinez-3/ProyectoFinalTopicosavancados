namespace ProyectoFinalTap
{
    partial class FrmProductosAComprar
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
            this.dgvProductosAComprar = new System.Windows.Forms.DataGridView();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosAComprar
            // 
            this.dgvProductosAComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAComprar.Location = new System.Drawing.Point(23, 160);
            this.dgvProductosAComprar.Name = "dgvProductosAComprar";
            this.dgvProductosAComprar.Size = new System.Drawing.Size(311, 305);
            this.dgvProductosAComprar.TabIndex = 3;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(23, 112);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(89, 42);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // FrmProdcutosAComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 488);
            this.Controls.Add(this.dgvProductosAComprar);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "FrmProdcutosAComprar";
            this.Text = "Productos a comprar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAComprar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosAComprar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}