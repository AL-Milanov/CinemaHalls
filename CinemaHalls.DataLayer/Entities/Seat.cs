using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaHalls.DataLayer.Entities
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }

        public int Number { get; set; }

        public int Row { get; set; }

        [ForeignKey(nameof(Hall))]
        public byte HallId { get; set; }

        public Hall Hall { get; set; }
    }
}