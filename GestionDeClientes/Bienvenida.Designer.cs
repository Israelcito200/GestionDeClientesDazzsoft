
namespace GestionDeClientes
{
    partial class Bienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos utilizados por el formulario.
        /// </summary>
        /// <param name="disposing">true para liberar recursos administrados; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para la inicialización del formulario en el diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));

            // Inicialización del panel principal
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            // Configuración del panel
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // Panel principal
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(512, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 289);
            this.panel1.TabIndex = 2;

            // Botón para ver el listado de clientes
            this.button1.Font = new System.Drawing.Font("Centaur", 10.2F);
            this.button1.Location = new System.Drawing.Point(180, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "VER LISTADO DE CLIENTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Etiqueta del nombre de la empresa
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "DAZZSOFT";

            // Etiqueta del título del formulario
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestoría de Clientes ";

            // Configuración del formulario principal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.objetos_espacio_trabajo_1112_82;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1102, 590);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 637);
            this.Name = "Form1";
            this.Text = "BIENVENIDO A SU GESTORÍA";
            this.Load += new System.EventHandler(this.Form1_Load);

            // Finaliza la configuración del panel y formulario
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
