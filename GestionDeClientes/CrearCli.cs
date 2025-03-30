using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GestionDeClientes
{
    public partial class CrearCli : Form
    {
        public CrearCli()
        {
            InitializeComponent();

            this.btncrearenbase.Click += new System.EventHandler(this.btncrearenbase_Click);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CrearCli_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void btncrearenbase_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = aggnombre.Text.Trim();
            string apellido = aggapellido.Text.Trim();
            string email = aggemail.Text.Trim();

            // Validar que el campo 'nombre' tenga al menos 3 caracteres
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 3 caracteres.");
                return;
            }

            // Validar que el campo 'email' tenga un formato válido
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validar que los campos 'apellido' y 'email' no estén vacíos
            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El email es obligatorio.");
                return;
            }

            // Si todas las validaciones pasan, guardar los datos en la base de datos
            string connectionString = "server=localhost;database=dbcliente;user=root;password=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta para insertar los datos en la base de datos
                    string query = "INSERT INTO clientes (nombre, apellido, email) VALUES (@nombre, @apellido, @email)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }

        // Función para validar el formato de correo electrónico
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

        private void LimpiarCampos()
        {
            aggnombre.Clear();
            aggapellido.Clear();
            aggemail.Clear();
        }


    }
}
