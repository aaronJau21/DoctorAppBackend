using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace Dataa
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
