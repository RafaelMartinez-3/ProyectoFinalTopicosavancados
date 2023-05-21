namespace ProyectoFinalTap
{
    partial class FrmLogin
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.mbtnIniciar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario";
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.Location = new System.Drawing.Point(153, 76);
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.Size = new System.Drawing.Size(217, 23);
            this.mtxtUsuario.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Contraseña";
            // 
            // mtxtContrasenia
            // 
            this.mtxtContrasenia.Location = new System.Drawing.Point(153, 112);
            this.mtxtContrasenia.Name = "mtxtContrasenia";
            this.mtxtContrasenia.Size = new System.Drawing.Size(217, 23);
            this.mtxtContrasenia.TabIndex = 3;
            // 
            // mbtnIniciar
            // 
            this.mbtnIniciar.Location = new System.Drawing.Point(66, 169);
            this.mbtnIniciar.Name = "mbtnIniciar";
            this.mbtnIniciar.Size = new System.Drawing.Size(137, 23);
            this.mbtnIniciar.TabIndex = 4;
            this.mbtnIniciar.Text = "Iniciar sesión";
            this.mbtnIniciar.Click += new System.EventHandler(this.mbtnIniciar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 237);
            this.Controls.Add(this.mbtnIniciar);
            this.Controls.Add(this.mtxtContrasenia);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtContrasenia;
        private MetroFramework.Controls.MetroButton mbtnIniciar;
    }
}