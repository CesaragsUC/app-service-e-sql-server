using Microsoft.EntityFrameworkCore;
using service_app_2.Entities;

namespace service_app_2.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {}

        public DbSet<Produto> Produtos { get; set; }
    }
}