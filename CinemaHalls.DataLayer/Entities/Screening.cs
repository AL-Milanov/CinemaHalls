using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHalls.DataLayer.Entities
{
    public class Screening
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }

        public Movie Movie { get; set; }

        [ForeignKey(nameof(Hall))]
        public Guid HallId { get; set; }

        public Hall Hall { get; set; }
    }
}
