using ClosedXML.Excel;
using GestionDeClientes.Data;
using System;
using System.Linq;
using System.Windows.Forms;

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
            using (var context = new MYDbContext())
            {
                var clientesQuery = context.Clientes.AsQueryable();

                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    clientesQuery = clientesQuery.Where(c => c.Nombre.Contains(busqueda) || c.Apellido.Contains(busqueda) || c.Email.Contains(busqueda));
                }

                var clientes = clientesQuery.ToList();

                // Asignar los clientes al DataGridView
                dataGridViewClientes.DataSource = clientes;
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
            using (var context = new MYDbContext())
            {
                var cliente = context.Clientes.SingleOrDefault(c => c.Id == clienteId);

                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);  // Eliminar el cliente
                    context.SaveChanges();  // Guardar los cambios en la base de datos

                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();  // Recargar la lista de clientes
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (var context = new MYDbContext())
            {
                var clientes = context.Clientes.ToList();

                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Clientes");

                    // Agregar encabezados
                    ws.Cell(1, 1).Value = "ID";
                    ws.Cell(1, 2).Value = "Nombre";
                    ws.Cell(1, 3).Value = "Apellido";
                    ws.Cell(1, 4).Value = "Email";

                    // Agregar los datos del cliente a Excel
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        ws.Cell(i + 2, 1).Value = clientes[i].Id;
                        ws.Cell(i + 2, 2).Value = clientes[i].Nombre;
                        ws.Cell(i + 2, 3).Value = clientes[i].Apellido;
                        ws.Cell(i + 2, 4).Value = clientes[i].Email;
                    }

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(sfd.FileName);  // Guardar el archivo Excel
                        MessageBox.Show("Datos exportados a Excel exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
