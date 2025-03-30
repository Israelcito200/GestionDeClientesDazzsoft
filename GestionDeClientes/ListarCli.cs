using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace GestionDeClientes
{
    public partial class ListarCli : Form
    {
        public ListarCli()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);  // Cargar los clientes cuando el formulario se carga
            this.dataGridViewClientes.CellClick += new DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);  // Manejar clics en celdas
        }

        // Método que se ejecuta cuando el formulario se carga
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarClientes();  // Llamar al método para cargar clientes al cargar el formulario
            AgregarBotonEditar();  // Añadir el botón de editar
            AgregarBotonEliminar();  // Añadir el botón de eliminar
        }

        // Cargar los clientes en el DataGridView, con opción de búsqueda
        private void CargarClientes(string busqueda = "")
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password=;";  // Cadena de conexión a la base de datos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nombre, apellido, email FROM clientes";  // Consulta SQL para obtener los clientes

                    // Si se ha ingresado un término de búsqueda, agregar condición WHERE
                    if (!string.IsNullOrWhiteSpace(busqueda))
                    {
                        query += " WHERE nombre LIKE @busqueda OR apellido LIKE @busqueda OR email LIKE @busqueda";
                    }

                    // Usar MySqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%"); // Parámetro de búsqueda
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Llenar el DataTable con los resultados de la consulta
                    dataGridViewClientes.DataSource = dataTable;  // Asignar los datos al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los clientes: " + ex.Message);  // Manejar errores
                }
            }
        }

        // Filtrar clientes al escribir en el cuadro de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;  // Obtener el texto del cuadro de búsqueda
            CargarClientes(busqueda);  // Recargar los datos filtrados
        }

        // Volver al formulario de bienvenida
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Bienvenida form1 = new Bienvenida();  // Crear nueva instancia del formulario de bienvenida
            form1.Show();  // Mostrar el formulario
            this.Hide();  // Ocultar el formulario actual
        }

        // Abrir formulario para crear un nuevo cliente
        private void btnAgg_Click(object sender, EventArgs e)
        {
            CrearCli crearClienteForm = new CrearCli();
            crearClienteForm.ShowDialog();  // Mostrar el formulario de creación de cliente
            CargarClientes();  // Recargar los clientes después de crear uno nuevo
        }

        // Agregar el botón de editar en el DataGridView
        private void AgregarBotonEditar()
        {
            if (dataGridViewClientes.Columns["Editar"] == null)
            {
                DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Image = Properties.Resources.edit;  // Usar una imagen de los recursos
                btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewClientes.Columns.Add(btnEditar);  // Agregar columna de editar
            }
        }

        // Manejar clic en celdas del DataGridView (editar o eliminar)
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;  // Evitar clic fuera de las celdas

            // Si se hace clic en la columna "Editar"
            if (e.ColumnIndex == dataGridViewClientes.Columns["Editar"].Index)
            {
                int id = Convert.ToInt32(dataGridViewClientes.Rows[e.RowIndex].Cells["id"].Value);
                string nombre = dataGridViewClientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string apellido = dataGridViewClientes.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                string email = dataGridViewClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();

                // Abrir formulario de edición
                EditarCli formEditar = new EditarCli(id, nombre, apellido, email);
                formEditar.ShowDialog();

                // Recargar los clientes después de la edición
                CargarClientes();
            }

            // Si se hace clic en la columna "Eliminar"
            else if (e.ColumnIndex == dataGridViewClientes.Columns["Eliminar"].Index)
            {
                int clienteId = Convert.ToInt32(dataGridViewClientes.Rows[e.RowIndex].Cells["id"].Value);
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EliminarCliente(clienteId);  // Eliminar el cliente
                }
            }
        }

        // Agregar el botón de eliminar en el DataGridView
        private void AgregarBotonEliminar()
        {
            if (dataGridViewClientes.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "❌";  // El texto del botón
                btnEliminar.UseColumnTextForButtonValue = true;  // Mostrar el texto en el botón
                dataGridViewClientes.Columns.Add(btnEliminar);  // Agregar columna de eliminar
            }
        }

        // Eliminar cliente de la base de datos
        private void EliminarCliente(int clienteId)
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password=";  // Cadena de conexión a la base de datos

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes WHERE id = @id";  // Consulta SQL para eliminar el cliente

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);  // Añadir parámetro de clienteId

                        int filasAfectadas = cmd.ExecuteNonQuery();  // Ejecutar la consulta

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes();  // Recargar la lista de clientes
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

        // Exportar los datos a un archivo Excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel();
        }

        // Método para exportar datos a Excel
        private void ExportarDatosAExcel()
        {
            string connectionString = "server=localhost;database=dbcliente;user=root;password=";  // Asegúrate de que la cadena de conexión sea correcta
            string query = "SELECT id, nombre, apellido, email FROM clientes";  // Consulta SQL para obtener los clientes

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);  // Llenar el DataTable con los datos

                    // Crear un libro de trabajo Excel
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Crear una hoja de trabajo
                        IXLWorksheet ws = wb.Worksheets.Add("Clientes");

                        // Agregar encabezados
                        ws.Cell(1, 1).Value = "ID";
                        ws.Cell(1, 2).Value = "Nombre";
                        ws.Cell(1, 3).Value = "Apellido";
                        ws.Cell(1, 4).Value = "Email";

                        // Agregar los datos del DataTable a la hoja Excel
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable.Columns.Count; j++)
                            {
                                ws.Cell(i + 2, j + 1).Value = dataTable.Rows[i][j].ToString();
                            }
                        }

                        // Mostrar cuadro de diálogo para elegir ubicación de guardado
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            wb.SaveAs(sfd.FileName);  // Guardar el archivo Excel
                            MessageBox.Show("Datos exportados a Excel exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar los datos: " + ex.Message);  // Manejar errores
                }
            }
        }
    }
}
