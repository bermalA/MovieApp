using Microsoft.EntityFrameworkCore;

namespace MovieAppHopefullyLast.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) { } 

        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<DirectorMovie> DirectorMovies { get; set;}

    }
}
