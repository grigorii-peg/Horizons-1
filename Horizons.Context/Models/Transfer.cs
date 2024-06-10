using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Horizons.Context.Models
{
    public class Transfer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public int Cost { get; set; }
        public ICollection<TourOrder> Tours { get; set; }
    }
}