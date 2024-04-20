using Microsoft.EntityFrameworkCore;
using ProjetoBiblioteca.Models;

namespace ProjetoBiblioteca.Persistencia
{
    public class OracleFIAPDbContext : DbContext
    {
        public OracleFIAPDbContext(DbContextOptions<OracleFIAPDbContext> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura��o da chave prim�ria para a entidade Livro
            modelBuilder.Entity<Livro>().HasKey(l => l.Id);

            // Configura��o de relacionamento 1..N entre Autor e Livro
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.AutorId);

            // Configura��o de relacionamento 1..N entre Editora e Livro
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Editora)
                .WithMany(e => e.Livros)
                .HasForeignKey(l => l.EditoraId);

            // Configura��o da chave prim�ria para a entidade Autor
            modelBuilder.Entity<Autor>().HasKey(a => a.Id);

            // Configura��o de relacionamento 1..N entre Autor e Livro
            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Livros)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.AutorId);

            // Configura��o da chave prim�ria para a entidade Editora
            modelBuilder.Entity<Editora>().HasKey(e => e.Id);

            // Configura��o de relacionamento 1..N entre Editora e Livro
            modelBuilder.Entity<Editora>()
                .HasMany(e => e.Livros)
                .WithOne(l => l.Editora)
                .HasForeignKey(l => l.EditoraId);

            // Configura��o da chave prim�ria para a entidade Emprestimo
            modelBuilder.Entity<Emprestimo>().HasKey(e => e.Id);

            // Configura��es de modelo, como restri��es, �ndices etc.
            modelBuilder.Entity<Livro>()
                .Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(100); // Define o tamanho m�ximo do t�tulo para 100 caracteres

            modelBuilder.Entity<Livro>()
                .HasIndex(l => l.Titulo); // Cria um �ndice para a propriedade Titulo da entidade Livro
        }
    }
}