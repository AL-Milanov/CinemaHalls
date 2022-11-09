using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHalls.DataLayer.Entities
{
    public class Seat
    {
        public int Number { get; set; }

        public int Row { get; set; }

        [ForeignKey(nameof(Hall))]
        public Guid HallId { get; set; }

        public Hall Hall { get; set; }
    }
}