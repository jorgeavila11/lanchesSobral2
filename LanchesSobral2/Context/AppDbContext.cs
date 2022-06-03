using LanchesSobral2.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesSobral2.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanches> Lanches { get; set; }

    }
}
