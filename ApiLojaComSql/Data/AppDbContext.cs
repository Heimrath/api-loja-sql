using Microsoft.EntityFrameworkCore;
using ApiLojaComSql.Models;

namespace ApiLojaComSql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        
        public DbSet<Pedido> Pedidos { get; set; }
    }
}