using System;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de Form2 (donde está el DataGridView)
            Form2 form2 = new Form2();

            // Mostrar el formulario Form2
            form2.Show();

            // Si quieres que el formulario actual se cierre al abrir Form2, puedes usar:
            // this.Hide(); // Esto ocultará Form1
            // O también puedes usar:
            // this.Close(); // Esto cerrará Form1 completamente.
            this.Hide();

        }

    }
}
