using CinemaHalls.Common.Constraints;
using CinemaHalls.DataLayer.Enumerations;
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
        [StringLength(MovieConstraints.TITLE_MAX_LENGTH)]
        public string Title { get; set; }

        [Required]
        [StringLength(MovieConstraints.DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; }

        [Required]
        [StringLength(MovieConstraints.CAST_MAX_LENGTH)]
        public string Cast { get; set; }

        [Required]
        [StringLength(MovieConstraints.PRODUCER_MAX_LENGTH)]
        public string Producer { get; set; }

        public ushort Duration { get; set; }

        public Category Category { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}
