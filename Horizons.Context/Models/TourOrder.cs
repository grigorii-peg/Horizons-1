using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Horizons.Context.Models
{
    public class TourOrder
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now.Date;
        [Required]
        public DateTime EndDate { get; set; }
        public long ClientId { get; set; }
        public User Client { get; set; }
        [Required]
        public int PersonCount { get; set; } = 1;
        public long RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public long? TransferId { get; set; }
        public Transfer Transfer { get; set; }
        public long ManagerId { get; set; }
        public User Manager { get; set; }
        public ICollection<Excursion> Excursions { get; set; }
        public TourOrder()
        {
            Excursions = new HashSet<Excursion>();
        }
    }
}
