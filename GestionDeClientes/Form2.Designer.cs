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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label1f2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(182, 142);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(852, 309);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // label1f2
            // 
            this.label1f2.AutoSize = true;
            this.label1f2.BackColor = System.Drawing.Color.Transparent;
            this.label1f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1f2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1f2.Location = new System.Drawing.Point(176, 47);
            this.label1f2.Name = "label1f2";
            this.label1f2.Size = new System.Drawing.Size(154, 38);
            this.label1f2.TabIndex = 2;
            this.label1f2.Text = "NÓMINA";
            this.label1f2.Click += new System.EventHandler(this.label1f2_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(738, 507);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 29);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER A INICIO";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgg
            // 
            this.btnAgg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgg.Location = new System.Drawing.Point(278, 507);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(171, 29);
            this.btnAgg.TabIndex = 4;
            this.btnAgg.Text = "CREAR CLIENTES";
            this.btnAgg.UseVisualStyleBackColor = false;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(176, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Registro 🔎";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(362, 109);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(844, 107);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(190, 29);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GestionDeClientes.Properties.Resources.s;
            this.ClientSize = new System.Drawing.Size(1145, 609);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1f2);
            this.Controls.Add(this.dataGridViewClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1163, 656);
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
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnExportar;
    }
}
