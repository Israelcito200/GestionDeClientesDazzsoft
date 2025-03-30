using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class EditarCli : Form
    {
        private int clienteId;

        public EditarCli(int id, string nombre, string apellido, string email)
        {
            InitializeComponent();
            clienteId = id;

            // Asignamos los valores recibidos a los TextBox del formulario
            actnombre.Text = nombre;
            actapellido.Text = apellido;
            actemail.Text = email;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            // Validación básica para asegurarse de que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(actnombre.Text) || string.IsNullOrWhiteSpace(actapellido.Text) || string.IsNullOrWhiteSpace(actemail.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Llamada al método para actualizar los datos del cliente
            ActualizarCliente();

           
        }

        private void ActualizarCliente()
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password=;"; // Ajusta según tu configuración

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, email = @email WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);
                        cmd.Parameters.AddWithValue("@nombre", actnombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", actapellido.Text);
                        cmd.Parameters.AddWithValue("@email", actemail.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Cerrar el formulario después de actualizar
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditarCli_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar cosas si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Aquí no parece ser necesario realizar ninguna acción por el momento
        }
    }
}
