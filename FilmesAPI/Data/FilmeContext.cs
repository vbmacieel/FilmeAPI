using FilmesAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> contextOptions) : base(contextOptions){}

        public DbSet<Filme> Filmes { get; set; }
    }
}
