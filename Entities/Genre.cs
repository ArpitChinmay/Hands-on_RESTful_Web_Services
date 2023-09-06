using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Genre
    {
        [Required(ErrorMessage = "GenreId is a required feild.")]
        [Key]
        public Guid GenreId { get; set; }

        [Required(ErrorMessage = "Genre description is a required feild.")]
        [MaxLength(100, ErrorMessage = "Genre description cannot be more than 200 characters.")]
        public string? GenreDescription { get; set; }

        public ICollection<Item>? Items { get; set; }
    }
}
