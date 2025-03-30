
namespace GestionDeClientes
{
    partial class CrearCli
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
            this.aggnombre = new System.Windows.Forms.TextBox();
            this.aggapellido = new System.Windows.Forms.TextBox();
            this.aggemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncrearenbase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aggnombre
            // 
            this.aggnombre.Location = new System.Drawing.Point(298, 142);
            this.aggnombre.Name = "aggnombre";
            this.aggnombre.Size = new System.Drawing.Size(282, 22);
            this.aggnombre.TabIndex = 0;
            // 
            // aggapellido
            // 
            this.aggapellido.Location = new System.Drawing.Point(298, 202);
            this.aggapellido.Name = "aggapellido";
            this.aggapellido.Size = new System.Drawing.Size(282, 22);
            this.aggapellido.TabIndex = 1;
            // 
            // aggemail
            // 
            this.aggemail.Location = new System.Drawing.Point(298, 261);
            this.aggemail.Name = "aggemail";
            this.aggemail.Size = new System.Drawing.Size(282, 22);
            this.aggemail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREAR CLIENTE ✔️";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(155, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(155, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "EMAIL :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btncrearenbase
            // 
            this.btncrearenbase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncrearenbase.Location = new System.Drawing.Point(356, 341);
            this.btncrearenbase.Name = "btncrearenbase";
            this.btncrearenbase.Size = new System.Drawing.Size(128, 33);
            this.btncrearenbase.TabIndex = 7;
            this.btncrearenbase.Text = "GUARDAR";
            this.btncrearenbase.UseVisualStyleBackColor = false;
            // 
            // CrearCli
            // 
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
            this.Name = "CrearCli";
            this.Text = "AgregarCli";
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