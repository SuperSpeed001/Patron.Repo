namespace Patron.Repo.Model
{
    using Microsoft.EntityFrameworkCore;
    using Patron.Modelos;
    
    /// <summary>
    /// Aqui se define el contexto, se podria usar UseSql y 
    /// generar con migration una base de datos en sql para que funcione
    /// </summary>

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");

    }
}
