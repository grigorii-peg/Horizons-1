using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Horizons.Context.Models
{
    public class Excursion
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public int Cost { get; set; }
        public ICollection<TourOrder> TourOrders { get; set; }
        public Excursion()
        {
            TourOrders = new HashSet<TourOrder>();
        }
    }
}