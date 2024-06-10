using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Horizons.Context.Models
{
    public class RoomType
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public int MaxPersonCount { get; set; }
        [Required]
        public int NightCost { get; set; }
        public ICollection<TourOrder> Tours { get; set; }
    }
}