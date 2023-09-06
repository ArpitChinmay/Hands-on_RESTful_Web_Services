using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Item
    {
        [Column("ItemId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Item name is a required feild.")]
        [MaxLength(50, ErrorMessage = "Item name cannot be more than 30 characters.")]
        public string? Name { get; set; }

        [MaxLength(200, ErrorMessage = "Item description cannot be more than 200 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Label name is a required feild.")]
        [MaxLength(30, ErrorMessage = "Item label name cannot be more than 30 characters.")]
        public string? LabelName { get; set; }

        [Required(ErrorMessage = "Price is a required feild")]
        [ForeignKey(nameof(Price))]
        public Price? Price { get; set; }

        public string? PictureUri { get; set; }

        [Required(ErrorMessage = "Release date is a required feild.")]
        [Range(typeof(DateTime), "1900-01-01", "2100-12-31")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTimeOffset ReleaseDate { get; set; }

        public string? Format { get; set; }

        [Required(ErrorMessage = "Available stock is a required feild.")]
        [Range(0, 9999999999999999999)]
        public int AvailableStock { get; set; }

        [Required(ErrorMessage = "Genre is a required feild.")]
        public Genre? Genre { get; set; }

        [Required(ErrorMessage = "Artist is a required feild.")]
        public ICollection<Artist>? Artists { get; set; }
    }
}
