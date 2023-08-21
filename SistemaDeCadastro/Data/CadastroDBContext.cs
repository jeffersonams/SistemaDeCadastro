using Microsoft.EntityFrameworkCore;
using SistemaDeCadastro.Data.Map;
using SistemaDeCadastro.Models;

namespace SistemaDeCadastro.Data
{
    public class CadastroDBContext : DbContext
    {

        public CadastroDBContext(DbContextOptions<CadastroDBContext> options) : base(options) 
        {
            
        }

        public DbSet<CadastroModel>Cadastros{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroMap());
            base.OnModelCreating(modelBuilder);
        }
          
    }
}
