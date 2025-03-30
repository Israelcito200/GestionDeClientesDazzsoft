namespace GestionDeClientes
{
    partial class CrearCli
    {
        /// <summary>
        /// Recurso requerido por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar los recursos en uso.
        /// </summary>
        /// <param name="disposing">True si se deben liberar los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Inicialización del formulario

        /// <summary>
        /// Método requerido por el diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCli));

            // Campos de entrada
            this.aggnombre = new System.Windows.Forms.TextBox();
            this.aggapellido = new System.Windows.Forms.TextBox();
            this.aggemail = new System.Windows.Forms.TextBox();

            // Botón para guardar
            this.btncrearenbase = new System.Windows.Forms.Button();

            // Etiquetas
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Configuración del campo 'Nombre'
            this.aggnombre.Location = new System.Drawing.Point(298, 142);
            this.aggnombre.Name = "aggnombre";
            this.aggnombre.Size = new System.Drawing.Size(282, 22);
            this.aggnombre.TabIndex = 0;

            // Configuración del campo 'Apellido'
            this.aggapellido.Location = new System.Drawing.Point(298, 202);
            this.aggapellido.Name = "aggapellido";
            this.aggapellido.Size = new System.Drawing.Size(282, 22);
            this.aggapellido.TabIndex = 1;

            // Configuración del campo 'Email'
            this.aggemail.Location = new System.Drawing.Point(298, 261);
            this.aggemail.Name = "aggemail";
            this.aggemail.Size = new System.Drawing.Size(282, 22);
            this.aggemail.TabIndex = 2;

            // Título principal
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREAR CLIENTE ✔️";

            // Etiqueta 'Nombre'
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE :";

            // Etiqueta 'Apellido'
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(155, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO :";

            // Etiqueta 'Email'
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(155, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "EMAIL :";

            // Botón 'Guardar'
            this.btncrearenbase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncrearenbase.Location = new System.Drawing.Point(356, 341);
            this.btncrearenbase.Name = "btncrearenbase";
            this.btncrearenbase.Size = new System.Drawing.Size(128, 33);
            this.btncrearenbase.TabIndex = 7;
            this.btncrearenbase.Text = "GUARDAR";
            this.btncrearenbase.UseVisualStyleBackColor = false;

            // Configuración del formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.s;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncrearenbase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aggemail);
            this.Controls.Add(this.aggapellido);
            this.Controls.Add(this.aggnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearCli";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.CrearCli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox aggnombre;
        private System.Windows.Forms.TextBox aggapellido;
        private System.Windows.Forms.TextBox aggemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncrearenbase;
    }
}