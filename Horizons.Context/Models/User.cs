using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizons.Context.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Login { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        [MaxLength(255)]
        public string Salt { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<TourOrder> Clients { get; set; }
        public ICollection<TourOrder> Managers { get; set; }
    }
}
