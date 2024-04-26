using Microsoft.EntityFrameworkCore;
using ProjetoLivro.Models;

namespace ProjetoLivro.Persistencia
{
    public class OracleFIAPDbContext(DbContextOptions<OracleFIAPDbContext> options) : DbContext(options)
    {
        internal object Usuario;


        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Usuario>().HasKey(l => l.IdUsuario);
       
        }
        public DbSet<ProjetoLivro.Models.Livro> Livro { get; set; } = default!;
        public DbSet<ProjetoLivro.Models.Autor> Autor { get; set; } = default!;
        public DbSet<ProjetoLivro.Models.Editora> Editora { get; set; } = default!;
        public DbSet<ProjetoLivro.Models.Emprestimo> Emprestimo { get; set; } = default!;
    }
}
