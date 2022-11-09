using CinemaHalls.Common.Constraints;
using System.ComponentModel.DataAnnotations;

namespace CinemaHalls.DataLayer.Entities
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(GenreConstraints.NAME_MAX_LENGTH)]
        public string Name { get; set; }

        [Required]
        [StringLength(GenreConstraints.NAME_MAX_LENGTH)]
        public string NormalizedName { get; set; }
    }
}
