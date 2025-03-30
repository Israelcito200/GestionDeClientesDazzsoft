using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionDeClientes
{
    public partial class EditarCli : Form
    {
        private int clienteId; // Almacenará el ID del cliente a editar

        // Constructor para inicializar el formulario con los datos del cliente
        public EditarCli(int id, string nombre, string apellido, string email)
        {
            InitializeComponent();
            clienteId = id;

            // Asignamos los valores recibidos a los TextBox del formulario
            actnombre.Text = nombre;
            actapellido.Text = apellido;
            actemail.Text = email;
        }

        // Evento para manejar la acción de clic en el botón de actualización
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

        // Método que se encarga de actualizar los datos del cliente en la base de datos
        private void ActualizarCliente()
        {
            // Cadena de conexión a la base de datos MySQL
            string connectionString = "server=localhost;database=dbcliente;user=root;password=;"; // Ajusta según tu configuración

            // Abrimos la conexión a la base de datos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Consulta SQL para actualizar los datos del cliente
                    string query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, email = @email WHERE id = @id";

                    // Ejecutamos la consulta con los parámetros proporcionados
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);
                        cmd.Parameters.AddWithValue("@nombre", actnombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", actapellido.Text);
                        cmd.Parameters.AddWithValue("@email", actemail.Text);

                        // Ejecutamos la consulta y verificamos si se actualizó algún registro
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // Si se actualizó correctamente, mostramos un mensaje de éxito y cerramos el formulario
                            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            // Si no se pudo actualizar el cliente, mostramos un mensaje de error
                            MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, mostramos el mensaje correspondiente
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método que se ejecuta al cargar el formulario (no se necesita en este caso específico)
        private void EditarCli_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar cosas si es necesario
        }

        // Estos eventos no parecen tener una acción específica, por lo que se pueden omitir si no se van a usar
        private void label2_Click(object sender, EventArgs e)
        {
            // Sin acciones necesarias por el momento
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Sin acciones necesarias por el momento
        }

        private void actnombre_TextChanged(object sender, EventArgs e)
        {
            // Sin acciones necesarias por el momento
        }

        private void EditarCli_Load_1(object sender, EventArgs e)
        {
            // Sin acciones necesarias por el momento
        }
    }
}
