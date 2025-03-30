using MySql.Data.MySqlClient;
using System;
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarClientes();  // Llamar al método para cargar los datos en el DataGridView
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
            crearClienteForm.Show();
        }


    }
}