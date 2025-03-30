using GestionDeClientes.Models;
using System.Data.Entity;

namespace GestionDeClientes.Data
{
    public class MYDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public MYDbContext() : base("name=ConexionCli") // MiConexion debe coincidir con el nombre en App.config
        {
        }
    }
}
