using System.ComponentModel.DataAnnotations;

namespace CinemaHalls.DataLayer.Entities
{
    public class Hall
    {
        public Hall()
        {
            Seats = new HashSet<Seat>();
        }

        [Key]
        public int Number { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}
