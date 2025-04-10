﻿using GestionDeClientes.Data;  // Asegúrate de tener la referencia al contexto
using GestionDeClientes.Models;
using System;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class CrearCli : Form
    {
        public CrearCli()
        {
            InitializeComponent();

            // Asociar evento al botón para guardar en la base de datos
            btncrearenbase.Click += new EventHandler(btncrearenbase_Click);
        }

        private void CrearCli_Load(object sender, EventArgs e)
        {
            // Limpiar los campos al cargar el formulario
            LimpiarCampos();
        }

        private void btncrearenbase_Click(object sender, EventArgs e)
        {
            // Obtener valores de los TextBox
            string nombre = aggnombre.Text.Trim();
            string apellido = aggapellido.Text.Trim();
            string email = aggemail.Text.Trim();

            // Validaciones de los campos ingresados
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 3 caracteres.");
                return;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Crear una nueva instancia de Cliente
            var nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email
            };

            // Usar Entity Framework para guardar el nuevo cliente
            try
            {
                using (var context = new MYDbContext())
                {
                    // Añadir el nuevo cliente
                    context.Clientes.Add(nuevoCliente);
                    // Guardar los cambios en la base de datos
                    context.SaveChanges();
                    MessageBox.Show("Cliente guardado exitosamente.");
                    this.Close(); // Cerrar el formulario después de guardar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        // Función para validar formato de correo electrónico
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

        // Función para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            aggnombre.Clear();
            aggapellido.Clear();
            aggemail.Clear();
        }
    }
}
