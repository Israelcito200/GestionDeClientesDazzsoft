using GestionDeClientes.Data;
using System;
using System.Linq;
using System.Windows.Forms;

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

            if (string.IsNullOrEmpty(actnombre.Text) || actnombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 3 caracteres.");
                return;
            }

            if (string.IsNullOrEmpty(actemail.Text) || !IsValidEmail(actemail.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Llamada al método para actualizar los datos del cliente utilizando Entity Framework
            ActualizarCliente();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Método que se encarga de actualizar los datos del cliente en la base de datos usando Entity Framework
        private void ActualizarCliente()
        {
            try
            {
                // Usamos el contexto de Entity Framework que ya está definido
                using (var context = new MYDbContext()) // Asumiendo que ClienteContext es tu DbContext
                {
                    // Buscamos al cliente por ID
                    var cliente = context.Clientes.SingleOrDefault(c => c.Id == clienteId);
                    if (cliente != null)
                    {
                        // Actualizamos los valores del cliente
                        cliente.Nombre = actnombre.Text;
                        cliente.Apellido = actapellido.Text;
                        cliente.Email = actemail.Text;

                        // Guardamos los cambios en la base de datos
                        context.SaveChanges();

                        // Mensaje de éxito
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Si no se encuentra el cliente
                        MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostramos el mensaje correspondiente
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

