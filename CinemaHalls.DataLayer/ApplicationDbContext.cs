using CinemaHalls.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaHalls.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<Showing> Showings { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
