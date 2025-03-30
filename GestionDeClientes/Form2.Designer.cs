namespace GestionDeClientes
{
    partial class Form2
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label1f2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(264, 142);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(596, 309);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // label1f2
            // 
            this.label1f2.AutoSize = true;
            this.label1f2.BackColor = System.Drawing.Color.Transparent;
            this.label1f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1f2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1f2.Location = new System.Drawing.Point(258, 86);
            this.label1f2.Name = "label1f2";
            this.label1f2.Size = new System.Drawing.Size(132, 32);
            this.label1f2.TabIndex = 2;
            this.label1f2.Text = "NÓMINA";
            this.label1f2.Click += new System.EventHandler(this.label1f2_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(700, 507);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 29);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER A INICIO";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.s;
            this.ClientSize = new System.Drawing.Size(1082, 609);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1f2);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label1f2;
        private System.Windows.Forms.Button btnVolver;
    }
}
