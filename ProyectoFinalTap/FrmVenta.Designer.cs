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
            this.CboVCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtVClave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CboVProducto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtVUnidades = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtVAgregar = new MetroFramework.Controls.MetroButton();
            this.btnVQuitar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVFinalizar = new MetroFramework.Controls.MetroButton();
            this.btnVCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboVCliente
            // 
            this.CboVCliente.FormattingEnabled = true;
            this.CboVCliente.ItemHeight = 23;
            this.CboVCliente.Location = new System.Drawing.Point(78, 89);
            this.CboVCliente.Name = "CboVCliente";
            this.CboVCliente.Size = new System.Drawing.Size(275, 29);
            this.CboVCliente.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Cliente";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Clave";
            // 
            // txtVClave
            // 
            this.txtVClave.Location = new System.Drawing.Point(78, 144);
            this.txtVClave.Name = "txtVClave";
            this.txtVClave.Size = new System.Drawing.Size(75, 23);
            this.txtVClave.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(192, 144);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Producto";
            // 
            // CboVProducto
            // 
            this.CboVProducto.FormattingEnabled = true;
            this.CboVProducto.ItemHeight = 23;
            this.CboVProducto.Location = new System.Drawing.Point(281, 138);
            this.CboVProducto.Name = "CboVProducto";
            this.CboVProducto.Size = new System.Drawing.Size(328, 29);
            this.CboVProducto.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(192, 193);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Unidades";
            // 
            // TxtVUnidades
            // 
            this.TxtVUnidades.Location = new System.Drawing.Point(278, 193);
            this.TxtVUnidades.Name = "TxtVUnidades";
            this.TxtVUnidades.Size = new System.Drawing.Size(75, 23);
            this.TxtVUnidades.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(637, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "TOTAL";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(637, 89);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "0.00";
            // 
            // txtVAgregar
            // 
            this.txtVAgregar.Location = new System.Drawing.Point(627, 140);
            this.txtVAgregar.Name = "txtVAgregar";
            this.txtVAgregar.Size = new System.Drawing.Size(75, 23);
            this.txtVAgregar.TabIndex = 10;
            this.txtVAgregar.Text = "Agregar";
            // 
            // btnVQuitar
            // 
            this.btnVQuitar.Location = new System.Drawing.Point(637, 231);
            this.btnVQuitar.Name = "btnVQuitar";
            this.btnVQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnVQuitar.TabIndex = 11;
            this.btnVQuitar.Text = "Quitar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnVFinalizar
            // 
            this.btnVFinalizar.Location = new System.Drawing.Point(180, 436);
            this.btnVFinalizar.Name = "btnVFinalizar";
            this.btnVFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnVFinalizar.TabIndex = 13;
            this.btnVFinalizar.Text = "Finalizar";
            // 
            // btnVCancelar
            // 
            this.btnVCancelar.Location = new System.Drawing.Point(379, 436);
            this.btnVCancelar.Name = "btnVCancelar";
            this.btnVCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnVCancelar.TabIndex = 14;
            this.btnVCancelar.Text = "Cancelar";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnVCancelar);
            this.Controls.Add(this.btnVFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVQuitar);
            this.Controls.Add(this.txtVAgregar);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TxtVUnidades);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.CboVProducto);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtVClave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CboVCliente);
            this.Name = "FrmVenta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CboVCliente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtVClave;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CboVProducto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtVUnidades;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton txtVAgregar;
        private MetroFramework.Controls.MetroButton btnVQuitar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnVFinalizar;
        private MetroFramework.Controls.MetroButton btnVCancelar;
    }
}