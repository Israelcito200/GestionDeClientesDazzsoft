namespace GestionDeClientes
{
    partial class EditarCli
    {
        // Variable del diseñador necesaria para liberar recursos.
        private System.ComponentModel.IContainer components = null;

        // Método para liberar los recursos cuando el formulario es cerrado.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Destruye los componentes para liberar recursos.
            }
            base.Dispose(disposing);
        }

        // Declaración de controles del formulario (labels, textboxes y botón).
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actnombre;
        private System.Windows.Forms.TextBox actapellido;
        private System.Windows.Forms.TextBox actemail;
        private System.Windows.Forms.Button btnactualizar;

        #region Windows Form Designer generated code

        /// <summary>
        /// Método necesario para el diseño del formulario. No debe modificarse.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actnombre = new System.Windows.Forms.TextBox();
            this.actapellido = new System.Windows.Forms.TextBox();
            this.actemail = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1: Título del formulario.
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDITAR CLIENTE ✏️";

            // label2: Etiqueta para el campo de nombre.
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE :";

            // label3: Etiqueta para el campo de apellido.
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO :";

            // label4: Etiqueta para el campo de correo.
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO :";

            // actnombre: Caja de texto para ingresar o editar el nombre.
            this.actnombre.Location = new System.Drawing.Point(326, 160);
            this.actnombre.Name = "actnombre";
            this.actnombre.Size = new System.Drawing.Size(263, 22);
            this.actnombre.TabIndex = 4;

            // actapellido: Caja de texto para ingresar o editar el apellido.
            this.actapellido.Location = new System.Drawing.Point(326, 211);
            this.actapellido.Name = "actapellido";
            this.actapellido.Size = new System.Drawing.Size(263, 22);
            this.actapellido.TabIndex = 5;

            // actemail: Caja de texto para ingresar o editar el correo.
            this.actemail.Location = new System.Drawing.Point(326, 269);
            this.actemail.Name = "actemail";
            this.actemail.Size = new System.Drawing.Size(263, 22);
            this.actemail.TabIndex = 6;

            // btnactualizar: Botón para actualizar los datos del cliente.
            this.btnactualizar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(295, 345);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(179, 38);
            this.btnactualizar.TabIndex = 7;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);

            // Configuración final del formulario.
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.s; // Imagen de fondo del formulario.
            this.ClientSize = new System.Drawing.Size(800, 450); // Tamaño de la ventana.
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.actemail);
            this.Controls.Add(this.actapellido);
            this.Controls.Add(this.actnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon"))); // Icono del formulario.
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "EditarCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR"; // Título del formulario.
            this.Load += new System.EventHandler(this.EditarCli_Load_1); // Evento que se ejecuta al cargar el formulario.
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
