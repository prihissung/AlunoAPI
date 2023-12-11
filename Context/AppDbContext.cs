using AlunoAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AlunoAPI.Context
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
            public DbSet<Categoria>? Categorias { get; set; }

            public DbSet<Produto>? Produtos { get; set; }

           public DbSet<Inscricao>? Inscricoes { get; set; }

            public DbSet<Concurso>? Concursos { get; set; }

    }
}
