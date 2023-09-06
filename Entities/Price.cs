using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Keyless]
    public class Price
    {
        [Required(ErrorMessage = "Amount is required feild.")]
        [Range(0, 9999999999999999)]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Currency is a required feild.")]
        public string? Currency { get;set; }

        [ForeignKey(nameof(Item))]
        public Guid ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
