using Microsoft.EntityFrameworkCore;
using ProjetoLivro.Models;

namespace ProjetoLivro.Persistencia
{
    public class OracleFIAPDbContext(DbContextOptions<OracleFIAPDbContext> options) : DbContext(options)
    {
        internal object Usuario;

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da chave primária para a entidade Livro
            modelBuilder.Entity<Livro>().HasKey(l => l.Id);

            // Configuração de relacionamento 1..N entre Autor e Livro
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Livro)
                .HasForeignKey(l => l.AutorId);

            // Configuração de relacionamento 1..N entre Editora e Livro
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Editora)
                .WithMany(e => e.Livro)
                .HasForeignKey(l => l.EditoraId);

            // Configuração da chave primária para a entidade Autor
            modelBuilder.Entity<Autor>().HasKey(a => a.Id);

            // Configuração de relacionamento 1..N entre Autor e Livro
            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Livro)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.AutorId);

            // Configuração da chave primária para a entidade Editora
            modelBuilder.Entity<Editora>().HasKey(e => e.Id);

            // Configuração de relacionamento 1..N entre Editora e Livro
            modelBuilder.Entity<Editora>()
                .HasMany(e => e.Livro)
                .WithOne(l => l.Editora)
                .HasForeignKey(l => l.EditoraId);

            // Configuração da chave primária para a entidade Emprestimo
            modelBuilder.Entity<Emprestimo>().HasKey(e => e.Id);

            // Configurações de modelo, como restrições, índices etc.
            modelBuilder.Entity<Livro>()
                .Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(100); // Define o tamanho máximo do título para 100 caracteres

            modelBuilder.Entity<Livro>()
                .HasIndex(l => l.Titulo); // Cria um índice para a propriedade Titulo da entidade Livro
        }
    }
}
