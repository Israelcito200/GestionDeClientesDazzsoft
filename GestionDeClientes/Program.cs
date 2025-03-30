using System;
using System.Windows.Forms;

namespace GestionDeClientes
{
    static class Program
    {
        // Punto de entrada principal para la aplicación.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí se debe cargar el formulario principal
            Application.Run(new Bienvenida());  // Asegúrate de que Form1 sea el formulario que quieres abrir
        }
    }
}
