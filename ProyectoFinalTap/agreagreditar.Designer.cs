namespace ProyectoFinalTap
{
    partial class agreagreditar
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
            this.txtid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtdesc = new MetroFramework.Controls.MetroTextBox();
            this.cbocategories = new MetroFramework.Controls.MetroComboBox();
            this.btnaceptar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(109, 13);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 23);
            this.txtid.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Category id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Descripcion";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(109, 53);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(130, 23);
            this.txtdesc.TabIndex = 3;
            // 
            // cbocategories
            // 
            this.cbocategories.FormattingEnabled = true;
            this.cbocategories.ItemHeight = 23;
            this.cbocategories.Location = new System.Drawing.Point(109, 106);
            this.cbocategories.Name = "cbocategories";
            this.cbocategories.Size = new System.Drawing.Size(152, 29);
            this.cbocategories.TabIndex = 4;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(186, 141);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 5;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // agreagreditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 238);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cbocategories);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtid);
            this.Name = "agreagreditar";
            this.Text = "agreagreditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtdesc;
        private MetroFramework.Controls.MetroComboBox cbocategories;
        private MetroFramework.Controls.MetroButton btnaceptar;
    }
}