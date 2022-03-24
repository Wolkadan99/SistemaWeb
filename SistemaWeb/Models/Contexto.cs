using Microsoft.EntityFrameworkCore;

namespace SistemaWeb.Models
{
    public class Contexto: DbContext
    {

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Categoria> Produtos { get; set; }
    }
}
