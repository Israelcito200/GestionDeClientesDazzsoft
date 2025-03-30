
namespace GestionDeClientes
{
    partial class EditarCli
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDITAR CLIENTE ✏️";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO :";
            // 
            // actnombre
            // 
            this.actnombre.Location = new System.Drawing.Point(326, 160);
            this.actnombre.Name = "actnombre";
            this.actnombre.Size = new System.Drawing.Size(263, 22);
            this.actnombre.TabIndex = 4;
            this.actnombre.TextChanged += new System.EventHandler(this.actnombre_TextChanged);
            // 
            // actapellido
            // 
            this.actapellido.Location = new System.Drawing.Point(326, 211);
            this.actapellido.Name = "actapellido";
            this.actapellido.Size = new System.Drawing.Size(263, 22);
            this.actapellido.TabIndex = 5;
            // 
            // actemail
            // 
            this.actemail.Location = new System.Drawing.Point(326, 269);
            this.actemail.Name = "actemail";
            this.actemail.Size = new System.Drawing.Size(263, 22);
            this.actemail.TabIndex = 6;
            // 
            // btnactualizar
            // 
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
            // 
            // EditarCli
            // 
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.s;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "EditarCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}