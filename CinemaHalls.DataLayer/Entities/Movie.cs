using System.ComponentModel.DataAnnotations;

namespace CinemaHalls.DataLayer.Entities
{
    public class Movie
    {
        public Movie()
        {
            Genres = new HashSet<Genre>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Cast { get; set; }

        public string Producer { get; set; }

        public ushort Duration { get; set; }

        public ICollection<Genre> Genres { get; set; }

    }
}
