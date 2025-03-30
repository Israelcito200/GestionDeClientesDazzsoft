using System;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Actualmente no hay lógica en la carga del formulario
        }

        // Evento que se ejecuta al hacer clic en el botón
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear y mostrar una nueva instancia de ListarCli (ventana con el listado de clientes)
            ListarCli form2 = new ListarCli();
            form2.Show();

            // Ocultar el formulario actual (Bienvenida)
            this.Hide();
        }
    }
}
