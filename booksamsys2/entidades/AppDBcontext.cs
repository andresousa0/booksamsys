using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using booksamsys2.entidades;

namespace booksamsys2.entidades
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<livro> Livros { get; set; }
        public DbSet<autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<livro>()
                .HasKey(l => l.isbn);

            modelBuilder.Entity<livro>()
                .HasOne(l => l.autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.autorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}