namespace eventsRegisterInterface
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.STC_Udeg = new System.Windows.Forms.Label();
            this.STC_Universidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CON_Contenedor = new System.Windows.Forms.Panel();
            this.EDT_Codigo = new System.Windows.Forms.TextBox();
            this.BTN_IniciarSesion = new System.Windows.Forms.Button();
            this.EDT_Clave = new System.Windows.Forms.TextBox();
            this.STC_Clave = new System.Windows.Forms.Label();
            this.STC_Codigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CON_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // STC_Udeg
            // 
            this.STC_Udeg.AutoSize = true;
            this.STC_Udeg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Udeg.ForeColor = System.Drawing.Color.Navy;
            this.STC_Udeg.Location = new System.Drawing.Point(162, 48);
            this.STC_Udeg.Name = "STC_Udeg";
            this.STC_Udeg.Size = new System.Drawing.Size(201, 21);
            this.STC_Udeg.TabIndex = 10;
            this.STC_Udeg.Text = "Universidad de Guadalajara";
            // 
            // STC_Universidad
            // 
            this.STC_Universidad.AutoSize = true;
            this.STC_Universidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Universidad.ForeColor = System.Drawing.Color.Navy;
            this.STC_Universidad.Location = new System.Drawing.Point(189, 17);
            this.STC_Universidad.Name = "STC_Universidad";
            this.STC_Universidad.Size = new System.Drawing.Size(139, 21);
            this.STC_Universidad.TabIndex = 9;
            this.STC_Universidad.Text = "Escuela Vocacional";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 123);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CON_Contenedor
            // 
            this.CON_Contenedor.Controls.Add(this.pictureBox1);
            this.CON_Contenedor.Controls.Add(this.EDT_Codigo);
            this.CON_Contenedor.Controls.Add(this.BTN_IniciarSesion);
            this.CON_Contenedor.Controls.Add(this.EDT_Clave);
            this.CON_Contenedor.Controls.Add(this.STC_Clave);
            this.CON_Contenedor.Controls.Add(this.STC_Codigo);
            this.CON_Contenedor.Location = new System.Drawing.Point(72, 81);
            this.CON_Contenedor.Name = "CON_Contenedor";
            this.CON_Contenedor.Size = new System.Drawing.Size(357, 352);
            this.CON_Contenedor.TabIndex = 11;
            // 
            // EDT_Codigo
            // 
            this.EDT_Codigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Codigo.Location = new System.Drawing.Point(79, 192);
            this.EDT_Codigo.Name = "EDT_Codigo";
            this.EDT_Codigo.Size = new System.Drawing.Size(200, 29);
            this.EDT_Codigo.TabIndex = 7;
            // 
            // BTN_IniciarSesion
            // 
            this.BTN_IniciarSesion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IniciarSesion.ForeColor = System.Drawing.Color.Navy;
            this.BTN_IniciarSesion.Location = new System.Drawing.Point(79, 296);
            this.BTN_IniciarSesion.Name = "BTN_IniciarSesion";
            this.BTN_IniciarSesion.Size = new System.Drawing.Size(200, 35);
            this.BTN_IniciarSesion.TabIndex = 10;
            this.BTN_IniciarSesion.Text = "Iniciar Sesión";
            this.BTN_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // EDT_Clave
            // 
            this.EDT_Clave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Clave.Location = new System.Drawing.Point(79, 251);
            this.EDT_Clave.Name = "EDT_Clave";
            this.EDT_Clave.Size = new System.Drawing.Size(200, 29);
            this.EDT_Clave.TabIndex = 9;
            this.EDT_Clave.UseSystemPasswordChar = true;
            // 
            // STC_Clave
            // 
            this.STC_Clave.AutoSize = true;
            this.STC_Clave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Clave.ForeColor = System.Drawing.Color.Navy;
            this.STC_Clave.Location = new System.Drawing.Point(78, 229);
            this.STC_Clave.Name = "STC_Clave";
            this.STC_Clave.Size = new System.Drawing.Size(94, 22);
            this.STC_Clave.TabIndex = 8;
            this.STC_Clave.Text = "Contraseña";
            // 
            // STC_Codigo
            // 
            this.STC_Codigo.AutoSize = true;
            this.STC_Codigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Codigo.ForeColor = System.Drawing.Color.Navy;
            this.STC_Codigo.Location = new System.Drawing.Point(78, 170);
            this.STC_Codigo.Name = "STC_Codigo";
            this.STC_Codigo.Size = new System.Drawing.Size(61, 22);
            this.STC_Codigo.TabIndex = 6;
            this.STC_Codigo.Text = "Codigo";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 499);
            this.Controls.Add(this.STC_Udeg);
            this.Controls.Add(this.STC_Universidad);
            this.Controls.Add(this.CON_Contenedor);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicia Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CON_Contenedor.ResumeLayout(false);
            this.CON_Contenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STC_Udeg;
        private System.Windows.Forms.Label STC_Universidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CON_Contenedor;
        private System.Windows.Forms.TextBox EDT_Codigo;
        private System.Windows.Forms.Button BTN_IniciarSesion;
        private System.Windows.Forms.TextBox EDT_Clave;
        private System.Windows.Forms.Label STC_Clave;
        private System.Windows.Forms.Label STC_Codigo;
    }
}

