using CinemaHalls.Common.Constraints;
using System.ComponentModel.DataAnnotations;

namespace CinemaHalls.DataLayer.Entities
{
    public class Showing
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(ShowingConstraints.NAME_MAX_LENGTH)]
        public string Name { get; set; }

        [Required]
        [StringLength(ShowingConstraints.NAME_MAX_LENGTH)]
        public string NormalizedName { get; set; }
    }
}
