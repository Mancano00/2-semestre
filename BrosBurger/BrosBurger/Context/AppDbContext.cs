using Microsoft.EntityFrameworkCore;
using BrosBurger.Models;
namespace BrosBurger.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Banners> Banners { get; set;}
    }
}