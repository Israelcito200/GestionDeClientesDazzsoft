using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);  // Cargar los clientes cuando el formulario se carga
            this.dataGridViewClientes.CellClick += new DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarClientes();
            AgregarBotonEditar();
            AgregarBotonEliminar();// Llamar al método para cargar los datos en el DataGridView
        }

        private void CargarClientes()
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password=;";  // Cambiar según tu base de datos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nombre, apellido, email FROM clientes";  // Consulta para obtener los datos de los clientes
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewClientes.DataSource = dataTable;  // Asignar los datos al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los clientes: " + ex.Message);
                }
            }
        }

        private void label1f2_Click(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Crear una nueva instancia de Form1
            form1.Show();  // Mostrar Form1
            this.Hide();  // Ocultar Form2
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            CrearCli crearClienteForm = new CrearCli();
            crearClienteForm.ShowDialog();

            CargarClientes();
        }



        private void AgregarBotonEditar()
        {
            if (dataGridViewClientes.Columns["Editar"] == null)
            {
                DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Image = Properties.Resources.edit; // Usa una imagen en tus recursos
                btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewClientes.Columns.Add(btnEditar);
            }
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewClientes.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                int id = Convert.ToInt32(dataGridViewClientes.Rows[e.RowIndex].Cells["id"].Value);
                string nombre = dataGridViewClientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string apellido = dataGridViewClientes.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                string email = dataGridViewClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();

                // Abrir el formulario de edición
                EditarCli formEditar = new EditarCli(id, nombre, apellido, email);
                formEditar.ShowDialog();

                // Recargar los clientes después de la edición
               CargarClientes();
            }

            // Verificar si el clic fue en el botón de Eliminar
            else if (e.ColumnIndex == dataGridViewClientes.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                int clienteId = Convert.ToInt32(dataGridViewClientes.Rows[e.RowIndex].Cells["id"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EliminarCliente(clienteId);
                }
            }
        }

        private void AgregarBotonEliminar()
        {
            if (dataGridViewClientes.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "❌"; // El texto que aparecerá en el botón
                btnEliminar.UseColumnTextForButtonValue = true; // Esto hace que se muestre el texto "Eliminar" en el botón
                dataGridViewClientes.Columns.Add(btnEliminar);
            }
        }

        private void EliminarCliente(int clienteId)
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password="; // Cambiar según tu configuración

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); // Recargar la lista de clientes
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





    }
}