using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Artist
    {
        [Required(ErrorMessage = "Artist Id is a required feild.")]
        public Guid ArtistId { get; set; }

        [Required(ErrorMessage = "Artist name is a required feild.")]
        [MaxLength(50, ErrorMessage = "Artist name cannot be more than 30 characters")]
        public string ArtistName { get; set; }

        public ICollection<Item>? Items { get; set; }
    }
}
