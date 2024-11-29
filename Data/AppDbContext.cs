using IfoodSocial.Model;
using Microsoft.EntityFrameworkCore;

namespace IfoodSocial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empreedimento> Empreedimentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
